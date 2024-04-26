using HerokuAppOperations;
using OpenQA.Selenium;

namespace HerokuWebdriverImplemention
{
    public class AddRemovePage : HerokuApp, IAddRemoveElements
    {

        private IWebDriver browser;
        private By AddREmoveLink;

        public AddRemovePage() 
        {
            this.AddREmoveLink = By.XPath("//a[@href=\"/add_remove_elements/\"]");
          
        }

        bool IAddRemoveElements.checkForPresenceofDeleteButton()
        {
            throw new NotImplementedException();
        }

        void IAddRemoveElements.clickOnAddElements()
        {
            throw new NotImplementedException();
        }

        void IAddRemoveElements.clickOnDelete()
        {
            throw new NotImplementedException();
        }

        bool IAddRemoveElements.pageContent()
        {
            this.driver.FindElement(AddREmoveLink).Click();
            return true;

            throw new NotImplementedException();
        }
    }
}