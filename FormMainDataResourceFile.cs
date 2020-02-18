using System.IO;
using System.Text.RegularExpressions;
// ReSharper disable MemberCanBePrivate.Global

namespace ResourceStringsTranslate
{
    public class FormMainDataResourceFile
    {
        public FormMainDataResourceFile(FileInfo file)
        {
            File = file;
            Name = file.Name;
            Language = Regex.Match(file.Name, @"(?<=\.)[a-z]{2}(?=(\-[a-z]*|)\.resx)").Value;
            Language = !string.IsNullOrWhiteSpace(Language) ? Language : "default";
            Details = new[] {Name, Language};
        }

        public FileInfo File { get; }
        public string Language { get; }
        public string Name { get; }
        public string[] Details { get; }
    }
}
