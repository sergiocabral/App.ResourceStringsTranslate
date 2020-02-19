namespace ResourceStringsTranslate
{
    public class DataForTranslationGoogleApi
    {
        private const string UrlMarkText = "{text}";
        private const string UrlMarkLanguageFrom = "{languageFrom}";
        private const string UrlMarkLanguageTo = "{languageTo}";
        public const string UrlValue = "https://api.google.com/?from=" + UrlMarkLanguageFrom + "&to=" + UrlMarkLanguageTo + "&text=" + UrlMarkText;

        public string Url { get; set; }

        public string Key { get; set; }
        
        public static DataForTranslationGoogleApi Default() =>
            new DataForTranslationGoogleApi
            {
                Url = UrlValue,
                Key = string.Empty
            };
    }
}