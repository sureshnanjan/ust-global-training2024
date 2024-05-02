using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;

namespace HerokuWebdriverImplemention
{
    public class BasicAuthPage : HerokuApp, IBasicAuthOperations
    {
        private readonly By headingLocator;
        private readonly By statusMessageLocator;

        public BasicAuthPage()
        {
            this.headingLocator = By.TagName("h3");
            this.statusMessageLocator = By.XPath("//*[@id='content']/div/p");
        }
        public void Authenticate(string uname, string pwd)
        {
            // NO direct support for basic auth HTTP
            string authUrl = $"https://{uname}:{pwd}@the-internet.herokuapp.com/basic_auth";
            this.driver.Navigate().GoToUrl(authUrl);
            // JS Executor
            // this.driver.ExecuteJavaScript(); This si a CATCH all workaround
        }

        public string getHeading()
        {
            return this.driver.FindElement(this.headingLocator).Text;
        }

        public string getStatusMessage()
        {
            return this.driver.FindElement(this.statusMessageLocator).Text;
        }
    }
}
