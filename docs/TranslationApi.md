# EdenAI.Api.TranslationApi

All URIs are relative to *https://localhosthttps://api.edenai.run/v1/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AutomaticTranslation**](TranslationApi.md#automatictranslation) | **POST** /pretrained/translation/automatic_translation | 
[**LangiageDetection**](TranslationApi.md#langiagedetection) | **POST** /pretrained/translation/language_detection | 


<a name="automatictranslation"></a>
# **AutomaticTranslation**
> InlineResponse2007 AutomaticTranslation (string text, string sourceLanguage, string targetLanguage, string providers)



Machine translation refers to the translation of a text into another language using rules, statics or ml technics.  **SUPPORTED LANGUAGE**  |Name|Type|Value| |- -- -|- -- -|- -- --| |**Afrikaans**|`string`|`af-AF`| |**Albanian**|`string`|`sq-SQ`| |**Amharic**|`string`|`am-AM`| |**Arabic**|`string`|`ar-XA`| |**Armenian**|`string`|`hy-HY`| |**Azerbaijani**|`string`|`az-AZ`| |**Basque**|`string`|`eu-BA`| |**Belarusian**|`string`|`be-BE`| |**Bengali**|`string`|`bn-BN`| |**Bosnian**|`string`|`bs-BS`| |**Bulgarian**|`string`|`bg-BG`| |**Catalan**|`string`|`ca-ES`| |**Cebuano**|`string`|`ceb-CB`| |**Chinese-Simplified**|`string`|`zh-CN`| |**Chinese-Traditional**|`string`|`zh-TW`| |**Corsican**|`string`|`co-CO`| |**Croatian**|`string`|`hr-HR`| |**Czech**|`string`|`cz-CZ`| |**Danish**|`string`|`da-DK`| |**Dutch**|`string`|`nl-NL`| |**English**|`string`|`en-US`| |**Esperanto**|`string`|`eo-EO`| |**Estonian**|`string`|`et-ET`| |**Finnish**|`string`|`fn-FN`| |**French**|`string`|`fr-FR`| |**French-Canadian**|`string`|`fr-CA`| |**Frisian**|`string`|`fy-FY`| |**Galician**|`string`|`gl-GL`| |**Georgian**|`string`|`ka-KA`| |**German**|`string`|`de-DE`| |**Greek**|`string`|`gr-GR`| |**Gujarati**|`string`|`gu-GU`| |**Haitian-Creole**|`string`|`ht-HT`| |**Hausa**|`string`|`ha-HA`| |**Hawaiian**|`string`|`haw-HA`| |**Hebrew**|`string`|`he-HE`| |**Hindi**|`string`|`hi-HI`| |**Hmong**|`string`|`hmn_HM`| |**Hungarian**|`string`|`hu-HU`| |**Icelandic**|`string`|`is-IS`| |**Igbo**|`string`|`ig-IG`| |**Indonesian**|`string`|`id-ID`| |**Irish**|`string`|`ga-IR`| |**Italian**|`string`|`it-IT`| |**Japanese**|`string`|`ja-JP`| |**Javanese**|`string`|`jv-JV`| |**Kannada**|`string`|`kn-KN`| |**Kazakh**|`string`|`kk-KK`| |**Khmer**|`string`|`km-KM`| |**Korean**|`string`|`ko-KR`| |**Kurdish**|`string`|`ku-KU`| |**Kyrgyz**|`string`|`ky-KY`| |**Lao**|`string`|`lo-LO`| |**Latin**|`string`|`la-LA`| |**Latvian**|`string`|`lv-LV`| |**Lithuanian**|`string`|`lt-LT`| |**Luxembourgish**|`string`|`lb-LB`| |**Macedonian**|`string`|`mk-MK`| |**Malagasy**|`string`|`mg-MG`| |**Malay**|`string`|`ms-MY`| |**Malayalam**|`string`|`ml-ML`| |**Maltese**|`string`|`mt-MT`| |**Maori**|`string`|`mi-MI`| |**Marathi**|`string`|`mr-MR`| |**Mongolian**|`string`|`mn-MN`| |**Myanmar-Burmese**|`string`|`my-MY`| |**Nepali**|`string`|`ne-NE`| |**Norwegian**|`string`|`no-NO`| |**Nyanja Chichewa**|`string`|`ny-NY`| |**Pashto**|`string`|`ps-PS`| |**Persian**|`string`|`fa-FA`| |**Polish**|`string`|`pl-PO`| |**Portuguese**|`string`|`pt-PT`| |**Punjabi**|`string`|`pa-PA`| |**Romanian**|`string`|`ro-RO`| |**Russian**|`string`|`ru-RU`| |**Samoan**|`string`|`sm-SM`| |**Scots Gaelic**|`string`|`gd-GD`| |**Serbian**|`string`|`sr-SR`| |**Sesotho**|`string`|`st-ST`| |**Shona**|`string`|`sn-SN`| |**Sindhi**|`string`|`sd-SD`| |**Sinhala-Sinhalese**|`string`|`si-SI`| |**Slovak**|`string`|`sk-SK`| |**Slovenian**|`string`|`sl-SL`| |**Somali**|`string`|`so-SO`| |**Spanish**|`string`|`es-ES`| |**Sundanese**|`string`|`su-SU`| |**Swahili**|`string`|`sh-SH`| |**Swedish**|`string`|`sw-SW`| |**Tagalog-Filipino**|`string`|`tl-TL`| |**Tajik**|`string`|`tg-TG`| |**Tamil**|`string`|`ta-TA`| |**Telugu**|`string`|`te-TE`| |**Thai**|`string`|`th-TH`| |**Turkish**|`string`|`tr-TR`| |**Ukrainian**|`string`|`uk-UK`| |**Urdu**|`string`|`ur-UR`| |**Uzbek**|`string`|`uz-UZ`| |**Vietnamese**|`string`|`vi-VI`| |**Welsh**|`string`|`cy-CY`| |**Xhosa**|`string`|`xh-XH`| |**Yiddish**|`string`|`yi-YI`| |**Yoruba**|`string`|`yo-YO`|  **AVAILABLE PROVIDERS**   |Name|Value|Version| |- -- -|- -- --|- -- -- --| |[**Microsoft Azure**](https://www.edenai.co/catalog/azure-translator)|`microsoft`|`v3.0`| |[**Amazon Web Services**](https://www.edenai.co/catalog/amazon-translate)|`amazon`|`boto3 (v1.15.18)`| |[**Google Cloud**](https://www.edenai.co/catalog/google-cloud-translation)|`google`|`v3`|

### Example
```csharp
using System;
using System.Diagnostics;
using EdenAI.Api;
using EdenAI.Client;
using EdenAI.Model;

namespace Example
{
    public class AutomaticTranslationExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TranslationApi();
            var text = text_example;  // string | Text to translate
            var sourceLanguage = sourceLanguage_example;  // string | Language code of text (ex: fr (French), en (English), es (Spanish))
            var targetLanguage = targetLanguage_example;  // string | Language code of text (ex: fr (French), en (English), es (Spanish))
            var providers = providers_example;  // string | Provider to compare (ex: [ 'amazon', 'microsoft', 'ibm', 'google'])

            try
            {
                InlineResponse2007 result = apiInstance.AutomaticTranslation(text, sourceLanguage, targetLanguage, providers);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TranslationApi.AutomaticTranslation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **text** | **string**| Text to translate | 
 **sourceLanguage** | **string**| Language code of text (ex: fr (French), en (English), es (Spanish)) | 
 **targetLanguage** | **string**| Language code of text (ex: fr (French), en (English), es (Spanish)) | 
 **providers** | **string**| Provider to compare (ex: [ &#39;amazon&#39;, &#39;microsoft&#39;, &#39;ibm&#39;, &#39;google&#39;]) | 

### Return type

[**InlineResponse2007**](InlineResponse2007.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="langiagedetection"></a>
# **LangiageDetection**
> InlineResponse2008 LangiageDetection (string text, string providers)



Language Detection or language guessing is the algorithm of determining which natural language given content is in.  **AVAILABLE PROVIDERS**   |Name|Value|Version| |- -- -|- -- --|- -- -- --| |[**Microsoft Azure**](https://www.edenai.co/catalog/azure-translator)|`microsoft`|`v3.1`| |[**Amazon Web Services**](https://www.edenai.co/catalog/amazon-translate)|`amazon`|`boto3 (v1.15.18)`| |[**Google Cloud**](https://www.edenai.co/catalog/google-cloud-translation)|`google`|`v1`| |[**Lettria**](https://www.edenai.co/catalog/Lettria)|`lettria`|`v5.5.2`|

### Example
```csharp
using System;
using System.Diagnostics;
using EdenAI.Api;
using EdenAI.Client;
using EdenAI.Model;

namespace Example
{
    public class LangiageDetectionExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TranslationApi();
            var text = text_example;  // string | Text to analyze
            var providers = providers_example;  // string | Provider to compare (ex: [ 'amazon', 'microsoft', 'ibm','google'])

            try
            {
                InlineResponse2008 result = apiInstance.LangiageDetection(text, providers);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TranslationApi.LangiageDetection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **text** | **string**| Text to analyze | 
 **providers** | **string**| Provider to compare (ex: [ &#39;amazon&#39;, &#39;microsoft&#39;, &#39;ibm&#39;,&#39;google&#39;]) | 

### Return type

[**InlineResponse2008**](InlineResponse2008.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

