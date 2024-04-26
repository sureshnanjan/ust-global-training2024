using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;

namespace TestHerokuApp
{
    [TestFixture]
    public class TestRedirectLinkOperation
    {

        /// <summary>
        /// Verifing page URL 
        /// </summary>
        [Test]
        public void testUrlCorrect()
        {
            IRedirectLinkOperations url = null;
            string expectedUrl = "https://the-internet.herokuapp.com/redirector";
            string actualUrl = url.GetURL();
            Assert.That(actualUrl, Is.EqualTo(expectedUrl));
        }

        /// <summary>
        /// Verifing page title 
        /// </summary>
        [Test]
        public void testRedirectLinkOperationsPageTitleCorrect()
        {
            IRedirectLinkOperations page = null;
            string expectedTitle = "Redirection";
            string actualTitle = page.GetTitle();
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
        }

        /// <summary>
        /// Verfiy page content
        /// </summary>
        [Test]
        public void testPageMainContent()
        {
            IRedirectLinkOperations page = null;
            string expectedContent = "This is separate from directly returning a redirection status code, in that some browsers cannot handle a raw redirect status code without a destination page as part of the HTTP " +
                                      "response.\r\n\r\nClick here to trigger a redirect (and be taken to the status codes page). ";
            string actualContent = page.GetMainContent();
            Assert.That(actualContent, Is.EqualTo(expectedContent));
        }

        /// <summary>
        /// method helps to trigger redirect link
        /// <action> Redirect to the Home Page</action>
        [Test]
        public void testClickRedirectLink()
        {
            IRedirectLinkOperations page = null;
            string expectedLink = "here";
            string actualLink = page.ClickOnRedirectLink();
            Assert.That(actualLink, Is.EqualTo(expectedLink));
        }

        /// <summary>
        /// Helps to get the result of triggering redirect link
        /// </summary>
        [Test]
        public void testResultofRedirectLink()
        {
            IRedirectLinkOperations url = null;
            string expectedUrl = "https://the-internet.herokuapp.com/status_codes";
            string actualUrl = url.GetResultOfRedirect();
            Assert.That(actualUrl, Is.EqualTo(expectedUrl));
        }

        /// <summary>
        /// helps to click on status code 200
        /// <action> Redirect to the Home Page</action>
        [Test]
        public void testClick200Link()
        {
            IRedirectLinkOperations page = null;
            string expectedLink = "200";
            string actualLink = page.ClickOn200();
            Assert.That(actualLink, Is.EqualTo(expectedLink));
        }

        /// <summary>
        /// Helps to get the result of triggering 200 link
        /// </summary>
        [Test]
        public void testResultofClicking200Link()
        {
            IRedirectLinkOperations url = null;
            string expectedUrl = "https://the-internet.herokuapp.com/status_codes/200";
            string actualUrl = url.GetResultOfClicking200();
            Assert.That(actualUrl, Is.EqualTo(expectedUrl));
        }
    }
}

