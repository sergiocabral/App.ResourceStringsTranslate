using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml;

namespace ResourceStringsTranslate
{
    public class DataForResourceFile
    {
        public const string LanguageDefaultName = "default";

        public DataForResourceFile(FileInfo fileXml)
        {
            FileXml = fileXml;
            Language = Regex.Match(fileXml.Name, @"(?<=\.)[a-z]{2}(\-[a-z]*|)(?=\.resx)", RegexOptions.IgnoreCase).Value;
            IsDefaultLanguage = string.IsNullOrWhiteSpace(Language);
            Language = !IsDefaultLanguage ? Language : LanguageDefaultName;
            FileCSharp =
                new FileInfo(Regex.Replace(FileXml.FullName, @"\.resx$", ".Designer.cs", RegexOptions.IgnoreCase));
            HasCSharpCode = FileCSharp.Exists && FileCSharp.Length > 0 &&
                            !string.IsNullOrWhiteSpace(System.IO.File.ReadAllText(FileCSharp.FullName).Trim());
        }

        public FileInfo FileXml { get; }
        public FileInfo FileCSharp { get; }
        public string Language { get; }
        public string Name => FileXml.Name;
        public string[] Details => new[] {Name, Language, FileXml.FullName};
        public bool IsDefaultLanguage { get; }
        public bool HasCSharpCode { get; }

        private XmlDocument LoadXml()
        {
            var xml = new XmlDocument();
            xml.LoadXml(System.IO.File.ReadAllText(FileXml.FullName));
            return xml;
        }

        public IDictionary<string, string> LoadData(out string errors)
        {
            var xml = LoadXml();
            var nodes = xml.SelectNodes("/root/data");

            var list = (
                from XmlNode node in nodes
                let key = node.Attributes["name"]?.Value
                where key != null
                select new KeyValuePair<string, string>(key, node["value"].InnerXml)
            ).ToList();

            var duplicates = list
                .GroupBy(a => a.Key)
                .Where(a => a.Count() > 1)
                .Select(a => new KeyValuePair<string, int>(a.Key, a.Count()))
                .ToArray();

            if (duplicates.Length > 0)
            {
                list.Reverse();
                foreach (var duplicate in duplicates)
                    for (var i = 0; i < duplicate.Value - 1; i++)
                        list.Remove(list.First(a => a.Key == duplicate.Key));
                list.Reverse();

                errors =
                    $"Resource file \"{FileXml.Name}\" has duplicate keys:{Environment.NewLine}{string.Join(Environment.NewLine, duplicates)}";
            }
            else
            {
                errors = null;
            }

            return list.ToDictionary(key => key.Key, value => value.Value);
        }

        public void SaveData(IDictionary<string, string> translations)
        {
            SaveDataXml(translations);
            SaveDataCSharp(translations);
        }

        private static string FormatKeyCSharp(string key) =>
            key.Replace("-", "_");

        private void SaveDataCSharp(IDictionary<string, string> translations)
        {
            var lines = new List<string>();

            var file = FileCSharp;

            if (HasCSharpCode)
            {
                var (header, footer) = GetHeaderFooterCSharp();

                lines.AddRange(header);
                lines.AddRange(
                    from translate in translations
                    let keyCSharp = FormatKeyCSharp(translate.Key)
                    select $@"        
        /// <summary>
        ///   Looks up a localized string similar to {translate.Value}.
        /// </summary>
        public static string {keyCSharp} {{
            get {{
                return ResourceManager.GetString(""{translate.Key}"", resourceCulture);
            }}
        }}");
                lines.AddRange(footer);
            }
            
            File.WriteAllLines(file.FullName, lines);
        }

        private void SaveDataXml(IDictionary<string, string> translations)
        {
            var lines = new List<string>();

            var file = FileXml;
            var (header, footer) = GetHeaderFooterXml();

            lines.AddRange(header);
            lines.AddRange(
                from translate in translations
                select $@"  <data name=""{translate.Key}"" xml:space=""preserve"">
    <value>{translate.Value}</value>
  </data>");
            lines.AddRange(footer);

            File.WriteAllLines(file.FullName, lines);
        }

        public (string[], string[]) GetHeaderFooterXml()
        {
            var file = FileXml;
            if (!file.Exists) return (new string[0], new string[0]);
            
            var header = new List<string>();
            var footer = new List<string>();

            var lines = System.IO.File.ReadAllLines(file.FullName);
            var commentOpened = false;
            for (var i = 0; i < lines.Length; i++)
            {
                if (lines[i].Contains("<!--")) commentOpened = true;
                if (lines[i].Contains("-->")) commentOpened = false;
                if (commentOpened || !Regex.IsMatch(lines[i], @"^\s*<data\s+name=""[^""]+""",
                        RegexOptions.IgnoreCase)) continue;
                header.AddRange(lines.Take(i));
                break;
            }

            for (var i = lines.Length - 1; i >= 0; i--)
            {
                if (!Regex.IsMatch(lines[i], @"^\s*<\s*/\s*data", RegexOptions.IgnoreCase)) continue;
                footer.AddRange(lines.Skip(i + 1));
                break;
            }

            return (header.ToArray(), footer.ToArray());
        }

        public (string[], string[]) GetHeaderFooterCSharp()
        {
            var file = FileCSharp;
            if (!file.Exists) return (new string[0], new string[0]);

            var header = new List<string>();
            var footer = new List<string>();

            var lines = System.IO.File.ReadAllLines(file.FullName);
            for (var i = 0; i < lines.Length; i++)
            {
                if (!Regex.IsMatch(lines[i], @"^\s*public\s*static\s*string\s*[a-zA-Z0-9_]+\s*{",
                    RegexOptions.IgnoreCase)) continue;
                for (i--; i >= 0; i--)
                {
                    if (lines[i].Trim() != "}") continue;
                    header.AddRange(lines.Take(i + 1));
                    break;
                }

                break;
            }

            var countBrackets = 3;
            for (var i = lines.Length - 1; i >= 0; i--)
            {
                if (lines[i].Trim() == "}") countBrackets--;
                if (countBrackets > 0) continue;
                footer.AddRange(lines.Skip(i + 1));
                break;
            }

            return (header.ToArray(), footer.ToArray());
        }
    }
}