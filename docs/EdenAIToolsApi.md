# EdenAI.Api.EdenAIToolsApi

All URIs are relative to *https://localhosthttps://api.edenai.run/v1/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Search**](EdenAIToolsApi.md#search) | **POST** /tools/search | 


<a name="search"></a>
# **Search**
> InlineResponse20012 Search (string text, string words)



This is an easy tool to lookup for a list of words in a given text

### Example
```csharp
using System;
using System.Diagnostics;
using EdenAI.Api;
using EdenAI.Client;
using EdenAI.Model;

namespace Example
{
    public class SearchExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EdenAIToolsApi();
            var text = text_example;  // string | Text to analyze
            var words = words_example;  // string | (ex: [ 'Happy', 'New', 'Year'])

            try
            {
                InlineResponse20012 result = apiInstance.Search(text, words);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EdenAIToolsApi.Search: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **text** | **string**| Text to analyze | 
 **words** | **string**| (ex: [ &#39;Happy&#39;, &#39;New&#39;, &#39;Year&#39;]) | 

### Return type

[**InlineResponse20012**](InlineResponse20012.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

