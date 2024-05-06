using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;
using OpenQA.Selenium;

namespace HerokuWebdriverImplemention
{
    public class MultipleWindowsPage : HerokuApp, IMultipleWindows
    {

        private By pageLink;
        private By URL;
        private By childLink;
        private By heading;
        private By clickHereHyperlink;
        public MultipleWindowsPage() 
        { 
          this.pageLink= By.XPath("//*[@id=\"content\"]/ul/li/a[text()='Multiple Windows']");
          this.heading= By.TagName("html");
          this.clickHereHyperlink = By.XPath("//*[@id=\"content\"]/div/a");

        }
        public string getTitle()
        {
            driver.FindElement(pageLink).Click();
            string pageTitle = driver.FindElement(heading).Text;
            return pageTitle;
        }

        public string getParenttURL()
        {
            string parentURL=driver.Url;
            return parentURL;
        }

        public void clickOnHyperlink()
        {
            driver.FindElement(clickHereHyperlink).Click();
        }

        public void verifyNewWindow()
        {
            driver.SwitchTo().Window(driver.WindowHandles.Last());

        }
    }
}
