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
            /// <summary>
            ///  Verify the Login Page Title
            /// </summary>
            // Arrange
            IFloatingMenuPage page = null;
           
            string expectedTitle = "Floating Menu";
            // Act
            string actualTitle = page.getTitle();
            // Assert
            Assert.That(actualTitle, Is.EqualTo(expectedTitle)); 

        }

        [Test]
        public void verifyPageCotent()
        {
            /// <summary>
            ///  Verify the Content
            /// </summary>
            //Arrange
            IFloatingMenuPage content = null;
            string expectedContent = "Consectetur asperiores delectus enim dignissimos dolore sed ipsam minus pariatur fugiat autem adipisci odit ipsam dolores necessitatibus pariatur id earum eligendi quibusdam nesciunt quibusdam incidunt aut veniam voluptates";
            //Act
            string actualContent = content.getScreenContent();
            //Assert
            Assert.That(actualContent,Contains.Substring(expectedContent));
        }

        [Test]
        public void verifyMenuPageCount() 
        {
            /// <summary>
            ///  Get the menu page count
            /// </summary>
            // Arrange
            IFloatingMenuPage page = null;

            int expectedMenuPageCount = 4;
            // Act
             int actualMenuPageCount = page.getMenuOptionCount();
            // Assert
            Assert.That(actualMenuPageCount, Is.EqualTo(expectedMenuPageCount)); 

        }


    }



}
