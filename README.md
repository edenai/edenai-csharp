# Eden AI C#

![Screenshot](https://github.com/edenai/edenai-python/blob/3829feb170f11cfd55aacd877d23c5f8d69e203f/Logo%20complet%20Eden%20AI%20-%20format%20PNG.png)


This is the official Eden AI C# Github for interacting with our powerful APIs. [Eden AI](https://www.edanai.co/) is a SaaS providing APIs connected to big (AWS, GCP, etc.) and small AI providers for vision, text, audio, OCR, prediction and translation AI engines. Our solution allows users to compare the performance of these providers APIs according to their data and use them directly via our API thus offering great flexibility and making it very easy to change supplier. In particular, we offer better performance with the "Genius" feature that cleverly combines results from multiple providers.

* Eden AI support: contact@edenai.co              
* Look to our website: https://www.edenai.co
* Sign Iup for a free account: https://app.edenai.run/user/login
* Read our documentation: https://api.edenai.run/v1/redoc/


Eden AI simplifies the use and integration of AI technologies by providing a unique API connected to the best AI engines and combined with a powerful management platform. The platform covers a wide range of AI technologies:
* Vision: www.edenai.co/vision
* Text & NLP: www.edenai.co/text
* Speech & Audio: www.edenai.co/speech
* OCR: www.edenai.co/ocr
* Machine Translation: www.edenai.co/translation
* Prediction: www.edenai.co/prediction

For all the proposed technologies, we provide a single endpoint: the service provider is only a parameter that can be changed very easily. All the engines available on Eden AI are listed here: www.edenai.co/catalog

## Getting started
To start using Eden AI APIs, you first need to get your API Token.  You can get your token on your IAM [here](https://app.edenai.run/admin/account).
Enter your access token:
```cs
request.AddHeader("Authorization", "Bearer your_api_key");
```

## Usage
### Initialization
Select your API endpoint:
```cs
var client = new RestClient("https://api.edenai.run/v1/pretrained/+endpoint");
var request = new RestRequest(Method.POST);
```
### Select parameters 
Set parameters corresponding to the API, and providers APIs you want to run :
Example:
```cs
request.AddParameter("providers", "[\'google\', \'microsoft\', \'aws\', \'ibm\']");
request.AddFile("files", "/Downloads/example.png");
```
### Get results
```cs
IRestResponse response = client.Execute(request);
Console.WriteLine(response.Content);
```

## Support & Community

If you have any problems, please contact us at this email address: contact@edenai.co. We will be happy to help you in the use of Eden AI.

Community:
You can interact personally with other people actively using and working with Eden AI and join our Slack community.
We are always updating our docs, so a good way to always stay up to date is to watch our documentation repo on Github: github.com/edenai

Blog:
We also regularly publish various articles with Eden AI news and technical articles on the different AI engines that exist. You can find these articles here: edenai.co/blog

## Documentation
To have more information about platform and API use, you can check ou our [documentation](https://api.edenai.run/v1/redoc/)

## SDK

### Getting started
Install the library from Nuget Manager:
```
edenai
```
### How to use it
Construct service and set the API key:
```cs
var text = new edenai.Text("Bearer <<YOUR_API_KEY>>");
```
OR
```cs
edenai.Keys.ApiKey = "Bearer <<YOUR_API_KEY>>";
var text = new edenai.Text();
```
Access API:
```cs 
var result = await text.KeywordExtraction(new Text.KeywordExtraction_Request() { Language = "en-US" , Text = "test tester testing",  KeywordsToFind = new System.Collections.Generic.List<string>() { "test"  }, Providers = new System.Collections.Generic.List<string>() { "microsoft", "ibm" } });
```
### How to use tests
You can use edenai_tests for reference on API calls. The naming of tests matches the class and method for specific API call.
```cs
[Fact]
        async void TextToSpeech()
        {
            var ed = new edenai.Speech("Bearer <<YOUR_API_KEY>>");

            var result = await ed.TextToSpeech(new edenai.Speech.TextToSpeech_Request() { Text = "test", Language = "en-US", Option = "FEMALE", Providers = new System.Collections.Generic.List<string>() { "google", "ibm" } });
             
        }
```
If you wish to execute tests in the project, you can do so in Visual Studio:
- Go to Test and open Test Explorer
- You can choose to execute all tests or specific test(s)