using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RestfulBookerAPI;

namespace TestRestfulBooker
{
    [TestFixture]
    public class RSTests
    {
        //Test to Validate the create Token
        [Test]
        public void TestCreateToken()
        {
            Task<RestSharp.RestResponse>response = RSRestfulBooker.doAuth();
            Console.WriteLine(response.Result);
            Assert.That(response.Result.IsSuccessStatusCode,Is.True);
        }

        // Test to validate the Delete Booking 
        [Test]
        public void TestDeleteBooking()
        {
            var resp = RSRestfulBooker.DeleteBooking(0,"","").Result;
            Assert.IsNotNull(resp);
        }


        // Test to validate the Booking ID's 
        [Test]
        public void TestBookingIDs()
        {
            Task<RestSharp.RestResponse> response = RSRestfulBooker.getBookingIds();
            Console.WriteLine(response.Result.Content);
        }

        // Test to validate the Booking 
        [Test]
        public void TestBooking()
        {
            Task<RestSharp.RestResponse> response = RSRestfulBooker.getBooking();
            Console.WriteLine(response.Result.ResponseStatus);
            Console.WriteLine(response.Result.Content);
        }

        // Test to validate the Create Booking
        [Test]
        public void TestCreateBooking()
        {
            Task<RestSharp.RestResponse> response = RSRestfulBooker.CreateBooking();
            Console.WriteLine(response.Result.Content);
        }

        //Test to validate the Update booking 
        [Test]
        public void TestUpdateBooking()
        {
            Task<RestSharp.RestResponse> response = RSRestfulBooker.UpdateBooking();
            Console.WriteLine(response.Result.Content);
        }

        // Test to validate the Partial Update Booking 
        [Test]
        public void TestPartialUpdateBooking()
        {
            Task<RestSharp.RestResponse> response = RSRestfulBooker.PartialUpdateBooking();
            Console.WriteLine(response.Result.Content);

        }

    }
}
