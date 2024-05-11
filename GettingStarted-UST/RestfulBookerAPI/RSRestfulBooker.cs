using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RestSharp;
using RestSharp.Authenticators;

namespace RestfulBookerAPI
{
    public class RSRestfulBooker
    {

        public static async void DoRestSharpDemo() {
            var options = new RestClientOptions("https://restful-booker.herokuapp.com")
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest("/auth", Method.Get);
            request.AddHeader("Content-Type", "application/json");
            var body = @"{
" + "\n" +
            @"    ""username"" : ""admin"",
" + "\n" +
            @"    ""password"" : ""wring""
" + "\n" +
            @"}";
            request.AddStringBody(body, DataFormat.Json);
            RestResponse response = await client.ExecuteAsync(request);
            Console.WriteLine(response);
        }


        public static async Task<RestResponse> DeleteBooking(int bookingid, string uname, string password) {

            var options = new RestClientOptions("https://restful-booker.herokuapp.com")
            {
                MaxTimeout = -1,
                Authenticator = new HttpBasicAuthenticator(uname, password)
            };
            var client = new RestClient(options); // Browser , PostManTool
            var request = new RestRequest("/booking/11", Method.Delete);
            request.AddHeader("Content-Type", "application/json");
            //request.AddHeader("Authorization", GetEncodedPassword("admin","password123"));
            var body = @"";
            request.AddStringBody(body, DataFormat.Json);
            // Its a lengthy task 
            RestResponse response = await client.ExecuteAsync(request);
            //Console.WriteLine(response.Content);
            return response;


        }

        public static string GetEncodedPassword(string uname, string password) {
            return String.Empty;
        }
    }
}
