var client = new RestClient("https://api.edenai.run/v1/pretrained/vision/object_detection");
client.Timeout = -1;
var request = new RestRequest(Method.POST);
request.AddHeader("Authorization", "Bearer your_api_key");
request.AddParameter("providers", "[\'google_cloud\', \'microsoft\', \'aws\', \'ibm\']");
request.AddFile("files", "/Downloads/example.mp3");
request.AddParameter("language", "en-US");
IRestResponse response = client.Execute(request);
Console.WriteLine(response.Content);
