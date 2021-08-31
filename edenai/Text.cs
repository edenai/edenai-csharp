using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edenai
{
    public class Text
    {
        private readonly string API_KEY;

        public Text()
        {
            API_KEY = Keys.ApiKey;
        }

        public Text(string api_key)
        {
            API_KEY = api_key;
        }

        #region Keyword Extraction

        public async Task<KeywordExtraction_Response> KeywordExtraction(KeywordExtraction_Request requestbody)
        {

            try
            {
                var client = new RestClient("https://api.edenai.run/v1/pretrained/text/keyword_extraction");

                var request = new RestRequest(Method.POST);
                request.Timeout = -1;
                request.AddHeader("Authorization", API_KEY);


                request.AddParameter("providers", JsonConvert.SerializeObject(requestbody.Providers));
                request.AddParameter("keywords_to_find", JsonConvert.SerializeObject(requestbody.KeywordsToFind));
                request.AddParameter("text", requestbody.Text);
                request.AddParameter("language", requestbody.Language);

                IRestResponse response = await client.ExecuteAsync(request);

                if (response.IsSuccessful)
                {
                    KeywordExtraction_Response responsefinal = JsonConvert.DeserializeObject<KeywordExtraction_Response>(response.Content);
                    return responsefinal;
                }

                KeywordExtraction_Error error = JsonConvert.DeserializeObject<KeywordExtraction_Error>(response.Content);
                return new KeywordExtraction_Response() { Error = error };


            }
            catch (Exception e)
            {
                return new KeywordExtraction_Response() { Error = new KeywordExtraction_Error() };
            }
        }

        /// <summary>
        /// Keyword extraction (also known as keyword detection or keyword analysis) is a text analysis technique that consists of automatically extracting the most important words and expressions in a text.
        /// </summary>
        /// <param name="keywordstofind"></param>
        /// <param name="text"></param>
        /// <param name="language"></param>
        /// <param name="providers"></param>
        /// <returns></returns>
        public async Task<KeywordExtraction_Response> KeywordExtraction(List<string> keywordstofind,string text,string language,List<string> providers)
        {

            try
            {
                var client = new RestClient("https://api.edenai.run/v1/pretrained/text/keyword_extraction");

                var request = new RestRequest(Method.POST);
                request.Timeout = -1;
                request.AddHeader("Authorization", API_KEY);


                request.AddParameter("providers", JsonConvert.SerializeObject(providers));
                request.AddParameter("keywords_to_find", JsonConvert.SerializeObject(keywordstofind));
                request.AddParameter("text", text);
                request.AddParameter("language", language);

                IRestResponse response = await client.ExecuteAsync(request);

                if (response.IsSuccessful)
                {
                    KeywordExtraction_Response responsefinal = JsonConvert.DeserializeObject<KeywordExtraction_Response>(response.Content);
                    return responsefinal;
                }

                KeywordExtraction_Error error = JsonConvert.DeserializeObject<KeywordExtraction_Error>(response.Content);
                return new KeywordExtraction_Response() { Error = error };


            }
            catch (Exception e)
            {
                return new KeywordExtraction_Response() { Error = new KeywordExtraction_Error() };
            }
        }


        public class KeywordExtraction_Request
        {
            public List<string> KeywordsToFind { get; set; }
            public string Text { get; set; }
            public string Language { get; set; }
            public List<string> Providers { get; set; }
        }

        public class KeywordExtraction_Response
        {
            public KeywordExtraction_Error Error { get; set; }

            public List<Main> Result { get; set; }

            public class ResultData
            {
                public string text { get; set; }
                public List<string> keywords { get; set; }
                public List<object> importances { get; set; }
            }

            public class Usage
            {
                public int text_units { get; set; }
                public int text_characters { get; set; }
                public int features { get; set; }
            }

            public class Sentiment
            {
                public double score { get; set; }
                public string label { get; set; }
                public string mixed { get; set; }
            }

            public class Emotion
            {
                public double sadness { get; set; }
                public double joy { get; set; }
                public double fear { get; set; }
                public double disgust { get; set; }
                public double anger { get; set; }
            }

            public class Keyword
            {
                public string text { get; set; }
                public Sentiment sentiment { get; set; }
                public double relevance { get; set; }
                public Emotion emotion { get; set; }
                public int count { get; set; }
            }

            public class Document
            {
                public string id { get; set; }
                public List<string> keyPhrases { get; set; }
            }

            public class KeyPhras
            {
                public double Score { get; set; }
                public string Text { get; set; }
                public int BeginOffset { get; set; }
                public int EndOffset { get; set; }
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
                public Usage usage { get; set; }
                public string language { get; set; }
                public List<Keyword> keywords { get; set; }
                public List<Document> documents { get; set; }
                public List<object> errors { get; set; }
                public List<KeyPhras> KeyPhrases { get; set; }
                public ResponseMetadata ResponseMetadata { get; set; }
            }

            public class Main
            {
                public string solution_name { get; set; }
                public string execution_time { get; set; }
                public ResultData result { get; set; }
                public ApiResponse api_response { get; set; }
                public int found_keywords { get; set; }
            }
        }

        public class KeywordExtraction_Error
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


        #region Named Entity Recognition

        public async Task<NamedEntityRecognition_Response> NamedEntityRecognition(NamedEntityRecognition_Request requestbody)
        {

            try
            {
                var client = new RestClient("https://api.edenai.run/v1/pretrained/text/named_entity_recognition");

                var request = new RestRequest(Method.POST);
                request.Timeout = -1;
                request.AddHeader("Authorization", API_KEY);


                request.AddParameter("providers", JsonConvert.SerializeObject(requestbody.Providers));
                request.AddParameter("entities_to_find", JsonConvert.SerializeObject(requestbody.EntitiesToFind));
                request.AddParameter("text", requestbody.Text);
                request.AddParameter("language", requestbody.Language);

                IRestResponse response = await client.ExecuteAsync(request);

                if (response.IsSuccessful)
                {
                    NamedEntityRecognition_Response responsefinal = JsonConvert.DeserializeObject<NamedEntityRecognition_Response>(response.Content);
                    return responsefinal;
                }

                NamedEntityRecognition_Error error = JsonConvert.DeserializeObject<NamedEntityRecognition_Error>(response.Content);
                return new NamedEntityRecognition_Response() { Error = error };


            }
            catch (Exception e)
            {
                return new NamedEntityRecognition_Response() { Error = new NamedEntityRecognition_Error() };
            }
        }

        /// <summary>
        /// Named Entity Recognition (also called entity identification or entity extraction) is an information extraction technique that automatically identifies named entities in a text and classifies them into predefined categories.
        /// </summary>
        /// <param name="entitiestofind"></param>
        /// <param name="text"></param>
        /// <param name="language"></param>
        /// <param name="providers"></param>
        /// <returns></returns>
        public async Task<NamedEntityRecognition_Response> NamedEntityRecognition(List<string> entitiestofind,string text,string language,List<string> providers)
        {

            try
            {
                var client = new RestClient("https://api.edenai.run/v1/pretrained/text/named_entity_recognition");

                var request = new RestRequest(Method.POST);
                request.Timeout = -1;
                request.AddHeader("Authorization", API_KEY);


                request.AddParameter("providers", JsonConvert.SerializeObject(providers));
                request.AddParameter("entities_to_find", JsonConvert.SerializeObject(entitiestofind));
                request.AddParameter("text", text);
                request.AddParameter("language", language);

                IRestResponse response = await client.ExecuteAsync(request);

                if (response.IsSuccessful)
                {
                    NamedEntityRecognition_Response responsefinal = JsonConvert.DeserializeObject<NamedEntityRecognition_Response>(response.Content);
                    return responsefinal;
                }

                NamedEntityRecognition_Error error = JsonConvert.DeserializeObject<NamedEntityRecognition_Error>(response.Content);
                return new NamedEntityRecognition_Response() { Error = error };


            }
            catch (Exception e)
            {
                return new NamedEntityRecognition_Response() { Error = new NamedEntityRecognition_Error() };
            }
        }


        public class NamedEntityRecognition_Request
        {
            public List<string> EntitiesToFind { get; set; }
            public string Text { get; set; }
            public string Language { get; set; }
            public List<string> Providers { get; set; }
        }

        public class NamedEntityRecognition_Response
        {
            public NamedEntityRecognition_Error Error { get; set; }

            public List<Main> Result { get; set; }

            public class OTHER
            {
                public string entity { get; set; }
                public double importance { get; set; }
                public string url { get; set; }
            }

            public class Classification
            {
                public List<OTHER> OTHER { get; set; }
            }

            public class ResultData
            {
                public string text { get; set; }
                public List<string> entities { get; set; }
                public List<double> importances { get; set; }
                public List<string> categories { get; set; }
                public List<string> urls { get; set; }
                public Classification classification { get; set; }
            }

            public class Metadata
            {
            }

            public class Text
            {
                public string content { get; set; }
                public int beginOffset { get; set; }
            }

            public class Mention
            {
                public Text text { get; set; }
                public string type { get; set; }
            }

            public class Entity
            {
                public string name { get; set; }
                public string type { get; set; }
                public Metadata metadata { get; set; }
                public double salience { get; set; }
                public List<Mention> mentions { get; set; }
            }

            public class Usage
            {
                public int text_units { get; set; }
                public int text_characters { get; set; }
                public int features { get; set; }
            }

            public class Document
            {
                public string id { get; set; }
                public List<object> entities { get; set; }
                public List<object> warnings { get; set; }
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
                public List<Entity> entities { get; set; }
                public string language { get; set; }
                public Usage usage { get; set; }
                public List<Document> documents { get; set; }
                public List<object> errors { get; set; }
                public string modelVersion { get; set; }
                public List<object> Entities { get; set; }
                public ResponseMetadata ResponseMetadata { get; set; }
            }

            public class Main
            {
                public string solution_name { get; set; }
                public string execution_time { get; set; }
                public ResultData result { get; set; }
                public ApiResponse api_response { get; set; }
                public int found_entities { get; set; }
            }

        }

        public class NamedEntityRecognition_Error
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

        #region Sentiment Analysis

        public async Task<SentimentAnalysis_Response> SentimentAnalysis(SentimentAnalysis_Request requestbody)
        {

            try
            {
                var client = new RestClient("https://api.edenai.run/v1/pretrained/text/sentiment_analysis");

                var request = new RestRequest(Method.POST);
                request.Timeout = -1;
                request.AddHeader("Authorization", API_KEY);


                request.AddParameter("providers", JsonConvert.SerializeObject(requestbody.Providers));
                request.AddParameter("sentiments_to_find", JsonConvert.SerializeObject(requestbody.SentimentsToFind));
                request.AddParameter("text", requestbody.Text);
                request.AddParameter("language", requestbody.Language);

                IRestResponse response = await client.ExecuteAsync(request);

                if (response.IsSuccessful)
                {
                    SentimentAnalysis_Response responsefinal = JsonConvert.DeserializeObject<SentimentAnalysis_Response>(response.Content);
                    return responsefinal;
                }

                SentimentAnalysis_Error error = JsonConvert.DeserializeObject<SentimentAnalysis_Error>(response.Content);
                return new SentimentAnalysis_Response() { Error = error };


            }
            catch (Exception e)
            {
                return new SentimentAnalysis_Response() { Error = new SentimentAnalysis_Error() };
            }
        }

        /// <summary>
        /// Sentiment analysis API extracts sentiment in a given string of text. Sentiment analysis, also called 'opinion mining', uses natural language processing, text analysis and computational linguistics to identify and detect subjective information from the input text.
        /// </summary>
        /// <param name="sentimentstofind"></param>
        /// <param name="text"></param>
        /// <param name="language"></param>
        /// <param name="providers"></param>
        /// <returns></returns>
        public async Task<SentimentAnalysis_Response> SentimentAnalysis(List<string> sentimentstofind,string text,string language,List<string> providers)
        {

            try
            {
                var client = new RestClient("https://api.edenai.run/v1/pretrained/text/sentiment_analysis");

                var request = new RestRequest(Method.POST);
                request.Timeout = -1;
                request.AddHeader("Authorization", API_KEY);


                request.AddParameter("providers", JsonConvert.SerializeObject(providers));
                request.AddParameter("sentiments_to_find", JsonConvert.SerializeObject(sentimentstofind));
                request.AddParameter("text", text);
                request.AddParameter("language", language);

                IRestResponse response = await client.ExecuteAsync(request);

                if (response.IsSuccessful)
                {
                    SentimentAnalysis_Response responsefinal = JsonConvert.DeserializeObject<SentimentAnalysis_Response>(response.Content);
                    return responsefinal;
                }

                SentimentAnalysis_Error error = JsonConvert.DeserializeObject<SentimentAnalysis_Error>(response.Content);
                return new SentimentAnalysis_Response() { Error = error };


            }
            catch (Exception e)
            {
                return new SentimentAnalysis_Response() { Error = new SentimentAnalysis_Error() };
            }
        }

        public class SentimentAnalysis_Request
        {
            public List<string> SentimentsToFind { get; set; }
            public string Text { get; set; }
            public string Language { get; set; }
            public List<string> Providers { get; set; }
        }

        public class SentimentAnalysis_Response
        {
            public SentimentAnalysis_Error Error { get; set; }

            public List<Main> Result { get; set; }

            public class ResultData
            {
                public string text { get; set; }
                public List<string> sentiments { get; set; }
                public List<double> sentiment_rate { get; set; }
            }

            public class DocumentSentiment
            {
                public double magnitude { get; set; }
                public double score { get; set; }
            }

            public class Text
            {
                public string content { get; set; }
                public int beginOffset { get; set; }
            }

            public class Sentiment
            {
                public double magnitude { get; set; }
                public double score { get; set; }
                public Document document { get; set; }
            }

            public class Sentence
            {
                public Text text { get; set; }
                public Sentiment sentiment { get; set; }
            }

            public class Usage
            {
                public int text_units { get; set; }
                public int text_characters { get; set; }
                public int features { get; set; }
            }

            public class Document
            {
                public double score { get; set; }
                public string label { get; set; }
            }

            public class Document2
            {
                public string id { get; set; }
                public double score { get; set; }
            }

            public class SentimentScore
            {
                public double Positive { get; set; }
                public double Negative { get; set; }
                public double Neutral { get; set; }
                public double Mixed { get; set; }
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
                public DocumentSentiment documentSentiment { get; set; }
                public string language { get; set; }
                public List<Sentence> sentences { get; set; }
                public Usage usage { get; set; }
                public Sentiment sentiment { get; set; }
                public List<Document> documents { get; set; }
                public List<object> errors { get; set; }
                public string Sentiment { get; set; }
                public SentimentScore SentimentScore { get; set; }
                public ResponseMetadata ResponseMetadata { get; set; }
            }

            public class Main
            {
                public string solution_name { get; set; }
                public string execution_time { get; set; }
                public ResultData result { get; set; }
                public ApiResponse api_response { get; set; }
                public int found_sentiments { get; set; }
            }


        }

        public class SentimentAnalysis_Error
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


        #region Syntax Analysis

        /// <summary>
        /// Syntax analysis consists principal in highlighting the structure of a text.
        /// </summary>
        /// <param name="sentimentstofind"></param>
        /// <param name="text"></param>
        /// <param name="language"></param>
        /// <param name="providers"></param>
        /// <returns></returns>
        public async Task<SyntaxAnalysis_Response> SyntaxAnalysis(List<string> sentimentstofind,string text,string language,List<string> providers)
        {

            try
            {
                var client = new RestClient("https://api.edenai.run/v1/pretrained/text/sentiment_analysis");

                var request = new RestRequest(Method.POST);
                request.Timeout = -1;
                request.AddHeader("Authorization", API_KEY);


                request.AddParameter("providers", JsonConvert.SerializeObject(providers));
                request.AddParameter("sentiments_to_find", JsonConvert.SerializeObject(sentimentstofind));
                request.AddParameter("text", text);
                request.AddParameter("language", language);

                IRestResponse response = await client.ExecuteAsync(request);

                if (response.IsSuccessful)
                {
                    SyntaxAnalysis_Response responsefinal = JsonConvert.DeserializeObject<SyntaxAnalysis_Response>(response.Content);
                    return responsefinal;
                }

                SyntaxAnalysis_Error error = JsonConvert.DeserializeObject<SyntaxAnalysis_Error>(response.Content);
                return new SyntaxAnalysis_Response() { Error = error };


            }
            catch (Exception e)
            {
                return new SyntaxAnalysis_Response() { Error = new SyntaxAnalysis_Error() };
            }
        }

        public class SyntaxAnalysis_Request
        {
            public List<string> SentimentsToFind { get; set; }
            public string Text { get; set; }
            public string Language { get; set; }
            public List<string> Providers { get; set; }
        }

        public class SyntaxAnalysis_Response
        {
            public SyntaxAnalysis_Error Error { get; set; }

            public List<Main> Result { get; set; }


            public class ResultData
            {
                public string text { get; set; }
                public List<string> keywords { get; set; }
                public List<object> importances { get; set; }
                public List<string> tags { get; set; }
                public List<string> lemmas { get; set; }
                public List<object> others { get; set; }
            }

            public class Text
            {
                public string content { get; set; }
                public int beginOffset { get; set; }
            }

            public class Sentence
            {
                public Text text { get; set; }
            }

            public class PartOfSpeech
            {
                public string tag { get; set; }
                public string aspect { get; set; }
                public string @case { get; set; }
                public string form { get; set; }
                public string gender { get; set; }
                public string mood { get; set; }
                public string number { get; set; }
                public string person { get; set; }
                public string proper { get; set; }
                public string reciprocity { get; set; }
                public string tense { get; set; }
                public string voice { get; set; }
            }

            public class DependencyEdge
            {
                public int headTokenIndex { get; set; }
                public string label { get; set; }
            }

            public class Token
            {
                public Text text { get; set; }
                public PartOfSpeech partOfSpeech { get; set; }
                public DependencyEdge dependencyEdge { get; set; }
                public string lemma { get; set; }
            }

            public class PartOfSpeech2
            {
                public string Tag { get; set; }
                public double Score { get; set; }
            }

            public class SyntaxToken
            {
                public int TokenId { get; set; }
                public string Text { get; set; }
                public int BeginOffset { get; set; }
                public int EndOffset { get; set; }
                public PartOfSpeech PartOfSpeech { get; set; }
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
                public List<Sentence> sentences { get; set; }
                public List<Token> tokens { get; set; }
                public string language { get; set; }
                public List<SyntaxToken> SyntaxTokens { get; set; }
                public ResponseMetadata ResponseMetadata { get; set; }
            }

            public class Main
            {
                public string solution_name { get; set; }
                public string execution_time { get; set; }
                public ResultData result { get; set; }
                public ApiResponse api_response { get; set; }
                public string found_keywords { get; set; }
                public int? nb_Provider { get; set; }
            }


        }

        public class SyntaxAnalysis_Error
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
