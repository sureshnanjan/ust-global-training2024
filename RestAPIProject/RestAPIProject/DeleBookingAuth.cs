using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace RestAPIProject
{
    public class DeleBookingAuth
    {
        public async void deleBookingAuth() {

            var options = new RestClientOptions("")
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest("https://restful-booker.herokuapp.com/booking/1?id=3325", Method.Delete);
            request.AddHeader("Authorization", "YWRtaW46cGFzc3dvcmQxMjM=");
            RestResponse response = await client.ExecuteAsync(request);
            Console.WriteLine(response.Content);
        }
    }
}
