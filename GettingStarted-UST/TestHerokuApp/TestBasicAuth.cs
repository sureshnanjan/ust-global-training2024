using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using HerokuAppOperations;
using HerokuWebdriverImplemention;


namespace TestHerokuApp
{
    [TestFixture]

    public class TestBasicAuth
    {
        [Test]
        public void authenication_success_getresults() {
            IBasicAuthOperations page = new BasicAuthPage();
            string expected = "Congratulations! You must have the proper credentials.";
            /// AAA
            page.Authenticate("admin", "admin");
            string actual = page.getStatusMessage();
            Assert.That(expected, Is.EqualTo(actual));



        }

        [Test]
        public void authenication_failure_getresults()
        {
            IBasicAuthOperations page = new BasicAuthPage();
            string expected = "Not authorised";
            /// AAA
            //page.Authenticate("wring", "admin");
            string actual = page.getStatusMessage();
            Assert.That(expected, Is.EqualTo(actual));



        }
    }
}
