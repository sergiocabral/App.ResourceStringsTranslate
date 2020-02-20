using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using Newtonsoft.Json;

namespace ResourceStringsTranslate
{
    public class EngineForTranslationGoogleTranslate : ITranslation
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

        private static WebClientEx _webClient;
        
        public string Translate(string languageFrom, string languageTo, string text)
        {
            if (_webClient == null)
            {
                _webClient = new WebClientEx();
                _webClient.Encoding = Encoding.UTF8;
                _webClient.Timeout = 10000;
            }
            
            var url = Url
                .Replace(UrlMarkLanguageFrom, languageFrom)
                .Replace(UrlMarkLanguageTo, languageTo)
                .Replace(UrlMarkText, text);

            try
            {
                var response = _webClient.DownloadString(url);
                try
                {
                    var json = (dynamic) JsonConvert.DeserializeObject(response);
                    var translated = new StringBuilder();
                    try
                    {
                        for (var i = 0; i < json[0].Count; i++)
                        {
                            translated.Append(json[0][i][0].ToString());
                        }
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
        }

        public static EngineForTranslationGoogleTranslate Default()
        {
            return new EngineForTranslationGoogleTranslate
            {
                Url = UrlValue,
                BetweenRequests = 5,
                AfterBlock = 3600
            };
        }
    }
}