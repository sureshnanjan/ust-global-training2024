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
    public class Test_DynamicControls
    {

        /// <summary>
        /// To verify the URL of page is correct
        /// </summary>
        [Test]
        public void UrlOfPageIsCorrect()
        {
            IDynamicControlPage dynamicControl = null;
            string expectedUrl = "https://the-internet.herokuapp.com/dynamic_controls";
            string actualUrl = dynamicControl.getURL();
            Assert.That(actualUrl, Is.EqualTo(expectedUrl));
        }
        /// <summary>
        /// Verify whether the page title is correct or not
        /// </summary>
        [Test]
        public void PageTitleverification()
        {
            //Arrange
            IHomepage_DynamicControl page = null;
            string expectedTitle = "Dynamic Controls";
            //Action
            string actualTitle = page.getTitle();
            //Assert
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));

        }
        /// <summary>
        /// Verifying user is able to select add things
        /// </summary>
        [Test]
        public void PerformAdd()
        {
            //Arrange
            IHomepage_DynamicControl page = null;
            string expectedButton = "Add";
            //Action
            string actualButton = page.PerformAddOpertion();
            //Assert
            Assert.That(actualButton, Is.EqualTo(expectedButton));

        }
        /// <summary>
        /// Verify the click remove action
        /// </summary>
        [Test]
        public void ClickRemove()
        {
            //Arrange
            IHomepage_DynamicControl page = null;
            string expectedButton = "Remove";
            //Action
            string actualButton = page.ClickRemoveButton();
            //Assert
            Assert.That(actualButton, Is.EqualTo(expectedButton));

        }

        /// <summary>
        /// Verify user is able to select check box
        /// </summary>

        [Test]
        public void SelectCheckbox()
        {
            //Arrange
            IHomepage_DynamicControl page = null;
            bool expectedCheckbok = true;
            //Action
            bool actualCheckbox= page.ClickonCheckbox();
            //Assert
            Assert.That(actualCheckbox, Is.EqualTo(expectedCheckbok));

        }

        /// <summary>
        /// Check whether user is able to click on Enable button
        /// </summary>

        [Test]
        public void ClickEnable()
        {
            //Arrange
            IHomepage_DynamicControl page = null;
            string expectedButton = "Enable";
            //Action
            string actualButton = page.ClickonEnableOption();
            //Assert
            Assert.That(actualButton, Is.EqualTo(expectedButton));

        }
        /// <summary>
        /// Verify whether user is able to click on disable button
        /// </summary>

        [Test]
        public void ClickDisable()
        {
            //Arrange
            IHomepage_DynamicControl page = null;
            string expectedButton = "Disable";
            //Action
            string actualButton = page.ClickonDisableOption();
            //Assert
            Assert.That(actualButton, Is.EqualTo(expectedButton));

        }


    }
}
