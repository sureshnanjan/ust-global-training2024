using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Xml.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Test_GettingStarted
{
    /// <summary>
    /// Test cases for Binary Search
    /// </summary>
    [TestClass]
    public class TestBinarySearchOperation
    {

        [TestMethod]
        //Test case for search item at the beginning 
        public void test_for_existing_values_atthebeginning()
        {
            int[] myArray = { 1, 2, 3 };
            int searchTerm = 1;
            int expected = 1;
            BinarySearchOperation searcher = new BinarySearchOperation(myArray, searchTerm);
            int actual = searcher.perfSearch();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        //Test case for search item in the middle 
        public void test_for_existing_values_inthemiddle()
        {

            int[] myArray = { 1, 2, 3 };
            int searchTerm = 2;
            int expected = 2;
            BinarySearchOperation searcher = new BinarySearchOperation(myArray, searchTerm);
            int actual = searcher.perfSearch();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        //Test case for search item at the end 
        public void test_for_existing_values_atthenend()
        {

            int[] myArray = { 1, 2, 3 };
            int searchTerm = 3;
            int expected = 3;
            BinarySearchOperation searcher = new BinarySearchOperation(myArray, searchTerm);
            int actual = searcher.perfSearch();
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        //Test case for unavailable item in the array
        public void test_for_non_existing_items_higher()
        {
            int[] myArray = { 1, 2, 3 };
            int searchTerm = 4;
            int expected = ~4;
            BinarySearchOperation searcher = new BinarySearchOperation(myArray, searchTerm);
            int actual = searcher.perfSearch();
            Assert.AreEqual(expected, actual);

        }


        [TestMethod]
        //Test case for unavailable search item in the array which is lowest 
        public void testing_non_existent_item_lower()
        {

            // If value is not found and value is less than one or more elements in array, the negative number returned is the
            // bitwise complement of the index of the first element that is larger than value. 
            int[] myArray = { 1, 2, 3 };
            int searchTerm = 0;
            int expected = ~1;
            BinarySearchOperation searcher = new BinarySearchOperation(myArray, searchTerm);
            int actual = searcher.perfSearch();
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        //Test case for unavailable search item in the array which has both greater and lesser values in array 
        public void testing_non_existent_item_middlevalue()
        {

            // If value is not found and value is less than one or more elements in array, the negative number returned is the
            // bitwise complement of the index of the first element that is larger than value. 
            int[] myArray = { 2, 6, 9 };
            int searchTerm = 4;
            int expected = ~2;
            BinarySearchOperation searcher = new BinarySearchOperation(myArray, searchTerm);
            int actual = searcher.perfSearch();
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        // Test case for non sorted array and unavailable item 
        public void testing_nonsortedarray_non_existent_item()
        {
            //Value less than non sorted array minimum value 
            int[] myArray = { 1, 7, 3 };
            int searchTerm = 0;
            //int expected = ~1;
            BinarySearchOperation searcher = new BinarySearchOperation(myArray, searchTerm);
            int actual = searcher.perfSearch();
            //Assert.AreEqual(expected, actual);
            Assert.IsTrue(actual < 0);

            //Value greated than non sorted array maximum value
            searchTerm = 9;
            actual = searcher.perfSearch();
            Assert.IsTrue(actual < 0);
        }
        [TestMethod]
        // Test case for non sorted array and available item 
        public void testing_nonsortedarray_existent_item()
        {

            // If value is not found and value is less than one or more elements in array, the negative number returned is the
            // bitwise complement of the index of the first element that is larger than value. 
            int[] myArray = { 1, 7, 3 };
            int searchTerm = 7;
            //int expected = ~1;
            BinarySearchOperation searcher = new BinarySearchOperation(myArray, searchTerm);
            int actual = searcher.perfSearch();
            //Assert.AreEqual(expected, actual);
            Assert.IsTrue(actual < 0);
        }
        /*Exceptions
        ArgumentNullException array is null.
        RankException array is multidimensional.
        ArgumentException value is of a type that is not compatible with the elements of array.
        InvalidOperationException value does not implement comparison mechanism.
        */
        // Test case for null array

    }

}
