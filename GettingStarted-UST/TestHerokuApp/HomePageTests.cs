﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
namespace TestHerokuApp
{
    /// <summary>
    /// Perform Tests in HomePage
    /// </summary>
    [TestFixture]
    public class HomePageTests
    {
        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void homePageTitleisCorrect() {
            // Arrange
            IHomePage page = new HomePage();
            // page.goToExample*().AddElement().CheckIfDisplayed()
            string expectedTitle = "Welcome to the-internet";
            // A
            string actualTitle = page.getTitle();
            // A
            Assert.That(actualTitle, Is.EqualTo(expectedTitle)); // NUNIT
                
        }

        /// <summary>
        /// Verify Subtitle of HomePage
        /// </summary>
        [Test]
        public void homePageSubTitleisCorrect() {
            IHomePage page = null;
            string expectedSubTitle = "Available Examples";
            // A
            string actualTitle = page.getSubTitle();
            // A
            Assert.That(actualTitle, Is.EqualTo(expectedSubTitle)); // NUNIT
        }

        /// <summary>
        /// Verify HomePage has 44 links available
        /// </summary>
        [Test]
        public void homePageHas44Links() {
            IHomePage page = new HomePage();
            int expectedCount = 44;
            int actual = page.getAvailableExamples().Length;
            Assert.That(actual, Is.EqualTo(expectedCount));
        }

        [Test]
        public void visintingAExamplePageWorks() {
            IHomePage page = null;
            string pagetovisit = "A/B Testing";
            string expectedTitle = "A/B Test Variation 1";
            //(IABTestOpetration) page.goToExample(pagetovisit);
            string actualTitle = page.getTitle();
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
        }

        [Test]
        public void testingIfFirstItemisDisabled() {
            IHomePage page = null;
            //bool itemToTest = "Disabled";
            bool expectedTitle = false;
            //string actualTitle = page.getStatus(itemToTest);
            //Assert.That(actualTitle, Is.EqualTo(expectedTitle));


        }

        [Test]
        public void testingIfPDFItemIsEnabled()
        {
            IHomePage page = null;
            string itemToTest = "ENABLED-Download-Pdf";
            bool expectedTitle = true;
            //bool actual = page.GetStatus(itemToTest);
            //Assert.That(actualTitle, Is.EqualTo(expectedTitle));


        }

        [Test]
        public void addRemoveElementPageObjectImplementationworks() {
            IHomePage page = new HomePage();
            page.goToHome();
            IAddRemoveOperations addremPage = (IAddRemoveOperations)page.goToExample("AddRemove");
            addremPage.goToHome();

        }

    }


    public class ChromeDriver : ChromiumDriver,
        IWebDriver, IDisposable, ISearchContext, IJavaScriptExecutor,
        IFindsElement, ITakesScreenshot, ISupportsPrint, IActionExecutor,
        IAllowsFileDetection, IHasCapabilities, IHasCommandExecutor, IHasSessionId,
        ICustomDriverCommandExecutor, IHasVirtualAuthenticator, ISupportsLogs, IDevTools
    {
        protected ChromeDriver(ChromiumDriverService service, ChromiumOptions options, TimeSpan commandTimeout) : base(service, options, commandTimeout)
        {
        }
    }

    
        };

}
}
