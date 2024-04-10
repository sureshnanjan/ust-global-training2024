// Test Binary Search Assignment
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Xml.Linq;


namespace Test_GettingStarted
{
    /// <summary>
    /// Binary Search Test cases 
    /// </summary>
    
    [TestClass]
    public class TestBinarySearch
    {
        //Test case for search value in the end 
        [TestMethod]
        public void ExistingValueTest_Atend()
        {

            int[] myinputArray = { 1, 2, 3,4,5 };
            int searchItem = 5;
            int expected = 5;
            BinarySearcher searcher = new BinarySearcher(myinputArray, searchItem);
            int actual = searcher.doSearch();
            Assert.AreEqual(expected, actual);
        }

        //Test case for search value in the middle 
        [TestMethod]
        public void ExistingValueTest_Atmiddle()
        {

            int[] myinputArray = { 1, 2, 3 };
            int searchItem = 2;
            int expected = 2;
            BinarySearcher searcher = new BinarySearcher(myinputArray, searchItem);
            int actual = searcher.doSearch();
            Assert.AreEqual(expected, actual);
        }

        //Test case for search value in the beginning 
        [TestMethod]
        public void ExistingValueTest_Atbeginning()
        {
            int[] myinputArray = { 1, 2, 3 };
            int searchItem = 1;
            int expected = 1;
            BinarySearcher searcher = new BinarySearcher(myinputArray, searchItem);
            int actual = searcher.doSearch();

            Assert.AreEqual(expected, actual);

        }

        //Test case for non available search value in the array which the highest of all
        [TestMethod]
        public void NonExistingValueTest_higherval()
        {
            int[] myinputArray = { 1, 2, 3 };
            int searchItem = 4;
            int expected = ~4;
            BinarySearcher searcher = new BinarySearcher(myinputArray, searchItem);
            int actual = searcher.doSearch();
            Assert.AreEqual(expected, actual);

        }

        //Test case for non available search value in the array which the lowest of all 
        [TestMethod]
        public void NonExistingValueTest_lowerval()
        {

            // If value is not found and value is less than one or more elements in array, the negative number returned is the
            // bitwise complement of the index of the first element that is larger than value. 
            int[] myinputArray = { 1, 2, 3 };
            int searchItem = 0;
            int expected = ~1;
            BinarySearcher searcher = new BinarySearcher(myinputArray, searchItem);
            int actual = searcher.doSearch();
            Assert.AreEqual(expected, actual);

        }

        //Test case for non available search value in the array which has both greater and lesser values in array
        [TestMethod]
        public void NonExistingValueTest_middleval()
        {

            // If value is not found and value is less than one or more elements in array, the negative number returned is the
            // bitwise complement of the index of the first element that is larger than value. 
            int[] myinputArray = { 2, 6, 9 };
            int searchItem = 4;
            int expected = ~2;
            BinarySearcher searcher = new BinarySearcher(myinputArray, searchItem);
            int actual = searcher.doSearch();
            Assert.AreEqual(expected, actual);

        }

        // Test case for non sorted array and unavailable item
        [TestMethod]
        public void NonSortedArray_NonExistentValueTest()
        {
            //Value less than non sorted array minimum value 
            int[] myinputArray = { 1, 7, 3 };
            int searchItem = 0;
            //int expected = ~1;
            BinarySearcher searcher = new BinarySearcher(myinputArray, searchItem);
            int actual = searcher.doSearch();
            //Assert.AreEqual(expected, actual);
            Assert.IsTrue(actual < 0);

            //Value greated than non sorted array maximum value
            searchItem = 9;
            actual = searcher.doSearch();
            Assert.IsTrue(actual < 0);
        }

        // Test case for non sorted array and available item 
        [TestMethod]
        public void NonSortedArray_ExistentValueTest()
        {

            // If value is not found and value is less than one or more elements in array, the negative number returned is the
            // bitwise complement of the index of the first element that is larger than value. 
            int[] myinputArray = { 1, 7, 3 };
            int searchItem = 7;
            //int expected = ~1;
            BinarySearcher searcher = new BinarySearcher(myinputArray, searchItem);
            int actual = searcher.doSearch();
            //Assert.AreEqual(expected, actual);
            Assert.IsTrue(actual < 0);
        }

        // Test case for Null Input Array throws ArgumentNullException
        [TestMethod]
        public void NullInputArray_Throws_ArgumentNullException()
        {
            //ArgumentNullException array is null.
            int[] input = null;
            int searchItem = 0;
            BinarySearcher searcher = new BinarySearcher(input, searchItem);
            Assert.ThrowsException<ArgumentNullException>(() => searcher.doSearch());
        }

    }
}