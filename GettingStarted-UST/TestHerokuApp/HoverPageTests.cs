using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using HerokuAppOperations;

namespace TestHerokuApp
{
    internal class HoverPageTests
    {
        [Test]
        /// <summary>
        /// Verifies that the subtitle of the Hover page is correct.
        /// </summary>
        public void HoverPageSubTitleIsCorrect()
        {
            // Arrange
            IHoverPage hoverPage = null; 
            string expectedTitle = "Hover over the image for additional information";

            // Act
            string actualTitle = hoverPage.GetTitle();

            // Assert
            Assert.That(expectedTitle, Is.EqualTo(actualTitle), "The retrieved title is not as expected.");
        }
        [Test]
        /// <summary>
        /// Verifies that the title of the Hover page is correct.
        /// </summary>
        public void HoverPageTitleIsCorrect()
        {
            // Arrange
            IHoverPage hoverPage = null;
            string expectedSubTitle = "Hover over the image for additional information";

            // Act
            string actualSubTitle = hoverPage.GetTitle();

            // Assert
            Assert.That(expectedSubTitle, Is.EqualTo(actualSubTitle), "The retrieved title is not as expected.");
        }

        /// <summary>
        /// Test case to verify hover text of images on the webpage.
        /// </summary>
        [Test]
        public void HoverOverImageToVerifyUserName()
        {
            // Arrange
            IHoverPage hoverPage = null; // Replace null with the instance of your implementation of IForgotPasswordPage
            string expected = "name:user1";

            // Act
            hoverPage.DoHover("1");
            string actual = hoverPage.GetUserName("1");

            // Assert
            Assert.That(expected, Is.EqualTo(actual), "The retrieved user name is not as expected.");

        }
        /// <summary>
        /// Test case to verify hover view profile link of images on the webpage.
        /// </summary>
        [Test]
        public void HoverOverImageToVerifyViewProfileLink()
        {
            // Arrange
            IHoverPage hoverPage = null; // Replace null with the instance of your implementation of IForgotPasswordPage
            string expected = "name:user1";

            // Act
            hoverPage.DoHover("1");
            string actual = hoverPage.GetUserName("1");

            // Assert
            Assert.That(expected, Is.EqualTo(actual), "The retrieved user name is not as expected.");

        }
    }
}
