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
    internal class HorizontalSliderPageTest
    {
        /// <summary>
        /// Validate the Title of Horizontal Slide Bar 
        /// </summary>
        [Test]
        public void verifyHorizontalSliderPageTitle()
        {
            string expectedTitle = "Horizontal Slider";
            IHorizontalSlider slider = null;
            string actualTitle = slider.getTitle();
            Assert.Equals(expectedTitle, actualTitle);
        }

        /// <summary>
        /// Verify Horizontal Sliding 
        /// </summary>
        [Test]
        public void verifyHorizontalSlider()
        {
            IHorizontalSlider slider = null;
            string expectedPosition = "3";
            slider.SlidetheBar(3);
            string currentPosition = slider.getSlidePosition();
            Assert.Equals(expectedPosition, currentPosition);
        }

        /// <summary>
        /// Verify the Minimum Position
        /// </summary>
        [Test]
        public void verifyMinimumPosition() {
            IHorizontalSlider slider = null;
            string expectedPosition = "0";
            slider.SlidetheBar(0);
            string currentPosition = slider.getSlidePosition();
            Assert.Equals(expectedPosition, currentPosition);
        }

        /// <summary>
        /// Verify the Maximum Position 
        /// </summary>
        [Test]
        public void verifyMaximumPosition() {
            IHorizontalSlider slider = null;
            string expectedPosition = "5";
            slider.SlidetheBar(5);
            string currentPosition = slider.getSlidePosition();
            Assert.Equals(expectedPosition, currentPosition);
        }

        /// <summary>
        /// Validate the content of Horizontal Slide Bar page
        /// </summary>
        [Test]
        public void verifyPageContent()
        {
            string expectedTitle = "Set the focus on the slider (by clicking on it) and use the arrow keys to move it right and left. Or click and drag the slider with your mouse. It will indicate the value of the slider to the right.";
            IHorizontalSlider slider = null;
            string actualTitle = slider.getScreenContent();
            Assert.Equals(expectedTitle, actualTitle);
        }

    }
}