using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;
using OpenQA.Selenium;

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

        /// <summary>
        /// Check if the email input box is displayed and accessible.
        /// </summary>
        [Test]
        public void VerifyEmailInputBoxTest()
        {
            // Arrange
            IForgotPasswordPage forgotPasswordPage = null;

            // Act
            IWebElement emailInput =default;

            // Assert that the email input box is displayed and enabled
            Assert.That(emailInput.Displayed && emailInput.Enabled,Is.True);
        }
        /// <summary>
        /// Check if the button is displayed and clickable.
        /// </summary>
        /// 
        [Test]
        public void VerifyButtonTest()
        {
            // Arrange
            IForgotPasswordPage forgotPasswordPage = null;

            // Act
            IWebElement button = default;

            // Assert that the button is displayed and enabled
            Assert.That(button.Displayed && button.Enabled,Is.True);
        }

        /// <summary>
        /// Test entering an email and clicking the button.
        /// </summary>
        [Test]
        public void EnterInvalidEmailTest()
        {
            // Arrange
            IForgotPasswordPage forgotPasswordPage = null;

            //Act
            IWebElement emailInput = default;
            emailInput.SendKeys("email");

            // Find and click the button
            IWebElement button = default;
            button.Click();

            // Assert any expected behavior after clicking the button
            //Assert.IsTrue(driver.PageSource.Contains("Invalid email format"));
        }



    }
}
