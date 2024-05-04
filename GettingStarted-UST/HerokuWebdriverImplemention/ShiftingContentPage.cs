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
            this.shiftingContenLink = By.LinkText("Shifting Content");
            this.shiftingContentTitle = By.TagName("h3");
        }

        public void clickShiftingContentLink()
        {
            this.driver.FindElement(shiftingContenLink).Click();
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
            //List<IWebElement> count = driver.FindElement(By.TagName(""));
            // Console.WriteLine(count);

            // IHomePage page = new HomePage();
            IShiftingContent obj = new ShiftingContent();
            int expectedCount = 3;
            int actualCount = obj.CountTheLink();
                
            Assert.That(actualCount, Is.EqualTo(expectedCount));
            Console.WriteLine("Total link on the page is " + expectedCount);
        }

        public List<string> getMenuElements()
        {
            throw new NotImplementedException();
        }

        public bool getMenuItemVisibilityStatus(string item)
        {
            throw new NotImplementedException();
        }

        public void titleOfShiftingContentPage()
        {
            string expectedTitle = "Shifting Content";
            string actualTitle = this.driver.FindElement(shiftingContentTitle).Text;
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));

        }

        public string validateContentOnShiftingContent()
        {
            throw new NotImplementedException();
        }
    }
}
