using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;

namespace TestHerokuApp
{
    /// <summary>
    /// Perform Tests in HomePage
    /// </summary>
    [TestFixture]
    public class HomePageTests
    {
        /// <summary>
        /// Verify Title of Homepage
        /// </summary>
        [Test]
        public void HomePageTitleisCorrect()
        {
            // Arrange
            IHomePage page = null;
            string expectedTitle = "Welcome to the-internet";
            // A
            string actualTitle = page.GetTitle();
            // A
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));

        }

        /// <summary>
        /// Verify Subtitle of HomePage
        /// </summary>
        [Test]
        public void HomePageSubTitleisCorrect()
        {
            IHomePage page = null;
            string expectedSubTitle = "Available Examples";
            // A
            string actualTitle = page.GetSubTitle();
            // A
            Assert.That(actualTitle, Is.EqualTo(expectedSubTitle));
        }

        /// <summary>
        /// Verify HomePage has 44 links available
        /// </summary>
        [Test]
        public void HomePageHas44Links()
        {
            IHomePage page = null;
            int expectedCount = 44;
            int actual = page.GetAvailableExamples().Length;
            Assert.That(actual, Is.EqualTo(expectedCount));
        }

        /// <summary>
        /// Verify each link in HomePage redirects to correct link
        /// </summary>
        [TestCaseSource(nameof(exampleUtility))]
        public void VisintingAExamplePageWorks(string actual, string expected)
        {
            IHomePage page = null;
            page.GoToExample(actual);
            string actualTitle = page.GetTitle();
            Assert.That(actualTitle, Is.EqualTo(expected));
            Assert.AreEqual(expected, actual);
        }

        public static object[] exampleUtility =
        {
            new object[] { "A/B Testing", "" },

        };

    }
}
