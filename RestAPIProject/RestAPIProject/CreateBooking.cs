using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace RestAPIProject
{
    internal class CreateBooking
    {
        public async void createBooking()
        {
            var options = new RestClientOptions("https://restful-booker.herokuapp.com/")
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest("https://restful-booker.herokuapp.com/booking", Method.Post);
            request.AddHeader("Content-Type", "application/json");
            var body = @"{
" + "\n" +
            @"    ""firstname"" : ""JimNEw"",
" + "\n" +
            @"    ""lastname"" : ""Brownnew"",
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
            Console.WriteLine(response.Content);
        }
    }
}
