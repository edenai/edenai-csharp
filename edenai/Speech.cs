using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;  

namespace edenai
{
    public class Speech
    {
        private readonly string API_KEY;

        public Speech(string api_key)
        {
            API_KEY = api_key;
        }
         
        #region Speech Recognition

        public async Task<SpeechRecognition_Response> SpeechRecognition(SpeechRecognition_Request requestbody)
        {

            try
            {
                var client = new RestClient("https://api.edenai.run/v1/pretrained/audio/speech_recognition");

                var request = new RestRequest(Method.POST);
                request.Timeout = -1;
                request.AddHeader("Authorization", API_KEY);


                request.AddParameter("providers", JsonConvert.SerializeObject(requestbody.Providers));
                request.AddParameter("text", requestbody.Text);
                request.AddParameter("language", requestbody.Language);
                request.AddFile("files", requestbody.FilePath);

                IRestResponse response = await client.ExecuteAsync(request);

                if (response.IsSuccessful)
                {
                    SpeechRecognition_Response responsefinal = JsonConvert.DeserializeObject<SpeechRecognition_Response>(response.Content);
                    return responsefinal;
                }

                SpeechRecognition_Error error = JsonConvert.DeserializeObject<SpeechRecognition_Error>(response.Content);
                return new SpeechRecognition_Response() { Error = error };


            }
            catch (Exception e)
            {
                return new SpeechRecognition_Response() { Error = new SpeechRecognition_Error() };
            }
        }

        /// <summary>
        /// Speech recognition is technology that can recognize spoken words, which can then be converted to text.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="language"></param>
        /// <param name="filepath"></param>
        /// <param name="providers"></param>
        /// <returns></returns>
        public async Task<SpeechRecognition_Response> SpeechRecognition(string text, string language, string filepath, List<string> providers)
        {

            try
            {
                var client = new RestClient("https://api.edenai.run/v1/pretrained/audio/speech_recognition");

                var request = new RestRequest(Method.POST);
                request.Timeout = -1;
                request.AddHeader("Authorization", API_KEY);


                request.AddParameter("providers", JsonConvert.SerializeObject(providers));
                request.AddParameter("text", text);
                request.AddParameter("language", language);
                request.AddFile("files", filepath);

                IRestResponse response = await client.ExecuteAsync(request);

                if (response.IsSuccessful)
                {
                    SpeechRecognition_Response responsefinal = JsonConvert.DeserializeObject<SpeechRecognition_Response>(response.Content);
                    return responsefinal;
                }

                SpeechRecognition_Error error = JsonConvert.DeserializeObject<SpeechRecognition_Error>(response.Content);
                return new SpeechRecognition_Response() { Error = error };


            }
            catch (Exception e)
            {
                return new SpeechRecognition_Response() { Error = new SpeechRecognition_Error() };
            }
        }
        public class SpeechRecognition_Request
        { 
            public string Text { get; set; }
            public string Language { get; set; }
            public string FilePath { get; set; }
            public List<string> Providers { get; set; }
        }

        public class SpeechRecognition_Response
        { 
            public SpeechRecognition_Error Error { get; set; }

            public List<Main> Result { get; set; }

            public class ResultAudio
            {
                public string audio_path { get; set; }
                public string transcribe { get; set; }
                public double confidence { get; set; }
            }

            public class Alternative
            {
                public string transcript { get; set; }
                public double confidence { get; set; }
            }

            public class Result2
            {
                public List<Alternative> alternatives { get; set; }
                public string languageCode { get; set; }
            }

            public class ApiResponse
            {
                public List<ResultAudio> results { get; set; }
            }

            public class Main
            {
                public string solution_name { get; set; }
                public string execution_time { get; set; }
                public ResultAudio result { get; set; }
               // public ApiResponse api_response { get; set; }
                public double matching_text { get; set; }
            }
        }

        public class SpeechRecognition_Error
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
      

        #region Text to speech
         
        public async Task<TextToSpeech_Response> TextToSpeech(TextToSpeech_Request requestbody)
        {

            try
            {
                var client = new RestClient("https://api.edenai.run/v1/pretrained/audio/text_to_speech");

                var request = new RestRequest(Method.POST);
                request.AddHeader("Authorization", API_KEY); 


                request.AddParameter("providers", JsonConvert.SerializeObject(requestbody.Providers));
                request.AddParameter("text", requestbody.Text);
                request.AddParameter("language", requestbody.Language);
                request.AddParameter("option", requestbody.Option);

                IRestResponse response = await client.ExecuteAsync(request);
                 
                if (response.IsSuccessful)
                {
                    TextToSpeech_Response responsefinal = JsonConvert.DeserializeObject<TextToSpeech_Response>(response.Content);
                    return responsefinal;
                }
                
                    TextToSpeech_Error error =  JsonConvert.DeserializeObject<TextToSpeech_Error>(response.Content);
                    return new TextToSpeech_Response() { Error = error };
           
            }
            catch (Exception e)
            {
                return new TextToSpeech_Response() { Error = new TextToSpeech_Error() };
            }
        }

        /// <summary>
        /// Text-to-speech (TTS) system converts normal language text into speech.
        /// </summary>
        /// <param name="text">Text to convert to speech</param>
        /// <param name="language">Language of text</param>
        /// <param name="option">Voice option</param>
        /// <param name="providers">Providers for procedure</param>
        /// <returns>Text converted to speech for each provider</returns>
        public async Task<TextToSpeech_Response> TextToSpeech(string text, string language, string option, List<string> providers)
        {

            try
            {
                var client = new RestClient("https://api.edenai.run/v1/pretrained/audio/text_to_speech");

                var request = new RestRequest(Method.POST);
                request.AddHeader("Authorization", API_KEY);  


                request.AddParameter("providers", JsonConvert.SerializeObject(providers));
                request.AddParameter("text", text);
                request.AddParameter("language", language);
                request.AddParameter("option", option);

                IRestResponse response = await client.ExecuteAsync(request);

                if (response.IsSuccessful)
                {
                    TextToSpeech_Response responsefinal = JsonConvert.DeserializeObject<TextToSpeech_Response>(response.Content);
                    return responsefinal;
                }

                TextToSpeech_Error error = JsonConvert.DeserializeObject<TextToSpeech_Error>(response.Content);
                return new TextToSpeech_Response() { Error = error };


            }
            catch (Exception e)
            {
                return new TextToSpeech_Response() { Error = new TextToSpeech_Error() };
            }
        }


        /// <summary>
        /// Text-to-Speech request data
        /// </summary>
        public class TextToSpeech_Request
        {
            /// <summary>
            /// Text to convert to speech
            /// </summary>
            public string Text { get; set; }
            public string Language { get; set; }
            public string Option { get; set; }
            public List<string> Providers { get; set; }
        }

        /// <summary>
        /// Text-to-Speech conversion result
        /// </summary>
        public class TextToSpeech_Response
        {
            public List<Response> Result { get; set; }
            public class Response
            {
                public string text { get; set; }
                public string audio_path { get; set; }
                public int voice_type { get; set; }
                public string solution_name { get; set; }
                public string execution_time { get; set; }
                public Result result { get; set; }
                public string status { get; set; }
                public bool is_failed { get; set; }

                public class Result
                {
                    public string text { get; set; }
                    public string audio_path { get; set; }
                    public int voice_type { get; set; }
                }
            }
            public TextToSpeech_Error Error { get; set; }
        }

        /// <summary>
        /// Text-to-Speech conversion error
        /// </summary>
        public class TextToSpeech_Error
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
