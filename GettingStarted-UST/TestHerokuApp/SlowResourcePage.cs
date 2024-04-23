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
    internal class SlowResourcePage
    {
        /// <summary>
        /// Validate the Title of the Slow Resource Page
        /// </summary>
        [Test]
        public void verifySlowResourcePageTitle()
        {
            string expectedTitle = "Slow Resources";
            ISlowResourcePage source = null;
            string actualTitle = source.getTitle();
            Assert.Equals(expectedTitle, actualTitle);
        }
    }
}
