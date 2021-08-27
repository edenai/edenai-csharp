using System;
using edenai;

namespace edenai_example_consoleapp
{
    class Program
    {
        static  void Main(string[] args)
        {
            test();
            Console.ReadKey();
        }

        static async void test()
        {
                var ed = new edenai.Speech("Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJ1c2VyX2lkIjoiOWI4MjdkYzEtNTk3Yy00YzZiLWEyYmMtOTNmNDc0ZTYyZWNlIiwidHlwZSI6ImFwaV90b2tlbiJ9.3VGt0-NM1mWQBcOtARtIAkVCng6CdTZWq0R_53F-7cM");

            var result1 = await ed.TextToSpeech(new edenai.Speech.TextToSpeech_Request() { Text = "test", Language = "en-US", Option = "FEMALE", Providers = new System.Collections.Generic.List<string>() { "google", "ibm" } });
             var result2 = await ed.SpeechRecognition(new edenai.Speech.SpeechRecognition_Request() { Text = "test", Language = "en-US", Providers = new System.Collections.Generic.List<string>() { "google"}, FilePath = "L:\\test\\audiotest.mp3" });

            var ed_OCR = new edenai.OCR("Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJ1c2VyX2lkIjoiOWI4MjdkYzEtNTk3Yy00YzZiLWEyYmMtOTNmNDc0ZTYyZWNlIiwidHlwZSI6ImFwaV90b2tlbiJ9.3VGt0-NM1mWQBcOtARtIAkVCng6CdTZWq0R_53F-7cM");

            var result4 = await ed_OCR.OCRInvoice(new edenai.OCR.OCRInvoice_Request() { Language = "en-US" , FilePath = "L:\\test\\fullfile.pdf", Providers = new System.Collections.Generic.List<string>() { "microsoft" } });
            var result5 = await ed_OCR.OCRReader(new edenai.OCR.OCRReader_Request() { Language = "en-US" , FilePath = "L:\\test\\fullfile.pdf", Providers = new System.Collections.Generic.List<string>() { "microsoft", "google" } });

            var translations = new edenai.Translation("Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJ1c2VyX2lkIjoiOWI4MjdkYzEtNTk3Yy00YzZiLWEyYmMtOTNmNDc0ZTYyZWNlIiwidHlwZSI6ImFwaV90b2tlbiJ9.3VGt0-NM1mWQBcOtARtIAkVCng6CdTZWq0R_53F-7cM");

            var result6 = await translations.AutomaticTranslation(new Translation.AutomaticTranslation_Request() { SourceLanguage = "en-US", TargetLanguage = "ja-JP", TextToTranslate = "testing translation", Providers = new System.Collections.Generic.List<string>() { "google", "ibm" } });
            var result7 = await translations.LanguageDetection(new Translation.LanguageDetection_Request() { LanguagesToFind = "en-US" , Text = "test",    Providers = new System.Collections.Generic.List<string>() { "google", "ibm" } });

            var text = new edenai.Text("Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJ1c2VyX2lkIjoiOWI4MjdkYzEtNTk3Yy00YzZiLWEyYmMtOTNmNDc0ZTYyZWNlIiwidHlwZSI6ImFwaV90b2tlbiJ9.3VGt0-NM1mWQBcOtARtIAkVCng6CdTZWq0R_53F-7cM");


            var result8 = await text.KeywordExtraction(new Text.KeywordExtraction_Request() { Language = "en-US" , Text = "test tester testing",  KeywordsToFind = new System.Collections.Generic.List<string>() { "test"  }, Providers = new System.Collections.Generic.List<string>() { "microsoft", "ibm" } });
             var result9 = await text.NamedEntityRecognition(new Text.NamedEntityRecognition_Request() { Language = "en-US" , Text = "test tester testing language Keywords To Find", EntitiesToFind = new System.Collections.Generic.List<string>() { "test"  }, Providers = new System.Collections.Generic.List<string>() { "microsoft", "ibm" } });
              var result10 = await text.SentimentAnalysis(new Text.SentimentAnalysis_Request() { Language = "en-US" , Text = "test tester testing language Keywords To Find", SentimentsToFind = new System.Collections.Generic.List<string>() { "test"  }, Providers = new System.Collections.Generic.List<string>() { "microsoft", "ibm" } });

            var vision = new edenai.Vision("Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJ1c2VyX2lkIjoiOWI4MjdkYzEtNTk3Yy00YzZiLWEyYmMtOTNmNDc0ZTYyZWNlIiwidHlwZSI6ImFwaV90b2tlbiJ9.3VGt0-NM1mWQBcOtARtIAkVCng6CdTZWq0R_53F-7cM");

           var result11 = await vision.ExplicitContentDetection(new Vision.ExplicitContentDetection_Request() { FilePath = "L:\\test\\20210720_132931821_iOS.jpg", Providers = new System.Collections.Generic.List<string>() { "microsoft", "ibm" } });
           var result12 = await vision.FaceDetection(new Vision.FaceDetection_Request() { FilePath = "L:\\test\\20210720_132931821_iOS.jpg",  Providers = new System.Collections.Generic.List<string>() { "google", "amazon" } });
           var result13 = await vision.ObjectDetection(new Vision.ObjectDetection_Request() { FilePath = "L:\\test\\20210720_132931821_iOS.jpg", Providers = new System.Collections.Generic.List<string>() { "microsoft", "ibm" } });
   
        }
    }
}
