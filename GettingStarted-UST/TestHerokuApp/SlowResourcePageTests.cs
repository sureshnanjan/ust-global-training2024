using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;
using HerokuWebdriverImplemention;
using NUnit.Framework;

namespace TestHerokuApp
{
    [TestFixture]
    public class SlowResourcePageTests
    {
        /// <summary>
        /// Validate the Title of the Slow Resource Page
        /// </summary>
        [Test]
        public void verifySlowResourcePageTitle()
        {
            ISlowResourcePage source = new SlowResourcesPage();
            string expectedTitle = "Slow Resources";
            string actualTitle = source.getTitle();
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
            source.closeBrowser();
        }
    }
}