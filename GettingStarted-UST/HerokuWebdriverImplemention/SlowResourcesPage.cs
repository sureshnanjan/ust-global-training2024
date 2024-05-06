using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Safari;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static OpenQA.Selenium.PrintOptions;
using static System.Net.Mime.MediaTypeNames;
using Utilities;

namespace HerokuWebdriverImplemention
{
    /// <summary>
    /// Class to hold the Slow Resources page Properities and Methods
    /// </summary>
    public class SlowResourcesPage : HerokuApp, ISlowResourcePage
    {
        /// <summary>
        /// Properties of Slow Resources
        /// </summary>
        private By headingLocator;
        private By pageLink;

        /// <summary>
        /// Load all the webElements through Constructor
        /// </summary>
        public SlowResourcesPage(IWebDriver driver) : base(driver)
        {
            this.headingLocator = By.XPath("//*[@id=\"content\"]/div/h3");
            this.pageLink = By.XPath("//*[@id=\"content\"]/ul/li[40]/a");
            openPage();
        }

        /// <summary>
        /// Opens the Slow Resources Page 
        /// </summary>
        private void openPage()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            driver.FindElement(pageLink).Click();
        }

        public void closeBrowser()
        {
            this.driver.Quit();
        }
        public string getContext()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get the title of page
        /// </summary>
        /// <returns>String Title</returns>
        public string getTitle()
        {
            return (this.driver.FindElement(this.headingLocator)).Text;
            Thread.Sleep(5000);
        }
    }
}
