using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Xml.Linq;

namespace Test_GettingStarted
{
    [TestClass]
    public class TestBinarySearch
    {
        [TestMethod]
        public void test_for_existing_values_atend()
        {

            int[] myinputArray = { 1, 2, 3 };
            int searchTerm = 3;
            int expected = 3;
            BinarySearcher searcher = new BinarySearcher(myinputArray, searchTerm);
            int actual = searcher.doSearch();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void test_for_existing_values_atmiddle()
        {

            int[] myinputArray = { 1, 2, 3 };
            int searchTerm = 2;
            int expected = 2;
            BinarySearcher searcher = new BinarySearcher(myinputArray, searchTerm);
            int actual = searcher.doSearch();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void test_for_existing_values_atbeginning()
        {
            int[] myinputArray = { 1, 2, 3 };
            int searchTerm = 1;
            int expected = 1;
            BinarySearcher searcher = new BinarySearcher(myinputArray, searchTerm);
            int actual = searcher.doSearch();

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void test_for_non_existing_items_higherval()
        {
            int[] myinputArray = { 1, 2, 3 };
            int searchTerm = 4;
            int expected = ~4;
            BinarySearcher searcher = new BinarySearcher(myinputArray, searchTerm);
            int actual = searcher.doSearch();
            Assert.AreEqual(expected, actual);

        }


        [TestMethod]
        public void testing_non_existent_item_lowerval()
        {

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
        public void testing_non_existent_item_middleval()
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
        public void testing_nonsortedarray_non_existent_item()
        {
            //Value less than non sorted array minimum value 
            int[] myinputArray = { 1, 7, 3 };
            int searchTerm = 0;
            //int expected = ~1;
            BinarySearcher searcher = new BinarySearcher(myinputArray, searchTerm);
            int actual = searcher.doSearch();
            //Assert.AreEqual(expected, actual);
            Assert.IsTrue(actual < 0);

            //Value greated than non sorted array maximum value
            searchTerm = 9;
            actual = searcher.doSearch();
            Assert.IsTrue(actual < 0);
        }
        [TestMethod]
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


    }
}