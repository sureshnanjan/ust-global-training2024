using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;
using HerokuWebdriverImplemention;
using NUnit.Framework;
using OpenQA.Selenium;

namespace TestHerokuApp
{
    [TestFixture]
    public class KeyPressesTests
    {
        /// <summary>
        /// Validate the Title of Key Presses Page
        /// </summary>
        [Test]
        public void verifyKeyPressesPageTitle()
        {
            IHomePage home = new HomePage();
            IKeyPresses kp = (keypressespage)home.goToExample("Key Presses");
            string expectedTitle = "Key Presses";
            string actualTitle = kp.getTitle();
           // Assert.Equals(expectedTitle, actualTitle);
            Assert.That(expectedTitle, Is.EqualTo(actualTitle));
            ((IHerokuAppOperations)kp).closeBrowser();

        }

        /// <summary>
        /// Validate the content of Key Presses page
        /// </summary>
        [Test]
        public void verifyPageContent()
        {
            IHomePage home = new HomePage();
            IKeyPresses kp = (keypressespage)home.goToExample("Key Presses");
            string expectedTitle = "Key presses are often used to interact with a website (e.g., tab order, enter, escape, etc.). Press a key and see what you inputted.";
            string actualTitle = kp.getPageContent();
            // Assert.Equals(expectedTitle, actualTitle);
            Assert.That(expectedTitle, Is.EqualTo(actualTitle));
            ((IHerokuAppOperations)kp).closeBrowser();

        }

        /// <summary>
        /// Test to Validate Press Key 1 and see what you inputted 
        /// </summary>
        [Test]
        public void VerifyInputValue_PressKey1()
        {
            IHomePage home = new HomePage();
            IKeyPresses kp = (keypressespage)home.goToExample("Key Presses");
            string expectedMessage = "You entered: 1";
            kp.getNumericInputValue(1);
            string actualMessage = kp.getInputMessage();
            // Assert.Equals(expectedMessage, actualMessage);
            Assert.That(expectedMessage, Is.EqualTo(actualMessage));
            ((IHerokuAppOperations)kp).closeBrowser();

        }

        /// <summary>
        /// Test to Validate Press Enter Key  and see what you inputted 
        /// </summary>
        [Test]
        public void VerifyInputValue_PressKeyEnter()
        {
            IHomePage home = new HomePage();
            IKeyPresses kp = (keypressespage)home.goToExample("Key Presses");
            string expectedMessage = "You entered: ENTER";
            kp.getTextInputValue("ENTER");
            string actualMessage = kp.getInputMessage();
           // Assert.Equals(expectedMessage, actualMessage);
            Assert.That(expectedMessage, Is.EqualTo(actualMessage));
            ((IHerokuAppOperations)kp).closeBrowser();
        }
    }
}