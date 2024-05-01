using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;
using OpenQA.Selenium;

namespace HerokuWebdriverImplemention
{
    internal class EntryAdPage : HerokuApp, IEntryAd
    {
        private By titleLocator;
        private By contentLocator;
        private By clickHereLocator;

        public EntryAdPage()
        {
            titleLocator = By.XPath("//div[@class='example']//h3");
            contentLocator = By.ClassName("example");
            clickHereLocator =By.Id("restart-ad");
        }

        public void clickHere()
        {
            driver.FindElement(clickHereLocator).Click();
        }

        public string getPagecontentIentryAd()
        {
            return driver.FindElement(contentLocator).Text;
        }

        public string getTitle()
        {
            return driver.FindElement(titleLocator).Text;
        }
    }
}
