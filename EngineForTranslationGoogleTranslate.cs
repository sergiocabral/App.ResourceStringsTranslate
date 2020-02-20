namespace ResourceStringsTranslate
{
    public class EngineForTranslationGoogleTranslate: ITranslation
    {
        private const string UrlMarkText = "{text}";
        private const string UrlMarkLanguageFrom = "{languageFrom}";
        private const string UrlMarkLanguageTo = "{languageTo}";

        public const string UrlValue = "https://translate.google.com.br/translate_a/single?client=gtx&sl=" +
                                       UrlMarkLanguageFrom + "&tl=" + UrlMarkLanguageTo + "&hl=" + UrlMarkLanguageFrom +
                                       "&dt=at&dt=bd&dt=ex&dt=ld&dt=md&dt=qca&dt=rw&dt=rm&dt=ss&dt=t&otf=1&ssel=0&tsel=0&kc=7&q=" +
                                       UrlMarkText;

        public string Url { get; set; }

        public int BetweenRequests { get; set; }

        public int AfterBlock { get; set; }

        public static EngineForTranslationGoogleTranslate Default()
        {
            return new EngineForTranslationGoogleTranslate
            {
                Url = UrlValue,
                BetweenRequests = 5,
                AfterBlock = 3600
            };
        }

        public string Translate(string languageFrom, string languageTo, string text)
        {
            return text;
        }
    }
}