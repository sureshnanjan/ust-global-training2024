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
        /// Method to check the title of Shifting Content page
        /// </summary>
        public void validateTitleOfShiftingContentPage()
        {
            obj.titleOfShiftingContentPage();
        }

        [Test]
        /// <summary>
        /// Method to click second link in menu element page
        /// </summary>
        public void validateClickHereLinkInShiftContentMenuElement()
        {
            obj.clickShiftingContentLink();
            obj.CheckLinksOfMenuLink();
        }

        [Test]
        /// <summary>
        /// Method to click Home link in menu element page
        /// </summary>
        public void validateGoToHomeFromMenuElement()
        {
            obj.clickShiftingContentLink();
            obj.CheckLinksOfMenuLink();
            obj.clickHome();
        }

        [Test]
        /// <summary>
        /// Method to check the content of Shifting Content: List page
        /// </summary>
        public void validateContentOnShiftingContentList()
        {
            obj.clickShiftingContentLink();
            obj.ClickListlink_CheckTitleOfPage();
            obj.contentOnShiftingContentList();
        }

        [Test]
        /// <summary>
        /// Method to click the 3rd link "Example 3: List" and check title of its page
        /// </summary>
        public void validateClickingOfListLinkAndReadItsTitlesss()
        {
            obj.clickShiftingContentLink();
            obj.ClickListlink_CheckTitleOfPage();
        }
        [Test]
        public void validateClickOfImageLinkOpenLink()
        {
            obj.clickShiftingContentLink();
            obj.clickImagelink_ClickhereToShiftImage();
        }
    }
}
