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
        [Test]
        public void TestRSDemo() {
            RSRestfulBooker.DoRestSharpDemo();
            var resp = RSRestfulBooker.DeleteBooking(0, "", "").Result;

            //resp.Headers.Count
        }
    }
}
