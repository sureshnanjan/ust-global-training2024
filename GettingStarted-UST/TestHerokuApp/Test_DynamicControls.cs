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
        /// Verify whether the page title is correct or not
        /// </summary>
        [Test]
        public void PageTitleverification()
        {
            //Arrange
            IHomepage_DynamicControl Controls = null;
            string expectedTitle = "Dynamic Controls";
          
            //Action
            string actualTitle = Controls.VerifyTitle(string name);
            //Assert

            Assert.That(actualTitle, Is.EqualTo(expectedTitle));

        }
    }
}
