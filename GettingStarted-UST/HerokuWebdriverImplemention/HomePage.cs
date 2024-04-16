using HerokuAppOperations;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V121.Debugger;
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
    public class HomePage : IHomePage
    {
        private string herokuUrl; 
        private IWebDriver browser;
        private By headingLocator;
        private By subHeadingLocator;
        private By exapleLocator;
        private By repositoryLocator;
        private By footerLocator;
        public HomePage() {
            this.herokuUrl = "https://the-internet.herokuapp.com/";
            this.browser = new ChromeDriver();
            this.headingLocator = By.TagName("h1");
            this.subHeadingLocator = By.TagName("h2");
            this.exapleLocator = By.XPath("//*[@id=\"content\"]/ul/li[2]/a");
            // #content > h1
            // JSPath document.querySelector("#content > h1")
            // XPath //*[@id="content"]/h1
            // /html/body/div[2]/div/h1
            // By.TagName("h1")
            // RelativeB
            //  /html/body/div[2]/div/h1
            // RelativeBy mylocaTrategy = RelativeBy.WithLocator(headingLocator);
            this.browser.Url = this.herokuUrl;
        }
        public string[] getAvailableExamples()
        {
            throw new NotImplementedException();
        }

        public bool getStatus(string locator)
        {
            throw new NotImplementedException();
        }

        public string getSubTitle()
        {
            return browser.FindElement(subHeadingLocator).Text;
        }

        public string getTitle()
        {
            return browser.FindElement(headingLocator).Text;
        }

        public void goToExample(string exampleName)
        {
            throw new NotImplementedException();
        }
    }
}
