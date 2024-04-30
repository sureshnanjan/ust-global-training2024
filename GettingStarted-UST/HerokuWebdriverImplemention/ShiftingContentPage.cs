using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;
using NUnit.Framework;
using OpenQA.Selenium;

namespace HerokuWebdriverImplemention
{
    public class ShiftingContent : HerokuApp, IShiftingContent
    {
        private IWebDriver browser;
        private By shiftingContenLink;
        private By shiftingContentTitle;

        public ShiftingContent()
        {
            this.shiftingContenLink = By.LinkText("Shiting Content");
            this.shiftingContentTitle = By.TagName("h3");
        }

        public void titleOfShiftingContentPage()
        {
            string expectedTitle = "Shifting Content";
            string actualTitle = this.driver.FindElement(shiftingContentTitle).Text;
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));

        }
        public void clickShiftingContentLink()
        {
            throw new NotImplementedException();
        }

        public void clickToShiftImageLeft()
        {
            throw new NotImplementedException();
        }

        public void clickToShiftImageRight()
        {
            throw new NotImplementedException();
        }

        public int CountTheLink()
        {
            throw new NotImplementedException();
        }

        public List<string> getMenuElements()
        {
            throw new NotImplementedException();
        }

        public bool getMenuItemVisibilityStatus(string item)
        {
            throw new NotImplementedException();
        }

        public string getTitle()
        {
            throw new NotImplementedException();
        }

        public string validateContentOnShiftingContent()
        {
            throw new NotImplementedException();
        }

        string IShiftingContent.titleOfShiftingContentPage()
        {
            throw new NotImplementedException();
        }
    }
}
