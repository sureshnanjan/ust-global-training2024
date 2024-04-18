using HerokuAppOperations;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V121.Debugger;
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

        private ITakesScreenshot browser;

        public void CloseBrowser()
        {
            throw new NotImplementedException();
        }


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

        public string GetFooterDetails()
        {
            throw new NotImplementedException();
        }

        public string getFooterDetails()
        {
            return this.driver.FindElement(footerLocator).Text;
        }

        public string GetRepoDetails()
        {
            throw new NotImplementedException();
        }

        public string getRepoDetails()
        {
            return this.driver.FindElement(repoLocator).Text;
        }

        public bool GetStatus(string locator)
        {
            throw new NotImplementedException();
        }

        public bool GetStatus()
        {
            // Take screen shopt as part of this operation
            //throw new NotImplementedException();
            ITakesScreenshot mycamera = (ITakesScreenshot) this.browser;
            mycamera.GetScreenshot();
            return true;
            
        }

        public string getStatus(string locator)
        {
            throw new NotImplementedException();
        }

        public void GoToHome()
        {
            throw new NotImplementedException();
        }

        public void goToHome()
        {
            //this.driver.Url = this.appUrl;
            this.driver.Navigate().GoToUrl(this.appUrl);
        }

        string IHerokuAppOperations.GetStatus(string locator)
        {
            throw new NotImplementedException();
        }
    }
}
