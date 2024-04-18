using HerokuAppOperations;
using HerokuWebdriverImplemention;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using OpenQA.Selenium.Chromium;
using OpenQA.Selenium.DevTools;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.VirtualAuth;
using OpenQA.Selenium;
using System.Security.Cryptography;
namespace TestHerokuApp
{
    [TestFixture]
    public class HomePageTests
    {
        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void homePageTitleisCorrect() {
            // Arrange
            IHomePage page = new HomePage();
            // page.goToExample*().AddElement().CheckIfDisplayed()
            string expectedTitle = "Welcome to the-internet";
            // A
            string actualTitle = page.getTitle();
            // A
            Assert.That(actualTitle, Is.EqualTo(expectedTitle)); // NUNIT
                
        }

        [Test]
        public void homePageSubTitleisCorrect() {
            IHomePage page = null;
            string expectedSubTitle = "Available Examples";
            // A
            string actualTitle = page.getSubTitle();
            // A
            Assert.That(actualTitle, Is.EqualTo(expectedSubTitle)); // NUNIT
        }

        [Test]
        public void homePageHas44Links() {
            IHomePage page = null;
            int expectedCount = 44;
            int actual = page.getAvailableExamples().Length;
            Assert.That(actual, Is.EqualTo(expectedCount));
        }

        [Test]
        public void visintingAExamplePageWorks() {
            IHomePage page = null;
            string pagetovisit = "A/B Testing";
            string expectedTitle = "A/B Test Variation 1";
            //(IABTestOpetration) page.goToExample(pagetovisit);
            string actualTitle = page.getTitle();
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
        }

        [Test]
        public void testingIfFirstItemisDisabled() {
            IHomePage page = null;
            //bool itemToTest = "Disabled";
            bool expectedTitle = false;
            //string actualTitle = page.getStatus(itemToTest);
            //Assert.That(actualTitle, Is.EqualTo(expectedTitle));


        }

        [Test]
        public void testingIfPDFItemIsEnabled()
        {
            IHomePage page = null;
            string itemToTest = "ENABLED-Download-Pdf";
            bool expectedTitle = true;
            bool actual = page.getStatus(itemToTest);
            //Assert.That(actualTitle, Is.EqualTo(expectedTitle));


        }

    }

    
}
