using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Xml.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq.Expressions;


namespace Test_GettingStarted
{
    /// <summary>
    /// Binary Search Test cases 
    /// </summary>
    [TestClass]
    public  class TestBinarySearch
    {
        [TestMethod]
        //Test case for search value in the end 
        public void test_for_existing_values_inend() { 
        
            int[] myinputArray =  { 1, 2, 3 };
            int searchTerm = 3;
            int expected = 3;
            BinarySearcher searcher = new BinarySearcher(myinputArray, searchTerm);
            int actual = searcher.doSearch();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        //Test case for search value in the middle 
        public void test_for_existing_values_inmiddle()
        {

            int[] myinputArray = { 1, 2, 3 };
            int searchTerm = 2;
            int expected = 2;
            BinarySearcher searcher = new BinarySearcher(myinputArray, searchTerm);
            int actual = searcher.doSearch();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        //Test case for search value in the beginning 
        public void test_for_existing_values_inbeginning() {
            int[] myinputArray = { 1, 2, 3 };
            int searchTerm = 1;
            int expected = 1;
            BinarySearcher searcher = new BinarySearcher(myinputArray, searchTerm);
            int actual = searcher.doSearch();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        //Test case for non available search value in the array
        public void test_for_non_existing_items_higher() {
            int[] myinputArray = { 1, 2, 3 };
            int searchTerm = 4;
            int expected = ~4;
            BinarySearcher searcher = new BinarySearcher(myinputArray, searchTerm);
            int actual = searcher.doSearch();
            Assert.AreEqual(expected, actual);

        }


        [TestMethod]
        //Test case for non available search value in the array which the lowest of all  
        public void testing_non_existent_item_lower() {

            // If value is not found and value is less than one or more elements in array, the negative number returned is the
            // bitwise complement of the index of the first element that is larger than value. 
            int[] myinputArray = { 1, 2, 3 };
            int searchTerm = 0;
            int expected = ~1;
            BinarySearcher searcher = new BinarySearcher(myinputArray, searchTerm);
            int actual = searcher.doSearch();
            Assert.AreEqual(expected, actual);

        }
        
        [TestMethod]
        //Test case for non available search value in the array which has both greater and lesser values in array 
        public void testing_non_existent_item_middle()
        {

            // If value is not found and value is less than one or more elements in array, the negative number returned is the
            // bitwise complement of the index of the first element that is larger than value. 
            int[] myinputArray = { 2, 6, 9 };
            int searchTerm = 4;
            int expected = ~2;
            BinarySearcher searcher = new BinarySearcher(myinputArray, searchTerm);
            int actual = searcher.doSearch();
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        // Test case for non sorted array and unavailable item 
        public void testing_nonsortedarray_non_existent_item()
        {
            //Value less than non sorted array minimum value 
            int[] myinputArray = { 1, 7, 3 };
            int searchTerm = 0;
            //int expected = ~1;
            BinarySearcher searcher = new BinarySearcher(myinputArray, searchTerm);
            int actual = searcher.doSearch();
            //Assert.AreEqual(expected, actual);
            Assert.IsTrue(actual<0);
            
            //Value greated than non sorted array maximum value
            searchTerm = 9;
            actual = searcher.doSearch();
            Assert.IsTrue(actual < 0);
        }
        [TestMethod]
        // Test case for non sorted array and available item 
        public void testing_nonsortedarray_existent_item()
        {

            // If value is not found and value is less than one or more elements in array, the negative number returned is the
            // bitwise complement of the index of the first element that is larger than value. 
            int[] myinputArray = { 1, 7, 3 };
            int searchTerm = 7;
            //int expected = ~1;
            BinarySearcher searcher = new BinarySearcher(myinputArray, searchTerm);
            int actual = searcher.doSearch();
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
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException),
         "An Empty Array is given and couldn't be processed ")]
        public void testing_nullarray_exception()
        {

            int[] myinputArray = null;
            int searchTerm = 7;
            int expected = 0;
            BinarySearcher searcher = new BinarySearcher(myinputArray, searchTerm);
            int actual = searcher.doSearch();
            
        }
        // Test case for Multi Dimentional array
        [TestMethod]
        [ExpectedException(typeof(RankException),
         "Multi dimensional Array is given and couldn't be processed ")]
        public void testing_MultiDimArray_exception()
        {
            int[,] myinputArray ={ { 1, 2, 3, 4 },{ 1,3,4,6} };
            int searchTerm = 7;
            BinarySearcher searcher = new BinarySearcher(myinputArray, searchTerm);
        }

        // Test case for non int type array
        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
         "Incorrect value type given in Array to search and couldn't be processed ")]
        public void testing_IncorrectTypeArray_exception()
        {
            int[] myinputArray = { 1, 5, 4 };
            float searchTerm = 7.5f;
            BinarySearcher searcher = new BinarySearcher(myinputArray, searchTerm);
        }

        // Test case for non int type array -InvalidOperationException value does not implement comparison mechanism.
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException),
         "Incorrect method is called and couldn't be processed ")]
        public void testing_InvalidImplementation_exception()
        {
            int[] myinputArray = { 2, 6, 9 };
            int searchTerm = 4;
            BinarySearcher searcher = new BinarySearcher(myinputArray, searchTerm);
            int actual = searcher.doSearchandCompare();
            
        }
    }
}
