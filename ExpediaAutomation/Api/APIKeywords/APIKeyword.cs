
using ExpediaAutomation.Step_Def;
using Newtonsoft.Json;
using RestSharp;


namespace ExpediaAutomation.Api.APIKeywords
{
    class APIKeyword
        
    {
        public static int responseCode;
        public static int responseCode1;
        public static int responseCode2;
        public static string contentRaw;
        public static string contentRaw1;

        public static string token;
        public static string error;
        public static string data;

        public void SuccessfulRegistrationWithCorrectCredenials(string email,string password) {
            var client = new RestClient("https://reqres.in/");
            // client.Authenticator = new HttpBasicAuthenticator(username, password);

            var request = new RestRequest("/api/register", Method.POST);
            request.AddParameter("email", email); // adds to POST or URL querystring based on Method
            request.AddParameter("password", password); // replaces matching token in request.Resource
            IRestResponse response = client.Execute(request);
            responseCode = (int)response.StatusCode;
            var content = response.Content;
            contentRaw = content;
            MyData tmp = JsonConvert.DeserializeObject<MyData>(response.Content);
            token = tmp.token;
        }
        public string Tokenvalue() {
            return token;
        } 
        public string ContentValue()
        {
            return contentRaw;
        }
        public int ResponseCode()
        {
            return responseCode ;
        }

        public void UnSuccessfulRegistrationWithOnlyUsername(string email) {
            var client = new RestClient("https://reqres.in/");
            // client.Authenticator = new HttpBasicAuthenticator(username, password);

            var request = new RestRequest("/api/register", Method.POST);
            request.AddParameter("email", email); // adds to POST or URL querystring based on Method
            
            IRestResponse response = client.Execute(request);
            responseCode1 = (int)response.StatusCode;
            var content = response.Content;
            contentRaw1 = content;
            MyData tmp = JsonConvert.DeserializeObject<MyData>(response.Content);
            error = tmp.error;
        }
        public string Error()
        {
            return error;
        }
        public string ContentValue1()
        {
            return contentRaw1;
        }
        public int ResponseCode1()
        {
            return responseCode1;
        }


        public void ListUsers()
        {
            var client = new RestClient("https://reqres.in/");
            // client.Authenticator = new HttpBasicAuthenticator(username, password);

            var request = new RestRequest("/api/users?page=2", Method.GET);
            

            IRestResponse response = client.Execute(request);
            responseCode2 = (int)response.StatusCode;
            var content = response.Content;
            
            
        }
        
        public int ResponseCode2()
        {
            return responseCode2;
        }


    }
}
