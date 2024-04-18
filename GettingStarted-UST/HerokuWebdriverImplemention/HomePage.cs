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
    public class HomePage : HerokuApp, IHomePage
    {
        private IWebDriver browser;
        private By headingLocator;
        private By subHeadingLocator;
        private By exapleLocator;
        public HomePage():base() {
            
            this.headingLocator = By.TagName("h1");
            this.subHeadingLocator = By.TagName("h2");
            this.exapleLocator = By.XPath("//*[@id=\"content\"]/ul/li[2]/a");
        }
        public string[] getAvailableExamples()
        {
            // TO DO: Extract the Links Text and send the result
            this.browser.FindElements(exapleLocator);
            return new string[] { "" };
        }

        public bool GetStatus(string locator)
        {

            throw new NotImplementedException();

            //throw new NotImplementedException();
            return true;

        }

        public string getSubTitle()
        {
            return this.browser.Title;
        }

        public string getTitle()
        {
            return browser.Title;
        }

       IHerokuAppOperations IHomePage.goToExample(string exampleName)
        {
            // assignment " Implement this Using  ENUM ExampleNames
            switch (exampleName)
            {
                case "AddRemove":
                    return new AddRemovePage();
                case "A/B Testing":
                    return new HerokuApp();
                default:
                    return new HerokuApp();

            }
        }
    }
}
