using edenai;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

///Object detection is a computer vision technology which allows to detect common objects on images.

namespace edenai_tests  
{
    public class Vision_tests {         
        async void ObjectDetection()
        {
        ///Get your API key here: https://app.edenai.run/admin/account
            var vision = new edenai.Vision("Bearer <<YOUR_API_KEY>>");

        ///Available providers, languages and formats here: https://api.edenai.run/v1/redoc/#operation/Object%20Detection
            var result = await vision.ObjectDetection(new Vision.ObjectDetection_Request() { FilePath = "L:\\test\\20210720_132931821_iOS.jpg", Providers = new System.Collections.Generic.List<string>() { "microsoft", "ibm" } });
        }
    }
}
