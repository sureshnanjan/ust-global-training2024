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
    public class Test_JSOnloadEventError
    {
        /// <summary>
        /// Verify whether the page title is correct or not
        /// </summary>
        [Test]
        public void PageTitleverification()
        {
            //Arrange
<<<<<<< HEAD:GettingStarted-UST/TestHerokuApp/Test_EntryAd.cs
          //  IHomepage_DynamicControl Controls = null;
           // string expectedTitle = "Dynamic Controls";
          
            //Action
          //  string actualTitle = Controls.VerifyTitle(string name);
            //Assert

           // Assert.That(actualTitle, Is.EqualTo(expectedTitle));
=======
            IHomepage_DynamicControl page = null;
            string expectedTitle = "Dynamic Controls";
            //Action
            string actualTitle = page.VerifyTitle();
            //Assert
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
>>>>>>> origin/intermediate-branch:GettingStarted-UST/TestHerokuApp/Test_DynamicControls.cs

        }
    }
}
