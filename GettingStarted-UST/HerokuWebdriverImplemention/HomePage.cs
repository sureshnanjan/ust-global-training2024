using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HerokuWebdriverImplemention
{
    /// <summary>
    /// Implementation of Home page Interface
    /// </summary>
    public class HomePage : IHomePage
    {

        private string herokuUrl;
        private IWebDriver browser;
        private By headingLocator;
        private By subHeadingLocator;
        private By exapleLocator;
        private By repositoryLocator;
        private By footerLocator;

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

        /// <summary>
        /// Fetches all the available links in HomePage
        /// </summary>
        /// <returns>List of available examples</returns>
        /// <exception cref="NotImplementedException"></exception>
        public string[] GetAvailableExamples()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Fetches Sub Title of HomePage
        /// </summary>
        /// <returns>Sub Title in string format</returns>
        /// <exception cref="NotImplementedException"></exception>
        public string GetSubTitle()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Fetches Title of HomePage
        /// </summary>
        /// <returns>Title of page</returns>
        /// <exception cref="NotImplementedException"></exception>
        public string GetTitle()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Redirects to other pages
        /// </summary>
        /// <param name="exampleName">Link to which it needs to be redirected</param>
        /// <exception cref="NotImplementedException"></exception>
        public void GoToExample(string exampleName)
        {
            throw new NotImplementedException();
        }
    }
}
