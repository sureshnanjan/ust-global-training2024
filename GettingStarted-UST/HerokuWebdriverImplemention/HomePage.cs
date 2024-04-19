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

namespace HerokuWebdriverImplemention
{
    {

        private string herokuUrl;
        private IWebDriver browser;
        private By headingLocator;
        private By subHeadingLocator;
        private By exapleLocator;
            
        /// <summary>
        /// Constructor to take elements to variables
        /// </summary>
        public HomePage()
        {
            this.herokuUrl = "https://the-internet.herokuapp.com/";
            this.browser = new ChromeDriver();
            this.headingLocator = By.TagName("h1");
            this.subHeadingLocator = By.TagName("h2");
            this.exapleLocator = By.XPath("//*[@id=\"content\"]/ul/li[2]/a");
            this.browser.Url = this.herokuUrl;
        }
        public string[] getAvailableExamples()
        {
            // TO DO: Extract the Links Text and send the result
            this.browser.FindElements(exapleLocator);
            return new string[] { "" };
        }

        {

            throw new NotImplementedException();

            //throw new NotImplementedException();
            return true;

        }

        {
        }

        {
        }

            {
        }
    }
}
