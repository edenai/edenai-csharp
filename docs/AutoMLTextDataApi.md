# EdenAI.Api.AutoMLTextDataApi

All URIs are relative to *https://api.edenai.run/v1/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AutoMLTextDataDelete**](AutoMLTextDataApi.md#automltextdatadelete) | **DELETE** /automl/text/project/{project_id}/train/{train_id} | 
[**AutoMLTextDataLaunchPrediction**](AutoMLTextDataApi.md#automltextdatalaunchprediction) | **POST** /automl/text/project/{project_id}/train/{train_id}/prediction | 
[**AutoMLTextDataPredictionDetail**](AutoMLTextDataApi.md#automltextdatapredictiondetail) | **GET** /automl/text/project/{project_id}/train/{train_id}/prediction/{predict_id} | 
[**AutoMLTextDataPredictionResults**](AutoMLTextDataApi.md#automltextdatapredictionresults) | **GET** /automl/text/project/{project_id}/train/{train_id}/prediction/{predict_id}/results | 
[**AutoMLTextDataTrain**](AutoMLTextDataApi.md#automltextdatatrain) | **POST** /automl/text/project/{project_id}/train | 
[**AutoMLTextDataTrainDetail**](AutoMLTextDataApi.md#automltextdatatraindetail) | **GET** /automl/text/project/{project_id}/train/{train_id} | 
[**AutoMLTextProjectCreate**](AutoMLTextDataApi.md#automltextprojectcreate) | **POST** /automl/text/project | 
[**AutoMLTextProjectDelete**](AutoMLTextDataApi.md#automltextprojectdelete) | **DELETE** /automl/text/project/{project_id} | 
[**AutoMLTextProjectDetail**](AutoMLTextDataApi.md#automltextprojectdetail) | **GET** /automl/text/project/{project_id} | 
[**AutoMLTextProjectList**](AutoMLTextDataApi.md#automltextprojectlist) | **GET** /automl/text/project | 
[**AutoMLTextProjectUpdate**](AutoMLTextDataApi.md#automltextprojectupdate) | **PUT** /automl/text/project/{project_id} | 


<a name="automltextdatadelete"></a>
# **AutoMLTextDataDelete**
> void AutoMLTextDataDelete (string projectId, string trainId)



AutoML Text Data Delete

### Example
```csharp
using System;
using System.Diagnostics;
using EdenAI.Api;
using EdenAI.Client;
using EdenAI.Model;

namespace Example
{
    public class AutoMLTextDataDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AutoMLTextDataApi();
            var projectId = projectId_example;  // string | 
            var trainId = trainId_example;  // string | 

            try
            {
                apiInstance.AutoMLTextDataDelete(projectId, trainId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutoMLTextDataApi.AutoMLTextDataDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectId** | **string**|  | 
 **trainId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="automltextdatalaunchprediction"></a>
# **AutoMLTextDataLaunchPrediction**
> void AutoMLTextDataLaunchPrediction (string projectId, string trainId, System.IO.Stream files)



  **SUPPORTED FILES**  The API takes a csv file with no header and only one column, where each line contains a document to classify.  

### Example
```csharp
using System;
using System.Diagnostics;
using EdenAI.Api;
using EdenAI.Client;
using EdenAI.Model;

namespace Example
{
    public class AutoMLTextDataLaunchPredictionExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AutoMLTextDataApi();
            var projectId = projectId_example;  // string | 
            var trainId = trainId_example;  // string | 
            var files = new System.IO.Stream(); // System.IO.Stream | 

            try
            {
                apiInstance.AutoMLTextDataLaunchPrediction(projectId, trainId, files);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutoMLTextDataApi.AutoMLTextDataLaunchPrediction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectId** | **string**|  | 
 **trainId** | **string**|  | 
 **files** | **System.IO.Stream**|  | 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="automltextdatapredictiondetail"></a>
# **AutoMLTextDataPredictionDetail**
> void AutoMLTextDataPredictionDetail (string predictId, string projectId, string trainId)



  **SUPPORTED FILES**  The API takes a csv file with no header and only one column, where each line contains a document to classify.  

### Example
```csharp
using System;
using System.Diagnostics;
using EdenAI.Api;
using EdenAI.Client;
using EdenAI.Model;

namespace Example
{
    public class AutoMLTextDataPredictionDetailExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AutoMLTextDataApi();
            var predictId = predictId_example;  // string | 
            var projectId = projectId_example;  // string | 
            var trainId = trainId_example;  // string | 

            try
            {
                apiInstance.AutoMLTextDataPredictionDetail(predictId, projectId, trainId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutoMLTextDataApi.AutoMLTextDataPredictionDetail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **predictId** | **string**|  | 
 **projectId** | **string**|  | 
 **trainId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="automltextdatapredictionresults"></a>
# **AutoMLTextDataPredictionResults**
> void AutoMLTextDataPredictionResults (string predictId, string projectId, string trainId)



  **SUPPORTED FILES**  The API takes a csv file with no header and only one column, where each line contains a document to classify.  

### Example
```csharp
using System;
using System.Diagnostics;
using EdenAI.Api;
using EdenAI.Client;
using EdenAI.Model;

namespace Example
{
    public class AutoMLTextDataPredictionResultsExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AutoMLTextDataApi();
            var predictId = predictId_example;  // string | 
            var projectId = projectId_example;  // string | 
            var trainId = trainId_example;  // string | 

            try
            {
                apiInstance.AutoMLTextDataPredictionResults(predictId, projectId, trainId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutoMLTextDataApi.AutoMLTextDataPredictionResults: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **predictId** | **string**|  | 
 **projectId** | **string**|  | 
 **trainId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="automltextdatatrain"></a>
# **AutoMLTextDataTrain**
> void AutoMLTextDataTrain (string projectId, string provider, string trainingName)



  **AVAILABLE PROVIDERS**  |Name|Value| |- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --|- -- -- -- -- -- -- --| |[**Google Cloud Services**](https://www.edenai.co/catalog/google-cloud-natural-language)|`google`| |[**Amazon Web Services**](https://www.edenai.co/catalog/amazon-comprehend)|`amazon`|  

### Example
```csharp
using System;
using System.Diagnostics;
using EdenAI.Api;
using EdenAI.Client;
using EdenAI.Model;

namespace Example
{
    public class AutoMLTextDataTrainExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AutoMLTextDataApi();
            var projectId = projectId_example;  // string | 
            var provider = provider_example;  // string | 
            var trainingName = trainingName_example;  // string | 

            try
            {
                apiInstance.AutoMLTextDataTrain(projectId, provider, trainingName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutoMLTextDataApi.AutoMLTextDataTrain: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectId** | **string**|  | 
 **provider** | **string**|  | 
 **trainingName** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="automltextdatatraindetail"></a>
# **AutoMLTextDataTrainDetail**
> void AutoMLTextDataTrainDetail (string projectId, string trainId)



AutoML Text Data Train Detail

### Example
```csharp
using System;
using System.Diagnostics;
using EdenAI.Api;
using EdenAI.Client;
using EdenAI.Model;

namespace Example
{
    public class AutoMLTextDataTrainDetailExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AutoMLTextDataApi();
            var projectId = projectId_example;  // string | 
            var trainId = trainId_example;  // string | 

            try
            {
                apiInstance.AutoMLTextDataTrainDetail(projectId, trainId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutoMLTextDataApi.AutoMLTextDataTrainDetail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectId** | **string**|  | 
 **trainId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="automltextprojectcreate"></a>
# **AutoMLTextProjectCreate**
> void AutoMLTextProjectCreate (string projectName, string projectDescription, System.IO.Stream files, string type, string language)



  **SUPPORTED FILES**  The API takes csv files separated using ','. The csv must contain a header and exactly two columns, named `docs` and `labels` In case a document might have several labels, please separate your labels using '|'     **SUPPORTED LANGUAGE**  |Name|Type|Value| |- -- -- -- -- -- -- -- -- -- -- -- -- --|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --|- -- -- -- -- -- -- --| | **English (US)**|*`string`*|`en`| | **French**      |*`string`*|`fr`| | **German**      |*`string`*|`de`| | **Italian**     |*`string`*|`it`| | **Portuguese**  |*`string`*|`pt`| | **Arabic**      |*`string`*|`ar`| | **Chinese-Simplified**|*`string`*|`zh`| | **Chinese-Traditional**|*`string`*|`zh-TW`| | **Korean**      |*`string`*|`ko`| | **Japanese**    |*`string`*|`ja`| | **Hindi**       |*`string`*|`hi`| | **Spanish**     |*`string`*|`es`|    **AVAILABLE CLASSIFICATION TYPES**  |Type|Value|Description| |- -- -- -- -- -- -- -- -- -- -- -- -- --|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --|- -- -- -- -- -- -- --| | **Single Label Classification **|`single_label_classification`|Each document belongs to one category (label)| | **Multi Label Classification**|`multi_label_classification`|Documents might have several labels|  

### Example
```csharp
using System;
using System.Diagnostics;
using EdenAI.Api;
using EdenAI.Client;
using EdenAI.Model;

namespace Example
{
    public class AutoMLTextProjectCreateExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AutoMLTextDataApi();
            var projectName = projectName_example;  // string | 
            var projectDescription = projectDescription_example;  // string | 
            var files = new System.IO.Stream(); // System.IO.Stream | 
            var type = type_example;  // string | 
            var language = language_example;  // string | 

            try
            {
                apiInstance.AutoMLTextProjectCreate(projectName, projectDescription, files, type, language);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutoMLTextDataApi.AutoMLTextProjectCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectName** | **string**|  | 
 **projectDescription** | **string**|  | 
 **files** | **System.IO.Stream**|  | 
 **type** | **string**|  | 
 **language** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="automltextprojectdelete"></a>
# **AutoMLTextProjectDelete**
> void AutoMLTextProjectDelete (string projectId)



AutoML Text Project Delete

### Example
```csharp
using System;
using System.Diagnostics;
using EdenAI.Api;
using EdenAI.Client;
using EdenAI.Model;

namespace Example
{
    public class AutoMLTextProjectDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AutoMLTextDataApi();
            var projectId = projectId_example;  // string | 

            try
            {
                apiInstance.AutoMLTextProjectDelete(projectId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutoMLTextDataApi.AutoMLTextProjectDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="automltextprojectdetail"></a>
# **AutoMLTextProjectDetail**
> void AutoMLTextProjectDetail (string projectId)



AutoML Text Project Detail

### Example
```csharp
using System;
using System.Diagnostics;
using EdenAI.Api;
using EdenAI.Client;
using EdenAI.Model;

namespace Example
{
    public class AutoMLTextProjectDetailExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AutoMLTextDataApi();
            var projectId = projectId_example;  // string | 

            try
            {
                apiInstance.AutoMLTextProjectDetail(projectId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutoMLTextDataApi.AutoMLTextProjectDetail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="automltextprojectlist"></a>
# **AutoMLTextProjectList**
> void AutoMLTextProjectList ()



AutoML Text Project List

### Example
```csharp
using System;
using System.Diagnostics;
using EdenAI.Api;
using EdenAI.Client;
using EdenAI.Model;

namespace Example
{
    public class AutoMLTextProjectListExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AutoMLTextDataApi();

            try
            {
                apiInstance.AutoMLTextProjectList();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutoMLTextDataApi.AutoMLTextProjectList: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="automltextprojectupdate"></a>
# **AutoMLTextProjectUpdate**
> void AutoMLTextProjectUpdate (string projectId, string projectName, string projectDescription, string type, string language)



AutoML Text Project Update

### Example
```csharp
using System;
using System.Diagnostics;
using EdenAI.Api;
using EdenAI.Client;
using EdenAI.Model;

namespace Example
{
    public class AutoMLTextProjectUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AutoMLTextDataApi();
            var projectId = projectId_example;  // string | 
            var projectName = projectName_example;  // string | 
            var projectDescription = projectDescription_example;  // string | 
            var type = type_example;  // string | 
            var language = language_example;  // string | 

            try
            {
                apiInstance.AutoMLTextProjectUpdate(projectId, projectName, projectDescription, type, language);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutoMLTextDataApi.AutoMLTextProjectUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectId** | **string**|  | 
 **projectName** | **string**|  | 
 **projectDescription** | **string**|  | 
 **type** | **string**|  | 
 **language** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

