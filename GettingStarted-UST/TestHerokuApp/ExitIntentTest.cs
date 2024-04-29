using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;
using HerokuWebdriverImplemention;

namespace TestHerokuApp
{
    /// <summary>
    /// Test cases to verify the ExitIntent features
    /// </summary>
    [TestFixture]
    public class ExitIntentTest
    {
        /// <summary>
        /// Test case to verify the Page Title 
        /// </summary>
        [Test]
        public void verifyPageTitle()
        {
            IHomePage page = new HomePage();
            IExitIntent mw = (ExitIntentPage)page.goToExample("ExitIntent");
            string expectedTitle = "Exit Intent";
            string actualTitle = mw.GetTitle();
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
            mw.CloseBrowser();
        }

        /// <summary>
        /// Test case to verify the OPen and Close of Modal window 
        /// </summary>
        [Test]
        public void verifyAndCloseModalWindow() {
            IHomePage page = new HomePage();
            IExitIntent mw = (ExitIntentPage)page.goToExample("ExitIntent");
            string expectedTitle = "THIS IS A MODAL WINDOW";
            mw.moustOutOfView();
            bool mwStatus = mw.getModalWindowStatus();
            string actualTitle = mw.getModalWIndowTitle();
            Assert.That(mwStatus, Is.True);
            Assert.That(actualTitle,Is.EqualTo(expectedTitle));
            mw.closeModalWindow();
            mw.CloseBrowser();
        }
    }
}
