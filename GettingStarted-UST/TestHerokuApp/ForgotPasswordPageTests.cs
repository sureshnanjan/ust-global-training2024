using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;

namespace TestHerokuApp
{
    internal class ForgotPasswordPageTests
    {
        [Test]
        /// <summary>
        /// Verifies that the title of the Forgot Password page is correct.
        /// </summary>
        public void ForgotPasswordPageTitleIsCorrect()
        {
            // Arrange
            IForgotPasswordPage forgotPasswordPage = null; // Replace null with the instance of your implementation of IForgotPasswordPage
            string expectedTitle = "Forgot Password";

            // Act
            string actualTitle = forgotPasswordPage.GetTitle();

            // Assert
            Assert.That(expectedTitle, Is.EqualTo(actualTitle), "The retrieved title is not as expected.");
        }

        [Test]
        /// <summary>
        /// Verifies that the label for the email input field is correct.
        /// </summary>
        public void InputLabelIsCorrect()
        {
            // Arrange
            IForgotPasswordPage forgotPasswordPage = null; // Replace null with the instance of your implementation of IForgotPasswordPage
            string expectedLabel = "Email";

            // Act
            string actualLabel = forgotPasswordPage.GetLabel();

            // Assert
            Assert.That(expectedLabel, Is.EqualTo(actualLabel), "The retrieved label is not as expected.");
        }

    }
}
