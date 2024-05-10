using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookerAPIRequests;
using NUnit.Framework;


namespace TestBookerAPI
{
    [TestFixture]
    internal class TestRestFulAPI
    {
        [Test]
        public void verifyAuthenticationAPI()
        {
            
            Task<RestSharp.RestResponse> response = RestBookerAPI.doAuth();
            Console.WriteLine(response.Result);
            Assert.That(response.Result.IsSuccessStatusCode, Is.True);
        }
        [Test]
        public void verifyGetBookingIdsAPI()
        {
            Console.WriteLine("Started");
            Task<RestSharp.RestResponse> response = RestBookerAPI.getBookingIds();
            Console.WriteLine(response.Result.Content);
            
        }
        [Test]
        public void verifyBookingsDetailsAPI()
        {
            Task<RestSharp.RestResponse> response = RestBookerAPI.getBookingDetails();
            Console.WriteLine(response.Result.ResponseStatus);
            
        }
        [Test]
        public void verifyBookingCreationAPI()
        {
            RestBookerAPI.createBooking();
            
        }
        [Test]
        public void verifyBookingUpdateAPI()
        {
            RestBookerAPI.updateBooking();
          
        }
        [Test] public void verifyPartialBookingUpdateAPI()
        {
            RestBookerAPI.updatePartialBooking();
         
        }
        [Test]
        public void verifyBookingDeleteAPI()
        {
            RestBookerAPI.deleteBooking();
            
        }
    }
}
