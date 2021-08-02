var client = new RestClient("https://api.edenai.run/v1/pretrained/text/syntax_analysis");
client.Timeout = -1;
var request = new RestRequest(Method.POST);
request.AddHeader("Authorization", "Bearer your_api_key");
request.AlwaysMultipartFormData = true;
request.AddParameter("providers", "[\'google\', \'aws\', \'ibm\']");
request.AddParameter("text", "\'I am angry today\'");
request.AddParameter("language", "en-US");
IRestResponse response = client.Execute(request);
Console.WriteLine(response.Content);
