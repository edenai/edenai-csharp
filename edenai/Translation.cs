using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edenai
{
    public class Translation
    {

        private readonly string API_KEY;

        public Translation()
        {
            API_KEY = Keys.ApiKey;
        }

        public Translation(string api_key)
        {
            API_KEY = api_key;
        }

        #region Automatic Translation 

        public async Task<AutomaticTranslation_Response> AutomaticTranslation(AutomaticTranslation_Request requestbody)
        {

            try
            {
                var client = new RestClient("https://api.edenai.run/v1/pretrained/translation/automatic_translation");

                var request = new RestRequest(Method.POST);
                request.Timeout = -1;
                request.AddHeader("Authorization", API_KEY);


                request.AddParameter("providers", JsonConvert.SerializeObject(requestbody.Providers));
                request.AddParameter("text_to_translate", requestbody.TextToTranslate);
                request.AddParameter("source_language", requestbody.SourceLanguage);
                request.AddParameter("target_language", requestbody.TargetLanguage); 

                IRestResponse response = await client.ExecuteAsync(request);

                if (response.IsSuccessful)
                {
                    AutomaticTranslation_Response responsefinal = JsonConvert.DeserializeObject<AutomaticTranslation_Response>(response.Content);
                    return responsefinal;
                }

                AutomaticTranslation_Error error = JsonConvert.DeserializeObject<AutomaticTranslation_Error>(response.Content);
                return new AutomaticTranslation_Response() { Error = error };


            }
            catch (Exception e)
            {
                return new AutomaticTranslation_Response() { Error = new AutomaticTranslation_Error() };
            }
        }

        /// <summary>
        /// Machine translation refers to the translation of a text into another language using rules, statics or ml techniques.
        /// </summary>
        /// <param name="texttotranslate"></param>
        /// <param name="sourcelanguage"></param>
        /// <param name="targetlanguage"></param>
        /// <param name="providers"></param>
        /// <returns></returns>
        public async Task<AutomaticTranslation_Response> AutomaticTranslation(string texttotranslate,string sourcelanguage,string targetlanguage,List<string> providers)
        {

            try
            {
                var client = new RestClient("https://api.edenai.run/v1/pretrained/text/automatic_translation");

                var request = new RestRequest(Method.POST);
                request.Timeout = -1;
                request.AddHeader("Authorization", API_KEY);


                request.AddParameter("providers", JsonConvert.SerializeObject(providers));
                request.AddParameter("text_to_translate", texttotranslate);
                request.AddParameter("source_language", sourcelanguage);
                request.AddParameter("target_language", targetlanguage);

                IRestResponse response = await client.ExecuteAsync(request);

                if (response.IsSuccessful)
                {
                    AutomaticTranslation_Response responsefinal = JsonConvert.DeserializeObject<AutomaticTranslation_Response>(response.Content);
                    return responsefinal;
                }

                AutomaticTranslation_Error error = JsonConvert.DeserializeObject<AutomaticTranslation_Error>(response.Content);
                return new AutomaticTranslation_Response() { Error = error };


            }
            catch (Exception e)
            {
                return new AutomaticTranslation_Response() { Error = new AutomaticTranslation_Error() };
            }
        }


        public class AutomaticTranslation_Request
        { 
            public string TextToTranslate { get; set; }
            public string SourceLanguage { get; set; }
            public string TargetLanguage { get; set; } 
            public List<string> Providers { get; set; }
        }

        public class AutomaticTranslation_Response
        {
            public AutomaticTranslation_Error Error { get; set; }

            public List<Main> Result { get; set; }

            public class ResultData
            {
                public string source_language { get; set; }
                public string target_language { get; set; }
                public string translated_text { get; set; }
            }

            public class Main
            {
                public string solution_name { get; set; }
                public string execution_time { get; set; }
                public ResultData result { get; set; }
                public object api_response { get; set; }
            }
        }

        public class AutomaticTranslation_Error
        {
            public Error errors { get; set; }
            public class Error
            {
                public List<string> Token { get; set; }
                public List<string> Language { get; set; }
                public List<string> Option { get; set; }
                public List<string> Providers { get; set; }
            }
        }
        #endregion

        #region Language Detection

        public async Task<LanguageDetection_Response> LanguageDetection(LanguageDetection_Request requestbody)
        {

            try
            {
                var client = new RestClient("https://api.edenai.run/v1/pretrained/translation/language_detection");

                var request = new RestRequest(Method.POST);
                request.Timeout = -1;
                request.AddHeader("Authorization", API_KEY);


                request.AddParameter("providers", JsonConvert.SerializeObject(requestbody.Providers)); 
                request.AddParameter("Text", requestbody.Text);
                request.AddParameter("languages_to_find", requestbody.LanguagesToFind);

                IRestResponse response = await client.ExecuteAsync(request);

                if (response.IsSuccessful)
                {
                    LanguageDetection_Response responsefinal = JsonConvert.DeserializeObject<LanguageDetection_Response>(response.Content);
                    return responsefinal;
                }

                LanguageDetection_Error error = JsonConvert.DeserializeObject<LanguageDetection_Error>(response.Content);
                return new LanguageDetection_Response() { Error = error };


            }
            catch (Exception e)
            {
                return new LanguageDetection_Response() { Error = new LanguageDetection_Error() };
            }
        }

        /// <summary>
        /// Language Detection or language guessing is the algorithm of determining which natural language given content is in.
        /// </summary>
        /// <param name="languagestofind"></param>
        /// <param name="text"></param>
        /// <param name="providers"></param>
        /// <returns></returns>
        public async Task<LanguageDetection_Response> LanguageDetection(string languagestofind,string text,List<string> providers)
        {

            try
            {
                var client = new RestClient("https://api.edenai.run/v1/pretrained/text/language_detection");

                var request = new RestRequest(Method.POST);
                request.Timeout = -1;
                request.AddHeader("Authorization", API_KEY);


                request.AddParameter("providers", JsonConvert.SerializeObject(providers));
                request.AddParameter("Text", text);
                request.AddParameter("languages_to_find", languagestofind);

                IRestResponse response = await client.ExecuteAsync(request);

                if (response.IsSuccessful)
                {
                    LanguageDetection_Response responsefinal = JsonConvert.DeserializeObject<LanguageDetection_Response>(response.Content);
                    return responsefinal;
                }

                LanguageDetection_Error error = JsonConvert.DeserializeObject<LanguageDetection_Error>(response.Content);
                return new LanguageDetection_Response() { Error = error };


            }
            catch (Exception e)
            {
                return new LanguageDetection_Response() { Error = new LanguageDetection_Error() };
            }
        }

        public class LanguageDetection_Request
        {
            public string LanguagesToFind { get; set; } 
            public string Text { get; set; }
            public List<string> Providers { get; set; }
        }

        public class LanguageDetection_Response
        {
            public LanguageDetection_Error Error { get; set; }

            public List<Main> Result { get; set; }

            public class ResultData
            {
                public List<string> languages { get; set; }
                public List<double> confidences { get; set; }
                public string text { get; set; }
            }

            public class Language
            {
                public string language { get; set; }
                public double confidence { get; set; }
            }

            public class DetectedLanguage
            {
                public string name { get; set; }
                public string iso6391Name { get; set; }
                public int confidenceScore { get; set; }
            }

            public class Document
            {
                public string id { get; set; }
                public DetectedLanguage detectedLanguage { get; set; }
                public List<object> warnings { get; set; }
            }

            public class Language2
            {
                public string LanguageCode { get; set; }
                public double Score { get; set; }
            }

            public class HTTPHeaders
            {
                [JsonProperty("x-amzn-requestid")]
                public string XAmznRequestid { get; set; }

                [JsonProperty("content-type")]
                public string ContentType { get; set; }

                [JsonProperty("content-length")]
                public string ContentLength { get; set; }
                public string date { get; set; }
            }

            public class ResponseMetadata
            {
                public string RequestId { get; set; }
                public int HTTPStatusCode { get; set; }
                public HTTPHeaders HTTPHeaders { get; set; }
                public int RetryAttempts { get; set; }
            }

            public class ApiResponse
            {
                public List<Language> languages { get; set; }
                public List<Document> documents { get; set; }
                public List<object> errors { get; set; }
                public string modelVersion { get; set; }
                public List<Language> Languages { get; set; }
                public ResponseMetadata ResponseMetadata { get; set; }
            }

            public class Main
            {
                public string solution_name { get; set; }
                public string execution_time { get; set; }
                public ResultData result { get; set; }
                public ApiResponse api_response { get; set; }
                public int found_languages { get; set; }
            }

        }

        public class LanguageDetection_Error
        {
            public Error errors { get; set; }
            public class Error
            {
                public List<string> Token { get; set; }
                public List<string> Language { get; set; }
                public List<string> Option { get; set; }
                public List<string> Providers { get; set; }
            }
        }
        #endregion
    }
}
