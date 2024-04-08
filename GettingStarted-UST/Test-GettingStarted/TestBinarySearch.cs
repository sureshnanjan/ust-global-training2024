using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_GettingStarted;


namespace Test_GettingStarted
{
    /// <summary>
    /// Contains unit tests for the BinarySearcher class, testing various scenarios.
    /// </summary>
    [TestClass]
    public  class TestBinarySearch
    {
        /// <summary>
        /// Tests binary search for an existing value in the array.
        /// </summary>
        [TestMethod]
        public void Test_for_existing_values() { 
        
            int[] myinputArray =  { 1, 2, 3 };
            int searchTerm = 3;
            int expected = 3;
            BinarySearcher searcher = new BinarySearcher(myinputArray, searchTerm);
            int actual = searcher.doSearch();
            Assert.AreEqual(expected, actual);

        }
        /// <summary>
        /// Tests binary search for an existing value at the beginning of the input array.
        /// </summary>
        [TestMethod]
        public void Test_for_existing_values_inbeginning() {
            int[] myinputArray = { 1,2, 3 };
            int searchItem = 1;
            int expected = 1;
            BinarySearcher searcher=new BinarySearcher(myinputArray,searchItem);
            int actual = searcher.doSearch();
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Tests binary search for an existing value in the middle of the input array.
        /// </summary>
        [TestMethod]
        public void Test_for_existing_values_inmiddle()
        {
            int[] myinputArray = { 1, 2, 3 };
            int searchItem = 2;
            int expected = 2;
            BinarySearcher searcher = new BinarySearcher(myinputArray, searchItem);
            int actual = searcher.doSearch();
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Tests binary search for an existing value at the end of the input array.
        /// </summary>
        [TestMethod]
        public void Test_for_existing_values_inend()
        {
            int[] myinputArray = { 1, 2, 3 };
            int searchItem = 3;
            int expected = 3;
            BinarySearcher searcher = new BinarySearcher(myinputArray, searchItem);
            int actual = searcher.doSearch();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests binary search for an non existing value in the input array.
        /// </summary>
        [TestMethod]
        public void Test_for_non_existing_items() {
            int[] myinputArray = { 1, 2, 3 };
            int searchTerm = 4;
            int expected = ~4;
            BinarySearcher searcher = new BinarySearcher(myinputArray, searchTerm);
            int actual = searcher.doSearch();
            Assert.AreEqual(expected, actual);

        }

        /// <summary>
        /// Tests binary search for an non existing value in the input array.
        /// </summary>
        [TestMethod]
        public void Testing_non_existent_item() {

            // If value is not found and value is less than one or more elements in array, the negative number returned is the
            // bitwise complement of the index of the first element that is larger than value. 
            int[] myinputArray = { 1, 2, 3 };
            int searchTerm = 0;
            int expected = ~1;
            BinarySearcher searcher = new BinarySearcher(myinputArray, searchTerm);
            int actual = searcher.doSearch();
            Assert.AreEqual(expected, actual);

        }

        /// <summary>
        /// Throws ArgumentNullException when the input array is null.
        /// </summary>
        public void nullinputarray_throws_ArgumentNullException() {
            int[] input = null;
            int searchTerm = 0;
            BinarySearcher searcher = new BinarySearcher(input, searchTerm);

            Assert.ThrowsException<ArgumentNullException>(() => { searcher.doSearch(); });
            

        }

    }
}


