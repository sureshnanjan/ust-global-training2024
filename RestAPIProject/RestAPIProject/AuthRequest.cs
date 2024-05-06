using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace RestAPIProject
{
    public class AuthRequest
    {
       public  async void postReq()
        {
            var options = new RestClientOptions("https://restful-booker.herokuapp.com/")
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest("https://restful-booker.herokuapp.com/auth", Method.Post);
            request.AddHeader("Content-Type", "application/json");
            var body = @"{" + "\n" +  @"    ""username"" : ""admin""," + "\n" +    @"    ""password"" : ""password123"" " + "\n" +   @"}";
            request.AddStringBody(body, DataFormat.Json);
            RestResponse response = await client.ExecuteAsync(request);
            Console.WriteLine(response.Content);
        }
    }
}
