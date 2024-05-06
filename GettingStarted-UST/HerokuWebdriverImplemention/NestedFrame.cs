using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;
using OpenQA.Selenium;

namespace HerokuWebdriverImplemention
{
    public class NestedFrame : HerokuApp, INestedFrame
    {

        private readonly By contentLocator;

        public NestedFrame()
        {
            this.contentLocator = By.TagName("p");
        }

        public string getNestedFrameContent()
        {
            return this.driver.FindElement(this.contentLocator).Text;
        }
        public void pageUrl()
        {
            string pageUrl = "https://the-internet.herokuapp.com/nested_frames";
            this.driver.Navigate().GoToUrl(pageUrl);
        }
    }
}
