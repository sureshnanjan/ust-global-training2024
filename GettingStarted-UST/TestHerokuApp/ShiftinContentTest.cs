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
        public void validateShiftingContentLinkClick()
        {
            obj.clickShiftingContentLink();
        }

        [Test]
        public void validateTitleOfShiftingContentPage()
        {
            obj.titleOfShiftingContentPage();
        }

        [Test]
        public void validateClickHereLinkInShiftContentMenuElement()
        {
            obj.clickShiftingContentLink();
            obj.CheckLinksOfMenuLink();
        }

        [Test]
        public void validateGoToHomeFromMenuElement()
        {
            obj.clickShiftingContentLink();
            obj.CheckLinksOfMenuLink();
            obj.clickHome();
        }

        [Test]
        public void validateContentOnShiftingContentList()
        {
            obj.clickShiftingContentLink();
            obj.ClickListlink_CheckTitleOfPage();
            obj.contentOnShiftingContentList();
        }

        [Test]
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
