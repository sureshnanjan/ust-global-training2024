using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace RestAPIProject
{
    public class GetBookingIdsAll
    {
        public async void GetBookingIds()
        {
            var options = new RestClientOptions("https://restful-booker.herokuapp.com/")
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest("https://restful-booker.herokuapp.com/booking", Method.Get);
            RestResponse response = await client.ExecuteAsync(request);
            Console.WriteLine(response.Content);
        }
    }
}
