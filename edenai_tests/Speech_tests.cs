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
            var ed = new edenai.Speech("Bearer <<YOUR_API_KEY>>");

            var result = await ed.TextToSpeech(new edenai.Speech.TextToSpeech_Request() { Text = "test", Language = "en-US", Option = "FEMALE", Providers = new System.Collections.Generic.List<string>() { "google", "ibm" } });
             
        }

        [Fact]
        async void SpeechRecognition()
        {
            var ed = new edenai.Speech("Bearer <<YOUR_API_KEY>>");

            var result = await ed.SpeechRecognition(new edenai.Speech.SpeechRecognition_Request() { Text = "test", Language = "en-US", Providers = new System.Collections.Generic.List<string>() { "google" }, FilePath = "L:\\test\\audiotest.mp3" });

        }
    }
}
