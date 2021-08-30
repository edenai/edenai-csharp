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
            var translations = new edenai.Translation("Bearer <<YOUR_API_KEY>>");

            var result = await translations.AutomaticTranslation(new Translation.AutomaticTranslation_Request() { SourceLanguage = "en-US", TargetLanguage = "ja-JP", TextToTranslate = "testing translation", Providers = new System.Collections.Generic.List<string>() { "google", "ibm" } });
             
        }

        [Fact]
        async void LanguageDetection()
        {
            var translations = new edenai.Translation("Bearer <<YOUR_API_KEY>>");

            var result = await translations.LanguageDetection(new Translation.LanguageDetection_Request() { LanguagesToFind = "en-US", Text = "test", Providers = new System.Collections.Generic.List<string>() { "google", "ibm" } });

        }
    }
}
