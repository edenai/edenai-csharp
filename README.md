# EdenAI - the C# library for the Eden AI API Documentation

## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using EdenAI.Api;
using EdenAI.Client;
using EdenAI.Model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out EdenAI.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using EdenAI.Api;
using EdenAI.Client;
using EdenAI.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {

            // Configure API key authorization: Bearer
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

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

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.edenai.run/v1/*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AutoMLTextDataApi* | [**AutoMLTextDataDelete**](docs/AutoMLTextDataApi.md#automltextdatadelete) | **DELETE** /automl/text/project/{project_id}/train/{train_id} | 
*AutoMLTextDataApi* | [**AutoMLTextDataLaunchPrediction**](docs/AutoMLTextDataApi.md#automltextdatalaunchprediction) | **POST** /automl/text/project/{project_id}/train/{train_id}/prediction | 
*AutoMLTextDataApi* | [**AutoMLTextDataPredictionDetail**](docs/AutoMLTextDataApi.md#automltextdatapredictiondetail) | **GET** /automl/text/project/{project_id}/train/{train_id}/prediction/{predict_id} | 
*AutoMLTextDataApi* | [**AutoMLTextDataPredictionResults**](docs/AutoMLTextDataApi.md#automltextdatapredictionresults) | **GET** /automl/text/project/{project_id}/train/{train_id}/prediction/{predict_id}/results | 
*AutoMLTextDataApi* | [**AutoMLTextDataTrain**](docs/AutoMLTextDataApi.md#automltextdatatrain) | **POST** /automl/text/project/{project_id}/train | 
*AutoMLTextDataApi* | [**AutoMLTextDataTrainDetail**](docs/AutoMLTextDataApi.md#automltextdatatraindetail) | **GET** /automl/text/project/{project_id}/train/{train_id} | 
*AutoMLTextDataApi* | [**AutoMLTextProjectCreate**](docs/AutoMLTextDataApi.md#automltextprojectcreate) | **POST** /automl/text/project | 
*AutoMLTextDataApi* | [**AutoMLTextProjectDelete**](docs/AutoMLTextDataApi.md#automltextprojectdelete) | **DELETE** /automl/text/project/{project_id} | 
*AutoMLTextDataApi* | [**AutoMLTextProjectDetail**](docs/AutoMLTextDataApi.md#automltextprojectdetail) | **GET** /automl/text/project/{project_id} | 
*AutoMLTextDataApi* | [**AutoMLTextProjectList**](docs/AutoMLTextDataApi.md#automltextprojectlist) | **GET** /automl/text/project | 
*AutoMLTextDataApi* | [**AutoMLTextProjectUpdate**](docs/AutoMLTextDataApi.md#automltextprojectupdate) | **PUT** /automl/text/project/{project_id} | 
*EdenAIToolsApi* | [**Search**](docs/EdenAIToolsApi.md#search) | **POST** /tools/search | 
*OCRApi* | [**Ocr**](docs/OCRApi.md#ocr) | **POST** /pretrained/ocr/ocr | 
*OCRApi* | [**OcrInvoice**](docs/OCRApi.md#ocrinvoice) | **POST** /pretrained/ocr/ocr_invoice | 
*PipelinesApi* | [**Pipelines**](docs/PipelinesApi.md#pipelines) | **POST** /pipelines | 
*SpeechApi* | [**AsynchronousSpeechRecognition**](docs/SpeechApi.md#asynchronousspeechrecognition) | **POST** /pretrained/audio/speech_recognition_async | 
*SpeechApi* | [**AsynchronousSpeechRecognition_0**](docs/SpeechApi.md#asynchronousspeechrecognition_0) | **GET** /pretrained/audio/speech_recognition_async/{job_id} | 
*SpeechApi* | [**SpeechRecognition**](docs/SpeechApi.md#speechrecognition) | **POST** /pretrained/audio/speech_recognition | 
*SpeechApi* | [**TextToSpeech**](docs/SpeechApi.md#texttospeech) | **POST** /pretrained/audio/text_to_speech | 
*TextApi* | [**KeywordExtraction**](docs/TextApi.md#keywordextraction) | **POST** /pretrained/text/keyword_extraction | 
*TextApi* | [**NamedEntityRecognition**](docs/TextApi.md#namedentityrecognition) | **POST** /pretrained/text/named_entity_recognition | 
*TextApi* | [**SentimentAnalysis**](docs/TextApi.md#sentimentanalysis) | **POST** /pretrained/text/sentiment_analysis | 
*TextApi* | [**SyntaxAnalysis**](docs/TextApi.md#syntaxanalysis) | **POST** /pretrained/text/syntax_analysis | 
*TranslationApi* | [**AutomaticTranslation**](docs/TranslationApi.md#automatictranslation) | **POST** /pretrained/translation/automatic_translation | 
*TranslationApi* | [**LangiageDetection**](docs/TranslationApi.md#langiagedetection) | **POST** /pretrained/translation/language_detection | 
*VisionApi* | [**ExplicitContentDetection**](docs/VisionApi.md#explicitcontentdetection) | **POST** /pretrained/vision/explicit_content_detection | 
*VisionApi* | [**FaceDetection**](docs/VisionApi.md#facedetection) | **POST** /pretrained/vision/face_detection | 
*VisionApi* | [**ObjectDetection**](docs/VisionApi.md#objectdetection) | **POST** /pretrained/vision/object_detection | 


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.InlineResponse200](docs/InlineResponse200.md)
 - [Model.InlineResponse2001](docs/InlineResponse2001.md)
 - [Model.InlineResponse20010](docs/InlineResponse20010.md)
 - [Model.InlineResponse20010Result](docs/InlineResponse20010Result.md)
 - [Model.InlineResponse20010Result1](docs/InlineResponse20010Result1.md)
 - [Model.InlineResponse20010ResultLandmarks](docs/InlineResponse20010ResultLandmarks.md)
 - [Model.InlineResponse20011](docs/InlineResponse20011.md)
 - [Model.InlineResponse20011Result](docs/InlineResponse20011Result.md)
 - [Model.InlineResponse20011Result1](docs/InlineResponse20011Result1.md)
 - [Model.InlineResponse20012](docs/InlineResponse20012.md)
 - [Model.InlineResponse20012Result](docs/InlineResponse20012Result.md)
 - [Model.InlineResponse2001Result](docs/InlineResponse2001Result.md)
 - [Model.InlineResponse2001Result1](docs/InlineResponse2001Result1.md)
 - [Model.InlineResponse2001ResultBoundingBoxes](docs/InlineResponse2001ResultBoundingBoxes.md)
 - [Model.InlineResponse2002](docs/InlineResponse2002.md)
 - [Model.InlineResponse2002CustomerInformation](docs/InlineResponse2002CustomerInformation.md)
 - [Model.InlineResponse2002ItemLines](docs/InlineResponse2002ItemLines.md)
 - [Model.InlineResponse2002Locale](docs/InlineResponse2002Locale.md)
 - [Model.InlineResponse2002MerchantInformation](docs/InlineResponse2002MerchantInformation.md)
 - [Model.InlineResponse2002Result](docs/InlineResponse2002Result.md)
 - [Model.InlineResponse2002Result1](docs/InlineResponse2002Result1.md)
 - [Model.InlineResponse2002Results](docs/InlineResponse2002Results.md)
 - [Model.InlineResponse2003](docs/InlineResponse2003.md)
 - [Model.InlineResponse2003Result](docs/InlineResponse2003Result.md)
 - [Model.InlineResponse2003Result1](docs/InlineResponse2003Result1.md)
 - [Model.InlineResponse2004](docs/InlineResponse2004.md)
 - [Model.InlineResponse2004Result](docs/InlineResponse2004Result.md)
 - [Model.InlineResponse2004Result1](docs/InlineResponse2004Result1.md)
 - [Model.InlineResponse2005](docs/InlineResponse2005.md)
 - [Model.InlineResponse2005Result](docs/InlineResponse2005Result.md)
 - [Model.InlineResponse2005Result1](docs/InlineResponse2005Result1.md)
 - [Model.InlineResponse2006](docs/InlineResponse2006.md)
 - [Model.InlineResponse2006Result](docs/InlineResponse2006Result.md)
 - [Model.InlineResponse2006Result1](docs/InlineResponse2006Result1.md)
 - [Model.InlineResponse2007](docs/InlineResponse2007.md)
 - [Model.InlineResponse2007Result](docs/InlineResponse2007Result.md)
 - [Model.InlineResponse2007Result1](docs/InlineResponse2007Result1.md)
 - [Model.InlineResponse2008](docs/InlineResponse2008.md)
 - [Model.InlineResponse2008Result](docs/InlineResponse2008Result.md)
 - [Model.InlineResponse2008Result1](docs/InlineResponse2008Result1.md)
 - [Model.InlineResponse2009](docs/InlineResponse2009.md)
 - [Model.InlineResponse2009Result](docs/InlineResponse2009Result.md)
 - [Model.InlineResponse2009Result1](docs/InlineResponse2009Result1.md)
 - [Model.InlineResponse201](docs/InlineResponse201.md)
 - [Model.InlineResponse2011](docs/InlineResponse2011.md)
 - [Model.InlineResponse2011Result](docs/InlineResponse2011Result.md)
 - [Model.InlineResponse2011Result1](docs/InlineResponse2011Result1.md)
 - [Model.InlineResponse201Result](docs/InlineResponse201Result.md)
 - [Model.InlineResponse201Result1](docs/InlineResponse201Result1.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="Bearer"></a>
### Bearer

- **Type**: API key
- **API key parameter name**: Authorization
- **Location**: HTTP header

