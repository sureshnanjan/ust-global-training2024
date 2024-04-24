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
    internal class SlowResourcePageTests
    {
        /// <summary>
        /// Validate the Title of the Slow Resource Page
        /// </summary>
        [Test]
        public void verifySlowResourcePageTitle()
        {
            string expectedTitle = "Slow Resources";
            ISlowResourcePage source = new SlowResourcesPage();
            string actualTitle = source.getTitle();
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
        }
    }
}