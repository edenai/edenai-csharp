using edenai;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace edenai_tests
{
    public class Translation_tests
    {
        [Fact]
        async void AutomaticTranslation()
        {
            var translations = new edenai.Translation("Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJ1c2VyX2lkIjoiOWI4MjdkYzEtNTk3Yy00YzZiLWEyYmMtOTNmNDc0ZTYyZWNlIiwidHlwZSI6ImFwaV90b2tlbiJ9.3VGt0-NM1mWQBcOtARtIAkVCng6CdTZWq0R_53F-7cM");

            var result = await translations.AutomaticTranslation(new Translation.AutomaticTranslation_Request() { SourceLanguage = "en-US", TargetLanguage = "ja-JP", TextToTranslate = "testing translation", Providers = new System.Collections.Generic.List<string>() { "google", "ibm" } });
             
        }

        [Fact]
        async void LanguageDetection()
        {
            var translations = new edenai.Translation("Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJ1c2VyX2lkIjoiOWI4MjdkYzEtNTk3Yy00YzZiLWEyYmMtOTNmNDc0ZTYyZWNlIiwidHlwZSI6ImFwaV90b2tlbiJ9.3VGt0-NM1mWQBcOtARtIAkVCng6CdTZWq0R_53F-7cM");

            var result = await translations.LanguageDetection(new Translation.LanguageDetection_Request() { LanguagesToFind = "en-US", Text = "test", Providers = new System.Collections.Generic.List<string>() { "google", "ibm" } });

        }
    }
}
