using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace edenai_tests
{
   public class Speech_tests
    {
        [Fact]
        async void TextToSpeech()
        {
            var ed = new edenai.Speech("Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJ1c2VyX2lkIjoiOWI4MjdkYzEtNTk3Yy00YzZiLWEyYmMtOTNmNDc0ZTYyZWNlIiwidHlwZSI6ImFwaV90b2tlbiJ9.3VGt0-NM1mWQBcOtARtIAkVCng6CdTZWq0R_53F-7cM");

            var result = await ed.TextToSpeech(new edenai.Speech.TextToSpeech_Request() { Text = "test", Language = "en-US", Option = "FEMALE", Providers = new System.Collections.Generic.List<string>() { "google", "ibm" } });
             
        }

        [Fact]
        async void SpeechRecognition()
        {
            var ed = new edenai.Speech("Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJ1c2VyX2lkIjoiOWI4MjdkYzEtNTk3Yy00YzZiLWEyYmMtOTNmNDc0ZTYyZWNlIiwidHlwZSI6ImFwaV90b2tlbiJ9.3VGt0-NM1mWQBcOtARtIAkVCng6CdTZWq0R_53F-7cM");

            var result = await ed.SpeechRecognition(new edenai.Speech.SpeechRecognition_Request() { Text = "test", Language = "en-US", Providers = new System.Collections.Generic.List<string>() { "google" }, FilePath = "L:\\test\\audiotest.mp3" });

        }
    }
}
