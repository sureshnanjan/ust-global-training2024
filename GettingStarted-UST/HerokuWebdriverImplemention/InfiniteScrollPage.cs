using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;
using HerokuWebdriverImplemention;
using OpenQA.Selenium;

namespace HerokuWebdriverImplemention
{
    /// <summary>
    /// Class to hold the properties and Methods of Infinite Scroll Page
    /// </summary>
    
    public class InfiniteScrollPage : HerokuApp, IInfiniteScrollPage
    {
        /// <summary>
        /// Properties
        /// </summary>
        private By heading;
        private By nthParagraph;
        private By pageUrl;
       // int n;



        /// <summary>
        /// Infinite Scroll  page construction webelements
        /// </summary>
        /// <param name="driver"></param>
        public InfiniteScrollPage(IWebDriver driver) : base(driver)
        {
            this.heading = By.XPath("//h3[normalize-space()='Infinite Scroll']");
            this.nthParagraph = By.XPath("div.jscroll-added:nth-of-type({n})");
            this.pageUrl = By.XPath("//*[@id=\"content\"]/ul/li[26]/a");

        }

        string IInfiniteScrollPage.getURL()
        {
            return driver.FindElement(pageUrl).Text;

        }
        string IInfiniteScrollPage.getHeading()
        {
            driver.FindElement(pageUrl).Click();
            return driver.FindElement(heading).Text;
        }



        string IInfiniteScrollPage.getTitle()
        {
            return driver.FindElement(heading).Text;
        }
        void IInfiniteScrollPage.performNScroll(int n)
        {
            for (int i = 0; i < n; i++)
            {
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("window.scrollTo(0,document.body.scrollHeight);");
                Thread.Sleep(2000);

            }

        }

        string IInfiniteScrollPage.getNthParagraph(int n)

        {
            return driver.FindElement(nthParagraph).Text;

        }
    }
}



