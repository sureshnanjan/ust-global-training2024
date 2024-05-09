using HerokuAppOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHerokuApp
{
    [TestFixture]
    internal class TestNotificationMsg
    {

        [Test]
        public void NotificationPageTitleisCorrect()
        {
            // Arrange
            INotificationMessages page = default;
            string expectedTitle = "Notification Message";
            // Act
            string actualTitle = page.GetTitle();
            // Assert
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));

        }

        [Test]

        public void NotificationPageContentisCorrect()
        {
            // Arrange
            INotificationMessages page = default;
            string expectedContent = "The message displayed above the heading is a notification message";
            // Act
            string actualContent = page.GetContent();
            // Assert
            Assert.That(actualContent, Contains.Substring(expectedContent));
        }

        [Test]
        public void OnLoadNotificationMsgisVisible()
        {
            // Arrange
            INotificationMessages page = default;
            string expectedNotificationMessage = "Action successful";
            // Act
            string actualNotificationMessage = page.GetNotificationMessage();
            // Assert
            Assert.That(actualNotificationMessage, Contains.Substring(expectedNotificationMessage));
        }
        [Test]
        public void TestForCloseButtonDismissal()
        {
            // Arrange
            INotificationMessages page = default;
            //Act
            page.CloseNotification();
            //Assert
            Assert.That(page.IsNotificationBarisVisible(),Is.False);

        }
        [Test]
        public void TestClickHere()
        {
            // Arrange
            INotificationMessages page = default;
            string expectedNotificationMessage = "Action successful";
            //Act
            page.ClickHere();
            string actualNotificationMessage = page.GetNotificationMessage();
            //Assert
            Assert.That(actualNotificationMessage, Contains.Substring(expectedNotificationMessage));

        }


    }
}