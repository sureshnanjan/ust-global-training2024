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

    public class ChallengingDomTests
    {
        /// <summary>
        /// Verify whether the page title is correct or not
        /// </summary>
        [Test]
        public void PageTitleverification()
        {
            //Arrange
            IChallengingDomOperations page = new ChallengingDomPage();
            string expectedTitle = "Challenging DOM";
            //Action
            string actualTitle = page.getTitle();
            //Assert
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
            page.closeBrowser();
        }

        [Test]
        /// <summary>
        /// Verify whether the page description is correct or not
        /// </summary>
        public void PageDescriptionverification()
        {
            IChallengingDomOperations page = new ChallengingDomPage();
            string expectedDesc = "The hardest part in automated web testing is finding the best locators (e.g., ones that well named, unique, and unlikely to change). It's more often than not that the application you're testing was not built with this concept in mind. This example demonstrates that with unique IDs, a table with no helpful locators, and a canvas element.";
            //Action
            string actualDesc = page.getMainContent();
            //Assert
            Assert.That(actualDesc, Is.EqualTo(expectedDesc));
            page.closeBrowser();
        }


        [Test]
        /// <summary>
        /// Verify whether first button works fine
        /// </summary>
        public void PerformOperation1()
        {
            IChallengingDomOperations page = new ChallengingDomPage();
            //Arrange
            string expectedValue = "baz";
            //Action
            page.doOperation1();
            string buttonValue1 = page.getOperation1Label();
            //Assert
            Assert.That(buttonValue1, Is.EqualTo(expectedValue));
            page.closeBrowser();
        }

        /// <summary>
        /// Verify whether the second button works fine
        /// </summary>
        [Test]
        public void PerformOperation2()
        {
            IChallengingDomOperations page = new ChallengingDomPage();
            //Arrange
            string expectedValue1 = "foo";
            string expectedValue2 = "baz";
            string expectedValue3 = "bar";
            string expectedValue4 = "qux";
            //Action
            page.doOperation2();
            string buttonValue1 = page.getOperation2Label();
            //Assert
            Assert.That(buttonValue1, Is.AnyOf(expectedValue1, expectedValue2, expectedValue3, expectedValue4));
            page.closeBrowser();
        }

        /// <summary>
        /// Verify whether third button works as expected
        /// </summary>
        [Test]
        public void PerformOperation3()
        {
            IChallengingDomOperations page = new ChallengingDomPage();
            //Arrange
            string expectedValue1 = "foo";
            string expectedValue2 = "baz";
            string expectedValue3 = "bar";
            string expectedValue4 = "qux";
            //Action
            page.doOperation3();
            string buttonValue1 = page.getOperation3Label();
            //Assert
            Assert.That(buttonValue1, Is.AnyOf(expectedValue1, expectedValue2, expectedValue3, expectedValue4));
            page.closeBrowser();
        }

        /// <summary>
        /// Verify whether answer is updated when the button is pressed 
        /// </summary>
        [Test]
        public void UpdateAnswerField()
        {
            IChallengingDomOperations page = new ChallengingDomPage();
            string currentAnswer = page.getResult();
            page.doOperation1();
            string afterAnswer = page.getResult();
            Assert.That(currentAnswer, Is.EqualTo(afterAnswer));
            page.closeBrowser();
        }

        /// <summary>
        /// Verify whether table Headers are expected
        /// </summary>
        [Test]
        public void FetchTableHeadings()
        {
            IChallengingDomOperations page = new ChallengingDomPage();
            string[] tableHeadings = { "Lorem", "Ipsum", "Dolor", "Sit", "Amet", "Diceret", "Action" };
            string[] actualTableHeadings = page.getTableHeadings();
            Assert.That(tableHeadings, Is.EqualTo(actualTableHeadings));
            page.closeBrowser();
        }

        /// <summary>
        /// Verify whether table row1 data are expected
        /// </summary>
        [Test]
        public void FetchTableRow1Data()
        {
            IChallengingDomOperations page = new ChallengingDomPage();
            string[] tablerow1num = { "Iuvaret0 Apeirian0 Adipisci0 Definiebas0 Consequuntur0 Phaedrum0 edit delete"};
            string[] actualTablerow1 = page.getRowData();
            Assert.That(tablerow1num, Is.EqualTo(actualTablerow1));
            page.closeBrowser();
        }
    }
}