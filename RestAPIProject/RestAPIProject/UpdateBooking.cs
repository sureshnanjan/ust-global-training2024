using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace RestAPIProject
{
    public class UpdateBooking
    {
        public async void updateBooking()
        {
            var options = new RestClientOptions("https://restful-booker.herokuapp.com/")
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest("https://restful-booker.herokuapp.com/booking/915", Method.Put);
            request.AddHeader("Cookie", "token=145dcebc895b5d6");
            request.AddHeader("Content-Type", "application/json");
            var body = @"{
" + "\n" +
            @"    ""firstname"" : ""James"",
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
            Console.WriteLine(response.Content);
        }
    }
}
