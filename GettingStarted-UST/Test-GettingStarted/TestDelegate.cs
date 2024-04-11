using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GettingStarted_UST;

namespace Test_GettingStarted
{
    [TestClass]
    public class TestDelegate
    {
        /// <summary>
        /// comparing values in an array
        /// </summary>

        [TestMethod]
        public void testDelegateGreaterThan()
        {
            Func<int, bool> predicate = x => x > 3;
            int[] mynumbers = { 1, 2, 3, 4, 5 };
            List<int> expected =new List<int> { 4,5};
            List<int> actual = mynumbers.Where(param => param > 3).ToList();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void testDelegateLessThan()
        {
            Func<int, bool> predicate = x => x < 3;
            int[] myNumbers = { 1, 2,3,4,5 };
            List<int> expected = new List<int> { 1, 2 };
            List<int> actual = myNumbers.Where(param => param < 3).ToList();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void testDelegateEqualto()
        {
            Func<int, bool> predicate = x => x == 3;
            int[] myNumbers = { 1, 2, 3, 4, 5 };
            List<int> expected = new List<int> { 3 } ;
            List<int> actual = myNumbers.Where(param => param == 3).ToList();
            Assert.AreEqual(expected, actual);
        }

    }
}
