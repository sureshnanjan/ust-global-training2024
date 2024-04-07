using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GettingStarted_UST;

namespace Test_GettingStarted
{
    /// <summary>
    /// Test class for sorted array
    /// </summary>
    [TestClass]
    public class Test_SortedArray
    {
        /// <summary>
        /// Test method for already Sorted Array
        /// </summary>
        [TestMethod]
        public void SortingForAlreadySortedArray()
        {
            SimpleClass instanceOne = new SimpleClass(1, 0);
            SimpleClass instanceTwo = new SimpleClass(1, 2);
            SimpleClass[] actual = { instanceOne, instanceTwo };
            Array.Sort(actual);
            SimpleClass[] expected = { instanceOne, instanceTwo };
            CollectionAssert.AreEqual(actual, expected);

            /*SimpleClass[] actual = { new SimpleClass(1, 0), new SimpleClass(1, 2) };
            SimpleClass[] expected = { new SimpleClass(1, 0), new SimpleClass(1, 2) };
            Array.Sort(actual);
            Assert.AreEqual(expected, actual);*/
        }

        /// <summary>
        /// Test method for sorting based on first element
        /// </summary>
        [TestMethod]
        public void SortingBasedOnFirstElement()
        {
            SimpleClass instanceOne = new SimpleClass(1, 0);
            SimpleClass instanceTwo = new SimpleClass(0, 2);
            SimpleClass[] actual = { instanceOne, instanceTwo };
            Array.Sort(actual);
            SimpleClass[] expected = { instanceTwo, instanceOne };
            CollectionAssert.AreEqual(actual, expected);
        }

        /// <summary>
        /// Test method if first elements are equal, sorting based on second element
        /// </summary>
        public void SortingBasedOnSecondElement()
        {
            SimpleClass instanceOne = new SimpleClass(2, 2);
            SimpleClass instanceTwo = new SimpleClass(2, 1);
            SimpleClass[] actual = { instanceOne, instanceTwo };
            Array.Sort(actual);
            SimpleClass[] expected = { instanceTwo, instanceOne };
            CollectionAssert.AreEqual(actual, expected);
        }

        /// <summary>
        /// Test method for sorting when 2 instances are same
        /// </summary>
        [TestMethod]
        public void SortingWhen2instancesAreSame()
        {
            SimpleClass instanceOne = new SimpleClass(2, 2);
            SimpleClass instanceTwo = new SimpleClass(2, 2);
            SimpleClass[] actual = { instanceOne, instanceTwo };
            Array.Sort(actual);
            SimpleClass[] expected = { instanceOne, instanceTwo };
            CollectionAssert.AreEqual(actual, expected);
        }

        /// <summary>
        /// Test method of ToString method that should return in the format item1 - item
        /// </summary>
        [TestMethod]
        public void FormatOfOutputAfterSorting()
        {
            SimpleClass instance = new SimpleClass(1, 2);
            string expected = "1-2";
            string actual = instance.ToString();
            Assert.AreEqual(actual, expected);
        }

    }
}
