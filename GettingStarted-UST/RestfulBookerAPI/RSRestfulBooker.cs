using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Authenticators;

namespace RestfulBookerAPI
{
    public class RSRestfulBooker
    {
        //Creates a new auth token to use for access to the PUT and DELETE /booking
        public static async Task<RestResponse> doAuth()
        {
            var options = new RestClientOptions("https://restful-booker.herokuapp.com/")
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest("/auth", Method.Post);
            request.AddHeader("Content-Type", "application/json");
            var body = @"{
" + "\n" +
            @"    ""username"" : ""admin"",
" + "\n" +
            @"    ""password"" : ""password123""
" + "\n" +
            @"}";
            request.AddStringBody(body, DataFormat.Json);
            RestResponse response = await client.ExecuteAsync(request);
            Console.WriteLine(response.Content);
            return response;
        }

        //Returns the ids of all the bookings that exist within the API
        public static async Task<RestResponse> getBookingIds()
        {
            var options = new RestClientOptions("https://restful-booker.herokuapp.com/")
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest("/booking", Method.Get);
            var body = @"";
            request.AddParameter("text/plain", body, ParameterType.RequestBody);
            RestResponse response = await client.ExecuteAsync(request);
            Console.WriteLine(response.Content);
            return response;
        }

        //Returns a specific booking based upon the booking id provided
        public static async Task<RestResponse> getBooking()
        {
            var options = new RestClientOptions("https://restful-booker.herokuapp.com")
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest("/booking/2013", Method.Get);
            request.AddHeader("Accept", "application/json");
            var body = @"";
            request.AddParameter("text/plain", body, ParameterType.RequestBody);
            RestResponse response = await client.ExecuteAsync(request);
            //Console.WriteLine(response.Content);
            return response;
        }

        //Creates a new booking in the API
        public static async Task<RestResponse> CreateBooking()
        {
            var options = new RestClientOptions("https://restful-booker.herokuapp.com")
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest("/booking", Method.Post);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Accept", "application/json");
            var body = @"{
" + "\n" +
            @"    ""firstname"" : ""Jim"",
" + "\n" +
            @"    ""lastname"" : ""Brown"",
" + "\n" +
            @"    ""totalprice"" : 111,
" + "\n" +
            @"    ""depositpaid"" : true,
" + "\n" +
            @"    ""bookingdates"" : {
" + "\n" +
            @"        ""checkin"" : ""2018-01-01"",
" + "\n" +
            @"        ""checkout"" : ""2019-01-01""
" + "\n" +
            @"    },
" + "\n" +
            @"    ""additionalneeds"" : ""Breakfast""
" + "\n" +
            @"}";
            request.AddStringBody(body, DataFormat.Json);
            RestResponse response = await client.ExecuteAsync(request);
            //Console.WriteLine(response.Content);
            return response;
        }

        //Updates a current booking
        public static async Task<RestResponse> UpdateBooking()
        {
            var options = new RestClientOptions("https://restful-booker.herokuapp.com")
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest("/booking/837", Method.Put);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Cookie", "Bearera836e6b66e73d37");
            request.AddHeader("Authorization", "Basic YWRtaW46cGFzc3dvcmQxMjM=");
            var body = @"{
" + "\n" +
            @"    ""firstname"" : ""Jame"",
" + "\n" +
            @"    ""lastname"" : ""Brown"",
" + "\n" +
            @"    ""totalprice"" : 111,
" + "\n" +
            @"    ""depositpaid"" : true,
" + "\n" +
            @"    ""bookingdates"" : {
" + "\n" +
            @"        ""checkin"" : ""2018-01-01"",
" + "\n" +
            @"        ""checkout"" : ""2019-01-01""
" + "\n" +
            @"    },
" + "\n" +
            @"    ""additionalneeds"" : ""Breakfast""
" + "\n" +
            @"}";
            request.AddStringBody(body, DataFormat.Json);
            RestResponse response = await client.ExecuteAsync(request);
            //Console.WriteLine(response.Content);
            return response;
        }

        //Updates a current booking with a partial payload
        public static async Task<RestResponse> PartialUpdateBooking()
        {
            var options = new RestClientOptions("https://restful-booker.herokuapp.com")
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest("/booking/667", Method.Patch);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Cookie", "Bearer438c6556b4c275d");
            request.AddHeader("Authorization", "Basic YWRtaW46cGFzc3dvcmQxMjM=");
            var body = @"{
" + "\n" +
            @"    ""firstname"" : ""James"",
" + "\n" +
            @"    ""lastname"" : ""Brown""
" + "\n" +
            @"}";
            request.AddStringBody(body, DataFormat.Json);
            RestResponse response = await client.ExecuteAsync(request);
            //Console.WriteLine(response.Content);
            return response;
        }

        //Returns the ids of all the bookings that exist within the API
        public static async Task<RestResponse> DeleteBooking(int bookingid, string uname, string password)
        {
            var options = new RestClientOptions("https://restful-booker.herokuapp.com/")
            {
                MaxTimeout = -1,
                Authenticator = new HttpBasicAuthenticator(uname, password)
            };
            var client = new RestClient(options);//Browser, PostMan Tool
            var request = new RestRequest("booking/2403", Method.Delete);
            request.AddHeader("Content_Type", "application/json");
            // request.AddHeader("Authorization", GetEncodedPassword("admin","password123"));
            var body = @"";
            request.AddStringBody(body, DataFormat.Json);
            //Its a lengthy task
            RestResponse response = await client.ExecuteAsync(request);
            //Console.WriteLine(response.Content);
            return response;
        }

        public static string GetEncodedPassword(string uname, string password)
        {
            return String.Empty;
        }
    }
}
