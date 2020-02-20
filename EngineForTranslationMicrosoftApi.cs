namespace ResourceStringsTranslate
{
    public class EngineForTranslationMicrosoftApi : ITranslation
    {
        private const string UrlMarkText = "{text}";
        private const string UrlMarkLanguageFrom = "{languageFrom}";
        private const string UrlMarkLanguageTo = "{languageTo}";

        public const string UrlValue = "https://azure.microsoft.com/?from=" + UrlMarkLanguageFrom + "&to=" +
                                       UrlMarkLanguageTo + "&text=" + UrlMarkText;

        public string Url { get; set; }

        public string Key { get; set; }

        public string Translate(string languageFrom, string languageTo, string text)
        {
            return text;
        }

        public static EngineForTranslationMicrosoftApi Default()
        {
            return new EngineForTranslationMicrosoftApi
            {
                Url = UrlValue,
                Key = string.Empty
            };
        }
    }
}