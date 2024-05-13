using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookerAPIRequests;
using NUnit.Framework;


namespace TestBookerAPI
{
    /// <summary>
    /// Test class to validate the Restfull APIs
    /// </summary>
    [TestFixture]
    internal class TestRestFulAPI
    {
        /// <summary>
        /// Testcase to validate TOKEN generation
        /// </summary>
        [Test]
        public void verifyAuthenticationAPI()
        {
            
            Task<RestSharp.RestResponse> response = RestBookerAPI.doAuth();
            Console.WriteLine(response.Result);
            Assert.That(response.Result.IsSuccessStatusCode, Is.True);
        }
        /// <summary>
        /// Testcase to get all the Booking ids
        /// </summary>
        [Test]
        public void verifyGetBookingIdsAPI()
        {
            Task<RestSharp.RestResponse> response = RestBookerAPI.getBookingIds();
            Console.WriteLine(response.Result.Content);
            Assert.That(response.Result.IsSuccessStatusCode, Is.True);

        }
        /// <summary>
        /// Test case to verify the Booking details
        /// </summary>
        [Test]
        public void verifyBookingsDetailsAPI()
        {
            Task<RestSharp.RestResponse> response = RestBookerAPI.getBookingDetails();
            Console.WriteLine(response.Result.Content);
            
        }
        /// <summary>
        /// Test case to create New Booking 
        /// </summary>
        [Test]
        public void verifyBookingCreationAPI()
        {
            Task<RestSharp.RestResponse> response = RestBookerAPI.createBooking();
            Console.WriteLine(response.Result.Content);
        }
        /// <summary>
        /// Test case to verify the update booking API
        /// </summary>
        [Test]
        public void verifyBookingUpdateAPI()
        {
            Task<RestSharp.RestResponse> response = RestBookerAPI.updateBooking();
            Console.WriteLine(response.Result.Content);

        }
        
        /// <summary>
        /// Testcase to verify partial booking API
        /// </summary>
        [Test] 
        public void verifyPartialBookingUpdateAPI()
        {
            Task<RestSharp.RestResponse> response = RestBookerAPI.updatePartialBooking();
            Console.WriteLine(response.Result.Content);

        }

        /// <summary>
        /// Testcase to verify Delete Booking API 
        /// </summary>
        [Test]
        public void verifyBookingDeleteAPI()
        {
            Task<RestSharp.RestResponse> response = RestBookerAPI.deleteBooking();
            Console.WriteLine(response.Result.Content);

        }
    }
}
