using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;
using OpenQA.Selenium;

namespace HerokuWebdriverImplemention
{
    /// <summary>
    /// Represents the page object for the Forgot Password page of the HerokuApp.
    /// </summary>
    internal class ForgotPasswordPage : HerokuApp, IForgotPasswordPage
    {
        private By emailInputBoxLocator;
        private By inputLabelLocator;
        private By titleLocator;
        private By retrivePasswordButtonLocatore;

        /// <summary>
        /// Initializes a new instance of the ForgotPasswordPage  class.
        /// </summary>
        public ForgotPasswordPage()
        {
            emailInputBoxLocator = By.Id("email");
            inputLabelLocator = By.CssSelector("label[for='email']");
            titleLocator = By.XPath("//div[@class='example']/h2");
            retrivePasswordButtonLocatore = By.Id("form_submit");
        }

        /// <summary>
        /// Clicks on the 'Retrieve Password' button.
        /// </summary>
        public void ClickOnRetrievePassword()
        {
            driver.FindElement(retrivePasswordButtonLocatore).Click();
        }

        /// <summary>
        /// Enters the specified email into the email input box.
        /// </summary>
        /// <param name="email">The email to enter.</param>
        public void EnterEmail(string email)
        {
            driver.FindElement(emailInputBoxLocator).SendKeys(email);
        }

        /// <summary>
        /// Retrieves the text entered in the email input box.
        /// </summary>
        /// <returns>The text entered in the email input box.</returns>
        public string GetInputEmail()
        {
            return driver.FindElement(emailInputBoxLocator).GetAttribute("value");
        }

        /// <summary>
        /// Retrieves the text of the label associated with the email input box.
        /// </summary>
        /// <returns>The text of the label associated with the email input box.</returns>
        public string GetLabel()
        {
            return driver.FindElement(inputLabelLocator).Text;
        }

        /// <summary>
        /// Retrieves the text of the title element of the page.
        /// </summary>
        /// <returns>The text of the title element of the page.</returns>
        public string GetTitle()
        {
            return driver.FindElement(titleLocator).Text;
        }
    }

}
