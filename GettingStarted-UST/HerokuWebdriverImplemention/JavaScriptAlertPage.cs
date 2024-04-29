using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;
using OpenQA.Selenium;

namespace HerokuWebdriverImplemention
{
    /// <summary>
    /// Class to hold the properties and Methods of Java Script Alert Page
    /// </summary>
    public class JavaScriptAlertPage : HerokuApp,IJavascriptAlert
    {
        /// <summary>
        /// Properties
        /// </summary>
        private By heading;
        private By JSAlertBtn;
        private By JSConfirmBtn;
        private By JSPrmptBtn;
        private By resultMessage;
        private By pageLink;

        /// <summary>
        /// JavaScript Alert page construction webelements
        /// </summary>
        /// <param name="driver"></param>
        public JavaScriptAlertPage(IWebDriver driver): base(driver)
        {
            this.heading = By.TagName("h3");
            this.JSAlertBtn = By.XPath("//*[@id=\"content\"]/div/ul/li[1]/button");
            this.JSConfirmBtn = By.XPath("//*[@id=\"content\"]/div/ul/li[2]/button");
            this.JSPrmptBtn = By.XPath("//*[@id=\"content\"]/div/ul/li[3]/button");
            this.resultMessage = By.XPath("//*[@id=\"result\"]");
            this.pageLink = By.XPath("//*[@id=\"content\"]/ul/li[29]/a");
            openPage();
           
        }

        /// <summary>
        /// Opens the Exit Intent Page 
        /// </summary>
        private void openPage()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            driver.FindElement(pageLink).Click();
        }

        /// <summary>
        /// Accepts the Java Script Alert
        /// </summary>
        public void ClickAndAcceptJSAlert()
        {
            driver.FindElement(JSAlertBtn).Click();
            driver.SwitchTo().Alert().Accept();
        }
        /// <summary>
        /// Accepts the Java Script Alert
        /// </summary>
        public void ClickAndAcceptJSConfirm()
        {
            driver.FindElement(JSConfirmBtn).Click();
            driver.SwitchTo().Alert().Accept();
        }

        /// <summary>
        /// Cancels the Java Script Alert
        /// </summary>
        public void ClickAndCancelJSConfirm()
        {
            driver.FindElement(JSConfirmBtn).Click();
            driver.SwitchTo().Alert().Dismiss();
        }

        /// <summary>
        /// Opens the Java Script prompt
        /// </summary>
        /// <param name="prompt"></param>
        public void ClickJSPromt(string prompt)
        {
            driver.FindElement(JSPrmptBtn).Click();
            driver.SwitchTo().Alert().SendKeys(prompt);
            driver.SwitchTo().Alert().Accept();
        }

        /// <summary>
        /// Get the result 
        /// </summary>
        /// <returns>string message</returns>
        public string getResult()
        {
            return driver.FindElement(resultMessage).Text;
        }


        /// <summary>
        /// Get the Title of the Page
        /// </summary>
        /// <returns>String Title</returns>
        public string GetTitle()
        {
            return  driver.FindElement(heading).Text;
        }
    }
}
