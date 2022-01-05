# EdenAI.Api.OCRApi

All URIs are relative to *https://api.edenai.run/v1/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Ocr**](OCRApi.md#ocr) | **POST** /pretrained/ocr/ocr | 
[**OcrInvoice**](OCRApi.md#ocrinvoice) | **POST** /pretrained/ocr/ocr_invoice | 


<a name="ocr"></a>
# **Ocr**
> InlineResponse2001 Ocr (System.IO.Stream files, string providers, string language)



Optical Character Recognition or optical character reader (OCR) is the electronic or mechanical conversion of images of typed, handwritten or printed text into machine-encoded text, whether from a scanned document, a photo of a document  **SUPPORTED LANGUAGE**  |Name|Type|Value| |- -- -|- -- -|- -- --| |**Arabic**|`string`|`ar-XA`| |**Chinese - Simplified**|`string`|`zh-CN`| |**Chinese - Traditional**|`string`|`zh-TW`| |**Czech**|`string`|`cz-CZ`| |**Danish**|`string`|`da-DK`| |**Dutch**|`string`|`nl-NL`| |**English**|`string`|`en-US`| |**Finnish**|`string`|`fn-FN`| |**French**|`string`|`fr-FR`| |**German**|`string`|`de-DE`| |**Greek**|`string`|`gr-GR`| |**Hungarian**|`string`|`hu-HU`| |**Italian**|`string`|`it-IT`| |**Japanese**|`string`|`ja-JP`| |**Korean**|`string`|`ko-KR`| |**Polish**|`string`|`pl-PO`| |**Portuguese**|`string`|`pt-PT`| |**Russian**|`string`|`ru-RU`| |**Swedish**|`string`|`sw-SW`| |**Spanish**|`string`|`es-ES`| |**Turkish**|`string`|`tr-TR`|  **AVAILABLE PROVIDERS**   |Name|Value|Version| |- -- -|- -- --|- -- -- --| |[**Google Cloud**](https://www.edenai.co/catalog/google-cloud-vision-(ocr))|`google`|`v1`| |[**Microsoft Azure**](https://www.edenai.co/catalog/azure-computer-vision-(ocr))|`microsoft`|`v3.2`| |[**Amazon Web Services**](https://www.edenai.co/catalog/amazon-textract)|`amazon`|`boto3 (v1.15.18)`|

### Example
```csharp
using System;
using System.Diagnostics;
using EdenAI.Api;
using EdenAI.Client;
using EdenAI.Model;

namespace Example
{
    public class OcrExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OCRApi();
            var files = new System.IO.Stream(); // System.IO.Stream | File to analyse (ex: pdf, jpg, jpeg, png, tiff)
            var providers = providers_example;  // string | Providers to compare (ex: [ 'amazon', 'microsoft', 'ibm', 'google'])
            var language = language_example;  // string | Language code expected (ex: fr-FR)

            try
            {
                InlineResponse2001 result = apiInstance.Ocr(files, providers, language);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OCRApi.Ocr: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | **System.IO.Stream**| File to analyse (ex: pdf, jpg, jpeg, png, tiff) | 
 **providers** | **string**| Providers to compare (ex: [ &#39;amazon&#39;, &#39;microsoft&#39;, &#39;ibm&#39;, &#39;google&#39;]) | 
 **language** | **string**| Language code expected (ex: fr-FR) | 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ocrinvoice"></a>
# **OcrInvoice**
> InlineResponse2002 OcrInvoice (System.IO.Stream files, string providers, string language)



The OCR Invoice API enables customers to take invoices in a variety of formats and return structured data to automate the invoice processing.  **SUPPORTED LANGUAGE**  |Name|Type|Value| |- -- -|- -- -|- -- --| |**English(US)**|`string`|`en-US`| |**French**|`string`|`fr-FR`| |**Spanish**|`string`|`es-ES`|  **AVAILABLE PROVIDERS**   |Name|Value|Version| |- -- -|- -- --|- -- -- --| |[**Microsoft Azure**](https://www.edenai.co/catalog/azure-computer-vision-(ocr))|`microsoft`|`v2.1-preview.3`|

### Example
```csharp
using System;
using System.Diagnostics;
using EdenAI.Api;
using EdenAI.Client;
using EdenAI.Model;

namespace Example
{
    public class OcrInvoiceExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OCRApi();
            var files = new System.IO.Stream(); // System.IO.Stream | File Image to analyse (ex: pdf, jpg, jpeg, png)
            var providers = providers_example;  // string | Provider to compare (ex: [ 'mindee', 'microsoft'])
            var language = language_example;  // string | Language code of invoice (ex: fr-FR (French), en-US (English), es-ES (Spanish))

            try
            {
                InlineResponse2002 result = apiInstance.OcrInvoice(files, providers, language);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OCRApi.OcrInvoice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | **System.IO.Stream**| File Image to analyse (ex: pdf, jpg, jpeg, png) | 
 **providers** | **string**| Provider to compare (ex: [ &#39;mindee&#39;, &#39;microsoft&#39;]) | 
 **language** | **string**| Language code of invoice (ex: fr-FR (French), en-US (English), es-ES (Spanish)) | 

### Return type

[**InlineResponse2002**](InlineResponse2002.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

