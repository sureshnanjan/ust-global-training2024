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
            IHomepage_DynamicControl page = null;
            string expectedTitle = "Dynamic Controls";
            //Action
            string actualTitle = page.VerifyTitle();
            //Assert
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));

        }
    }
}
