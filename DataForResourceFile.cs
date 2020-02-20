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

        public DataForResourceFile(FileInfo file)
        {
            File = file;
            Language = Regex.Match(file.Name, @"(?<=\.)[a-z]{2}(\-[a-z]*|)(?=\.resx)", RegexOptions.IgnoreCase).Value;
            Language = !string.IsNullOrWhiteSpace(Language) ? Language : LanguageDefaultName;
        }

        public FileInfo File { get; }
        public string Language { get; }
        public string Name => File.Name;
        public string[] Details => new[] {Name, Language, File.FullName};

        private XmlDocument LoadXml()
        {
            var xml = new XmlDocument();
            xml.LoadXml(System.IO.File.ReadAllText(File.FullName));
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
                    $"Resource file \"{File.Name}\" has duplicate keys:{Environment.NewLine}{string.Join(Environment.NewLine, duplicates)}";
            }
            else
            {
                errors = null;
            }

            return list.ToDictionary(key => key.Key, value => value.Value);
        }
    }
}