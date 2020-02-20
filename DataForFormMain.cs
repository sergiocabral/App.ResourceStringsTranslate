using System;
using System.Collections.Generic;
using System.IO;

namespace ResourceStringsTranslate
{
    public class DataForFormMain
    {
        public const string DefaultLanguageValue = "en";

        private bool _checkNewFiles;
        public List<string> Status { get; } = new List<string>();

        public int Progress { get; set; }
        public string DefaultLanguage { get; set; } = DefaultLanguageValue;

        public List<DataForResourceFile> ResourceFiles { get; set; } = new List<DataForResourceFile>();

        public DirectoryInfo SelectedResourceFilesDirectory { get; set; }

        public List<DataForResourceFile> SelectedResourceFileGroup { get; set; } = new List<DataForResourceFile>();

        public string SelectedResourceFilePrefix { get; set; }

        public Type TranslationService { get; set; } = typeof(DataForTranslationGoogleTranslate);

        public DataForTranslationGoogleTranslate TranslationGoogleTranslate { get; set; } =
            DataForTranslationGoogleTranslate.Default();

        public DataForTranslationGoogleApi TranslationGoogleApi { get; set; } = DataForTranslationGoogleApi.Default();

        public DataForTranslationMicrosoftApi TranslationMicrosoftApi { get; set; } =
            DataForTranslationMicrosoftApi.Default();

        public TableForTranslations Table { get; set; } = new TableForTranslations();

        public bool CheckNewFiles
        {
            get
            {
                if (!_checkNewFiles) return false;
                _checkNewFiles = false;
                return true;
            }
            set => _checkNewFiles = value;
        }

        public bool TranslatingRunning { get; set; }
    }
}