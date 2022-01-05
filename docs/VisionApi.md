# EdenAI.Api.VisionApi

All URIs are relative to *https://localhosthttps://api.edenai.run/v1/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ExplicitContentDetection**](VisionApi.md#explicitcontentdetection) | **POST** /pretrained/vision/explicit_content_detection | 
[**FaceDetection**](VisionApi.md#facedetection) | **POST** /pretrained/vision/face_detection | 
[**ObjectDetection**](VisionApi.md#objectdetection) | **POST** /pretrained/vision/object_detection | 


<a name="explicitcontentdetection"></a>
# **ExplicitContentDetection**
> InlineResponse2009 ExplicitContentDetection (System.IO.Stream files, string providers)



Explicit Content Detection detects adult only content in videos, who is generally inappropriate for people under the age of 18 and includes nudity, sexual activity and pornography ...  **AVAILABLE PROVIDERS**   |Name|Value|Version| |- -- -|- -- --|- -- -- --| |[**Microsoft Azure**](https://www.edenai.co/catalog/azure-computer-vision)|`microsoft`|`v3.2`| |[**Amazon Web Services**](https://www.edenai.co/catalog/amazon-rekognition)|`amazon`|`boto3 (v1.15.18)`| |[**Google Cloud**](https://www.edenai.co/catalog/google-cloud-vision)|`google`|`v1`|

### Example
```csharp
using System;
using System.Diagnostics;
using EdenAI.Api;
using EdenAI.Client;
using EdenAI.Model;

namespace Example
{
    public class ExplicitContentDetectionExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VisionApi();
            var files = new System.IO.Stream(); // System.IO.Stream | 
            var providers = providers_example;  // string | 

            try
            {
                InlineResponse2009 result = apiInstance.ExplicitContentDetection(files, providers);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VisionApi.ExplicitContentDetection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | **System.IO.Stream**|  | 
 **providers** | **string**|  | 

### Return type

[**InlineResponse2009**](InlineResponse2009.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="facedetection"></a>
# **FaceDetection**
> InlineResponse20010 FaceDetection (System.IO.Stream files, string providers)



Face Detection is a computer technology being used in a variety of applicationsthat identifies human faces in digital images.  **AVAILABLE PROVIDERS**   |Name|Value|Version| |- -- -|- -- --|- -- -- --| |[**Microsoft Azure**](https://www.edenai.co/catalog/azure-computer-vision)|`microsoft`|`v3.2`| |[**Amazon Web Services**](https://www.edenai.co/catalog/amazon-rekognition)|`amazon`|`boto3 (v1.15.18)`| |[**Google Cloud**](https://www.edenai.co/catalog/google-cloud-vision)|`google`|`v1`|

### Example
```csharp
using System;
using System.Diagnostics;
using EdenAI.Api;
using EdenAI.Client;
using EdenAI.Model;

namespace Example
{
    public class FaceDetectionExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VisionApi();
            var files = new System.IO.Stream(); // System.IO.Stream | 
            var providers = providers_example;  // string | 

            try
            {
                InlineResponse20010 result = apiInstance.FaceDetection(files, providers);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VisionApi.FaceDetection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | **System.IO.Stream**|  | 
 **providers** | **string**|  | 

### Return type

[**InlineResponse20010**](InlineResponse20010.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="objectdetection"></a>
# **ObjectDetection**
> InlineResponse20011 ObjectDetection (System.IO.Stream files, string providers)



Object Detection is a computer vision technique that allows us to identify and locate objects in an image or video  **AVAILABLE PROVIDERS**   |Name|Value|Version| |- -- -|- -- --|- -- -- --| |[**Microsoft Azure**](https://www.edenai.co/catalog/azure-computer-vision)|`microsoft`|`v3.2`| |[**Amazon Web Services**](https://www.edenai.co/catalog/amazon-rekognition)|`amazon`|`boto3 (v1.15.18)`| |[**Google Cloud**](https://www.edenai.co/catalog/google-cloud-vision)|`google`|`v1`|

### Example
```csharp
using System;
using System.Diagnostics;
using EdenAI.Api;
using EdenAI.Client;
using EdenAI.Model;

namespace Example
{
    public class ObjectDetectionExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VisionApi();
            var files = new System.IO.Stream(); // System.IO.Stream | File Image to analyse (ex: pdf, jpg, jpeg, png, tiff)
            var providers = providers_example;  // string | Provider to compare (ex: [ 'amazon', 'microsoft', 'ibm','google'])

            try
            {
                InlineResponse20011 result = apiInstance.ObjectDetection(files, providers);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VisionApi.ObjectDetection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | **System.IO.Stream**| File Image to analyse (ex: pdf, jpg, jpeg, png, tiff) | 
 **providers** | **string**| Provider to compare (ex: [ &#39;amazon&#39;, &#39;microsoft&#39;, &#39;ibm&#39;,&#39;google&#39;]) | 

### Return type

[**InlineResponse20011**](InlineResponse20011.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

