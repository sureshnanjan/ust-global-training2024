using System;
using System.Collections.Generic;
using System.Drawing;
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
        private By example1MenuLink;
        private By example2AnImageLink;
        private By example3List;
        private By shiftingContentListTitle;
        private By shiftingContentListText;
        private By clickHere2;
        private By portfolio;
        private By clickMyHome;
        private By clickHereInImage;
        private By getImage;

        public ShiftingContent()
        {
            this.shiftingContenLink = By.LinkText("Shifting Content");
            this.shiftingContentTitle = By.TagName("h3");
            this.example1MenuLink = By.XPath("//a[contains(text(), 'Example 1: Menu Element')]");
            this.example2AnImageLink = By.LinkText("Example 2: An image");
            this.example3List = By.LinkText("Example 3: List");
            this.shiftingContentListTitle = By.TagName("h3");
            this.shiftingContentListText = By.XPath("//p[contains(text(), 'This example demonstrates')]");
            this.clickHere2 = By.XPath("//a[@href='/shifting_content/menu?pixel_shift=100']");
            this.portfolio = By.XPath("//*[@id=\"content\"]/div/ul/li[4]/a");
            this.clickMyHome = By.XPath("//*[@id=\"content\"]/div/ul/li[1]/a");
            this.clickHereInImage = By.XPath("//*[@id=\"content\"]/div/p[3]/a");
            this.getImage = By.XPath(" //img[@src = \"/img/avatar.jpg]");

        }

        public void CheckLinksOfMenuLink()
        {
            this.driver.FindElement(example1MenuLink).Click();

            this.driver.FindElement(clickHere2).Click();

            bool visible = this.driver.FindElement(portfolio).Displayed;
            if (visible == false)
            {
                Console.WriteLine("Portfolio menu item is invisible");
            }
            else
            {
                Console.WriteLine("Portfolio menu item is visible");
            }
        }

        public void clickHome()
        {
            this.driver.FindElement(clickMyHome).Click();
        }

        public void ClickListlink_CheckTitleOfPage()
        {
            this.driver.FindElement(example3List).Click();
            string expectedTitle = "Shifting Content: List";
            string actualTitle = this.driver.FindElement(shiftingContentListTitle).Text;
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
        }

        public void clickShiftingContentLink()
        {
            this.driver.FindElement(shiftingContenLink).Click();
        }

        public void titleOfShiftingContentPage()
        {
            string expectedTitle = "Shifting Content";
            string actualTitle = this.driver.FindElement(shiftingContentTitle).Text;
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
        }

        public void contentOnShiftingContentList()
        {
            string expectedContent = "This example demonstrates a list of dynamic content with a static record that constantly moves around.";
            string actualContent = this.driver.FindElement(shiftingContentListText).Text;
            Assert.That(actualContent, Is.EqualTo(expectedContent));

        }

        public void clickImagelink_ClickhereToShiftImage()
        {
            this.driver.FindElement(example2AnImageLink).Click();
            Point P = this.driver.FindElement(By.XPath("//img[@class=\"shift\"]")).Location;
            Console.WriteLine(P.X);
            this.driver.FindElement(clickHereInImage).Click();
            Point Q = this.driver.FindElement(By.XPath("//img[@class=\"shift\"]")).Location;
            Console.WriteLine(Q.X);
            Assert.That(P, Is.Not.EqualTo(Q));

        }

        public void clickImagelink_ClickhereRandomLoadImage()
        {
            this.driver.FindElement(example2AnImageLink).Click();
            Point P = this.driver.FindElement(By.XPath("//img[@class=\"shift\"]")).Location;
            Console.WriteLine(P.X);
            this.driver.FindElement(clickHereInImage).Click();
            Point Q = this.driver.FindElement(By.XPath("//img[@class=\"shift\"]")).Location;
            Console.WriteLine(Q.X);
            Assert.That(P, Is.EqualTo(Q));

        }
    }
   
}
