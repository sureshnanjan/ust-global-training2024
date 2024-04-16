using NUnit.Framework;
using NUnit.Framework.Constraints;
using HerokuAppOperations;
using System.Security.Cryptography;

namespace TestHerokuApp
{
    /// <summary>
    /// KeyPresses Tests for HerokuApp
    /// </summary>
    /// 
    [TestFixture]
    public class TestKeyPresses
    {
        /// <summary>
        /// Test to Validate Title is Correct
        /// </summary>
        [Test]
        public void KeyPressesScreenTitleIsCorrect()
        {
            //Arrange
            IHomeScreen page = null;
            string expectedTitle = "Key Presses";
            //Action
            string actualTitle = page.getTitle();
            //Assert
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));

        }

        /// <summary>
        /// Test to Validate Press Key 1 and see what you inputted 
        /// </summary>
        [Test]
        public void VerifyInputValue_PressKey1()
        {

        }

        /// <summary>
        /// Test to Validate Press Enter Key and see what you inputted 
        /// </summary>
        [Test]
        public void VerifyInputValue_PressKeyEnter()
        {

        }


        /// <summary>
        /// Test to Validate Press Shift Key and see what you inputted 
        /// </summary>
        [Test]
        public void VerifyInputValue_PressKeyShift()
        {

        }

        /// <summary>
        /// Test to Validate Press Tab Key and see what you inputted 
        /// </summary>
        [Test]
        public void VerifyInputValue_PressKeyTab()
        {

        }

        /// <summary>
        /// Test to Validate Press CapsLock Key and see what you inputted 
        /// </summary>
        [Test]
        public void VerifyInputValue_PressKeyCapsLock()
        {

        }
    }
}
