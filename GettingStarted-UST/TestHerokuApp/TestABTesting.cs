using HerokuAppOperations;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuWebdriverImplemention;

namespace TestHerokuApp
{
    [TestFixture]
    public class TestABTesting
    {
        [TearDown]
        public void afterTestcasedoThis() { }

        [SetUp]
        public void beforeSetUp() { }
        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void without_disabling_should_get_other_Title() {
            IABTestControl control = default;
            string actual = control.getTitle();
            Assert.That((Is.Equals(actual, "NO AB Test")));
        }

        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void disabling_should_get_other_noabtest()
        {
            // this, default, linq
            IABTestControl control = default;
            control.disableABTesting();
            string actual = control.getTitle();
            Assert.That(Is.Equals(actual, "NO AB Test"));
        }

        [Test]
        public void add1elements() {
            IAddRemoveOperations page = new AddRemovePage();


        }

        // Adding a single ements works
        // Adding multiple elements works
        // Deleting elements works
        // Deleting multiple elementss

    }
}
