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
            Console.WriteLine("Started");
            RestBookerAPI.doAuth();
        }
        [Test]
        public void verifyGetBookingIdsAPI()
        {
            RestBookerAPI.getBookingIds();
        }
        [Test]
        public void verifyBookingsDetailsAPI()
        {
            RestBookerAPI.getBookingDetails();
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
