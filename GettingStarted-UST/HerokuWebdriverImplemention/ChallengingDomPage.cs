using System;
using System.Collections.Generic;
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
    /// Class to hold the ChallengingDom page Properities and Methods
    /// </summary>
    public class ChallengingDomPage: HerokuApp, IChallengingDomOperations
    {
        /// <summary>
        /// Properties of Challenging Dom
        /// </summary>
        private By pageLink;
        private readonly By headingLocator;
        private readonly By contentLocator;
        private readonly By button1Locator;
        private readonly By button2Locator;
        private readonly By button3Locator;
        private readonly By tableheadingLocator;
        private readonly By tablerow1Locator;
        private readonly By resultLocator;

        /// <summary>
        /// Load all the webElements through Constructor
        /// </summary>
        public ChallengingDomPage(IWebDriver driver) : base(driver)
        {
            this.headingLocator = By.TagName("h3");
            this.contentLocator = By.XPath("//*[@id=\"content\"]/div/p");
            this.button1Locator = By.XPath("/html/body/div[2]/div/div/div/div/div[1]/a[1]");
            this.button2Locator = By.XPath("/html/body/div[2]/div/div/div/div/div[1]/a[2]");
            this.button3Locator = By.XPath("/html/body/div[2]/div/div/div/div/div[1]/a[3]");
            this.tableheadingLocator = By.XPath("//*[@id=\"content\"]/div/div/div/div[2]/table/thead/tr/th");
            this.tablerow1Locator = By.XPath("//*[@id=\"content\"]/div/div/div/div[2]/table/tbody/tr[1]");
            this.resultLocator = By.XPath("//*[@id=\"content\"]/div/div/div/div[2]/div/div");
            this.pageLink = By.XPath("//*[@id=\"content\"]/ul/li[5]/a");
            openPage();

        }

        /// <summary>
        /// Opens the ChallengingDom Page 
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

        public void deleteRow(int rownum)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Clicks Button 1 on the Page
        /// </summary>
        public void doOperation1()
        {
            driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div/div[1]/a[1]")).Click();
        }

        /// <summary>
        /// Clicks Button 2 on the Page
        /// </summary>
        public void doOperation2()
        {
            driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div/div[1]/a[2]")).Click();
        }

        /// <summary>
        /// Clicks Button 3 on the Page
        /// </summary>
        public void doOperation3()
        {
            driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div/div[1]/a[3]")).Click();
        }

        public void editRow(int rownum)
        {
            throw new NotImplementedException();
        }

        public string getContext()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get the Main Content of the Page
        /// </summary>
        public string getMainContent()
        {
            return (this.driver.FindElement(this.contentLocator)).Text;
            Thread.Sleep(5000);
        }

        /// <summary>
        /// Get the button 1 label on the Page
        /// </summary>
        public string getOperation1Label()
        {
            return (this.driver.FindElement(this.button1Locator)).Text;
            Thread.Sleep(5000);
        }

        /// <summary>
        /// Get the button 3 label on the Page
        /// </summary>
        public string getOperation2Label()
        {
            return (this.driver.FindElement(this.button2Locator)).Text;
            Thread.Sleep(5000);
        }


        /// <summary>
        /// Get the button 3 label on the Page
        /// </summary>
        public string getOperation3Label()
        {
            return (this.driver.FindElement(this.button3Locator)).Text;
            Thread.Sleep(5000);
        }

        /// <summary>
        /// Get the Result of the Page
        /// </summary>
        /// <returns>String Result</returns>
        public string getResult()
        {
            return (this.driver.FindElement(this.resultLocator)).Text;
            Thread.Sleep(5000);
        }


        /// <summary>
        /// Get the Rowdata of the Page
        /// </summary>
        /// <returns>String Rowdata</returns>
        public string[] getRowData()
        {
            List<string> row1data = new List<string> { };
            foreach (var item in this.driver.FindElements(tablerow1Locator))
            {
                row1data.Add(item.Text);

            }
            return row1data.ToArray();
        }


        /// <summary>
        /// Get the TableHeadings of the Page
        /// </summary>
        /// <returns>String Table Headings</returns>
        public string[] getTableHeadings()
        {
            List<string> headings = new List<string> { };
            foreach (var item in this.driver.FindElements(tableheadingLocator))
            {
                headings.Add(item.Text);

            }

            return headings.ToArray();
        }

        /// <summary>
        /// Get the Title of the Page
        /// </summary>
        /// <returns>String Title</returns>
        public string getTitle()
        {
            return (this.driver.FindElement(this.headingLocator)).Text;
            Thread.Sleep(5000);
        }

        public string getURL()
        {
            throw new NotImplementedException();
        }
    }
}
