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
    public class ChallengingDomPage: HerokuApp, IChallengingDomOperations
    {
        private readonly By headingLocator;
        private readonly By contentLocator;
        private readonly By button1Locator;
        private readonly By button2Locator;
        private readonly By button3Locator;
        private readonly By tableheadingLocator;
        private readonly By tablerow1Locator;
        private readonly By resultLocator;

        public ChallengingDomPage()
        {
            this.headingLocator = By.TagName("h3");
            this.contentLocator = By.XPath("//*[@id=\"content\"]/div/p");
            this.button1Locator = By.XPath("/html/body/div[2]/div/div/div/div/div[1]/a[1]");
            this.button2Locator = By.XPath("/html/body/div[2]/div/div/div/div/div[1]/a[2]");
            this.button3Locator = By.XPath("/html/body/div[2]/div/div/div/div/div[1]/a[3]");
            this.tableheadingLocator = By.XPath("//*[@id=\"content\"]/div/div/div/div[2]/table/thead/tr/th");
            this.tablerow1Locator = By.XPath("//*[@id=\"content\"]/div/div/div/div[2]/table/tbody/tr[1]");
            this.resultLocator = By.XPath("//*[@id=\"content\"]/div/div/div/div[2]/div/div");
        }

        public void closeBrowser()
        {
            this.driver.Quit();
        }

        public void deleteRow(int rownum)
        {
            throw new NotImplementedException();
        }

        public void doOperation1()
        {
            driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div/div[1]/a[1]")).Click();
        }

        public void doOperation2()
        {
            driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div/div[1]/a[2]")).Click();
        }

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

        public string getMainContent()
        {
            return (this.driver.FindElement(this.contentLocator)).Text;
            Thread.Sleep(5000);
        }

        public string getOperation1Label()
        {
            return (this.driver.FindElement(this.button1Locator)).Text;
            Thread.Sleep(5000);
        }

        public string getOperation2Label()
        {
            return (this.driver.FindElement(this.button2Locator)).Text;
            Thread.Sleep(5000);
        }

        public string getOperation3Label()
        {
            return (this.driver.FindElement(this.button3Locator)).Text;
            Thread.Sleep(5000);
        }

        public string getResult()
        {
            return (this.driver.FindElement(this.resultLocator)).Text;
            Thread.Sleep(5000);
        }

        public string[] getRowData()
        {
            List<string> row1data = new List<string> { };
            foreach (var item in this.driver.FindElements(tablerow1Locator))
            {
                row1data.Add(item.Text);

            }
            return row1data.ToArray();
        }

        public string[] getTableHeadings()
        {
            List<string> headings = new List<string> { };
            foreach (var item in this.driver.FindElements(tableheadingLocator))
            {
                headings.Add(item.Text);

            }

            return headings.ToArray();
        }

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
