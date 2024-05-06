using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;
using OpenQA.Selenium;

namespace HerokuWebdriverImplemention
{
    public class DynamicContentPage : HerokuApp, IDynamicContent
    {
        private By pageLink;
        private By pageContent;
        private By clickHere;
        private By heading;
        
        public DynamicContentPage(IWebDriver driver)
        {
            this.heading = By.TagName("h3");
            this.pageLink = By.XPath("//*[@id=\"content\"]/ul/li/a[text()='Dynamic Content']");
            this.pageContent = By.TagName("html");
            this.clickHere = By.XPath("//*[@id=\"content\"]/div/p/a[text()='text()='click here'']");
  
        }
        public string getPageTitle()
        {
            driver.FindElement(pageLink).Click();
            string pageTitle= driver.FindElement(heading).Text;
            return pageTitle;
        }


        public string getMainContent()
        {
            //IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            //string script= "return document.get"
            return driver.FindElement(pageContent).Text;

        }
        public void clickHereButton()
        {
            driver.FindElement(clickHere).Click();
        }

        public string getDynamicPageContent()
        {
           return driver.FindElement(pageContent).Text;

        }

    
        public string verifyLink()
        {
            throw new NotImplementedException();
        }
    }
}
