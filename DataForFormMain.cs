using System;
using System.Collections.Generic;
using System.IO;

namespace ResourceStringsTranslate
{
    public class DataForFormMain
    {
        public List<string> Status { get; } = new List<string>();

        public int Progress { get; set; }

        public const string DefaultLanguageValue = "en";
        public string DefaultLanguage { get; set; } = DefaultLanguageValue;

        public List<FormMainDataResourceFile> ResourceFiles { get; set; } = new List<FormMainDataResourceFile>();
        
        public List<FileInfo> SelectedResourceFileGroup { get; set; } = new List<FileInfo>();

        public Type TranslationService { get; set; } = typeof(DataForTranslationGoogleTranslate);
        
        public DataForTranslationGoogleTranslate TranslationGoogleTranslate { get; set; } = DataForTranslationGoogleTranslate.Default();
        
        public DataForTranslationGoogleApi TranslationGoogleApi { get; set; } = DataForTranslationGoogleApi.Default();
        
        public DataForTranslationMicrosoftApi TranslationMicrosoftApi { get; set; } = DataForTranslationMicrosoftApi.Default();
    }
}
