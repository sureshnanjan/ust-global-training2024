using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestHerokuApp
{
    [TestClass]
    public class TyposPageTest
    {
        ITypos typo = null;
        /// <summary>
        /// this method is used to get the title of the page and validate it it matches the expected title
        /// </summary>         
        [TestMethod]
        public void validatePageTitle()
        {
            String expectedTitle = "Test";
            String actualTitle;
            actualTitle = typo.getTitle();
            Assert.AreEqual(expectedTitle, actualTitle);
        }

        /// <summary>
        /// this method is used to get the message displayed on the page and validate it it matches the expected message
        /// </summary>         
        [TestMethod]
        public void validatePageContent()
        {
            String expectedContent = "Test";
            String actualContent;
            actualContent = typo.pageContent();
            Assert.AreEqual(expectedContent, actualContent);
        }
    }
}
