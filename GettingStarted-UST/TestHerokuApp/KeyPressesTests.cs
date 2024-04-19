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
    internal class KeyPressesTests
    {
        /// <summary>
        /// Validate the Title of Key Presses Page
        /// </summary>
        [Test]
        public void verifyKeyPressesPageTitle()
        {
            IKeyPresses keypressespage = null;
            string expectedTitle = "Key Presses";
            string actualTitle = keypressespage.getTitle();
            Assert.Equals(expectedTitle, actualTitle);
        }

        /// <summary>
        /// Validate the content of Key Presses page
        /// </summary>
        [Test]
        public void verifyPageContent()
        {
            IKeyPresses keypressespage = null;
            string expectedTitle = "Key presses are often used to interact with a website (e.g., tab order, enter, escape, etc.). Press a key and see what you inputted.";
            string actualTitle = keypressespage.getPageContent();
            Assert.Equals(expectedTitle, actualTitle);
        }

        /// <summary>
        /// Test to Validate Press Key 1 and see what you inputted 
        /// </summary>
        [Test]
        public void VerifyInputValue_PressKey1()
        {
            IKeyPresses keypressespage = null;
            string expectedMessage = "You entered: 1";
            keypressespage.getNumericInputValue(1);
            string actualMessage = keypressespage.getInputMessage();
            Assert.Equals(expectedMessage, actualMessage);

        }

        /// <summary>
        /// Test to Validate Press Enter Key  and see what you inputted 
        /// </summary>
        [Test]
        public void VerifyInputValue_PressKeyEnter()
        {
            IKeyPresses keypressespage = null;
            string expectedMessage = "You entered: ENTER";
            keypressespage.getTextInputValue("ENTER");
            string actualMessage = keypressespage.getInputMessage();
            Assert.Equals(expectedMessage, actualMessage);

        }
    }
}
