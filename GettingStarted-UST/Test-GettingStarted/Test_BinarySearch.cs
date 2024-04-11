using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_GettingStarted
{
    [TestClass]
    public class Test_BinarySearch
    {
        /// <summary>
        /// Search for existing end values in an Array
        /// </summary>
        [TestMethod]
        public void test_for_existing_end_value()
        {
            int[] inPutArray = { 5, 6, 7 };
            int searchItem = 7;
            int expected = 7;
            BinarySearch mySearch = new BinarySearch(inPutArray, searchItem);
            int actual = mySearch.doSearch();
            Assert.AreEqual(expected, actual);

        }
        /// <summary>
        /// Search for existing values in the begining of an array
        /// </summary>
        [TestMethod]
        public void test_for_existingvalues_inbegining()
        {
            int[] inPutArray = { 5, 6, 7 };
            int searchItem = 5;
            int expected = 5;
            BinarySearch mySearch = new BinarySearch(inPutArray, searchItem);
            int actual = mySearch.doSearch();
            Assert.AreEqual(expected, actual);

        }
        /// <summary>
        ///If value is not found and value is greater than all elements in array, the negative number returned is the bitwise
        /// complement of (the index of the last element plus 1).
        /// </summary>
        [TestMethod]
        public void test_for_non_existing_items()
        {
            int[] inPutArray = { 5, 6, 7 };
            int searchItem = 8;
            int expected = ~(3+1);
            BinarySearch mySearch = new BinarySearch(inPutArray, searchItem);
            int actual = mySearch.doSearch();
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// If value is not found and value is less than one or more elements in array, the negative number returned is the bitwise
        /// complement of the index of the first element that is larger than value.
        /// </summary>
        [TestMethod]
        public void testing_non_existent_item()
        {
            int[] inPutArray = { 5, 6, 7 };
            int searchItem = 4;
            int expected = ~1;
            BinarySearch mySearch = new BinarySearch(inPutArray, searchItem);
            int actual = mySearch.doSearch();
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Search for an existing item in the middle of an array
        /// </summary>
        [TestMethod]
        public void testing_for_middle_existing_item()
        {
            int[] inPutArray = { 5, 6, 7 };
            int searchItem = 6;
            int expected = 6;
            BinarySearch mySearch = new BinarySearch(inPutArray, searchItem);
            int actual = mySearch.doSearch();
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Search for an existing item in an array
        /// </summary>
        [TestMethod]
        public void testing_for_existing_value()
        {
            int[] inPutArray = { 5, 6, 7, 9,3 };
            int searchItem = 9;
            int expected = 9;
            BinarySearch mySearch = new BinarySearch(inPutArray, searchItem);
            int actual = mySearch.doSearch();
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// NullException throws argument exceptions
        /// </summary>
        [TestMethod]
        public void nullInputArray_throws_ArgumentNullException()
        {
            int[] inputArray = null;
            int searchItem = 0;
            BinarySearch mySearch = new BinarySearch(inputArray, searchItem);
            Assert.ThrowsException<ArgumentNullException>(() => { mySearch.doSearch(); });

        }

    }
}
