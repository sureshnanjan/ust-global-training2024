using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;
using NUnit.Framework;

namespace TestHerokuApp
{
    public class ChallengingDomTests
    {
        /// <summary>
        /// Verify whether the page title is correct or not
        /// </summary>
        /// [Test]
        public void PageTitleverification()
        {
            //Arrange
            IChallengingDomOperations page = null;
            string expectedTitle = "Challenging DOM";
            //Action
            string actualTitle = page.getTitle();
            //Assert
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
        }
    }
}
