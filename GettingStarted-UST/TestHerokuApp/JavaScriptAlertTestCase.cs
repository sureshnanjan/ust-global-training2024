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
    /// <summary>
    /// Test class to verify the Java Script Alert functionality
    /// </summary>
    [TestFixture]
    internal class JavascriptAlertsTestCase
    {
        /// <summary>
        /// Test method to execute the title verification of the javascript alert page
        /// </summary>
        [Test]
        public void JavascriptAlertTitleverify()
        {
            IHomePage page = new HomePage();
            IJavascriptAlert jsAlert = (JavaScriptAlertPage)page.goToExample("JavaScriptAlert");
            string expectedTitle = "JavaScript Alerts";
            string actualTitle = jsAlert.GetTitle();
            Assert.That(expectedTitle, Is.EqualTo(actualTitle));
            jsAlert.CloseBrowser();
        }

        /// <summary>
        /// Test method to execute the button click of the javascript alert page
        /// </summary>
        [Test]
        public void JavascriptAlertClickOperationVerify()
        {
            IHomePage page = new HomePage();
            IJavascriptAlert jsAlert = (JavaScriptAlertPage)page.goToExample("JavaScriptAlert");
            string expectedResult = "You successfully clicked an alert";
            jsAlert.ClickAndAcceptJSAlert();
            string actualResult = jsAlert.getResult();
            Assert.That(expectedResult, Is.EqualTo(actualResult));
            jsAlert.CloseBrowser();
        }
        /// <summary>
        /// Test method to execute the results in the javascript accept operation
        /// </summary>
        [Test]
        public void JavaScriptConfirmOperationVerify()
        {
            IHomePage page = new HomePage();
            IJavascriptAlert jsAlert = (JavaScriptAlertPage)page.goToExample("JavaScriptAlert");
            string expectedResult = "You clicked: Ok";
            jsAlert.ClickAndAcceptJSConfirm();
            string actualResult = jsAlert.getResult();
            Assert.That(expectedResult, Is.EqualTo(actualResult));
            jsAlert.CloseBrowser();
        }
        /// <summary>
        /// Test method to execute the results in the javascript dismiss operation
        /// </summary>
        [Test]
        public void verifyJavaScriptRejectOperation()
        {
            IHomePage page = new HomePage();
            IJavascriptAlert jsAlert = (JavaScriptAlertPage)page.goToExample("JavaScriptAlert");
            string expectedResult = "You clicked: Cancel";
            jsAlert.ClickAndCancelJSConfirm();
            string actualResult = jsAlert.getResult();
            Assert.That(expectedResult, Is.EqualTo(actualResult));
            jsAlert.CloseBrowser();
        }
        /// <summary>
        /// Test method to execute the results in the javascript prompt entry
        /// </summary>
        [Test]
        public void JavaScriptPromptOperationVerify()
        {
            IHomePage page = new HomePage();
            IJavascriptAlert jsAlert = (JavaScriptAlertPage)page.goToExample("JavaScriptAlert");
            string expectedResult = "You entered: Sample Prompt";
            jsAlert.ClickJSPromt("Sample Prompt");
            string actualResult = jsAlert.getResult();
            Assert.That(expectedResult, Is.EqualTo(actualResult));
            jsAlert.CloseBrowser();
        }
    }
}
