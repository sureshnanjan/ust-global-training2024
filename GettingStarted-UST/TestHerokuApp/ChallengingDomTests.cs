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
    /// <summary>
    /// Test cases to verify the  ChallengingDom features
    /// </summary>
    [TestFixture]
    public class ChallengingDomTests
    {
        /// <summary>
        /// Verify whether the page title is correct or not
        /// </summary>
        [Test]
        public void PageTitleverification()
        {
            IHomePage page = new HomePage();
            IChallengingDomOperations dom = (ChallengingDomPage)page.goToExample("ChallengingDom");
            string expectedTitle = "Challenging DOM";
            string actualTitle = dom.getTitle();
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
            dom.closeBrowser();
        }

        [Test]
        /// <summary>
        /// Verify whether the page description is correct or not
        /// </summary>
        public void PageDescriptionverification()
        {
            IHomePage page = new HomePage();
            IChallengingDomOperations dom = (ChallengingDomPage)page.goToExample("ChallengingDom");
            string expectedDesc = "The hardest part in automated web testing is finding the best locators (e.g., ones that well named, unique, and unlikely to change). It's more often than not that the application you're testing was not built with this concept in mind. This example demonstrates that with unique IDs, a table with no helpful locators, and a canvas element.";
            string actualDesc = dom.getMainContent();
            Assert.That(actualDesc, Is.EqualTo(expectedDesc));
            dom.closeBrowser();
        }


        [Test]
        /// <summary>
        /// Verify whether first button works fine
        /// </summary>
        public void PerformOperation1()
        { 
            IHomePage page = new HomePage();
            IChallengingDomOperations dom = (ChallengingDomPage)page.goToExample("ChallengingDom");
            string expectedValue = "baz";
            dom.doOperation1();
            string buttonValue1 = dom.getOperation1Label();
            Assert.That(buttonValue1, Is.EqualTo(expectedValue));
            dom.closeBrowser();
        }

        /// <summary>
        /// Verify whether the second button works fine
        /// </summary>
        [Test]
        public void PerformOperation2()
        {
            IHomePage page = new HomePage();
            IChallengingDomOperations dom = (ChallengingDomPage)page.goToExample("ChallengingDom");
            string expectedValue1 = "foo";
            string expectedValue2 = "baz";
            string expectedValue3 = "bar";
            string expectedValue4 = "qux";
            dom.doOperation2();
            string buttonValue1 = dom.getOperation2Label();
            Assert.That(buttonValue1, Is.AnyOf(expectedValue1, expectedValue2, expectedValue3, expectedValue4));
            dom.closeBrowser();
        }

        /// <summary>
        /// Verify whether third button works as expected
        /// </summary>
        [Test]
        public void PerformOperation3()
        {
            IHomePage page = new HomePage();
            IChallengingDomOperations dom = (ChallengingDomPage)page.goToExample("ChallengingDom");
            string expectedValue1 = "foo";
            string expectedValue2 = "baz";
            string expectedValue3 = "bar";
            string expectedValue4 = "qux";
            dom.doOperation3();
            string buttonValue1 = dom.getOperation3Label();
            Assert.That(buttonValue1, Is.AnyOf(expectedValue1, expectedValue2, expectedValue3, expectedValue4));
            dom.closeBrowser();
        }

        /// <summary>
        /// Verify whether answer is updated when the button is pressed 
        /// </summary>
        [Test]
        public void UpdateAnswerField()
        {
            IHomePage page = new HomePage();
            IChallengingDomOperations dom = (ChallengingDomPage)page.goToExample("ChallengingDom");
            string currentAnswer = dom.getResult();
            dom.doOperation1();
            string afterAnswer = dom.getResult();
            Assert.That(currentAnswer, Is.EqualTo(afterAnswer));
            dom.closeBrowser();
        }

        /// <summary>
        /// Verify whether table Headers are expected
        /// </summary>
        [Test]
        public void FetchTableHeadings()
        {
            IHomePage page = new HomePage();
            IChallengingDomOperations dom = (ChallengingDomPage)page.goToExample("ChallengingDom");
            string[] tableHeadings = { "Lorem", "Ipsum", "Dolor", "Sit", "Amet", "Diceret", "Action" };
            string[] actualTableHeadings = dom.getTableHeadings();
            Assert.That(tableHeadings, Is.EqualTo(actualTableHeadings));
            dom.closeBrowser();
        }

        /// <summary>
        /// Verify whether table row1 data are expected
        /// </summary>
        [Test]
        public void FetchTableRow1Data()
        {
            IHomePage page = new HomePage();
            IChallengingDomOperations dom = (ChallengingDomPage)page.goToExample("ChallengingDom");
            string[] tablerow1num = { "Iuvaret0 Apeirian0 Adipisci0 Definiebas0 Consequuntur0 Phaedrum0 edit delete" };
            string[] actualTablerow1 = dom.getRowData();
            Assert.That(tablerow1num, Is.EqualTo(actualTablerow1));
            dom.closeBrowser();
        }
    }
}