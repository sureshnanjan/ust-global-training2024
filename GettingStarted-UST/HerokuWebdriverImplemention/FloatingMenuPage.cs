using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;
using OpenQA.Selenium;

namespace HerokuWebdriverImplemention
{
    internal class FloatingMenuPage : HerokuApp, IFloatingMenuPage
    {
        /// <summary>
        /// Properties
        /// </summary>
        private By heading;
        private By nthParagraph;
        private By pageUrl;
        /// <summary>
        /// Floating Menu  page construction webelements
        /// </summary>
        /// <param name="driver"></param>
        public FloatingMenuPage(IWebDriver driver) : base(driver)
        {
            this.heading = By.XPath("//h3[normalize-space()='Floating Menu']");
           // this.nthParagraph = By.XPath("div.jscroll-added:nth-of-type({n})");
            this.pageUrl = By.XPath("//*[@id=\"content\"]/ul/li[19]/a");

        }
        public string getURL()
        {
            return driver.FindElement(pageUrl).Text;
        }
        public string getHeading()
        {
            driver.FindElement(pageUrl).Click();
            return driver.FindElement(heading).Text;
        }

        public string getTitle()
        {
            return driver.FindElement(heading).Text;

        }
        public List<string> getAllMenuOptions()
        {
            throw new NotImplementedException();
        }

        public int getMenuOptionCount()
        {
            throw new NotImplementedException();
        }


        public void clickOnSpecificMenu(string menu)
        {
            throw new NotImplementedException();
        }

       
       

        public bool getMenuItemVisibilityStatus(string item = "All")
        {
            throw new NotImplementedException();
        }

       
       

        

        public void performNScroll(int n)
        {
            throw new NotImplementedException();
        }
    }
}