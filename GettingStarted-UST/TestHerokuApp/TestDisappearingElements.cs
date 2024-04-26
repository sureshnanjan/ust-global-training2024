using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;

namespace TestHerokuApp
{
    [TestFixture]
    public class TestDisappearingElements
    {

        /// <summary>
        /// Verifing page title 
        /// </summary>
        [Test]
        public void testDisappearingElementsPageTitleCorrect()
        {
            IDisappearingElementsOperations page = null;
            string expectedTitle = "Disappearing Elements";
            string actualTitle = page.GetTitle();
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
        }

        /// <summary>
        /// Verifing page URL 
        /// </summary>
        [Test]
        public void testUrlCorrect() 
        {
            IDisappearingElementsOperations url = null;
            string expectedUrl = "https://the-internet.herokuapp.com/disappearing_elements";
            string actualUrl = url.GetURL();
            Assert.That(actualUrl, Is.EqualTo(expectedUrl));
        }

        /// <summary>
        /// Verfiy page content
        /// </summary>
        [Test]
        public void testPageMainContent() 
        {
            IDisappearingElementsOperations page = null;
            string expectedContent = "This example demonstrates when elements on a page change by disappearing/reappearing on each page load.";
            string actualContent = page.GetMainContent();
            Assert.That(actualContent, Is.EqualTo(expectedContent));
        }

        /// <summary>
        /// Click on the Home button
        /// <action> Redirect to the Home Page</action>
        [Test]
        public void testClickHomeButton() 
        {
            IDisappearingElementsOperations page = null;
            string expectedButton = "Home";
            string actualButton = page.ClickHome();
            Assert.That(actualButton, Is.EqualTo(expectedButton));
        }

        /// <summary>
        /// Click on the About button
        /// </summary>
        [Test]
        public void testClickAboutButton() 
        {
            IDisappearingElementsOperations page = null;
            string expectedButton = "About";
            string actualButton = page.ClickAbout();
            Assert.That(actualButton, Is.EqualTo(expectedButton));
        }

        // <summary>
        /// Click on the Contact Us button
        /// </summary>
        [Test]
        public void testClickContactUsButton() 
        {  
            IDisappearingElementsOperations page = null;
            string expectedButton = "Contact Us";
            string actualButton = page.ClickContactUs();
            Assert.That(actualButton, Is.EqualTo(expectedButton));
        }

        // <summary>
        /// Click on the portfolio button
        /// </summary>
        [Test]
        public void testClickPortfolioButton() 
        {
            IDisappearingElementsOperations page = null;
            string expectedButton = "Portfolio";
            string actualButton = page.ClickPortfolio();
            Assert.That(actualButton, Is.EqualTo(expectedButton));
        }
    }
}
