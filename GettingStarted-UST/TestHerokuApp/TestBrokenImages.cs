using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using HerokuAppOperations;
using HerokuWebdriverImplemention;

namespace TestHerokuApp
{
    [TestFixture]
    public class TestBrokenImages
    {
        [Test]
        public void checkImageOne() {
            IHomePage page = new HomePage();
            page.GoToHome();
            IBrokenImageOperations bpage = (IBrokenImageOperations)page.goToExample("BrokenImages");
            string expected = "img/";
            string actual = bpage.getImage1Details();
            Assert.That(expected, Is.SamePathOrUnder(actual));

        }

    }
}
