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
            var ed_OCR = new edenai.OCR("Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJ1c2VyX2lkIjoiYzEzYzRmNTktOTAxMi00YzA1LTk2MWMtMWZmOTY4ZmE3ZmQyIiwidHlwZSI6ImFwaV90b2tlbiJ9.T-Z56RI__SuJaeAprWMuLUoLpTy2-SPFld4HLkIsXUc");

            var result = await ed_OCR.OCRInvoice(new edenai.OCR.OCRInvoice_Request() { Language = "en-US" , FilePath = "L:\\test\\fullfile.pdf", Providers = new System.Collections.Generic.List<string>() { "microsoft", "mindee" } });
            
        }

        [Fact]
        async void OCRReader()
        {
            var ed_OCR = new edenai.OCR("Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJ1c2VyX2lkIjoiYzEzYzRmNTktOTAxMi00YzA1LTk2MWMtMWZmOTY4ZmE3ZmQyIiwidHlwZSI6ImFwaV90b2tlbiJ9.T-Z56RI__SuJaeAprWMuLUoLpTy2-SPFld4HLkIsXUc");

             var result = await ed_OCR.OCRReader(new edenai.OCR.OCRReader_Request() { Language = "en-US", FilePath = "L:\\test\\fullfile.pdf", Providers = new System.Collections.Generic.List<string>() { "microsoft", "google" } });

        }
    }
}
