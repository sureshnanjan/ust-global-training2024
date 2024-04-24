using HerokuAppOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Utilities;

namespace HerokuWebdriverImplemention
{
    public class HerokuApp : IHerokuAppOperations
    {
        protected readonly IWebDriver driver;
        private readonly By footerLocator;
        private readonly By repoLocator;
        private string appUrl;

        public HerokuApp(IWebDriver argDriver)
        {
            if (this.driver == default)
            {
                this.driver = argDriver;

            }

            this.appUrl = AppUtil.getAppUrl();
            this.footerLocator = By.XPath("");
            this.repoLocator = By.XPath("");

        }

        public HerokuApp() {
            this.appUrl = AppUtil.getAppUrl();
            this.driver = WebdriverFactory.getBrowser();
            //To Navigate to Links
            goToHome();
        }
        public void closeBrowser()
        {
           this.driver.Quit();
        }

        public void CloseBrowser()
        {
            throw new NotImplementedException();
        }

        public string getFooterDetails()
        {
            return this.driver.FindElement(footerLocator).Text;
        }

        public string GetFooterDetails()
        {
            throw new NotImplementedException();
        }

        public string getRepoDetails()
        {
            return this.driver.FindElement(repoLocator).Text;
        }

        public string GetRepoDetails()
        {
            throw new NotImplementedException();
        }

        public string GetStatus(string locator)
        {
            throw new NotImplementedException();
        }

        public string getStatus(string locator)
        {
            throw new NotImplementedException();
        }

        public bool GetStatus()
        {
            throw new NotImplementedException();
        }

        public void goToHome()
        {
            //this.driver.Url = this.appUrl;
            this.driver.Navigate().GoToUrl(this.appUrl);

            /// <summary>
            /// Click the Slow Resources Link on https://the-internet.herokuapp.com/
            /// </summary>

            //driver.FindElement(By.XPath("//*[@id=\"content\"]/ul/li[40]/a")).Click();

            /// <summary>
            /// Click the Challenging Dom Link on https://the-internet.herokuapp.com/
            /// </summary>
            driver.FindElement(By.XPath("//*[@id=\"content\"]/ul/li[5]/a")).Click();
        }

        public void GoToHome()
        {
            throw new NotImplementedException();
        }
    }
}
