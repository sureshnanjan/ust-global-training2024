using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;
using OpenQA.Selenium;

namespace HerokuWebdriverImplemention
{
    internal class InputsPage : HerokuApp, IInputsPage
    {
        /// <summary>
        /// Properties
        /// </summary>
        private By heading;
        private By decrease;
        private By increase;

        /// <summary>
        /// Inputs Page construction webelements
        /// </summary>
        /// <param name="driver"></param>
        public InputsPage(IWebDriver driver) : base(driver) {
            this.heading = By.XPath("//*[@id=\"content\"]/div/div/h3");
            this.decrease = By.XPath("//*[@id=\"content\"]/div/div/div/input");
            this.increase = By.XPath("//*[@id=\"content\"]/div/div/div/input");
        }

        /// <summary>
        /// Test Method to get Title
        /// </summary>
        /// <returns></returns>
        public string getTitle()
        {
            return driver.FindElement(heading).Text;
        }

        /// <summary>
        /// Test method to validate - Input Increase Value
        /// </summary>
        /// <returns></returns>
        public int IncreaseValue()
        {
            driver.FindElement(increase).Click();
            throw new NotImplementedException();
        }

        /// <summary>
        /// Test method to validate - Input Decrease Value
        /// </summary>
        /// <returns></returns>
        public int DecreaseValue()
        {
            driver.FindElement(decrease).Click();
            throw new NotImplementedException();
        }

     
    }
}
