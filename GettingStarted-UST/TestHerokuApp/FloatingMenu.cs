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
    internal class FloatingMenu
    {
        [Test]

        public void FloatingMenuPageTitleIsCorrect()
        {
            // Arrange
            IFloatingMenuPage page = null;
           
            string expectedTitle = "Floating Menu";
            // Act
            string actualTitle = page.getTitle();
            // Assert
            Assert.That(actualTitle, Is.EqualTo(expectedTitle)); // NUNIT

        }

        [Test]
        public void verifyPageCotent()
        {
            //Arrange
            IFloatingMenuPage content = null;
            string expectedContent = "Content";
            //Act
            string actualContent = content.getScreenContent();
            //Assert
            Assert.Equals(expectedContent, actualContent);
        }

        [Test]
        public void verifyMenuPageCount() 
        {
            // Arrange
            IFloatingMenuPage page = null;
            
            string expected MenuPageCount = "4";
            // Act
            string actual MenuPageCount = MenuPageCount.();
            // Assert
            Assert.That(actualCount, Is.EqualTo(expectedCount)); // NUNIT

            string currentPosition =.getSlidePosition();
            Assert.Equals(expectedPosition, currentPosition);
        }

        
    }



}
