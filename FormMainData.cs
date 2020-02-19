using System.Collections.Generic;
using System.IO;

namespace ResourceStringsTranslate
{
    public class FormMainData
    {
        public List<string> Status { get; } = new List<string>();

        public int Progress { get; set; }

        public string DefaultLanguage { get; set; } = "auto";

        public List<FormMainDataResourceFile> ResourceFiles { get; set; } = new List<FormMainDataResourceFile>();
        
        public List<FileInfo> SelectedResourceFileGroup { get; set; } = new List<FileInfo>();
    }
}
