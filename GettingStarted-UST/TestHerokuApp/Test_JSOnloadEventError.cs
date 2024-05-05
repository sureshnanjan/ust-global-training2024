using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;
using NUnit.Framework;

namespace TestHerokuApp
{
    [TestFixture]
    public class Test_JSOnloadEventErrors
    
    {

        /// <summary>
        /// Verify the JSOnloadEventErrors Page description
        /// </summary>
        [Test]
        public void verifyLoginPagedescription()
        {
            IJavaScriptonloadeventerror JSPage = null;
            String expectedDescription = "Javascript error";
            String actualDescription = JSPage.getTitle();
            Assert.Equals(expectedDescription, actualDescription);
            
        }
        /// <summary>
        ///  Verify the Page URL is correct
        /// </summary>

        [Test]
        public void VerifyPageUrl()
        {
            IJavaScriptonloadeventerror JSPage = null;
            String expectedUrl = @"https://the-internet.herokuapp.com/jqueryui/menu";
            String actualUrl = JSPage.getUrl();
            Assert.Equals(expectedUrl, actualUrl);


        }

        /// <summary>
        ///  Verify the On load event error
        /// </summary>
        [Test]
        public void VerifyOnloadError()
        {
            IJavaScriptonloadeventerror JSPage = null;
            String expectedloadError = "status of 404";
            String actualloadError = JSPage.getloadError();
            Assert.Equals(expectedloadError, actualloadError);

        }
       

    }
    }
