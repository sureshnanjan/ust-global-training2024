using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;
using OpenQA.Selenium;

namespace HerokuWebdriverImplemention
{
    public class keypressespage : HerokuApp, IKeyPresses
    {
        private readonly By KeypressPageLink;
        private readonly By pageTitleLocator;
        private readonly By pageContentLocator;
        private readonly By editBox;
        private readonly By enteredOutcome;

        public keypressespage(IWebDriver driver) : base(driver)
        {
            this.pageContentLocator = By.XPath("//p[1]");
            this.pageTitleLocator=By.XPath("//*[@id=\"content\"]/div/h3");
            this.editBox = By.XPath("//input[@id=\"target\"]");
            this.enteredOutcome = By.XPath("//p[@id=\"result\"]");
            this.KeypressPageLink = By.XPath("//a[contains(text(),'Key Presses')]");
           // OpenKeypressPage();
        }

        string IKeyPresses.getInputMessage()  //can be renamed to getoutputmessage
        {
           return this.driver.FindElement(enteredOutcome).Text;
        }

        void IKeyPresses.getNumericInputValue(int n)  //changed the return type to void
        {
            this.driver.FindElement(editBox).SendKeys(n.ToString());

         }

        string IKeyPresses.getPageContent()
        {
            Console.WriteLine(" page content : " + this.driver.FindElement(pageContentLocator).Text);
            return this.driver.FindElement(pageContentLocator).Text;
        }

        void IKeyPresses.getTextInputValue(string keyValue)
        {
            this.driver.FindElement(editBox).SendKeys(Keys.Enter);
        }

        string IKeyPresses.getTitle()
        {
            return this.driver.FindElement(pageTitleLocator).Text;
        }

    }
}
