﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Test_GettingStarted
{
    [TestClass]
    public  class TestBinarySearch
    {
        [TestMethod]
        public void test_for_existing_values() { 
        
            int[] myinputArray =  { 1, 2, 3 };
            int searchTerm = 3;
            int expected = 3;
            BinarySearcher searcher = new BinarySearcher(myinputArray, searchTerm);
            int actual = searcher.doSearch();
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void test_for_existing_values_inbeginning() { }

        [TestMethod]
        public void test_for_non_existing_items() {
            int[] myinputArray = { 1, 2, 3 };
            int searchTerm = 4;
            int expected = ~4;
            BinarySearcher searcher = new BinarySearcher(myinputArray, searchTerm);
            int actual = searcher.doSearch();
            Assert.AreEqual(expected, actual);

        }


        [TestMethod]
        public void testing_non_existent_item() {

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
        /// 
        /// </summary>
        public void nullinputarray_throws_ArgumentNullException() {
            int[] input = null;
            int searchTerm = 0;
            BinarySearcher searcher = new BinarySearcher(input, searchTerm);

            Assert.ThrowsException<ArgumentNullException>(() => { searcher.doSearch(); });
            


        }

        public void someroutine() {
        // assert color
        // assert position
        // assert font
        
        }
    }
}
