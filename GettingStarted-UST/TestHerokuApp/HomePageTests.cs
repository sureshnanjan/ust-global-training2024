using HerokuAppOperations;
using HerokuWebdriverImplemention;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using System.Security.Cryptography;
namespace TestHerokuApp
{
    [TestFixture]
    public class HomePageTests
    {
        /// <summary>
        /// Test case to verify the home page title 
        /// </summary>
        [Test]
        public void homePageTitleisCorrect()
        {
            // Arrange
            IHomePage page = new HomePage();
            // page.goToExample*().AddElement().CheckIfDisplayed()
            string expectedTitle = "Welcome to the-internet";
            // Action
            string actualTitle = page.getTitle();
            Console.WriteLine(actualTitle);
            // Assert
            Assert.That(actualTitle, Is.EqualTo(expectedTitle)); // NUNIT
                
        }
        /// <summary>
        /// Test case to verify the Home page Sub Title 
        /// </summary>
        [Test]
        public void homePageSubTitleisCorrect() {
            IHomePage page = new HomePage();
            string expectedSubTitle = "Available Examples";
            // A
            string actualTitle = page.getSubTitle();
            // A
            Assert.That(actualTitle, Is.EqualTo(expectedSubTitle)); // NUNIT
        }

        /// <summary>
        /// Test case to verify the all the 44 links 
        /// </summary>

        [Test]
        public void homePageHas44Links() {
            IHomePage page = null;
            int expectedCount = 44;
            int actual = page.getAvailableExamples().Length;
            Assert.That(actual, Is.EqualTo(expectedCount));
        }


        /// <summary>
        /// Test case to verify the Example page title 
        /// </summary>
        [Test]
        public void visintingAExamplePageWorks() {
            IHomePage page = null;
            string pagetovisit = "A/B Testing";
            string expectedTitle = "A/B Test Variation 1";
            page.goToExample(pagetovisit);
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
