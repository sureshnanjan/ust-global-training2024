using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;
using HerokuWebdriverImplemention;
using NUnit.Framework;

namespace TestHerokuApp
{
    [TestFixture]
    public class CheckboxTest
    { 
        ICheckboxes chk = new Checkbox();


        [Test]

        public void validateCheckBoxLinkClick()
        {
            chk.clickCheckBoxLink();
            chk.getTitle();

            /// <summary>
            /// Method to click the CheckBox link
            /// </summary>

        }
        [Test]
        public void validateTitleOfCheckBoxPage()
        {
            string expectedTitle = "Checkboxes";
            string actualTitle = chk.getTitle();
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
            /// <summary>
            /// Method to check the title of CheckBox page
            /// </summary>
        }
        [Test]
        public void validateEnablingCheckBox1()
        {
            chk.EnableCheckBox1();
            /// <summary>
            /// Method to check Checkbox 1
            /// </summary>
        }

    }
}


