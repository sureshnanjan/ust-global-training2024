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
        /// Tests whether the home page title is correct.
        /// </summary>
        [Test]
        public void homePageTitleisCorrect()
        {
            // Arrange
            IHomePage page = null;
            string expectedTitle = "Welcome to the-internet";

            // Act
            string actualTitle = page.getTitle();

            // Assert
            Assert.That(actualTitle, Is.EqualTo(expectedTitle)); // NUNIT
        }

        /// <summary>
        /// Tests whether the home page subtitle is correct.
        /// </summary>
        [Test]
        public void homePageSubTitleisCorrect()
        {
            IHomePage page = null;
            string expectedSubTitle = "Available Examples";

            // Act
            string actualTitle = page.getSubTitle();

            // Assert
            Assert.That(actualTitle, Is.EqualTo(expectedSubTitle)); // NUNIT
        }

        /// <summary>
        /// Tests whether the home page has 44 links.
        /// </summary>
        [Test]
        public void homePageHas44Links()
        {
            IHomePage page = null;
            int expectedCount = 44;
            int actual = page.getAvailableExamples().Length;
            Assert.That(actual, Is.EqualTo(expectedCount));
        }

        /// <summary>
        /// Tests whether visiting an example page works correctly.
        /// </summary>
        [Test]
        public void visintingAExamplePageWorks()
        {
            IHomePage page = null;
            string pagetovisit = "A/B Testing";
            string expectedTitle = "A/B Test Variation 1";
            page.goToExample(pagetovisit);
            string actualTitle = page.getTitle();
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
        }

        /// <summary>
        /// Tests visiting an example page with specific page name and expected title.
        /// </summary>
        /// <param name="pageToVisit">The name of the page to visit.</param>
        /// <param name="expectedTitle">The expected title of the page.</param>
        [TestCase("A/B Testing", "A/B Test Variation 1")]
        [TestCase("Add/Remove Elements", "Add/Remove Elements")]
        [TestCase("Basic Auth", "Basic Auth")]
        [TestCase("Broken Images", "Broken Images")]
        [TestCase("Challenging DOM", "Challenging DOM")]
        [TestCase("Checkboxes", "Checkboxes")]
        [TestCase("Context Menu", "Context Menu")]
        [TestCase("Digest Authentication", "Digest Authentication")]
        public void VisitingExamplePageWorks(string pageToVisit, string expectedTitle)
        {
            // Arrange
            IHomePage page = null;
            page.goToExample(pageToVisit);

            // Act
            string actualTitle = page.getTitle();

            // Assert
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
        }

    }
}
