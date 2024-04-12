using HerokuAppOperations;
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
            IHomePage page = null;
            string expectedTitle = "Welcome to the-internet";
            // Action
            string actualTitle = page.getTitle();
            // Assert
            Assert.That(actualTitle, Is.EqualTo(expectedTitle)); // NUNIT
                
        }
        /// <summary>
        /// Test case to verify the Home page Sub Title 
        /// </summary>
        [Test]
        public void homePageSubTitleisCorrect() {
            IHomePage page = null;
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

        /// <summary>
        /// Test case to verify the Example page title 
        /// </summary>
        
        [TestCaseSource(typeof(MyDataClass), nameof(MyDataClass.TestCases))]
        public void visintingAllPageWorks(string pagetovisit,string expectedTitle)
        {
            IHomePage page = null;
            
            page.goToExample(pagetovisit);
            string actualTitle = page.getTitle();
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
        }
    }
}
