using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;
using OpenQA.Selenium;

namespace HerokuWebdriverImplemention
{
    public class Checkbox : HerokuApp, ICheckboxes
    {
        private IWebDriver browser;
        private By checkBoxLink;
        public Checkbox()
        {
            this.checkBoxLink = By.XPath("//a[@href=\"/checkboxes\"]");
        }


        public void checkCheckBox()
        {
            this.driver.FindElement(checkBoxLink).Click();
        }

        public void getCurrentStatus()
        {
            throw new NotImplementedException();
        }

        public string getTitle()
        {
            throw new NotImplementedException();
        }

        public void unCheckCheckbox()
        {
            throw new NotImplementedException();
        }
    }
}
