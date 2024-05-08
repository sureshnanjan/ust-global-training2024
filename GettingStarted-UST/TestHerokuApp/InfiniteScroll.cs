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
    internal class InfiniteScroll
    {
        [Test]
        public void InfiniteScrollTitleIsCorrect() 
        {
            /// <summary>
            ///  Verify the Login Page Title
            /// </summary>
            // Arrange
            IInfiniteScrollPage page = null;
            string expectedTitle = "InfiniteScroll";
            // Act
            string actualTitle = page.getTitle();
            // Assert
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
        }

        [Test]
        public void InfiniteScrollParagraphContentIsCorrect()
        {

            /// <summary>
            ///  Verify the content
            /// </summary>
            //Arrange
            IInfiniteScrollPage page = null;
            string expectedParaLines = "Velit fugiat nulla deleniti itaque hic nulla provident saepe minus voluptas tempore minima est ";
            //Act
           // page.performNScroll(3);
            string actualPara = page.getNthParagraph(3);
            //Assert
            Assert.That(actualPara, Contains.Substring(expectedParaLines));
        }

    }
}
