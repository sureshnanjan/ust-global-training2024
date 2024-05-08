using HerokuAppOperations;
using HerokuWebdriverImplemention;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using OpenQA.Selenium.Chromium;
using OpenQA.Selenium.DevTools;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.VirtualAuth;
using OpenQA.Selenium;
using System.Security.Cryptography;
using System.Collections;
namespace TestHerokuApp
{
    [TestFixture]
    public class FloatingMenuTests
    {
        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void TitleOfFloatingMenuIsCorrect()
        {
            //Repace this below null with actual webdriver implementation class name

            IFloatingMenuPage page = null;
            string expectedTitle = "Floating Menu";
            string actualTitle = page.getTitle();
            Assert.That(actualTitle, Is.EqualTo(expectedTitle)); // NUNIT

        }

        [Test]
        public void URLOfthePageisCorrect()
        {
            //Repace this below null with actual webdriver implementation class name

            IFloatingMenuPage page = null;
            string expectedUrl = "https://the-internet.herokuapp.com/floating_menu";
            string actualUrl = page.getURL();
            Assert.That(actualUrl, Is.EqualTo(expectedUrl));
        }

        [Test]
        public void headingIsCorrect()
        {
            //Repace this below null with actual webdriver implementation class name

            IFloatingMenuPage page = null;
            string expectedTitle = "Floating Menu";
            string actualTitle = page.getTitle();
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
        }

        [Test]
        public void numberOfMenuOptionsCorrect()
        {
            //Repace this below null with actual webdriver implementation class name

            IFloatingMenuPage page = null;
            int expected = 4;
            int actual = page.getMenuOptionCount();
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void menuOptionsValuesCorrect()
        {
            //Repace this below null with actual webdriver implementation class name

            IFloatingMenuPage page = null;
            ArrayList actual = new ArrayList();

            actual.Add("Home");
            actual.Add("News");
            actual.Add("Contact");
            actual.Add("About");

            List<string> expected = page.getAllMenuOptions();
            Assert.That(actual, Is.EqualTo(expected));


        }

        [Test]
        public void clickOnMenuItemChangesUrl()
        {
            //Repace this below null with actual webdriver implementation class name

            IFloatingMenuPage page = null;
            String actualUrl = "https://the-internet.herokuapp.com/floating_menu#home";
            page.clickOnSpecificMenu("Home");
            String expectedUrl = page.getURL();
            Assert.That(actualUrl, Is.EqualTo(expectedUrl));

            String actualUrlForNews = "https://the-internet.herokuapp.com/floating_menu#news";
            page.clickOnSpecificMenu("News");
            String expectedUrlForNews = page.getURL();
            Assert.That(actualUrlForNews, Is.EqualTo(expectedUrlForNews));
            String actualUrlForAbout = "https://the-internet.herokuapp.com/floating_menu#about";
            page.clickOnSpecificMenu("About");
            String expectedUrlForAbout = page.getURL();
            Assert.That(actualUrlForAbout, Is.EqualTo(expectedUrlForAbout));
            String actualUrlForContact = "https://the-internet.herokuapp.com/floating_menu#contact";
            page.clickOnSpecificMenu("Contact");
            String expectedUrlForContact = page.getURL();
            Assert.That(actualUrlForContact, Is.EqualTo(expectedUrlForContact));
        }


        [Test]
        public void verifyMenuItemVisibilityStatus()
        {
            //Repace this below null with actual webdriver implementation class name

            IFloatingMenuPage page = null;
            bool actual = page.getMenuItemVisibilityStatus();
            Assert.That(actual, Is.EqualTo(true));
        }

        [Test]
        public void verifyperformNScroll()
        {
            //Repace this below null with actual webdriver implementation class name

            IFloatingMenuPage page = null;
             page.performNScroll(2);
            ArrayList actual = new ArrayList();

            actual.Add("Home");
            actual.Add("News");
            actual.Add("Contact");
            actual.Add("About");

            List<string> expected = page.getAllMenuOptions();
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
