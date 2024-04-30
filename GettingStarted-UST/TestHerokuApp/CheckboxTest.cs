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
        /// <summary>
        /// Method to click the CheckBox link
        /// </summary>
        public void validateCheckBoxLinkClick()
        {
            chk.clickCheckBoxLink();
        }
        [Test]
        /// <summary>
        /// Method to check the title of CheckBox page
        /// </summary>
        public void validateTitleOfCheckBoxPage()
        {
            chk.titleOfCheckBoxPage();
        }
        [Test]
        /// <summary>
        /// Method to check the title of CheckBox page
        /// </summary>
        public void validateEnableDisableCheckBox1()
        {
            chk.enableDisableCheckBox1();
        }

    }
}


