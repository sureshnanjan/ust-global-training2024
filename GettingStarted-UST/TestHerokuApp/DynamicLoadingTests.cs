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
    internal class DynamicLoadingTests
    {
        /// <summary>
        /// Validate the Title of Dynamic Loading Page
        /// </summary>
        [Test]
        public void verifyDynamicLoadingPageTitle()
        {
            IDynamicLoadingPage dynamicloadingpage = null;
            string expectedTitle = "Dynamically Loaded Page Elements";
            string actualTitle = dynamicloadingpage.getTitle();
            Assert.Equals(expectedTitle, actualTitle);
        }

        /// <summary>
        /// Validate the content of Dynamic Loading page
        /// </summary>
        [Test]
        public void verifyPageContent()
        {
            IDynamicLoadingPage dynamicloadingpage = null;
            string expectedTitle = "It's common to see an action get triggered that returns a result dynamically. It does not rely on the page to reload or finish loading. The page automatically gets updated (e.g. hiding elements, showing elements, updating copy, etc) through the use of JavaScript.\nThere are two examples. One in which an element already exists on the page but it is not displayed. And anonther where the element is not on the page and gets added in.";
            string actualTitle = dynamicloadingpage.getDescription();
            Assert.Equals(expectedTitle, actualTitle);
        }

        /// <summary>
        /// Validate the Links count on Dynamic Loading page
        /// </summary>
        [Test]
        public void verifyDynamicLoadingPageHas2Links()
        {
            IDynamicLoadingPage dynamicloadingpage = null;
            int expectedCount = 2;
            int actual = dynamicloadingpage.getExamplesCount().Length;
            Assert.That(actual, Is.EqualTo(expectedCount));
        }

        /// <summary>
        /// Test case to verify Example1 Link subtitle is Correct 
        /// </summary>
        [Test]
        public void verifyExample1LinkSubTitleIsCorrect()
        {
            IDynamicLoadingPage dynamicloadingpage = null;
            string pagetovisit = "Example 1: Element on page that is hidden";
            string expectedSubTitle1 = "Example 1: Element on page that is hidden";
            dynamicloadingpage.goToExampleLinks(pagetovisit);
            string actualSubTitle1 = dynamicloadingpage.getSubTitleExample1();
            Assert.That(actualSubTitle1, Is.EqualTo(expectedSubTitle1));
        }

        /// <summary>
        /// Test case to verify Example2 Link subtitle is Correct 
        /// </summary>
        [Test]
        public void verifyExample2LinkSubTitleIsCorrect()
        {
            IDynamicLoadingPage dynamicloadingpage = null;
            string pagetovisit = "Example 2: Element rendered after the fact";
            string expectedSubTitle2 = "Example 2: Element rendered after the fact";
            dynamicloadingpage.goToExampleLinks(pagetovisit);
            string actualSubTitle2 = dynamicloadingpage.getSubTitleExample2();
            Assert.That(actualSubTitle2, Is.EqualTo(expectedSubTitle2));
        }

        /// <summary>
        /// Test to Validate Example1 Screen Clicking on the Start Button 
        /// </summary>
        /// <param>TimeOut to be given as Expected Second</param>
        [Test]
        public void verifyExample1StartButton()
        {
            IDynamicLoadingPage dynamicloadingpage = null;
            string expectedStartMessage = "Hello World!";
            string pagetovisit = "Example 1: Element on page that is hidden";
            dynamicloadingpage.goToExampleLinks(pagetovisit);
            dynamicloadingpage.enableStart();
            //driver.manage().timeout().implicitlywait(TimeOut,TimeUnit.SECONDS)
            string actualStartMessage = dynamicloadingpage.getStartMessage();
            Assert.Equals(expectedStartMessage, actualStartMessage);

        }

        /// <summary>
        /// Test to Validate Example2 Screen Clicking on the Start Button  
        /// </summary>
        /// <param>TimeOut to be given as Expected Second</param>
        [Test]
        public void verifyExample2StartButton()
        {
            IDynamicLoadingPage dynamicloadingpage = null;
            string expectedStartMessage = "Hello World!";
            string pagetovisit = "Example 2: Element rendered after the fact";
            dynamicloadingpage.goToExampleLinks(pagetovisit);
            dynamicloadingpage.enableStart();
            //driver.manage().timeout().implicitlywait(TimeOut,TimeUnit.SECONDS)
            string actualStartMessage = dynamicloadingpage.getStartMessage();
            Assert.Equals(expectedStartMessage, actualStartMessage);

        }

    }
}
