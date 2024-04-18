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
    internal class InputsTests
    {
        /// <summary>
        /// Test for Verifying Page title
        /// </summary>
        [Test]
        public void verifyPageTitleandfield()
        {
            IInputsPage inputspage = null;
            String expectedTitle = "Inputs";
            String actualTitle = inputspage.getTitle();
            Assert.Equals(expectedTitle, actualTitle);
        }
        /// <summary>
        /// Test for Entering and Verifying the value
        /// </summary>
        [Test]
        public void EnterandVerifyvalue()
        {
            IInputsPage inputspage = null;
            int expectedValue = 135;
            int actualValue = inputspage.IncreaseValue();
            Assert.Equals(expectedValue, actualValue);
        }
        /// <summary>
        /// Test for Entering and Verifying the non integer value
        /// </summary>

        [Test]
        public void nonnumericvalue()
        {
            IInputsPage inputspage = null;
            String expectedValue = "";
            int actualValue = inputspage.IncreaseValue();
            Assert.Equals(Convert.ToInt32(expectedValue), actualValue);
        }

    }
}