using HerokuAppOperations;
using NUnit.Framework;

namespace TestHerokuApp
{
    [TestFixture]
    internal class FormAuthenticationPageTest
    {
        /// <summary>
        ///  Verify the Login Page Title
        /// </summary>
        [Test]
        public void verifyLoginPageTitle()
        {
            IFormAuthenticationOperation FAPage = null;
            String expectedTitle = "Login Page";
            String actualTitle = FAPage.getTitle();
            Assert.Equals(expectedTitle, actualTitle);
        }

        /// <summary>
        /// Verify the Successful Login screen
        /// </summary>
        [Test]
        public void verifySuccessfulLogin() {
            IFormAuthenticationOperation FAPage = null;
            String expectedMessage = "You logged into a secure area!";
            FAPage.Login("tomsmith", "SuperSecretPassword!");
            String actualMessaage = FAPage.getSuccessMessage();
            Assert.Equals(expectedMessage, actualMessaage);
        }

        /// <summary>
        /// Verify login for Invalid Username 
        /// </summary>
        [Test]
        public void verifyFailedLoginInvalidUN()
        {
            IFormAuthenticationOperation FAPage = null;
            String expectedMessage = "Your username is invalid!";
            FAPage.Login("Invalid", "Invalid");
            String actualMessaage = FAPage.getLoginFail();
            Assert.Equals(expectedMessage, actualMessaage);
        }

        /// <summary>
        /// Verify login for Invalid Password 
        /// </summary>
        [Test]
        public void verifyFailedLoginInvalidPWD()
        {
            IFormAuthenticationOperation FAPage = null;
            String expectedMessage = "Your password is invalid!";
            FAPage.Login("tomsmith", "Invalid");
            String actualMessaage = FAPage.getLoginFail();
            Assert.Equals(expectedMessage, actualMessaage);
        }

        /// <summary>
        /// Verify the Logout fucntionality 
        /// </summary>
        [Test]
        public void verifyLogout() {
            IFormAuthenticationOperation FAPage = null;
            String expectedMessage = "You logged out of the secure area!";
            FAPage.Login("tomsmith", "SuperSecretPassword!");
            FAPage.logout();
            String actualMessaage = FAPage.getLogoutMessage();
            Assert.Equals(expectedMessage, actualMessaage);
        }
    }
}