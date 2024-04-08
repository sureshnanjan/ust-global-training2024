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
    [TestClass]
    public class TestBinarySearch
    {
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
        /*Exceptions
        RankException array is multidimensional.
        ArgumentException value is of a type that is not compatible with the elements of array.
        InvalidOperationException value does not implement comparison mechanism.
        */
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