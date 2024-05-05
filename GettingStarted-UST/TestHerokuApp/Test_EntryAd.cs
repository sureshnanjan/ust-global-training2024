using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;
using NUnit.Framework;

namespace TestHerokuApp
{
    [TestFixture]
    public class Test_EntryAd
    {/// <summary>
     /// Verify whether the page title is correct or not
     /// </summary>

        [Test]
        public void VerifyPageUrlisCorrect()
        {
            IEntryAddOperations EntryAdPage = null;
            String expectedUrl = @"https://the-internet.herokuapp.com/jqueryui/menu";
            String actualUrl = EntryAdPage.getUrl();
            Assert.Equals(expectedUrl, actualUrl);


        }
        /// <summary>
        /// Verify whether the page title is correct or not
        /// </summary>
        [Test]
        public void VerifyPageSubTitleisCorrect()
        {
            IEntryAddOperations EntryAdPage = null;
            String expectedTitle = "Entry Ad";
            String actualTitle = EntryAdPage.getTitle();
            Assert.Equals(expectedTitle, actualTitle);
        }

        /// <summary>
        /// Verify the Entry Ad Page description
        /// </summary>
        [Test]
        public void verifyEntryAdPagedescription()
        {
            IEntryAddOperations EntryAdPage = null;
            String expectedDescription = "Displays an ad on page load";
            String actualDescription =EntryAdPage.getPageContentIentryAd();
            Assert.Equals(expectedDescription, actualDescription);

        }
        [Test]
        public void checkAdOnPageDisplayed()
        {
            IEntryAddOperations EntryAdPage = null;
            String expectedWindowTitle = "This is a modal window";
            String actualWindowTitle = EntryAdPage.getWindowTitle();
            Assert.Equals(expectedWindowTitle, actualWindowTitle);


        }
        [Test]
        public void checkAdOnPageClosed()
        {
            IEntryAddOperations EntryAdPage = null;
            String expectedDisplay = "Entry Ad";
            String actualDisplay = EntryAdPage.clickClose();
            Assert.Equals(expectedDisplay, actualDisplay);


        }

        [Test]
        public void checkNoSubsequentPageLoad()

        {
            IEntryAddOperations EntryAdPage = null;
            String expectedDisplayTitle = "Entrty Ad";
            String actualDisplayTitle = EntryAdPage.reloadPage();
            Assert.Equals(expectedDisplayTitle, actualDisplayTitle);


        }

        [Test]
        public void checkReEnableAdOnPageDisplayedByClickingLink()
        {
            IEntryAddOperations EntryAdPage = null;
            String expectedDisplayTitle = "This is a modal window";
            String actualDisplayTitle = EntryAdPage.clickHere();
            Assert.Equals(expectedDisplayTitle, actualDisplayTitle);
        }
    }
}
