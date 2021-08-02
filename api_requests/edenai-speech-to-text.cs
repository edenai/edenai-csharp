var client = new RestClient("https://api.edenai.run/v1/pretrained/audio/speech_recognition");
client.Timeout = -1;
var request = new RestRequest(Method.POST);
request.AddHeader("Authorization", "Bearer your_api_key");
request.AddParameter("providers", "[\'google\', \'microsoft\', \'aws\']");
request.AddFile("files", "/Downloads/example.mp3");
request.AddFile("text_to_find", "\'Hi, I am Martin\'");
IRestResponse response = client.Execute(request);
Console.WriteLine(response.Content);
