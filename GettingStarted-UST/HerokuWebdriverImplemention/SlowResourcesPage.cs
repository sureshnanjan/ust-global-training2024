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
    public class SlowResourcesPage : HerokuApp, ISlowResourcePage
    {
        private readonly By headingLocator;

        public SlowResourcesPage()
        {
            this.headingLocator = By.XPath("//*[@id=\"content\"]/div/h3");
        }  

        public void closeBrowser()
        {
            this.driver.Quit();
        }
        public string getContext()
        {
            throw new NotImplementedException();
        }

        public string getTitle()
        {
            return (this.driver.FindElement(this.headingLocator)).Text;
            Thread.Sleep(5000);
        }
    }
}
