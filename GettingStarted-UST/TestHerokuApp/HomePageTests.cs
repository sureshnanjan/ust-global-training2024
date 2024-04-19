using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;
using HerokuWebdriverImplemention;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using OpenQA.Selenium.Chromium;
using OpenQA.Selenium.DevTools;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.VirtualAuth;
using OpenQA.Selenium;
using System.Security.Cryptography;
namespace TestHerokuApp
{
    /// <summary>
    /// Perform Tests in HomePage
    /// </summary>
    [TestFixture]
    public class HomePageTests
    {
        /// <summary>
        /// </summary>
        [Test]
            // Arrange
            IHomePage page = new HomePage();
            // page.goToExample*().AddElement().CheckIfDisplayed()
            string expectedTitle = "Welcome to the-internet";
            // A
            // A
                
        }

        /// <summary>
        /// Verify Subtitle of HomePage
        /// </summary>
        [Test]
            string expectedSubTitle = "Available Examples";
            // A
            // A
        }

        /// <summary>
        /// Verify HomePage has 44 links available
        /// </summary>
        [Test]
            int expectedCount = 44;
            Assert.That(actual, Is.EqualTo(expectedCount));
        }

        {
            IHomePage page = null;
            string itemToTest = "ENABLED-Download-Pdf";
            bool expectedTitle = true;
            //bool actual = page.GetStatus(itemToTest);
            //Assert.That(actualTitle, Is.EqualTo(expectedTitle));


        }

        [Test]
        public void addRemoveElementPageObjectImplementationworks() {
            IHomePage page = new HomePage();
    }

        {
    
        };

}
}
