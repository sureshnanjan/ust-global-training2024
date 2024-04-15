using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;
using NUnit.Framework;

namespace TestHerokuApp
{
    [TestFixture]
    internal class ForgotPasswordPageTests
    {
        /// <summary>
        /// Test case to verify that the correct title is retrieved from the forgot password page.
        /// </summary>
        [Test]
        public void ForgotPasswordPageTitleIsCorrect()
        {
            // Arrange
            IForgotPasswordPage fogotPasswordPage = null;
            string expectedTitle = "Forgot Password";
            // Act
            string actualTitle = fogotPasswordPage.GetTitle();

            // Assert
            Assert.That(expectedTitle,Is.EqualTo(actualTitle),"The retrieved title is not as expected."); 
        }
        public void InputLabelIsCorrect()
        {
            // Arrange
            IForgotPasswordPage fogotPasswordPage = null;
            string expectedTitle = "Email";
            // Act
            string actualTitle = fogotPasswordPage.GetLabel();

            // Assert
            Assert.That(expectedTitle, Is.EqualTo(actualTitle), "The retrieved label is not as expected.");
        }
    }
}
