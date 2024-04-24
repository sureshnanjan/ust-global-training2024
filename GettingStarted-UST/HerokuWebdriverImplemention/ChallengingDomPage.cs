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

        public ChallengingDomPage()
        {
            this.headingLocator = By.XPath("//*[@id=\"content\"]/div/h3");
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
            throw new NotImplementedException();
        }

        public void doOperation2()
        {
            throw new NotImplementedException();
        }

        public void doOperation3()
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public string getOperation1Label()
        {
            throw new NotImplementedException();
        }

        public string getOperation2Label()
        {
            throw new NotImplementedException();
        }

        public string getOperation3Label()
        {
            throw new NotImplementedException();
        }

        public string getResult()
        {
            throw new NotImplementedException();
        }

        public string[] getRowData(int rownum)
        {
            throw new NotImplementedException();
        }

        public string[] getTableHeadings()
        {
            throw new NotImplementedException();
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
