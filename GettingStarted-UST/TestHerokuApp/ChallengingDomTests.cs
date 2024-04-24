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
        }
        [Test]
        /// <summary>
        /// Verify whether the page description is correct or not
        /// </summary>
        public void PageDescriptionverification()
        {
            IChallengingDomOperations page = new ChallengingDomPage();
            string expectedDesc = "The hardest part in automated web testing";
            //Action
            string actualDesc = page.getMainContent();
            //Assert
            Assert.That(actualDesc, Is.EqualTo(expectedDesc));
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
            //Action
            page.doOperation2();
            string buttonValue1 = page.getOperation2Label();
            //Assert
            Assert.That(buttonValue1, Is.AnyOf(expectedValue1, expectedValue2, expectedValue3));
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
            //Action
            page.doOperation3();
            string buttonValue1 = page.getOperation3Label();
            //Assert
            Assert.That(buttonValue1, Is.AnyOf(expectedValue1, expectedValue2, expectedValue3));
        }

        /// <summary>
        /// Verify whether answer is updated when the button is pressed 
        /// </summary>
        public void UpdateAnswerField()
        {
            IChallengingDomOperations page = new ChallengingDomPage();
            string currentAnswer = page.getResult();
            page.doOperation1();
            string afterAnswer = page.getResult();
            Assert.That(currentAnswer, Is.EqualTo(afterAnswer));
        }

        /// <summary>
        /// Verify whether table Headers are expected
        /// </summary>
        public void FetchTableHeadings()
        {
            IChallengingDomOperations page = new ChallengingDomPage();
            string[] tableHeadings = { };
            string[] actualTableHeadings = page.getTableHeadings();
            Assert.That(tableHeadings, Is.EqualTo(actualTableHeadings));

        }

        /// <summary>
        /// Verify whether table Headers are expected
        /// </summary>
        public void FetchTableHeadings(int rownum)
        {
            IChallengingDomOperations page = new ChallengingDomPage();
            string[] tablerow = { };
            string[] actualTablerow = page.getRowData(rownum);
            Assert.That(tablerow, Is.EqualTo(actualTablerow));

        }
    }
}