using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;
using OpenQA.Selenium;

namespace HerokuWebdriverImplemention
{
    public class DigestAuthenticationPage : HerokuApp, IDigestAuthentication
    {

        private By heading;
        private By pageLink;
        private By userNameLocator;
        private By passwordLocator;
        private By signInButtonLocator;
        public IWebElement userNameElement;
        private By successMessage;



        public DigestAuthenticationPage()
        {
            this.heading = By.TagName("h3");
            this.pageLink = By.XPath("//*[@id=\"content\"]/ul/li/a[text()='Digest Authentication']");
            this.userNameLocator = By.Id("username");
            this.passwordLocator = By.Id("password");
            this.signInButtonLocator = By.Name("Login");
            this.successMessage = By.XPath("//*[@id=\"content\"]/div/p");
            openDigestAuthenticationPage();
        }

        public void  openDigestAuthenticationPage() {

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            driver.FindElement(pageLink).Click();
            driver.Manage().Window.Maximize();
        }

        public void DoSignIn(string userName, string password, bool doCancel = false)
        {
            
            IWebElement userNameElement = driver.FindElement(userNameLocator);
            userNameElement.SendKeys(userName);
            IWebElement passwordElement = driver.FindElement(passwordLocator);
            userNameElement.SendKeys(password);
            driver.FindElement(signInButtonLocator).Click();
        }

        public string GetSignInStatus()
        {
           return driver.FindElement(successMessage).Text;
        }

        public string GetTitle()
        {
            return driver.Title;
        }
    }
}
