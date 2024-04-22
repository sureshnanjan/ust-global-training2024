using HerokuAppOperations;
using NUnit.Framework;

namespace TestHerokuApp
{
    [TestFixture]

    
    public class TyposPageTest
    {
        ITypos typo = null;
        /// <summary>
        /// this method is used to get the title of the page and validate it it matches the expected title
        /// </summary>         
        [Test]
        public void validatePageTitle()
        {
            String expectedTitle = "Typos";
            String actualTitle;
            actualTitle = typo.getTitle();
            Assert.Equals(expectedTitle, actualTitle);
        }

        /// <summary>
        /// this method is used to get the message displayed on the page and validate it it matches the expected message
        /// </summary>         
        [Test]
        public void validatePageContent()
        {
            String expectedContent = "This example demonstrates a typo being introduced. It does it randomly on each page load.\r\n\r\nSometimes you'll see a typo, other times you won,t.";
            String actualContent;
            actualContent = typo.pageContent();
            Assert.Equals(expectedContent, actualContent);
        }
    }
}