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
    /// Represents the Entry Ad page of the HerokuApp.
    /// </summary>
    internal class EntryAdPage : HerokuApp, IEntryAd
    {
        private By titleLocator;
        private By contentLocator;
        private By clickHereLocator;

        /// <summary>
        /// Initializes a new instance of the EnteryAdPage class.
        /// </summary>
        public EntryAdPage()
        {
            titleLocator = By.XPath("//div[@class='example']//h3");
            contentLocator = By.ClassName("example");
            clickHereLocator = By.Id("restart-ad");
        }

        /// <summary>
        /// Clicks the "click here" link to restart the ad.
        /// </summary>
        public void clickHere()
        {
            driver.FindElement(clickHereLocator).Click();
        }

        /// <summary>
        /// Gets the content of the Entry Ad page.
        /// </summary>
        /// <returns>The content of the Entry Ad page.</returns>
        public string getPagecontentIentryAd()
        {
            return driver.FindElement(contentLocator).Text;
        }

        /// <summary>
        /// Gets the title of the Entry Ad.
        /// </summary>
        /// <returns>The title of the Entry Ad.</returns>
        public string getTitle()
        {
            return driver.FindElement(titleLocator).Text;
        }
    }

}
}
