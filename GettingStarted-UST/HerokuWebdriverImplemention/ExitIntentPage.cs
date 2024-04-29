using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;


namespace HerokuWebdriverImplemention
{
    /// <summary>
    /// Class to hold the Exit Intent page Properities and Methods
    /// </summary>
    public class ExitIntentPage : HerokuApp, IExitIntent
    {
        /// <summary>
        /// Properties of Exit Intent
        /// </summary>
        private By heading;
        private By windowTitle;
        private By windowClose;
        private By pageLink;

        /// <summary>
        /// Load all the webElements through Constructor
        /// </summary>
        public ExitIntentPage(IWebDriver driver) : base(driver)
        { 
            this.heading = By.TagName("h3");
            this.windowTitle = By.XPath("//*[@id=\"ouibounce-modal\"]/div[2]/div[1]/h3");
            this.windowClose = By.XPath("//p[text()='Close']");
            this.pageLink = By.XPath("//*[@id=\"content\"]/ul/li[16]/a");
            openPage();
        }

        /// <summary>
        /// Open the page for Exit intent 
        /// </summary>
        private void openPage()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            driver.FindElement(pageLink).Click();
        }

        /// <summary>
        /// Close the Modal window
        /// </summary>
        public void closeModalWindow()
        {
            Thread.Sleep(3000);
            driver.FindElement(windowClose).Click();
            Thread.Sleep(3000);
        }

        /// <summary>
        /// Get the status of Modal Window 
        /// </summary>
        /// <returns>Boolean true or False</returns>
        public bool getModalWindowStatus()
        {           
            return driver.FindElement(windowTitle).Enabled;
        }

        /// <summary>
        /// Get the title of Modal Window
        /// </summary>
        /// <returns>String title </returns>
        public string getModalWIndowTitle()
        {
            return driver.FindElement(windowTitle).Text;
        }

        /// <summary>
        /// Get the title of page
        /// </summary>
        /// <returns>String Title</returns>
        public string GetTitle()
        {
            return driver.FindElement(heading).Text;
        }

        /// <summary>
        /// move the mouse out of view 
        /// </summary>
        public void moustOutOfView()
        {
            driver.Manage().Window.Maximize();
            String pos = driver.Manage().Window.Position.ToString();
            string size = driver.Manage().Window.Size.ToString();
            Console.WriteLine($"Position : {pos} Size : {size}");

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("var event = new MouseEvent('mouseleave', {view: window, bubbles: true, cancelable: true}); document.body.dispatchEvent(event);");

            /*
            IWebElement e = driver.FindElement(By.TagName("h3"));
            Actions action = new Actions(driver);
            action.MoveToElement(e).MoveByOffset(600, -1).Build().Perform();
            
            Actions action = new Actions(driver);
            action.MoveByOffset(600, -1).Build().Perform();
            // action.MoveByOffset(100, 100).Build().Perform();
            Thread.Sleep(5000);
            //action.MoveByOffset(200, -6).Build().Perform();
            */
            Console.WriteLine("Mouse Pointer moved");
            //action.MoveToElement(driver.FindElement(heading),50,100).ContextClick().Build().Perform();

        }
    }
}
