using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;

namespace TestHerokuApp
{
    [TestFixture]
    public class Test_LargeAndDeepDom
    {

        /// <summary>
        /// To verify the URL of page is correct
        /// </summary>
        [Test]
        public void UrlOfPageIsCorrect()
        {
            ILargeandDeepDomPage page = null;
            string expectedUrl = "https://the-internet.herokuapp.com/large";
            string actualUrl = page.getURL();
            Assert.That(actualUrl, Is.EqualTo(expectedUrl));
        }
        /// <summary>
        /// Verify whether the page title is correct or not
        /// </summary>
        [Test]
        public void PageTitleverification()
        {
            //Arrange
            ILargeandDeepDomPage page = null;
            string expectedTitle = "Large & Deep DOM";
            //Action
            string actualTitle = page.getTitle();
            //Assert
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));

        }
        /// <summary>
        /// Verifying Nth Element
        /// </summary>
        [Test]
        public void NthElementIdentification()
        {
            //Arrange
            ILargeandDeepDomPage page = null;
            string expectedId = "10";
            //Action
            string actualID = page.AccessNthelement(10);
            //Assert
            Assert.That(actualID, Is.EqualTo(expectedId));

        }

    }
}
