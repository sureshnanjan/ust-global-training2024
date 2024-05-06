using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace HerokuWebdriverImplemention
{
    public class DropDown : HerokuApp, IDropDown
    {
        private readonly By headinglocator;

        public DropDown()
        {
            this.headinglocator = By.Id("");
        }

        /// <summary>
        /// verify page title
        /// </summary>
        public string getTitle()
        {
            return this.driver.FindElement(this.headinglocator).Text;
        }

        /// <summary>
        /// perform some click actions
        /// </summary>

        public void selectValueFromPicklist()
        {
            string[] dropDownValues = { "Please select an option", "Option 1", "Option 2" };
            SelectElement dropDown = new SelectElement(driver.FindElement(By.Id("select-demo")));

            foreach (string value in dropDownValues)
            {
                dropDown.SelectByValue(value);
            }
        }
    }
}
