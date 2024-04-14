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
        public void verifyHorizontalSliderPageTitle() {
            string expectedTitle = "Horizontal Slider";
            IHorizontalSlider slider = null;
            string actualTitle = slider.getTitle();
            Assert.Equals(expectedTitle, actualTitle);

        }

        /// <summary>
        /// Verify Horizontal Slide Increment 
        /// </summary>
        [Test]
        public void verifyHorizontalSliderIncrement() {
            IHorizontalSlider slider = null;
            int 
        }

        [Test]
        public void verifyHorizontalSliderPageDecrement() { }
    }
}
