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
using System;
namespace TestHerokuApp
{
    [TestFixture]
    public class InfiniteScrollTests
    {
        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void titleOfInfiniteScrollPagenuIsCorrect()
        {
            //Repace this below null with actual webdriver implementation class name
            IInfiniteScrollPage page = null;
            string expectedTitle = "Infinite Scroll";
            string actualTitle = page.getTitle();
            Assert.That(actualTitle, Is.EqualTo(expectedTitle)); // NUNIT

        }

        [Test]
        public void URLOfthePageisCorrect()
        {
            //Repace this below null with actual webdriver implementation class name

            IInfiniteScrollPage page = null;
            string expectedUrl = "https://the-internet.herokuapp.com/infinite_scroll";
            string actualUrl = page.getURL();
            Assert.That(actualUrl, Is.EqualTo(expectedUrl));
        }

        [Test]
        public void headingIsCorrect()
        {
            //Repace this below null with actual webdriver implementation class name

            IInfiniteScrollPage page = null;
            string expectedTitle = "Infinite Scroll";
            string actualTitle = page.getTitle();
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
        }

        [Test]
        public void verifyPerformNScroll()
        {
            //Repace this below null with actual webdriver implementation class name

            IInfiniteScrollPage page = null;
              page.performNScroll(2);
            //not sure what to test here
         }

        [Test]
        public void verifyGetNthParagraph()
        {
            //Repace this below null with actual webdriver implementation class name

            IInfiniteScrollPage page = null;
              

           string expected = page.getNthParagraph(2);
            Assert.That(string.IsNullOrEmpty(expected), Is.False);


        }

         
    }
}
