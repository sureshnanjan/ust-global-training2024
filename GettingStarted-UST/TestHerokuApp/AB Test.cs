using HerokuAppOperations;
using HerokuWebdriverImplemention;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHerokuApp
{
    [TestFixture]
    internal class AB_Test
    {
        [Test]
        public void HomePageTitleisCorrect()
        {
            // Arrange
            IABTestControl page = default;
            string expectedTitle = "A/B Test Control";
            // Act
            string actualTitle = page.getTitle();
            // Assert
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));

        }

        [Test]
        public void MainContentisCorrect()
        {
            // Arrange
            IABTestControl page = default;
            string expectedTitle = "Also known as split testing. This is a way in which businesses are able to simultaneously test and learn different versions of a page to see which text and/or functionality works best towards a desired outcome (e.g. a user action such as a click-through).";
            // Act
            string actualTitle = page.getMainContent();
            // Assert
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));

        }
    }
}
