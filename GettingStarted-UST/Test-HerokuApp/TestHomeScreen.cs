using NUnit.Framework;
using NUnit.Framework.Constraints;
using HerokuAppOperations;
using HerokuAppWebdriverImplementation;
using System.Security.Cryptography;
namespace Test_HerokuApp
{
    /// <summary>
    /// Home Screen Tests for HerokuApp
    /// </summary>
    [TestFixture]
    public class TestHomeScreen
    {
        /// <summary>
        /// Test to Validate Home Screen Title Is correct 
        /// </summary>
        [Test]
        public void HomeScreenTitleIsCorrect()
        {
            //Arrange
            IHomeScreen page= new HomeScreen(); 
            string expectedTitle = "The Internet";
            //Action
            string actualTitle = page.getTitle();
            //Assert
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));

        }

        /// <summary>
        /// Test to Validate Home Screen SubTitle Is correct 
        /// </summary>
        [Test]
        public void HomeScreenSubTitleIsCorrect()
        {
            //Arrange
            IHomeScreen page= new HomeScreen();
            string expectedSubTitle = "Available Examples";
            //Action 
            string actualSubTitle = page.getSubTitle();
            //Assert
            Assert.That(actualSubTitle, Is.EqualTo(expectedSubTitle));

        }

        /// <summary>
        /// Test to Validate the Links in Home Screen 
        /// </summary>
        [Test]
        public void HomeScreenHas44Links()
        {
            //Arrange
            IHomeScreen page = null;
            int expectedCount = 44;
            int actual = page.getAvailableExamples().Length;
            Assert.That(actual, Is.EqualTo(expectedCount));

        }

        /// <summary>
        /// Test case to verify visting A/B testing Link  
        /// </summary>
        [Test]
        public void visitingAExamplePageWorks()
        {
            IHomeScreen page = null;
            string pagetovisit = "A/B Testing";
            string expectedTitle = "A/B Test Variation 1";
            page.goToExample(pagetovisit);
            string actualTitle = page.getTitle();
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
        }

        /// <summary>
        /// Test case to verify visting all page Link  
        /// </summary>
        /// Sources with expected result using TestCaseData
        //[TestCaseSource(Type sourceType, string sourceName)]
        [TestCaseSource(typeof(MyData), nameof(MyData.HerOkuAppTestCases))]
        public void vistingAllPageWorks(string pagetovisit, string expectedTitle)
        {
            IHomeScreen page = null;
            page.goToExample(pagetovisit);
            string actualTitle = page.getTitle();
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
        }

    }
}
