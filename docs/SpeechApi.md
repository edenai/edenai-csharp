# EdenAI.Api.SpeechApi

All URIs are relative to *https://api.edenai.run/v1/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AsynchronousSpeechRecognition**](SpeechApi.md#asynchronousspeechrecognition) | **POST** /pretrained/audio/speech_recognition_async | 
[**AsynchronousSpeechRecognition_0**](SpeechApi.md#asynchronousspeechrecognition_0) | **GET** /pretrained/audio/speech_recognition_async/{job_id} | 
[**SpeechRecognition**](SpeechApi.md#speechrecognition) | **POST** /pretrained/audio/speech_recognition | 
[**TextToSpeech**](SpeechApi.md#texttospeech) | **POST** /pretrained/audio/text_to_speech | 


<a name="asynchronousspeechrecognition"></a>
# **AsynchronousSpeechRecognition**
> void AsynchronousSpeechRecognition (string language, System.IO.Stream files, string providers)



Speech recognition is technology that can recognize spoken words, which can then be converted to text. This endpoint allows you to launch asynchronous speech recognition jobs.  **SUPPORTED LANGUAGE**  |Name|Type|Value| |- -- -|- -- -|- -- --| |**English (US)**|`string`|`en-US`| |**English (GB)**|`string`|`en-GB`| |**French**|`string`|`fr-FR`| |**Spanish**|`string`|`es-ES`| |**Dutch (Netherlands)**|`string`|`nl-NL`| |**Japanese**|`string`|`ja-JP`| |**Russian**|`string`|`ru-RU`| |**Arabic**|`string`|`ar-SA`| |**Italian**|`string`|`it-IT`| |**Korean**|`string`|`ko-KR`| |**Portuguese**|`string`|`pt-PT`| |**Turkish**|`string`|`tr-TR`| |**Indonesian**|`string`|`id-ID`| |**Malay**|`string`|`ms-MY`|  **AVAILABLE PROVIDERS**   |Name|Value|Version| |- -- -|- -- --|- -- -- --| |[**Microsoft Azure**](https://www.edenai.co/catalog/azure-speech-to-text)|`microsoft`|`v1.0`| |[**Amazon Web Services**](https://www.edenai.co/catalog/amazon-transcribe)|`amazon`|`boto3 (v1.15.18)`| |[**Google Cloud**](https://www.edenai.co/catalog/google-cloud-speech-to-text)|`google`|`v1p1beta1`| |[**Deepgram**](https://www.edenai.co/catalog/deepgram)|`deepgram`|`v1`| |[**Assembly**](https://www.edenai.co/catalog/assembly-ai)|`assembly`|`v1`|

### Example
```csharp
using System;
using System.Diagnostics;
using EdenAI.Api;
using EdenAI.Client;
using EdenAI.Model;

namespace Example
{
    public class AsynchronousSpeechRecognitionExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SpeechApi();
            var language = language_example;  // string | Language code expected (ex: fr-FR (French), en-US (English), es-ES (Spanish), nl-NL Dutch (Netherlands))
            var files = new System.IO.Stream(); // System.IO.Stream | File to analyse (ex: mp3, wav, m4a)
            var providers = providers_example;  // string | Provider to compare (ex: [ 'amazon', 'microsoft', 'ibm','google', 'threescribe])

            try
            {
                apiInstance.AsynchronousSpeechRecognition(language, files, providers);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechApi.AsynchronousSpeechRecognition: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **language** | **string**| Language code expected (ex: fr-FR (French), en-US (English), es-ES (Spanish), nl-NL Dutch (Netherlands)) | 
 **files** | **System.IO.Stream**| File to analyse (ex: mp3, wav, m4a) | 
 **providers** | **string**| Provider to compare (ex: [ &#39;amazon&#39;, &#39;microsoft&#39;, &#39;ibm&#39;,&#39;google&#39;, &#39;threescribe]) | 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="asynchronousspeechrecognition_0"></a>
# **AsynchronousSpeechRecognition_0**
> void AsynchronousSpeechRecognition_0 (string jobId)



This endpoint allows you to check the state of  your asynchronous speech recognition job and returns the results when they are ready.

### Example
```csharp
using System;
using System.Diagnostics;
using EdenAI.Api;
using EdenAI.Client;
using EdenAI.Model;

namespace Example
{
    public class AsynchronousSpeechRecognition_0Example
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SpeechApi();
            var jobId = jobId_example;  // string | 

            try
            {
                apiInstance.AsynchronousSpeechRecognition_0(jobId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechApi.AsynchronousSpeechRecognition_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="speechrecognition"></a>
# **SpeechRecognition**
> InlineResponse201 SpeechRecognition (string language, System.IO.Stream files, string providers)



Speech recognition is technology that can recognize spoken words, which can then be converted to text.  **SUPPORTED LANGUAGE**  |Name|Type|Value| |- -- -|- -- -|- -- --| |**English (US)**|`string`|`en-US`| |**English (GB)**|`string`|`en-GB`| |**French**|`string`|`fr-FR`| |**Spanish**|`string`|`es-ES`| |**Dutch (Netherlands)**|`string`|`nl-NL`| |**Japanese**|`string`|`ja-JP`| |**Russian**|`string`|`ru-RU`| |**Arabic**|`string`|`ar-SA`| |**Italian**|`string`|`it-IT`| |**Korean**|`string`|`ko-KR`| |**Portuguese**|`string`|`pt-PT`| |**Turkish**|`string`|`tr-TR`| |**Indonesian**|`string`|`id-ID`| |**Malay**|`string`|`ms-MY`|  **AVAILABLE PROVIDERS**   |Name|Value|Version| |- -- -|- -- --|- -- -- --| |[**Microsoft Azure**](https://www.edenai.co/catalog/azure-speech-to-text)|`microsoft`|`v1.0`| |[**Amazon Web Services**](https://www.edenai.co/catalog/amazon-transcribe)|`amazon`|`boto3 (v1.15.18)`| |[**Google Cloud**](https://www.edenai.co/catalog/google-cloud-speech-to-text)|`google`|`v1p1beta1`| |[**Deepgram**](https://www.edenai.co/catalog/deepgram)|`deepgram`|`v1`| |[**Assembly**](https://www.edenai.co/catalog/assembly-ai)|`assembly`|`v1`|

### Example
```csharp
using System;
using System.Diagnostics;
using EdenAI.Api;
using EdenAI.Client;
using EdenAI.Model;

namespace Example
{
    public class SpeechRecognitionExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SpeechApi();
            var language = language_example;  // string | Language code expected (ex: fr-FR (French), en-US (English), es-ES (Spanish), nl-NL Dutch (Netherlands))
            var files = new System.IO.Stream(); // System.IO.Stream | File to analyse (ex: mp3, wav, m4a)
            var providers = providers_example;  // string | Provider to compare (ex: [ 'amazon', 'microsoft', 'ibm','google', 'threescribe])

            try
            {
                InlineResponse201 result = apiInstance.SpeechRecognition(language, files, providers);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechApi.SpeechRecognition: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **language** | **string**| Language code expected (ex: fr-FR (French), en-US (English), es-ES (Spanish), nl-NL Dutch (Netherlands)) | 
 **files** | **System.IO.Stream**| File to analyse (ex: mp3, wav, m4a) | 
 **providers** | **string**| Provider to compare (ex: [ &#39;amazon&#39;, &#39;microsoft&#39;, &#39;ibm&#39;,&#39;google&#39;, &#39;threescribe]) | 

### Return type

[**InlineResponse201**](InlineResponse201.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="texttospeech"></a>
# **TextToSpeech**
> InlineResponse2011 TextToSpeech (string text, string language, string option, string providers)



Text-to-speech (TTS) system converts normal language text into speech.  **SUPPORTED LANGUAGE**  |Name|Type|Value| |- -- -|- -- -|- -- --| |**Arabic**|`string`|`ar-XA`| |**Chinese**|`string`|`cmn-CN`| |**Danish**|`string`|`da-DK`| |**Dutch**|`string`|`nl-NL`| |**English (US)**|`string`|`en-US`| |**English (UK)**|`string`|`en-GB`| |**German**|`string`|`de-DE`| |**Italy**|`string`|`it-IT`| |**Japanese**|`string`|`ja-JP`| |**Portuguese (Brazil)**|`string`|`pt-BR`| |**Portuguese (Portugal)**|`string`|`pt-PT`| |**Russian**|`string`|`ru-RU`| |**Spanish**|`string`|`es-ES`|  **AVAILABLE PROVIDERS**   |Name|Value|Version| |- -- -|- -- --|- -- -- --| |[**Microsoft Azure**](https://www.edenai.co/catalog/azure-text-to-speech)|`microsoft`|`v1.0`| |[**Amazon Web Services**](https://www.edenai.co/catalog/amazon-polly)|`amazon`|`boto3 (v1.15.18)`| |[**Google Cloud**](https://www.edenai.co/catalog/google-cloud-text-to-speech)|`google`|`v1`|

### Example
```csharp
using System;
using System.Diagnostics;
using EdenAI.Api;
using EdenAI.Client;
using EdenAI.Model;

namespace Example
{
    public class TextToSpeechExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SpeechApi();
            var text = text_example;  // string | Text to transform
            var language = language_example;  // string | Language code expected (ex: fr-FR (French), en-US (English), es-ES (Spanish))
            var option = option_example;  // string | Voice gender selected (ex: FEMALE ou MALE)
            var providers = providers_example;  // string | Provider to compare (ex: [ 'amazon', 'microsoft', 'ibm','google'])

            try
            {
                InlineResponse2011 result = apiInstance.TextToSpeech(text, language, option, providers);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpeechApi.TextToSpeech: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **text** | **string**| Text to transform | 
 **language** | **string**| Language code expected (ex: fr-FR (French), en-US (English), es-ES (Spanish)) | 
 **option** | **string**| Voice gender selected (ex: FEMALE ou MALE) | 
 **providers** | **string**| Provider to compare (ex: [ &#39;amazon&#39;, &#39;microsoft&#39;, &#39;ibm&#39;,&#39;google&#39;]) | 

### Return type

[**InlineResponse2011**](InlineResponse2011.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

