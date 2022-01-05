# EdenAI.Api.PipelinesApi

All URIs are relative to *https://api.edenai.run/v1/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Pipelines**](PipelinesApi.md#pipelines) | **POST** /pipelines | 


<a name="pipelines"></a>
# **Pipelines**
> InlineResponse200 Pipelines (string description, bool? returnOnlyLast, string text = null, System.IO.Stream files = null)



Pipelines let you combine different AI APIs from different providers into a single ready to use pipeline that you can run on your data.   **AVAILABLE FEATURES**   |Feature                   |Value|Can be first|Can be followed by| |- -- -- -- -- -- -- -- -- -- -- -- -- -|- -- -- -- -- -- -- -- -- -- -- --|- -- -- -- -- -- -|- -- -- -- -- -- -- -- -- -| |**OCR**                     |`ocr`                  |`True`      |Sentiment Analysis, Syntax Analysis, Keyword Analysis, Named Entity Recognition, Text to speech, Translation,  Language Detection  | |**Translation**             |`automatic_translation`|`True`      |Sentiment Analysis, Syntax Analysis, Keyword Analysis, Named Entity Recognition, Text to speech                                    | |**Speech recognition**      |`speech_to_text`       |`True`      |Sentiment Analysis, Syntax Analysis, Keyword Analysis, Named Entity Recognition, Text to speech, Translation,  Language Detection  | |**Sentiment Analysis**      |`sentiment_analysis`   |`False`     |None                                                                                                                               | |**Syntax Analysis**         |`syntax_analysis`      |`False`     |None                                                                                                                               | |**Keyword Analysis**        |`keyword_extraction`   |`False`     |None                                                                                                                               | |**Named Entity Recognition**|`language_detection`   |`False`-    |None                                                                                                                               | |**Language Detection**      |`language_detection`   |`False`     |None                                                                                                                               | |**Text to speech**          |`text_to_speech`       |`False`     |None                                                                                                                               | 

### Example
```csharp
using System;
using System.Diagnostics;
using EdenAI.Api;
using EdenAI.Client;
using EdenAI.Model;

namespace Example
{
    public class PipelinesExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PipelinesApi();
            var description = description_example;  // string | The desciption field must be an array of ordered dictionaries.                                                      Each dictionary describes the feature to call. in fact, it has to contain two keys \"feature\" and \"params\".   * feature conatins a string (the value of the feature ex : automatic_translation).  * params contains a dictionary of parameters to be used to call the feature, see the feature corresponding documentation to know which parameters well be needed.   ex : `[ { \"feature\": \"ocr\",  \"params\": { \"providers\": \"['amazon']\",\"language\": \"en-US\" } }, { \"feature\": \"syntax_analysis\",  \"params\": { \"providers\": \"['amazon']\",\"language\": \"en-US\" } }]`                                                      
            var returnOnlyLast = true;  // bool? | This parameter allows user to choose to output only the final result or all the intermediate results.
            var text = text_example;  // string | The input text for the first feature of the pipeline (optional) 
            var files = new System.IO.Stream(); // System.IO.Stream | The input file for the first feature of the pipeline (optional) 

            try
            {
                InlineResponse200 result = apiInstance.Pipelines(description, returnOnlyLast, text, files);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PipelinesApi.Pipelines: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **description** | **string**| The desciption field must be an array of ordered dictionaries.                                                      Each dictionary describes the feature to call. in fact, it has to contain two keys \&quot;feature\&quot; and \&quot;params\&quot;.   * feature conatins a string (the value of the feature ex : automatic_translation).  * params contains a dictionary of parameters to be used to call the feature, see the feature corresponding documentation to know which parameters well be needed.   ex : &#x60;[ { \&quot;feature\&quot;: \&quot;ocr\&quot;,  \&quot;params\&quot;: { \&quot;providers\&quot;: \&quot;[&#39;amazon&#39;]\&quot;,\&quot;language\&quot;: \&quot;en-US\&quot; } }, { \&quot;feature\&quot;: \&quot;syntax_analysis\&quot;,  \&quot;params\&quot;: { \&quot;providers\&quot;: \&quot;[&#39;amazon&#39;]\&quot;,\&quot;language\&quot;: \&quot;en-US\&quot; } }]&#x60;                                                       | 
 **returnOnlyLast** | **bool?**| This parameter allows user to choose to output only the final result or all the intermediate results. | 
 **text** | **string**| The input text for the first feature of the pipeline | [optional] 
 **files** | **System.IO.Stream**| The input file for the first feature of the pipeline | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

