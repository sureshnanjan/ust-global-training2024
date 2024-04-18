using HerokuAppOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HerokuWebdriverImplemention
{
    public class HerokuApp : IHerokuAppOperations
    {
        private readonly IWebDriver driver;
        private readonly By footerLocator;
        private readonly By repoLocator;
        private string appUrl;

        public HerokuApp()
        {
            this.footerLocator = By.XPath("");
            this.repoLocator = By.XPath("");
            this.appUrl = "https://the-internet.herokuapp.com/";
        }
        public void closeBrowser()
        {
           this.driver.Quit();
        }

        public string getFooterDetails()
        {
            return this.driver.FindElement(footerLocator).Text;
        }

        public string getRepoDetails()
        {
            return this.driver.FindElement(repoLocator).Text;
        }

        public void goToHome()
        {
            //this.driver.Url = this.appUrl;
            this.driver.Navigate().GoToUrl(this.appUrl);
        }
    }
}
