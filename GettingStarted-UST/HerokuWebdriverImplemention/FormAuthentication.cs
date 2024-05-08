using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;
using OpenQA.Selenium;

namespace HerokuWebdriverImplemention
{
    internal class FormAuthentication : HerokuApp, IFormAuthenticationOperation
    {
        private By locatorTitle;
        private By messageLocator;
        private By usernameLocator;
        private By passwordLocator;
        private By loginButtonLocator;
        private By logoutButtonLocator;
        public FormAuthentication()
        {
            locatorTitle = By.XPath("//*[@id=\"content\"]/div/h2");
            messageLocator = By.Id("flash");
            usernameLocator = By.Id("username");
            passwordLocator = By.Id("password");
            loginButtonLocator = By.XPath("//*[@id=\"login\"]/button");
            logoutButtonLocator = By.XPath("//*[@id=\"content\"]/div/a");


    }

    public string getLoginFail()
        {
            return driver.FindElement(messageLocator).Text;
        }

        public string getLogoutMessage()
        {
            return driver.FindElement(messageLocator).Text;
        }

        public string getSuccessMessage()
        {
            return driver.FindElement(messageLocator).Text;
        }

        public string getTitle()
        {
            return driver.FindElement(locatorTitle).Text;
        }

        public bool Login(string uName, string Password)
        {
            driver.FindElement(usernameLocator).SendKeys(uName);
            driver.FindElement(passwordLocator).SendKeys(Password);
            driver.FindElement(loginButtonLocator).Click();
            return true;
        }

        public void logout()
        {
            driver.FindElement(logoutButtonLocator).Click();
        }
    }
}
