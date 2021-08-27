using edenai;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace edenai_tests
{
    public class Vision_tests
    {
        [Fact]
        async void ExplicitContentDetection()
        {
            var vision = new edenai.Vision("Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJ1c2VyX2lkIjoiOWI4MjdkYzEtNTk3Yy00YzZiLWEyYmMtOTNmNDc0ZTYyZWNlIiwidHlwZSI6ImFwaV90b2tlbiJ9.3VGt0-NM1mWQBcOtARtIAkVCng6CdTZWq0R_53F-7cM");

            var result = await vision.ExplicitContentDetection(new Vision.ExplicitContentDetection_Request() { FilePath = "L:\\test\\20210720_132931821_iOS.jpg", Providers = new System.Collections.Generic.List<string>() { "microsoft", "ibm" } });
             
        }

        [Fact]
        async void FaceDetection()
        {
            var vision = new edenai.Vision("Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJ1c2VyX2lkIjoiOWI4MjdkYzEtNTk3Yy00YzZiLWEyYmMtOTNmNDc0ZTYyZWNlIiwidHlwZSI6ImFwaV90b2tlbiJ9.3VGt0-NM1mWQBcOtARtIAkVCng6CdTZWq0R_53F-7cM");
            
            var result = await vision.FaceDetection(new Vision.FaceDetection_Request() { FilePath = "L:\\test\\20210720_132931821_iOS.jpg", Providers = new System.Collections.Generic.List<string>() { "google", "amazon" } });
             
        }

        [Fact]
        async void ObjectDetection()
        {
            var vision = new edenai.Vision("Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJ1c2VyX2lkIjoiOWI4MjdkYzEtNTk3Yy00YzZiLWEyYmMtOTNmNDc0ZTYyZWNlIiwidHlwZSI6ImFwaV90b2tlbiJ9.3VGt0-NM1mWQBcOtARtIAkVCng6CdTZWq0R_53F-7cM");
           
            var result = await vision.ObjectDetection(new Vision.ObjectDetection_Request() { FilePath = "L:\\test\\20210720_132931821_iOS.jpg", Providers = new System.Collections.Generic.List<string>() { "microsoft", "ibm" } });

        }
    }
}
