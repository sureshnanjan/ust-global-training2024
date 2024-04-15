﻿using HerokuAppOperations;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using System.Security.Cryptography;
namespace TestHerokuApp
{
    [TestFixture]
    public class HomePageTests
    {
        /// <summary>
        /// Title - Homepage verification
        /// </summary>
        [Test]
        public void homePageTitleisCorrect() {
            // Arrange
            IHomePage page = null;
            string expectedTitle = "Welcome to the-internet";
            // A
            string actualTitle = page.getTitle();
            // A
            Assert.That(actualTitle, Is.EqualTo(expectedTitle)); // NUNIT
                
        }
        /// <summary>
        /// Subtitle Verification
        /// </summary>
        [Test]
        public void homePageSubTitleisCorrect() {
            IHomePage page = null;
            string expectedSubTitle = "Available Examples";
            // A
            string actualTitle = page.getSubTitle();
            // A
            Assert.That(actualTitle, Is.EqualTo(expectedSubTitle)); // NUNIT
        }
        /// <summary>
        /// Multiple links - Single Method
        /// </summary>
        [Test]
        public void homePageHas44Links() {
            IHomePage page = null;
            int expectedCount = 44;
            int actual = page.getAvailableExamples().Length;
            Assert.That(actual, Is.EqualTo(expectedCount));
        }

        [Test]
        public void visintingAExamplePageWorks() {
            IHomePage page = null;
            string pagetovisit = "A/B Testing";
            string expectedTitle = "A/B Test Variation 1";
            page.goToExample(pagetovisit);
            string actualTitle = page.getTitle();
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
        }
        /// <summary>
        /// Multiple Link - Parametrization
        /// </summary>
                
            [TestCaseSource(typeof(MyDataClass), nameof(MyDataClass.TestCases))]
            public void MultipleLinksselectionusingSingleTest(string pagetovisit, string expectedtitle)
            {
                IHomePage page = null;
                //string pagetovisit = "A/B Testing";
                string expectedTitle = "A/B Test Variation 1";
                page.goToExample(pagetovisit);
                string actualTitle = page.getTitle();
                Assert.That(actualTitle, Is.EqualTo(expectedTitle));
            }
        /// <summary>
        /// 
        /// </summary>



    }
}