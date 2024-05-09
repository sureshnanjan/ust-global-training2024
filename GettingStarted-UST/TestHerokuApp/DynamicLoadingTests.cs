using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;
using HerokuWebdriverImplemention;
using NUnit.Framework;



namespace TestHerokuApp
{
    [TestFixture]

    public class DynamicLoadingTests
    {
        /*

        [SetUp]
        public void testSetup()
        {
            IHomePage home = new HomePage();
             IDynamicLoadingPage dyload = (Dynamicloadingpage)home.goToExample("Dynamic Loading");
        }

        [TearDown]
        public void testTearDown()
        {
            ((IHerokuAppOperations)dyload).closeBrowser();
        }  */

        /// <summary>
        /// Validate the Title of Dynamic Loading Page
        /// </summary>
        [Test]
        public void verifyDynamicLoadingPageTitle()
        {

            IHomePage home = new HomePage();
            IDynamicLoadingPage dyload = (Dynamicloadingpage)home.goToExample("Dynamic Loading");
            string expectedTitle = "Dynamically Loaded Page Elements";
            string actualTitle = dyload.getTitle();
            //  Assert.Equals(expectedTitle, actualTitle);
            Assert.That(expectedTitle, Is.EqualTo(actualTitle));
            ((IHerokuAppOperations)dyload).closeBrowser();
        }

        /// <summary>
        /// Validate the content of Dynamic Loading page
        /// </summary>
       
        [Test]
        public void verifyPageContent()
        {
            IHomePage home = new HomePage();
            IDynamicLoadingPage dyload = (Dynamicloadingpage)home.goToExample("Dynamic Loading");
            string expectedTitle = "It's common to see an action get triggered that returns a result dynamically. It does not rely on the page to reload or finish loading. The page automatically gets updated (e.g. hiding elements, showing elements, updating copy, etc) through the use of JavaScript.";
            string actualTitle = dyload.getDescription();
            Assert.That(expectedTitle, Is.EqualTo(actualTitle));
            ((IHerokuAppOperations)dyload).closeBrowser();
        }

        /// <summary>
        /// Validate the Links count on Dynamic Loading page
        /// </summary>
        [Test]
        public void verifyDynamicLoadingPageHas2Links()
        {
            IHomePage home = new HomePage();
            IDynamicLoadingPage dyload = (Dynamicloadingpage)home.goToExample("Dynamic Loading");
            int expectedCount = 2;
            int actual = dyload.getExamplesCount();
            Assert.That(actual, Is.EqualTo(expectedCount));
            Console.WriteLine("Passed!");
           ((IHerokuAppOperations)dyload).closeBrowser();

        }

        /// <summary>
        /// Test case to verify Example1 Link subtitle is Correct 
        /// </summary>
        [Test]
        public void verifyExample1LinkSubTitleIsCorrect()
        {
            IHomePage home = new HomePage();
            IDynamicLoadingPage dyload = (Dynamicloadingpage)home.goToExample("Dynamic Loading");
            string pagetovisit = "Example 1: Element on page that is hidden";
            string expectedSubTitle1 = "Example 1: Element on page that is hidden";
            dyload.goToExampleLinks(pagetovisit);
            string actualSubTitle1 = dyload.getSubTitleExample1();
            Assert.That(actualSubTitle1, Is.EqualTo(expectedSubTitle1));
            ((IHerokuAppOperations)dyload).closeBrowser();
        }

        /// <summary>
        /// Test case to verify Example2 Link subtitle is Correct 
        /// </summary>
        [Test]
        public void verifyExample2LinkSubTitleIsCorrect()
        {
            IHomePage home = new HomePage();
            IDynamicLoadingPage dyload = (Dynamicloadingpage)home.goToExample("Dynamic Loading");
            string pagetovisit = "Example 2: Element rendered after the fact";
            string expectedSubTitle2 = "Example 2: Element rendered after the fact";
            dyload.goToExampleLinks(pagetovisit);
            string actualSubTitle2 = dyload.getSubTitleExample2();
            Assert.That(actualSubTitle2, Is.EqualTo(expectedSubTitle2));
            ((IHerokuAppOperations)dyload).closeBrowser();
        }

        /// <summary>
        /// Test to Validate Example1 Screen Clicking on the Start Button 
        /// </summary>
        /// <param>TimeOut to be given as Expected Second</param>
        [Test]
        public void verifyExample1StartButton()
        {
            IHomePage home = new HomePage();
            IDynamicLoadingPage dyload = (Dynamicloadingpage)home.goToExample("Dynamic Loading");
            string expectedStartMessage = "Hello World!";
            string pagetovisit = "Example 1: Element on page that is hidden";
            dyload.goToExampleLinks(pagetovisit);
            dyload.enableStart();
            //driver.manage().timeout().implicitlywait(TimeOut, TimeUnit.SECONDS);  //shifted this line to enablestart method
            String actualStartMessage = dyload.getStartMessage();
            Assert.That(actualStartMessage, Is.EqualTo(expectedStartMessage));  
            ((IHerokuAppOperations)dyload).closeBrowser();

        }

        /// <summary>
        /// Test to Validate Example2 Screen Clicking on the Start Button  
        /// </summary>
        /// <param>TimeOut to be given as Expected Second</param>
        [Test]
        public void verifyExample2StartButton()
        {
            IHomePage home = new HomePage();
            IDynamicLoadingPage dyload = (Dynamicloadingpage)home.goToExample("Dynamic Loading");
            string expectedStartMessage = "Hello World!";
            string pagetovisit = "Example 2: Element rendered after the fact";
            dyload.goToExampleLinks(pagetovisit);
            dyload.enableStart();
            //driver.manage().timeout().implicitlywait(TimeOut,TimeUnit.SECONDS)
            string actualStartMessage = dyload.getStartMessage();
            Assert.That(expectedStartMessage, Is.EqualTo(actualStartMessage));
            ((IHerokuAppOperations)dyload).closeBrowser();

        }
        
    }
}