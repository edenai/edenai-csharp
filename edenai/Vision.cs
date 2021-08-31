using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edenai
{
    public class Vision
    {
        private readonly string API_KEY;

        public Vision()
        {
            API_KEY = Keys.ApiKey;
        }

        public Vision(string api_key)
        {
            API_KEY = api_key;
        }

        #region Explicit Content Detection

        public async Task<ExplicitContentDetection_Response> ExplicitContentDetection(ExplicitContentDetection_Request requestbody)
        {

            try
            {
                var client = new RestClient("https://api.edenai.run/v1/pretrained/vision/explicit_content_detection");

                var request = new RestRequest(Method.POST);
                request.Timeout = -1;
                request.AddHeader("Authorization", API_KEY);


                request.AddParameter("providers", JsonConvert.SerializeObject(requestbody.Providers)); 
                request.AddFile("files", requestbody.FilePath);

                IRestResponse response = await client.ExecuteAsync(request);

                if (response.IsSuccessful)
                {
                    ExplicitContentDetection_Response responsefinal = JsonConvert.DeserializeObject<ExplicitContentDetection_Response>(response.Content);
                    return responsefinal;
                }

                ExplicitContentDetection_Error error = JsonConvert.DeserializeObject<ExplicitContentDetection_Error>(response.Content);
                return new ExplicitContentDetection_Response() { Error = error };


            }
            catch (Exception e)
            {
                return new ExplicitContentDetection_Response() { Error = new ExplicitContentDetection_Error() };
            }
        }

        /// <summary>
        /// Explicit Content Detection detects adult only content in videos, who is generally inappropriate for people under the age of 18 and includes nudity, sexual activity and pornography
        /// </summary>
        /// <param name="filepath"></param>
        /// <param name="providers"></param>
        /// <returns></returns>
        public async Task<ExplicitContentDetection_Response> ExplicitContentDetection(string filepath,List<string> providers)
        {

            try
            {
                var client = new RestClient("https://api.edenai.run/v1/pretrained/vision/explicit_content_detection");

                var request = new RestRequest(Method.POST);
                request.Timeout = -1;
                request.AddHeader("Authorization", API_KEY);


                request.AddParameter("providers", JsonConvert.SerializeObject(providers));
                request.AddFile("files", filepath);

                IRestResponse response = await client.ExecuteAsync(request);

                if (response.IsSuccessful)
                {
                    ExplicitContentDetection_Response responsefinal = JsonConvert.DeserializeObject<ExplicitContentDetection_Response>(response.Content);
                    return responsefinal;
                }

                ExplicitContentDetection_Error error = JsonConvert.DeserializeObject<ExplicitContentDetection_Error>(response.Content);
                return new ExplicitContentDetection_Response() { Error = error };


            }
            catch (Exception e)
            {
                return new ExplicitContentDetection_Response() { Error = new ExplicitContentDetection_Error() };
            }
        }

        public class ExplicitContentDetection_Request
        { 
            public string FilePath { get; set; }
            public List<string> Providers { get; set; }
        }

        public class ExplicitContentDetection_Response
        {
            public ExplicitContentDetection_Error Error { get; set; }

            public List<Main> Result { get; set; }

            public class ResultData
            {
                public string image_path { get; set; }
                public List<string> labels { get; set; }
                public List<int> likelihood { get; set; }
            }

            public class Main
            {
                public string solution_name { get; set; }
                public string execution_time { get; set; }
                public ResultData result { get; set; }
                public object api_response { get; set; }
                public string status { get; set; }
                public int? nb_Provider { get; set; }
            }
        }

        public class ExplicitContentDetection_Error
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

        #region Face Detection

        public async Task<FaceDetection_Response> FaceDetection(FaceDetection_Request requestbody)
        {

            try
            {
                var client = new RestClient("https://api.edenai.run/v1/pretrained/vision/face_detection");

                var request = new RestRequest(Method.POST);
                request.Timeout = -1;
                request.AddHeader("Authorization", API_KEY);


                request.AddParameter("providers", JsonConvert.SerializeObject(requestbody.Providers));
                request.AddFile("files", requestbody.FilePath);

                IRestResponse response = await client.ExecuteAsync(request);

                if (response.IsSuccessful)
                {
                    FaceDetection_Response responsefinal = JsonConvert.DeserializeObject<FaceDetection_Response>(response.Content);
                    return responsefinal;
                }

                FaceDetection_Error error = JsonConvert.DeserializeObject<FaceDetection_Error>(response.Content);
                return new FaceDetection_Response() { Error = error };


            }
            catch (Exception e)
            {
                return new FaceDetection_Response() { Error = new FaceDetection_Error() };
            }
        }

        /// <summary>
        /// Face Detection is a computer technology being used in a variety of applications that identifies human faces in digital images.
        /// </summary>
        /// <param name="filepath"></param>
        /// <param name="providers"></param>
        /// <returns></returns>
        public async Task<FaceDetection_Response> FaceDetection(string filepath,List<string> providers)
        {

            try
            {
                var client = new RestClient("https://api.edenai.run/v1/pretrained/vision/face_detection");

                var request = new RestRequest(Method.POST);
                request.Timeout = -1;
                request.AddHeader("Authorization", API_KEY);


                request.AddParameter("providers", JsonConvert.SerializeObject(providers));
                request.AddFile("files", filepath);

                IRestResponse response = await client.ExecuteAsync(request);

                if (response.IsSuccessful)
                {
                    FaceDetection_Response responsefinal = JsonConvert.DeserializeObject<FaceDetection_Response>(response.Content);
                    return responsefinal;
                }

                FaceDetection_Error error = JsonConvert.DeserializeObject<FaceDetection_Error>(response.Content);
                return new FaceDetection_Response() { Error = error };


            }
            catch (Exception e)
            {
                return new FaceDetection_Response() { Error = new FaceDetection_Error() };
            }
        }

        public class FaceDetection_Request
        {
            public string FilePath { get; set; }
            public List<string> Providers { get; set; }
        }

        public class FaceDetection_Response
        {
            public FaceDetection_Error Error { get; set; }

            public List<Main> Result { get; set; }

            public class Landmark
            {
                public List<double> LEFT_EYE { get; set; }
                public List<double> RIGHT_EYE { get; set; }
                public List<double> LEFT_OF_LEFT_EYEBROW { get; set; }
                public List<double> RIGHT_OF_LEFT_EYEBROW { get; set; }
                public List<double> LEFT_OF_RIGHT_EYEBROW { get; set; }
                public List<double> RIGHT_OF_RIGHT_EYEBROW { get; set; }
                public List<double> MIDPOINT_BETWEEN_EYES { get; set; }
                public List<double> NOSE_TIP { get; set; }
                public List<double> UPPER_LIP { get; set; }
                public List<double> LOWER_LIP { get; set; }
                public List<double> MOUTH_LEFT { get; set; }
                public List<double> MOUTH_RIGHT { get; set; }
                public List<double> MOUTH_CENTER { get; set; }
                public List<double> NOSE_BOTTOM_RIGHT { get; set; }
                public List<double> NOSE_BOTTOM_LEFT { get; set; }
                public List<double> NOSE_BOTTOM_CENTER { get; set; }
                public List<double> LEFT_EYE_TOP_BOUNDARY { get; set; }
                public List<double> LEFT_EYE_RIGHT_CORNER { get; set; }
                public List<double> LEFT_EYE_BOTTOM_BOUNDARY { get; set; }
                public List<double> LEFT_EYE_LEFT_CORNER { get; set; }
                public List<double> RIGHT_EYE_TOP_BOUNDARY { get; set; }
                public List<double> RIGHT_EYE_RIGHT_CORNER { get; set; }
                public List<double> RIGHT_EYE_BOTTOM_BOUNDARY { get; set; }
                public List<double> RIGHT_EYE_LEFT_CORNER { get; set; }
                public List<double> LEFT_EYEBROW_UPPER_MIDPOINT { get; set; }
                public List<double> RIGHT_EYEBROW_UPPER_MIDPOINT { get; set; }
                public List<double> LEFT_EAR_TRAGION { get; set; }
                public List<double> RIGHT_EAR_TRAGION { get; set; }
                public List<double> FOREHEAD_GLABELLA { get; set; }
                public List<double> CHIN_GNATHION { get; set; }
                public List<double> CHIN_LEFT_GONION { get; set; }
                public List<double> CHIN_RIGHT_GONION { get; set; }
                public string type { get; set; }
                public Position position { get; set; }
            }

            public class Emotion
            {
                public int joy { get; set; }
                public int sorrow { get; set; }
                public int angry { get; set; }
                public int surprise { get; set; }
            }

            public class Pos
            {
                public double Roll { get; set; }
                public double Pan { get; set; }
                public double Tilt { get; set; }
            }

            public class ResultData 
            {
                public string image_path { get; set; }
                public List<List<string>> attributes_label { get; set; }
                public List<List<object>> attributes_value { get; set; }
                public List<double> confidences { get; set; }
                public List<Landmark> landmarks { get; set; }
                public List<Emotion> emotions { get; set; }
                public List<Pos> poses { get; set; }
                public List<double> x_mins { get; set; }
                public List<double> x_maxs { get; set; }
                public List<double> y_mins { get; set; }
                public List<double> y_maxs { get; set; }
            }

            public class Vertex
            {
                public int x { get; set; }
                public int? y { get; set; }
            }

            public class BoundingPoly
            {
                public List<Vertex> vertices { get; set; }
            }

            public class FdBoundingPoly
            {
                public List<Vertex> vertices { get; set; }
            }

            public class Position
            {
                public double x { get; set; }
                public double y { get; set; }
                public double z { get; set; }
            }

            public class FaceAnnotation
            {
                public BoundingPoly boundingPoly { get; set; }
                public FdBoundingPoly fdBoundingPoly { get; set; }
                public List<Landmark> landmarks { get; set; }
                public double rollAngle { get; set; }
                public double panAngle { get; set; }
                public double tiltAngle { get; set; }
                public double detectionConfidence { get; set; }
                public double landmarkingConfidence { get; set; }
                public string joyLikelihood { get; set; }
                public string sorrowLikelihood { get; set; }
                public string angerLikelihood { get; set; }
                public string surpriseLikelihood { get; set; }
                public string underExposedLikelihood { get; set; }
                public string blurredLikelihood { get; set; }
                public string headwearLikelihood { get; set; }
            }

            public class Respons
            {
                public List<FaceAnnotation> faceAnnotations { get; set; }
            }

            public class ApiResponse
            {
                public List<Respons> responses { get; set; }
            }

            public class Main
            {
                public string solution_name { get; set; }
                public string execution_time { get; set; }
                public ResultData result { get; set; }
                public ApiResponse api_response { get; set; }
                public string found_objects { get; set; }
            }
        }

        public class FaceDetection_Error
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

        #region Object Detection

        public async Task<ObjectDetection_Response> ObjectDetection(ObjectDetection_Request requestbody)
        {

            try
            {
                var client = new RestClient("https://api.edenai.run/v1/pretrained/vision/object_detection");

                var request = new RestRequest(Method.POST);
                request.Timeout = -1;
                request.AddHeader("Authorization", API_KEY);


                request.AddParameter("providers", JsonConvert.SerializeObject(requestbody.Providers));
                request.AddFile("files", requestbody.FilePath);

                IRestResponse response = await client.ExecuteAsync(request);

                if (response.IsSuccessful)
                {
                    ObjectDetection_Response responsefinal = JsonConvert.DeserializeObject<ObjectDetection_Response>(response.Content);
                    return responsefinal;
                }

                ObjectDetection_Error error = JsonConvert.DeserializeObject<ObjectDetection_Error>(response.Content);
                return new ObjectDetection_Response() { Error = error };


            }
            catch (Exception e)
            {
                return new ObjectDetection_Response() { Error = new ObjectDetection_Error() };
            }
        }

        /// <summary>
        /// Object Detection is a computer vision technique that allows us to identify and locate objects in an image or video
        /// </summary>
        /// <param name="filepath"></param>
        /// <param name="providers"></param>
        /// <returns></returns>
        public async Task<ObjectDetection_Response> ObjectDetection(string filepath, List<string> providers)
        {

            try
            {
                var client = new RestClient("https://api.edenai.run/v1/pretrained/vision/object_detection");

                var request = new RestRequest(Method.POST);
                request.Timeout = -1;
                request.AddHeader("Authorization", API_KEY);


                request.AddParameter("providers", JsonConvert.SerializeObject(providers));
                request.AddFile("files", filepath);

                IRestResponse response = await client.ExecuteAsync(request);

                if (response.IsSuccessful)
                {
                    ObjectDetection_Response responsefinal = JsonConvert.DeserializeObject<ObjectDetection_Response>(response.Content);
                    return responsefinal;
                }

                ObjectDetection_Error error = JsonConvert.DeserializeObject<ObjectDetection_Error>(response.Content);
                return new ObjectDetection_Response() { Error = error };


            }
            catch (Exception e)
            {
                return new ObjectDetection_Response() { Error = new ObjectDetection_Error() };
            }
        }

        public class ObjectDetection_Request
        {
            public string FilePath { get; set; }
            public List<string> Providers { get; set; }
        }

        public class ObjectDetection_Response
        {
            public ObjectDetection_Error Error { get; set; }

            public List<Main> Result { get; set; }

            public class ResultData
            {
                public string image_path { get; set; }
                public List<string> labels { get; set; }
                public List<double> confidences { get; set; }
                public List<object> x_mins { get; set; }
                public List<object> x_maxs { get; set; }
                public List<object> y_mins { get; set; }
                public List<object> y_maxs { get; set; }
            }

            public class NormalizedVertice
            {
                public double x { get; set; }
                public double y { get; set; }
            }

            public class BoundingPoly
            {
                public List<NormalizedVertice> normalizedVertices { get; set; }
            }

            public class LocalizedObjectAnnotation
            {
                public string mid { get; set; }
                public string name { get; set; }
                public double score { get; set; }
                public BoundingPoly boundingPoly { get; set; }
            }

            public class Respons
            {
                public List<LocalizedObjectAnnotation> localizedObjectAnnotations { get; set; }
            }

            public class Class
            {
                public string @class { get; set; }
                public double score { get; set; }
                public string type_hierarchy { get; set; }
            }

            public class Classifier
            {
                public string classifier_id { get; set; }
                public string name { get; set; }
                public List<Class> classes { get; set; }
            }

            public class Image
            {
                public List<Classifier> classifiers { get; set; }
                public string image { get; set; }
            }

            public class Rectangle
            {
                public int x { get; set; }
                public int y { get; set; }
                public int w { get; set; }
                public int h { get; set; }
            }

            public class Parent3
            {
                public string @object { get; set; }
                public double confidence { get; set; }
                public object parent { get; set; }
            }

            public class Object
            {
                public Rectangle rectangle { get; set; }
                public string @object { get; set; }
                public double confidence { get; set; }
                public object parent { get; set; }
            }

            public class Metadata
            {
                public int width { get; set; }
                public int height { get; set; }
                public string format { get; set; }
            }

            public class BoundingBox
            {
                public double Width { get; set; }
                public double Height { get; set; }
                public double Left { get; set; }
                public double Top { get; set; }
            }

            public class Instance
            {
                public BoundingBox BoundingBox { get; set; }
                public double Confidence { get; set; }
            }

            public class Parent4
            {
                public string Name { get; set; }
            }

            public class Label
            {
                public string Name { get; set; }
                public double Confidence { get; set; }
                public List<Instance> Instances { get; set; }
                public List<object> Parents { get; set; }
            }

            public class HTTPHeaders
            {
                [JsonProperty("content-type")]
                public string ContentType { get; set; }
                public string date { get; set; }

                [JsonProperty("x-amzn-requestid")]
                public string XAmznRequestid { get; set; }

                [JsonProperty("content-length")]
                public string ContentLength { get; set; }
                public string connection { get; set; }
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
                public List<Respons> responses { get; set; }
                public List<Image> images { get; set; }
                public int? images_processed { get; set; }
                public int? custom_classes { get; set; }
                public List<Object> objects { get; set; }
                public string requestId { get; set; }
                public Metadata metadata { get; set; }
                public List<Label> Labels { get; set; }
                public string LabelModelVersion { get; set; }
                public ResponseMetadata ResponseMetadata { get; set; }
            }

            public class Main
            {
                public string solution_name { get; set; }
                public string execution_time { get; set; }
                public ResultData result { get; set; }
                public ApiResponse api_response { get; set; }
                public object found_objects { get; set; }
            }
        }

        public class ObjectDetection_Error
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
