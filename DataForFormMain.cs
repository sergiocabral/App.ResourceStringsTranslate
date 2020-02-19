using System;
using System.Collections.Generic;
using System.IO;

namespace ResourceStringsTranslate
{
    public class DataForFormMain
    {
        public const string DefaultLanguageValue = "en";
        public List<string> Status { get; } = new List<string>();

        public int Progress { get; set; }
        public string DefaultLanguage { get; set; } = DefaultLanguageValue;

        public List<DataForResourceFile> ResourceFiles { get; set; } = new List<DataForResourceFile>();

        public List<FileInfo> SelectedResourceFileGroup { get; set; } = new List<FileInfo>();

        public Type TranslationService { get; set; } = typeof(DataForTranslationGoogleTranslate);

        public DataForTranslationGoogleTranslate TranslationGoogleTranslate { get; set; } =
            DataForTranslationGoogleTranslate.Default();

        public DataForTranslationGoogleApi TranslationGoogleApi { get; set; } = DataForTranslationGoogleApi.Default();

        public DataForTranslationMicrosoftApi TranslationMicrosoftApi { get; set; } =
            DataForTranslationMicrosoftApi.Default();
    }
}