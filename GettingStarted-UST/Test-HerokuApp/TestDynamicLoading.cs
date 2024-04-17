using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;
using NUnit.Framework;

namespace Test_HerokuApp
{
    /// <summary>
    /// Dynamic Loading Tests for HerokuApp
    /// </summary>
    [TestFixture]
    public class TestDynamicLoading
    {
        /// <summary>
        /// Test to Validate Title is Correct
        /// </summary>
        [Test]
        public void DynamicLoadingScreenTitleIsCorrect()
        {
            //Arrange
            IHomeScreen page = null;
            string expectedTitle = "Dynamically Loaded Page Elements";
            //Action
            string actualTitle = page.getTitle();
            //Assert
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));

        }

        /// <summary>
        /// Test to Validate Dynamic Loading Screen has 2 Links
        /// </summary>
        [Test]
        public void DynamicLoadingHas2ExampleLinks()
        {

        }

        /// <summary>
        /// Test to Validate Example1 and Example2 Links Works
        /// </summary>
        [Test]
        public void VisitingExample1AndExample2LinksWorks()
        {

        }

        /// <summary>
        /// Test to Validate Example1Screen Title is Correct 
        /// </summary>
        [Test]
        public void Exampl1LinkTitleIsCorrect()
        {

        }

        /// <summary>
        /// Test to Validate Example1Screen SubTitle is Correct 
        /// </summary>
        [Test]
        public void Example1LinkSubTitleIsCorrect()
        {

        }

        /// <summary>
        /// Test to Validate Example1Screen Clicking on the Start Button  
        /// </summary>
        [Test]
        public void Example1ClickStartButton()
        {

        }

        /// <summary>
        /// Test to Validate the Value displayed on Screen cliking on Start Button on Example1 Page
        /// </summary>
        [Test]
        public void Example1ValueGotOnStartButton()
        {

        }


        /// <summary>
        /// Test to Validate Example2Screen Title is Correct 
        /// </summary>
        [Test]
        public void Exampl2LinkTitleIsCorrect()
        {

        }

        /// <summary>
        /// Test to Validate Example2Screen SubTitle is Correct 
        /// </summary>
        [Test]
        public void Example2LinkSubTitleIsCorrect()
        {

        }

        /// <summary>
        /// Test to Validate Example2Screen Clicking on the Start Button  
        /// </summary>
        [Test]
        public void Example2ClickStartButton()
        {

        }

        /// <summary>
        /// Test to Validate the Value displayed on Screen cliking on Start Button on Example2 Page
        /// </summary>
        [Test]
        public void Example2ValueGotOnStartButton()
        {

        }
    }
}
