namespace ResourceStringsTranslate
{
    public class DataForTranslationMicrosoftApi
    {
        private const string UrlMarkText = "{text}";
        private const string UrlMarkLanguageFrom = "{languageFrom}";
        private const string UrlMarkLanguageTo = "{languageTo}";
        public const string UrlValue = "https://azure.microsoft.com/?from=" + UrlMarkLanguageFrom + "&to=" + UrlMarkLanguageTo + "&text=" + UrlMarkText;

        public string Url { get; set; }

        public string Key { get; set; }
        
        public static DataForTranslationMicrosoftApi Default() =>
            new DataForTranslationMicrosoftApi
            {
                Url = UrlValue,
                Key = string.Empty
            };
    }
}