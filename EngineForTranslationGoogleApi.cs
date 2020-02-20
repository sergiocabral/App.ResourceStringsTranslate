using System;
using System.Text;
using System.Web;
using Google.Api.Gax.ResourceNames;
using Google.Cloud.Translate.V3;

namespace ResourceStringsTranslate
{
    public class EngineForTranslationGoogleApi : ITranslation
    {
        private const string GoogleCredentialsVariable = "GOOGLE_APPLICATION_CREDENTIALS";

        public string JsonPath { get; set; }

        public string ProjectId { get; set; }

        public string Translate(string languageFrom, string languageTo, string text)
        {
            try
            {
                Environment.SetEnvironmentVariable(GoogleCredentialsVariable, JsonPath);
                var translationServiceClient = TranslationServiceClient.Create();
                var request = new TranslateTextRequest
                {
                    Contents = {text},
                    TargetLanguageCode = languageTo,
                    ParentAsLocationName = new LocationName(ProjectId, "global")
                };
                var response = translationServiceClient.TranslateText(request);

                var translated = new StringBuilder();
                foreach (var translation in response.Translations)
                    translated.Append(HttpUtility.HtmlDecode(translation.TranslatedText));
                return translated.ToString().Trim();
            }
            catch (Exception ex)
            {
                throw new Exception("Request error.", ex);
            }
        }

        public static EngineForTranslationGoogleApi Default()
        {
            return new EngineForTranslationGoogleApi
            {
                JsonPath = string.Empty,
                ProjectId = string.Empty
            };
        }
    }
}