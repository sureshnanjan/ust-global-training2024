using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;

namespace TestHerokuApp
{
    /// <summary>
    /// Test cases for JQuery UI Menus page
    /// </summary>
    [TestFixture]
    public class JQueryUIMenusTests
    {

        /// <summary>
        /// To verify the URL of page is correct
        /// </summary>
        [Test]
        public void UrlIsCorrect()
        {
            IJqueryMenu jqueryMenu = null;
            string expectedUrl = "https://the-internet.herokuapp.com/jqueryui/menu";
            string actualUrl = jqueryMenu.getURL();
            Assert.That(actualUrl, Is.EqualTo(expectedUrl));
        }

        /// <summary>
        /// To Verify the Title of page is correct
        /// </summary>
        [Test]
        public void TitleIsCorrect()
        {
            IJqueryMenu jqueryMenu = null;
            string expectedTitle = "JQueryUI - Menu";
            string actualTitle = jqueryMenu.getTitle();
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
        }

        /// <summary>
        /// To verify the content of page is correct
        /// </summary>
        [Test]
        public void ContentIsCorrect()
        {
            IJqueryMenu jqueryMenu = null;
            string expectedContent = "JQuery UI Menus are a nice UI element from a user perspective, but poses an interesting automation challenge since it requires mouse operations and synchronization between them.\r\n\r\nAnother 'fun' aspect is that the visibility of elements is actually not in the html itself, but done magically by JQuery so you cannot trust exactly what the html is telling you. A user cannot fire click events at certain UI elements, but you might -- if you have a big enough hammer to hit it with.";
            string actualContent = jqueryMenu.getMainContent();
            Assert.That(actualContent, Is.EqualTo(expectedContent));
        }

        /// <summary>
        /// To verify whether the JQuery UI Menus link in the page is redirecting correctly
        /// </summary>
        [Test]
        public void LinkIsRedirectingCorrectly()
        {
            IJqueryMenu jqueryMenu = null;
            string expectedUrl = "https://api.jqueryui.com/menu/";
            string actualUrl = jqueryMenu.getURL();
            Assert.That(actualUrl, Is.EqualTo(expectedUrl));
        }



    }
}
