using edenai;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace edenai_tests
{
    public class Text_tests
    {
        [Fact]
        async void KeywordExtraction()
        {
             var text = new edenai.Text("Bearer <<YOUR_API_KEY>>");


            var result = await text.KeywordExtraction(new Text.KeywordExtraction_Request() { Language = "en-US", Text = "test tester testing", KeywordsToFind = new System.Collections.Generic.List<string>() { "test" }, Providers = new System.Collections.Generic.List<string>() { "microsoft", "ibm" } });
            
        }

        [Fact]
        async void NamedEntityRecognition()
        {
            var text = new edenai.Text("Bearer <<YOUR_API_KEY>>");
             
            var result = await text.NamedEntityRecognition(new Text.NamedEntityRecognition_Request() { Language = "en-US", Text = "test tester testing language Keywords To Find", EntitiesToFind = new System.Collections.Generic.List<string>() { "test" }, Providers = new System.Collections.Generic.List<string>() { "microsoft", "ibm" } });
            
        }

        [Fact]
        async void SentimentAnalysis()
        {
            var text = new edenai.Text("Bearer <<YOUR_API_KEY>>");
            
            var result = await text.SentimentAnalysis(new Text.SentimentAnalysis_Request() { Language = "en-US", Text = "test tester testing language Keywords To Find", SentimentsToFind = new System.Collections.Generic.List<string>() { "test" }, Providers = new System.Collections.Generic.List<string>() { "microsoft", "ibm" } });

        }
    }
}
