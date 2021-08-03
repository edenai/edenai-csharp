var client = new RestClient("https://api.edenai.run/v1/pretrained/vision/explicit_content_detection");
client.Timeout = -1;
var request = new RestRequest(Method.POST);
request.AddHeader("Authorization", "Bearer your_api_key");
request.AddParameter("providers", "[\'mindee\', \'microsoft\']");
request.AddParameter("language", "en-US");
request.AddFile("files", "/Downloads/example.png");
IRestResponse response = client.Execute(request);
Console.WriteLine(response.Content);
