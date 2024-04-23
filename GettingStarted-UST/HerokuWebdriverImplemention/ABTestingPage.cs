using HerokuAppOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace HerokuWebdriverImplemention
{
    public class ABTestingPage : HerokuApp, IABTestControl
    {
        private readonly By headinglocator;
        private readonly By contentLocator;
        

        public ABTestingPage()
        {
            this.headinglocator = By.Id("");
            this.contentLocator = By.TagName("p");
        }
        public void disableABTesting()
        {
            OpenQA.Selenium.Cookie optout = new OpenQA.Selenium.Cookie("optimizelyOptOut", "true");
            //Cookie optout = new Cookie("optimizelyOptOut", "true");
            this.driver.Manage().Cookies.AddCookie(optout);
        }

        public string getMainContent()
        {
            return this.driver.FindElement(this.contentLocator).Text;
        }

        public string getTitle()
        {
            return this.driver.FindElement(this.headinglocator).Text;
           
        }
    }
}
