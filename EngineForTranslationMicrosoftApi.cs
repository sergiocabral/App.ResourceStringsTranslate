using System;
using System.Text;
using System.Web;
using Newtonsoft.Json;

namespace ResourceStringsTranslate
{
    public class EngineForTranslationMicrosoftApi : ITranslation
    {
        private const string MarkText = "{text}";
        private const string MarkLanguageFrom = "{languageFrom}";
        private const string MarkLanguageTo = "{languageTo}";

        public const string UrlValue = "https://api.cognitive.microsofttranslator.com/translate?api-version=3.0";

        private const string DataValue = "[{\"From\":'" + MarkLanguageFrom + "', \"Text\":'" + MarkText + "'}]";

        private readonly WebClientEx _webClient = new WebClientEx();

        public string Url { get; set; }

        public string Key { get; set; }

        public string Translate(string languageFrom, string languageTo, string text)
        {
            try
            {
                var url = $"{Url}&to={MarkLanguageTo}"
                    .Replace(MarkLanguageTo, languageTo);

                var data = DataValue
                    .Replace(MarkLanguageFrom, languageFrom)
                    .Replace(MarkText, text
                        .Replace("'", "\\'")
                        .Replace("\n", "\\n"));
                var dataBytes = Encoding.UTF8.GetBytes(data);

                _webClient.Headers.Clear();
                _webClient.Headers.Add("Ocp-Apim-Subscription-Key", Key);
                _webClient.Headers.Add("Content-Type", "application/json; charset=UTF-8");

                var responseBytes = _webClient.UploadData(url, "POST", dataBytes);
                var response = Encoding.UTF8.GetString(responseBytes);

                try
                {
                    var json = (dynamic) JsonConvert.DeserializeObject(response);
                    var translated = new StringBuilder();
                    try
                    {
                        for (var i = 0; i < json[0]["translations"].Count; i++)
                            translated.Append(HttpUtility.HtmlDecode(json[0]["translations"][i]["text"].ToString()));
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

        public static EngineForTranslationMicrosoftApi Default()
        {
            return new EngineForTranslationMicrosoftApi
            {
                Url = UrlValue,
                Key = ""
            };
        }
    }
}