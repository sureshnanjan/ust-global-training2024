using HerokuAppOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHerokuApp
{
    [TestFixture]
    internal class ITinyMCE_WYSIWYG
    {
        [Test]
        public void HomePageTitleisCorrect()
        {
            // Arrange
            ITinyMCEWYSIWYGEditor page = default;
            string expectedTitle = "An iFrame containing the TinyMCE WYSIWYG Editor";
            // Act
            string actualTitle = page.getTitle();
            // Assert
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));

        }

        [Test]
        public void HomePageTitleisCorrect()
        {
            // Arrange
            ITinyMCEWYSIWYGEditor page = default;
            string expectedTitle = "An iFrame containing the TinyMCE WYSIWYG Editor";
            // Act
            string actualTitle = page.getTitle();
            // Assert
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));

        }
    }
}
