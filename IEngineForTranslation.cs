namespace ResourceStringsTranslate
{
    public interface ITranslation
    {
        string Translate(string languageFrom, string languageTo, string text);
    }
}