using System;
using System.Collections.Generic;
using System.Data;
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

        public List<DataForResourceFile> SelectedResourceFileGroup { get; set; } = new List<DataForResourceFile>();

        public Type TranslationService { get; set; } = typeof(DataForTranslationGoogleTranslate);

        public DataForTranslationGoogleTranslate TranslationGoogleTranslate { get; set; } =
            DataForTranslationGoogleTranslate.Default();

        public DataForTranslationGoogleApi TranslationGoogleApi { get; set; } = DataForTranslationGoogleApi.Default();

        public DataForTranslationMicrosoftApi TranslationMicrosoftApi { get; set; } =
            DataForTranslationMicrosoftApi.Default();
        
        public DataTable Table { get; set; } = new DataTable();
    }
}