using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edenai
{
    public class OCR
    {

        private readonly string API_KEY;

        public OCR()
        {
            API_KEY = Keys.ApiKey;
        }

        public OCR(string api_key)
        {
            API_KEY = api_key;
        }

        #region OCR Invoice

        public async Task<OCRInvoice_Response> OCRInvoice(OCRInvoice_Request requestbody)
        {

            try
            {
                var client = new RestClient("https://api.edenai.run/v1/pretrained/ocr/ocr_invoice");

                var request = new RestRequest(Method.POST);
                request.AddHeader("Authorization", API_KEY);


                request.AddParameter("providers", JsonConvert.SerializeObject(requestbody.Providers));
                
                request.AddParameter("language", requestbody.Language);
                
                request.AddFile("files", requestbody.FilePath);
                IRestResponse response = await client.ExecuteAsync(request);

                if (response.IsSuccessful)
                {
                    OCRInvoice_Response responsefinal = JsonConvert.DeserializeObject<OCRInvoice_Response>(response.Content);
                    return responsefinal;
                }

                OCRInvoice_Error error = JsonConvert.DeserializeObject<OCRInvoice_Error>(response.Content);
                return new OCRInvoice_Response() { Error = error };

            }
            catch (Exception e)
            {
                return new OCRInvoice_Response() { Error = new OCRInvoice_Error() };
            }
        }

        /// <summary>
        /// Optical Character Recognition or optical character reader (OCR) is the electronic or mechanical conversion of images of typed, handwritten or printed text into machine-encoded text, whether from a scanned document, a photo of a document.
        /// </summary>
        /// <param name="providers">List of providers to be used. Available providers: "microsoft", "mindee"</param>
        /// <param name="language"></param>
        /// <param name="filepath"></param>
        /// <returns></returns>
        public async Task<OCRInvoice_Response> OCRInvoice(string providers, string language, string filepath)
        {

            try
            {
                var client = new RestClient("https://api.edenai.run/v1/pretrained/ocr/ocr_invoice");

                var request = new RestRequest(Method.POST);
                request.AddHeader("Authorization", API_KEY);


                request.AddParameter("providers", JsonConvert.SerializeObject(providers));

                request.AddParameter("language", language);

                request.AddFile("files", filepath);
                IRestResponse response = await client.ExecuteAsync(request);

                if (response.IsSuccessful)
                {
                    OCRInvoice_Response responsefinal = JsonConvert.DeserializeObject<OCRInvoice_Response>(response.Content);
                    return responsefinal;
                }

                OCRInvoice_Error error = JsonConvert.DeserializeObject<OCRInvoice_Error>(response.Content);
                return new OCRInvoice_Response() { Error = error };

            }
            catch (Exception e)
            {
                return new OCRInvoice_Response() { Error = new OCRInvoice_Error() };
            }
        }

        public class OCRInvoice_Request
        { 
           
            public string Language { get; set; }
            public string FilePath { get; set; }
    
            public List<string> Providers { get; set; }
        }

        
        public class OCRInvoice_Response
        {
            public List<Response> Result { get; set; }
             
              

            public class PreviousUnpaidBalance
            {
                public string type { get; set; }
                public double? valueNumber { get; set; }
                public string text { get; set; }
                public List<double?> boundingBox { get; set; }
                public double? page { get; set; }
                public double? confidence { get; set; }
                public List<string> elements { get; set; }
            }

            public class PurchaseOrder
            {
                public string type { get; set; }
                public string valueString { get; set; }
                public string text { get; set; }
                public List<double?> boundingBox { get; set; }
                public double? page { get; set; }
                public double? confidence { get; set; }
                public List<string> elements { get; set; }
            }

            public class RemittanceAddress
            {
                public string type { get; set; }
                public string valueString { get; set; }
                public string text { get; set; }
                public List<double?> boundingBox { get; set; }
                public double? page { get; set; }
                public double? confidence { get; set; }
                public List<string> elements { get; set; }
            }

            public class RemittanceAddressRecipient
            {
                public string type { get; set; }
                public string valueString { get; set; }
                public string text { get; set; }
                public List<double?> boundingBox { get; set; }
                public double? page { get; set; }
                public double? confidence { get; set; }
                public List<string> elements { get; set; }
            }

            public class ServiceAddress
            {
                public string type { get; set; }
                public string valueString { get; set; }
                public string text { get; set; }
                public List<double?> boundingBox { get; set; }
                public double? page { get; set; }
                public double? confidence { get; set; }
                public List<string> elements { get; set; }
            }

            public class ServiceAddressRecipient
            {
                public string type { get; set; }
                public string valueString { get; set; }
                public string text { get; set; }
                public List<double?> boundingBox { get; set; }
                public double? page { get; set; }
                public double? confidence { get; set; }
                public List<string> elements { get; set; }
            }

            public class ShippingAddress
            {
                public string type { get; set; }
                public string valueString { get; set; }
                public string text { get; set; }
                public List<double?> boundingBox { get; set; }
                public double? page { get; set; }
                public double? confidence { get; set; }
                public List<string> elements { get; set; }
            }

            public class ShippingAddressRecipient
            {
                public string type { get; set; }
                public string valueString { get; set; }
                public string text { get; set; }
                public List<double?> boundingBox { get; set; }
                public double? page { get; set; }
                public double? confidence { get; set; }
                public List<string> elements { get; set; }
            }

            public class SubTotal
            {
                public string type { get; set; }
                public double? valueNumber { get; set; }
                public string text { get; set; }
                public List<double?> boundingBox { get; set; }
                public double? page { get; set; }
                public double? confidence { get; set; }
                public List<string> elements { get; set; }
            }

            public class TotalTax
            {
                public string type { get; set; }
                public double? valueNumber { get; set; }
                public string text { get; set; }
                public List<double?> boundingBox { get; set; }
                public double? page { get; set; }
                public double? confidence { get; set; }
                public List<string> elements { get; set; }
            }

            public class VendorAddress
            {
                public string type { get; set; }
                public string valueString { get; set; }
                public string text { get; set; }
                public List<double?> boundingBox { get; set; }
                public double? page { get; set; }
                public double? confidence { get; set; }
                public List<string> elements { get; set; }
            }

            public class VendorAddressRecipient
            {
                public string type { get; set; }
                public string valueString { get; set; }
                public string text { get; set; }
                public List<double?> boundingBox { get; set; }
                public double? page { get; set; }
                public double? confidence { get; set; }
                public List<string> elements { get; set; }
            }

            public class VendorName
            {
                public string type { get; set; }
                public string valueString { get; set; }
                public string text { get; set; }
                public List<double?> boundingBox { get; set; }
                public double? page { get; set; }
                public double? confidence { get; set; }
                public List<string> elements { get; set; }
            }

            public class AmountDue
            {
                public string type { get; set; }
                public int? valueNumber { get; set; }
                public string text { get; set; }
                public List<int?> boundingBox { get; set; }
                public int? page { get; set; }
                public double? confidence { get; set; }
                public List<string> elements { get; set; }
            }

            public class BillingAddress
            {
                public string type { get; set; }
                public string valueString { get; set; }
                public string text { get; set; }
                public List<int?> boundingBox { get; set; }
                public int? page { get; set; }
                public double? confidence { get; set; }
                public List<string> elements { get; set; }
            }

            public class BillingAddressRecipient
            {
                public string type { get; set; }
                public string valueString { get; set; }
                public string text { get; set; }
                public List<double?> boundingBox { get; set; }
                public int? page { get; set; }
                public double? confidence { get; set; }
                public List<string> elements { get; set; }
            }

            public class CustomerAddress
            {
                public string type { get; set; }
                public string valueString { get; set; }
                public string text { get; set; }
                public List<double?> boundingBox { get; set; }
                public int? page { get; set; }
                public double confidence { get; set; }
                public List<string> elements { get; set; }
            }

            public class CustomerAddressRecipient
            {
                public string type { get; set; }
                public string valueString { get; set; }
                public string text { get; set; }
                public List<double> boundingBox { get; set; }
                public int? page { get; set; }
                public double confidence { get; set; }
                public List<string> elements { get; set; }
            }
            public class CustomerId
            {
                public string type { get; set; }
                public string valueString { get; set; }
                public string text { get; set; }
                public List<int?> boundingBox { get; set; }
                public int? page { get; set; }
                public double? confidence { get; set; }
                public List<string> elements { get; set; }
            }

            public class CustomerName
            {
                public string type { get; set; }
                public string valueString { get; set; }
                public string text { get; set; }
                public List<int?> boundingBox { get; set; }
                public int? page { get; set; }
                public double confidence { get; set; }
                public List<string> elements { get; set; }
            }

            public class DueDate
            {
                public string type { get; set; }
                public string valueDate { get; set; }
                public string text { get; set; }
                public List<int?> boundingBox { get; set; }
                public int? page { get; set; }
                public double? confidence { get; set; }
                public List<string> elements { get; set; }
            }

            public class InvoiceDate
            {
                public string type { get; set; }
                public string valueDate { get; set; }
                public string text { get; set; }
                public List<int?> boundingBox { get; set; }
                public int? page { get; set; }
                public double confidence { get; set; }
                public List<string> elements { get; set; }
            }

            public class InvoiceId
            {
                public string type { get; set; }
                public string valueString { get; set; }
                public string text { get; set; }
                public List<int?> boundingBox { get; set; }
                public int? page { get; set; }
                public int? confidence { get; set; }
                public List<string> elements { get; set; }
            }

            public class InvoiceTotal
            {
                public string type { get; set; }
                public int? valueNumber { get; set; }
                public string text { get; set; }
                public List<int?> boundingBox { get; set; }
                public int? page { get; set; }
                public double? confidence { get; set; }
                public List<string> elements { get; set; }
            }

            public class Fields
            {
                public AmountDue AmountDue { get; set; }
                public BillingAddress BillingAddress { get; set; }
                public BillingAddressRecipient BillingAddressRecipient { get; set; }
                public CustomerAddress CustomerAddress { get; set; }
                public CustomerAddressRecipient CustomerAddressRecipient { get; set; }
                public CustomerId CustomerId { get; set; }
                public CustomerName CustomerName { get; set; }
                public DueDate DueDate { get; set; }
                public InvoiceDate InvoiceDate { get; set; }
                public InvoiceId InvoiceId { get; set; }
                public InvoiceTotal InvoiceTotal { get; set; }
                public PreviousUnpaidBalance PreviousUnpaidBalance { get; set; }
                public PurchaseOrder PurchaseOrder { get; set; }
                public RemittanceAddress RemittanceAddress { get; set; }
                public RemittanceAddressRecipient RemittanceAddressRecipient { get; set; }
                public ServiceAddress ServiceAddress { get; set; }
                public ServiceAddressRecipient ServiceAddressRecipient { get; set; }
                public ShippingAddress ShippingAddress { get; set; }
                public ShippingAddressRecipient ShippingAddressRecipient { get; set; }
                public SubTotal SubTotal { get; set; }
                public TotalTax TotalTax { get; set; }
                public VendorAddress VendorAddress { get; set; }
                public VendorAddressRecipient VendorAddressRecipient { get; set; }
                public VendorName VendorName { get; set; }
            }

            public class DocumentResult
            {
                public string docType { get; set; }
                public List<double?> pageRange { get; set; }
                public Fields fields { get; set; }
            }

            public class AnalyzeResult
            {
                public string version { get; set; }
                public List<object> readResults { get; set; }
                public List<object> pageResults { get; set; }
                public List<DocumentResult> documentResults { get; set; }
            }

            public class OriginalResult
            {
                public string status { get; set; }
                public DateTime? createdDateTime { get; set; }
                public DateTime? lastUpdatedDateTime { get; set; }
                public AnalyzeResult analyzeResult { get; set; }
            }

            public class CustomerInformation
            {
                public string customer_address { get; set; }
                public string customer_id { get; set; }
                public string customer_name { get; set; }
            }

            public class MerchantInformation
            {
                public string merchant_address { get; set; }
                public string merchant_name { get; set; }
            }

            public class Locale
            {
                public string currency { get; set; }
            }

            public class NormalizedResult
            {
                public CustomerInformation customer_information { get; set; }
                public MerchantInformation merchant_information { get; set; }
                public double? invoice_total { get; set; }
                public double? subtotal { get; set; }
                public DateTime? date { get; set; }
                public DateTime? due_date { get; set; }
                public string invoice_number { get; set; }
                public TotalTax taxes { get; set; }
                public Locale locale { get; set; }
            }

            public class Response
            {
                public string solution_name { get; set; }
                public string execution_time { get; set; }
                public List<OriginalResult> original_result { get; set; }
                public List<NormalizedResult> normalized_result { get; set; }
                public double? number_of_pages { get; set; }
                public string status { get; set; }
                public bool is_failed { get; set; }
            }

            
            public OCRInvoice_Error Error { get; set; }
        }

       
        public class OCRInvoice_Error
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

        #region OCRReader
        public async Task<OCRReader_Response> OCRReader(OCRReader_Request requestbody)
        {

            try
            {
                var client = new RestClient("https://api.edenai.run/v1/pretrained/vision/ocr");

                var request = new RestRequest(Method.POST);
                request.AddHeader("Authorization", API_KEY);


                request.AddParameter("providers", JsonConvert.SerializeObject(requestbody.Providers));

                request.AddParameter("language", requestbody.Language);

                request.AddFile("files", requestbody.FilePath);
                IRestResponse response = await client.ExecuteAsync(request);

                if (response.IsSuccessful)
                {
                    OCRReader_Response responsefinal = JsonConvert.DeserializeObject<OCRReader_Response>(response.Content);
                    return responsefinal;
                }

                OCRReader_Error error = JsonConvert.DeserializeObject<OCRReader_Error>(response.Content);
                return new OCRReader_Response() { Error = error };

            }
            catch (Exception e)
            {
                return new OCRReader_Response() { Error = new OCRReader_Error() };
            }
        }

        /// <summary>
        /// Optical Character Recognition or optical character reader (OCR) is the electronic or mechanical conversion of images of typed, handwritten or printed text into machine-encoded text, whether from a scanned document, a photo of a document.
        /// </summary>
        /// <param name="language"></param>
        /// <param name="filepath"></param>
        /// <param name="providers"></param>
        /// <returns></returns>
        public async Task<OCRReader_Response> OCRReader(string language ,string filepath, List<string> providers )
        {

            try
            {
                var client = new RestClient("https://api.edenai.run/v1/pretrained/vision/ocr");

                var request = new RestRequest(Method.POST);
                request.AddHeader("Authorization", API_KEY);


                request.AddParameter("providers", JsonConvert.SerializeObject(providers));

                request.AddParameter("language", language);

                request.AddFile("files", filepath);
                IRestResponse response = await client.ExecuteAsync(request);

                if (response.IsSuccessful)
                {
                    OCRReader_Response responsefinal = JsonConvert.DeserializeObject<OCRReader_Response>(response.Content);
                    return responsefinal;
                }

                OCRReader_Error error = JsonConvert.DeserializeObject<OCRReader_Error>(response.Content);
                return new OCRReader_Response() { Error = error };

            }
            catch (Exception e)
            {
                return new OCRReader_Response() { Error = new OCRReader_Error() };
            }
        }


        public class OCRReader_Request
        {

            public string Language { get; set; }
            public string FilePath { get; set; }

            public List<string> Providers { get; set; }
        }


        public class OCRReader_Response
        {
            public List<Response> Result { get; set; }


            public class BoundingBox
            {
                public double Width { get; set; }
                public double Height { get; set; }
                public double Left { get; set; }
                public double Top { get; set; }
            }

            public class Polygon
            {
                public double X { get; set; }
                public double Y { get; set; }
            }

            public class Geometry
            {
                public BoundingBox BoundingBox { get; set; }
                public List<Polygon> Polygon { get; set; }
            }

            public class TextDetection
            {
                public string DetectedText { get; set; }
                public string Type { get; set; }
                public int Id { get; set; }
                public double Confidence { get; set; }
                public Geometry Geometry { get; set; }
                public int? ParentId { get; set; }
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
                public List<TextDetection> TextDetections { get; set; }
                public ResponseMetadata ResponseMetadata { get; set; }
            }

            public class Response
            {
                public string solution_name { get; set; }
                public string execution_time { get; set; }
                public string final_text { get; set; }
                public int matching_characters { get; set; }
                public List<ApiResponse> api_response { get; set; }
                public int number_of_pages { get; set; }
            }

            public OCRReader_Error Error { get; set; }
        }


        public class OCRReader_Error
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
