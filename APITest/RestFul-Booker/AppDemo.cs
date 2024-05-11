using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace RestFul_Booker
{
    public class AppDemo
    {

        public static async void CreateBooking()
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
                        @"    ""firstname"" : ""Paul"",
            " + "\n" +
                        @"    ""lastname"" : ""Miller"",
            " + "\n" +
                        @"    ""totalprice"" : 333,
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
            Console.WriteLine(response.Content);
        }

        public static async void Update()
        {
            var options = new RestClientOptions("https://restful-booker.herokuapp.com")
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest("/booking/648", Method.Put);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Authorization", "Basic YWRtaW46cGFzc3dvcmQxMjM=");
            var body = @"{
                " + "\n" +
                            @"    ""firstname"": ""Paul"",
                " + "\n" +
                            @"    ""lastname"": ""Miller"",
                " + "\n" +
                            @"    ""totalprice"": 222,
                " + "\n" +
                            @"    ""depositpaid"": true,
                " + "\n" +
                            @"    ""bookingdates"": {
                " + "\n" +
                            @"        ""checkin"": ""2018-01-01"",
                " + "\n" +
                            @"        ""checkout"": ""2019-01-01""
                " + "\n" +
                            @"    },
                " + "\n" +
                            @"    ""additionalneeds"": ""Breakfast""
                " + "\n" +
                            @"}";
            request.AddStringBody(body, DataFormat.Json);
            RestResponse response = await client.ExecuteAsync(request);
            Console.WriteLine(response.Content);
        }

    }
}
