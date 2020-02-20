using System;
using System.Diagnostics;
using System.Text;
using System.Threading;
using Newtonsoft.Json;

namespace ResourceStringsTranslate
{
    public class EngineForTranslationGoogleTranslate : ITranslation
    {
        private const string MarkText = "{text}";
        private const string MarkLanguageFrom = "{languageFrom}";
        private const string MarkLanguageTo = "{languageTo}";

        public const string UrlValue = "https://translate.google.com.br/translate_a/single?client=gtx&sl=" +
                                       MarkLanguageFrom + "&tl=" + MarkLanguageTo + "&hl=" + MarkLanguageFrom +
                                       "&dt=at&dt=bd&dt=ex&dt=ld&dt=md&dt=qca&dt=rw&dt=rm&dt=ss&dt=t&otf=1&ssel=0&tsel=0&kc=7&q=" +
                                       MarkText;

        private readonly Stopwatch Stopwatch = new Stopwatch();

        public string Url { get; set; }

        public int BetweenRequests { get; set; }

        public string Translate(string languageFrom, string languageTo, string text)
        {
            while (Stopwatch.IsRunning &&
                   Stopwatch.ElapsedMilliseconds < BetweenRequests * 1000) Thread.Sleep(500);

            var url = Url
                .Replace(MarkLanguageFrom, languageFrom)
                .Replace(MarkLanguageTo, languageTo)
                .Replace(MarkText, text);

            Stopwatch.Stop();
            try
            {
                var response = WebClientEx.Default.DownloadString(url);
                try
                {
                    var json = (dynamic) JsonConvert.DeserializeObject(response);
                    var translated = new StringBuilder();
                    try
                    {
                        for (var i = 0; i < json[0].Count; i++) translated.Append(json[0][i][0].ToString());
                    }
                    catch
                    {
                        // Se não conseguir capturar o texto segue em frente com o que conseguiu.
                    }

                    return translated.ToString().Trim();
                }
                catch (Exception ex)
                {
                    throw new Exception("Response error.", ex);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Request error.", ex);
            }
            finally
            {
                Stopwatch.Restart();
            }
        }

        public static EngineForTranslationGoogleTranslate Default()
        {
            return new EngineForTranslationGoogleTranslate
            {
                Url = UrlValue,
                BetweenRequests = 5
            };
        }
    }
}