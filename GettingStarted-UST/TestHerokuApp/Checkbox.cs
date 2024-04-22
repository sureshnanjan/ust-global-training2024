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
    internal class Checkbox
    {
        [Test]
        
        public void validateTitleOfCheckBoxPage()
        {

            /// <summary>
            /// Check the title of the page
            /// </summary>

            ICheckboxes obj = null;
            string expectedTitle = "Checkboxes";
            string actualTitle = obj.getTitle();
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
        }

        

    }

}
