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
    internal class ShiftinContentTest
    {
        IShiftingContent obj = new ShiftingContent();

        [Test]
        /// <summary>
        /// Method to click the ShiftingContent link
        /// </summary>
        public void validateShiftingContentLinkClick()
        {
            obj.clickShiftingContentLink();
        }

        [Test]
        /// <summary>
        /// Method to check the title of CheckBox page
        /// </summary>
        public void validateTitleOfShiftingContentPage()
        {
            obj.titleOfShiftingContentPage();
        }
    }
}
