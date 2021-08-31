using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace edenai_tests
{
    public class OCR_tests
    {
        [Fact]
        async  void OCRInvoice()
        {
            var ed_OCR = new edenai.OCR("Bearer <<YOUR_API_KEY>>");

            var result = await ed_OCR.OCRInvoice(new edenai.OCR.OCRInvoice_Request() { Language = "en-US" , FilePath = "L:\\test\\fullfile.pdf", Providers = new System.Collections.Generic.List<string>() { "microsoft", "mindee" } });
            
        }

        [Fact]
        async void OCRReader()
        {
            var ed_OCR = new edenai.OCR("Bearer <<YOUR_API_KEY>>");

             var result = await ed_OCR.OCRReader(new edenai.OCR.OCRReader_Request() { Language = "en-US", FilePath = "L:\\test\\fullfile.pdf", Providers = new System.Collections.Generic.List<string>() { "microsoft", "google" } });

        }
    }
}
