# EdenAI.Api.TextApi

All URIs are relative to *https://api.edenai.run/v1/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**KeywordExtraction**](TextApi.md#keywordextraction) | **POST** /pretrained/text/keyword_extraction | 
[**NamedEntityRecognition**](TextApi.md#namedentityrecognition) | **POST** /pretrained/text/named_entity_recognition | 
[**SentimentAnalysis**](TextApi.md#sentimentanalysis) | **POST** /pretrained/text/sentiment_analysis | 
[**SyntaxAnalysis**](TextApi.md#syntaxanalysis) | **POST** /pretrained/text/syntax_analysis | 


<a name="keywordextraction"></a>
# **KeywordExtraction**
> InlineResponse2003 KeywordExtraction (string language, string text, string providers)



Keyword extraction (also known as keyword detection or keyword analysis) is a text analysis technique that consists of automatically extracting the mostimportant words and expressions in a text.  **SUPPORTED LANGUAGE**  |Name|Type|Value| |- -- -|- -- -|- -- --| |**English(US)**|`string`|`en-US`| |**French**|`string`|`fr-FR`| |**Spanish**|`string`|`es-ES`|  **AVAILABLE PROVIDERS**   |Name|Value|Version| |- -- -|- -- --|- -- -- --| |[**Microsoft Azure**](https://www.edenai.co/catalog/azure-text-analytics)|`microsoft`|`v3.1`| |[**Amazon Web Services**](https://www.edenai.co/catalog/amazon-comprehend)|`amazon`|`boto3 (v1.15.18)`| |[**IBM Watson**](https://www.edenai.co/catalog/watson-natural-language-understanding)|`ibm`|`v1 (2021-08-01)`|

### Example
```csharp
using System;
using System.Diagnostics;
using EdenAI.Api;
using EdenAI.Client;
using EdenAI.Model;

namespace Example
{
    public class KeywordExtractionExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TextApi();
            var language = language_example;  // string | Language code of text (ex: fr-FR (French), en-US (English), es-ES (Spanish))
            var text = text_example;  // string | Text to analyze
            var providers = providers_example;  // string | Provider to compare (ex: [ 'amazon', 'microsoft', 'ibm'])

            try
            {
                InlineResponse2003 result = apiInstance.KeywordExtraction(language, text, providers);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TextApi.KeywordExtraction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **language** | **string**| Language code of text (ex: fr-FR (French), en-US (English), es-ES (Spanish)) | 
 **text** | **string**| Text to analyze | 
 **providers** | **string**| Provider to compare (ex: [ &#39;amazon&#39;, &#39;microsoft&#39;, &#39;ibm&#39;]) | 

### Return type

[**InlineResponse2003**](InlineResponse2003.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="namedentityrecognition"></a>
# **NamedEntityRecognition**
> InlineResponse2004 NamedEntityRecognition (string language, string text, string providers)



Named Entity Recognition (also called entity identification or entity extraction) is an information extraction technique that automatically identifies named entities in a text and classifies them into predefined categories.  **SUPPORTED LANGUAGE**  |Name|Type|Value| |- -- -|- -- -|- -- --| |**English(US)**|`string`|`en-US`| |**French**|`string`|`fr-FR`| |**Spanish**|`string`|`es-ES`|  **AVAILABLE PROVIDERS**   |Name|Value|Version| |- -- -|- -- --|- -- -- --| |[**Microsoft Azure**](https://www.edenai.co/catalog/azure-text-analytics)|`microsoft`|`v3.1`| |[**Amazon Web Services**](https://www.edenai.co/catalog/amazon-comprehend)|`amazon`|`boto3 (v1.15.18)`| |[**IBM Watson**](https://www.edenai.co/catalog/watson-natural-language-understanding)|`ibm`|`v1 (2021-08-01)`| |[**Google Cloud**](https://www.edenai.co/catalog/google-cloud-natural-language)|`google`|`v1`|

### Example
```csharp
using System;
using System.Diagnostics;
using EdenAI.Api;
using EdenAI.Client;
using EdenAI.Model;

namespace Example
{
    public class NamedEntityRecognitionExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TextApi();
            var language = language_example;  // string | Language code of text (ex: fr-FR (French), en-US (English), es-ES (Spanish))
            var text = text_example;  // string | Text to analyze
            var providers = providers_example;  // string | Provider to compare (ex: [ 'amazon', 'microsoft', 'ibm','google'])

            try
            {
                InlineResponse2004 result = apiInstance.NamedEntityRecognition(language, text, providers);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TextApi.NamedEntityRecognition: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **language** | **string**| Language code of text (ex: fr-FR (French), en-US (English), es-ES (Spanish)) | 
 **text** | **string**| Text to analyze | 
 **providers** | **string**| Provider to compare (ex: [ &#39;amazon&#39;, &#39;microsoft&#39;, &#39;ibm&#39;,&#39;google&#39;]) | 

### Return type

[**InlineResponse2004**](InlineResponse2004.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sentimentanalysis"></a>
# **SentimentAnalysis**
> InlineResponse2005 SentimentAnalysis (string language, string text, string providers)



Sentiment analysis API extracts sentiment in a given string of text.Sentiment analysis, also called 'opinion mining',uses natural language processing, text analysis and computational linguistics to identify and detect subjective information from the input text.  **SUPPORTED LANGUAGE**  |Name|Type|Value| |- -- -|- -- -|- -- --| |**English(US)**|`string`|`en-US`| |**French**|`string`|`fr-FR`| |**Spanish**|`string`|`es-ES`|  **AVAILABLE PROVIDERS**   |Name|Value|Version| |- -- -|- -- --|- -- -- --| |[**Microsoft Azure**](https://www.edenai.co/catalog/azure-text-analytics)|`microsoft`|`v3.1`| |[**Amazon Web Services**](https://www.edenai.co/catalog/amazon-comprehend)|`amazon`|`boto3 (v1.15.18)`| |[**IBM Watson**](https://www.edenai.co/catalog/watson-natural-language-understanding)|`ibm`|`v1 (2021-08-01)`| |[**Google Cloud**](https://www.edenai.co/catalog/google-cloud-natural-language)|`google`|`v1`| |[**Lettria**](https://www.edenai.co/catalog/Lettria)|`lettria`|`v5.5.2`|

### Example
```csharp
using System;
using System.Diagnostics;
using EdenAI.Api;
using EdenAI.Client;
using EdenAI.Model;

namespace Example
{
    public class SentimentAnalysisExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TextApi();
            var language = language_example;  // string | Language code of text (ex: fr-FR (French), en-US (English), es-ES (Spanish))
            var text = text_example;  // string | Text to analyze
            var providers = providers_example;  // string | Provider to compare (ex: [ 'amazon', 'microsoft', 'ibm', 'google'])

            try
            {
                InlineResponse2005 result = apiInstance.SentimentAnalysis(language, text, providers);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TextApi.SentimentAnalysis: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **language** | **string**| Language code of text (ex: fr-FR (French), en-US (English), es-ES (Spanish)) | 
 **text** | **string**| Text to analyze | 
 **providers** | **string**| Provider to compare (ex: [ &#39;amazon&#39;, &#39;microsoft&#39;, &#39;ibm&#39;, &#39;google&#39;]) | 

### Return type

[**InlineResponse2005**](InlineResponse2005.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="syntaxanalysis"></a>
# **SyntaxAnalysis**
> InlineResponse2006 SyntaxAnalysis (string language, string text, string providers)



Syntax analysis consists principaly in highlighting the structure of a text.  **SUPPORTED LANGUAGE**  |Name|Type|Value| |- -- -|- -- -|- -- --| |**English(US)**|`string`|`en-US`| |**French**|`string`|`fr-FR`| |**Spanish**|`string`|`es-ES`|  **AVAILABLE PROVIDERS**   |Name|Value|Version| |- -- -|- -- --|- -- -- --| |[**Microsoft Azure**](https://www.edenai.co/catalog/azure-text-analytics)|`microsoft`|`v3.1`| |[**Amazon Web Services**](https://www.edenai.co/catalog/amazon-comprehend)|`amazon`|`boto3 (v1.15.18)`| |[**IBM Watson**](https://www.edenai.co/catalog/watson-natural-language-understanding)|`ibm`|`v1 (2021-08-01)`| |[**Lettria**](https://www.edenai.co/catalog/Lettria)|`lettria`|`v5.5.2`| |[**Google Cloud**](https://www.edenai.co/catalog/google-cloud-natural-language)|`google`|`v1`|

### Example
```csharp
using System;
using System.Diagnostics;
using EdenAI.Api;
using EdenAI.Client;
using EdenAI.Model;

namespace Example
{
    public class SyntaxAnalysisExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TextApi();
            var language = language_example;  // string | Language code of text (ex: fr-FR (French), en-US (English), es-ES (Spanish))
            var text = text_example;  // string | Text to analyze
            var providers = providers_example;  // string | Provider to compare (ex: [ 'amazon', 'microsoft', 'ibm','google'])

            try
            {
                InlineResponse2006 result = apiInstance.SyntaxAnalysis(language, text, providers);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TextApi.SyntaxAnalysis: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **language** | **string**| Language code of text (ex: fr-FR (French), en-US (English), es-ES (Spanish)) | 
 **text** | **string**| Text to analyze | 
 **providers** | **string**| Provider to compare (ex: [ &#39;amazon&#39;, &#39;microsoft&#39;, &#39;ibm&#39;,&#39;google&#39;]) | 

### Return type

[**InlineResponse2006**](InlineResponse2006.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

