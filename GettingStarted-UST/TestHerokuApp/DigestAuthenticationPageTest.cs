using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.sun.org.apache.xml.@internal.resolver.helpers;
using HerokuAppOperations;
using HerokuWebdriverImplemention;
using OpenQA.Selenium;

namespace TestHerokuApp
{
    [TestFixture]
    public class DigestAuthenticationPageTest
    {
        //private IWebDriver driver;
        public IDigestAuthentication page = new DigestAuthenticationPage();

 
        [Test]

        public void verifyLogin() {

            IHomePage pageCall = new HomePage();
            IDigestAuthentication mw = (DigestAuthenticationPage)pageCall.goToExample("Digest Authentication");
            page.DoSignIn("admin", "admin", false);
            string expectedHeader = "Digest Auth";
            string actualHeader = page.GetSignInStatus();
            Assert.That(actualHeader, Is.EqualTo(expectedHeader));

        }

        [Test]
        public void verifyPageTitle()
        {
            page.DoSignIn("admin", "admin", false);
            string expectedSubTitle = "Digest Authentication";
            string actualTitle = page.GetTitle();
            Assert.That(actualTitle, Is.EqualTo(expectedSubTitle)); // NUNIT
        }
    }
}
