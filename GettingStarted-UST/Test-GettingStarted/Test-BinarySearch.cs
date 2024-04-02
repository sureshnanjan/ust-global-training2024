using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GettingStarted_UST;

namespace Test_GettingStarted
{
    [TestClass]
    public class Test_BinarySearch
    {

        [TestMethod]
        public void test_for_existing_element_beginning()
        {

            int[] Search_Array = { 4, 5, 6 };
            int Search_Element = 4;
            int expected = 1;
            BinarySearch mysearch = new BinarySearch(Search_Array, Search_Element);
            int actual = mysearch.dosearch();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void test_for_existing_element_middle()
        {

            int[] Search_Array = { 4, 5, 6 };
            int Search_Element = 5;
            int expected = 2;
            BinarySearch mysearch = new BinarySearch(Search_Array, Search_Element);
            int actual = mysearch.dosearch();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void test_for_existing_element_end()
        {

            int[] Search_Array = { 4, 5, 6 };
            int Search_Element = 6;
            int expected = 3;
            BinarySearch mysearch = new BinarySearch(Search_Array, Search_Element);
            int actual = mysearch.dosearch();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void test_for_nonexisting_element()
        {

            int[] Search_Array = { 4, 5, 6 };
            int Search_Element = 2;
            int expected = ~1;
            BinarySearch mysearch = new BinarySearch(Search_Array, Search_Element);
            int actual = mysearch.dosearch();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void test_for_nonexisting_element_less_than()
        {

            int[] Search_Array = { 4, 5, 6 };
            int Search_Element = 2;
            int expected = ~1;
            BinarySearch mysearch = new BinarySearch(Search_Array, Search_Element);
            int actual = mysearch.dosearch();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void test_for_nonexisting_element_greater_than()
        {

            int[] Search_Array = { 4, 5, 6 };
            int Search_Element = 7;
            int expected = ~(3+1);
            BinarySearch mysearch = new BinarySearch(Search_Array, Search_Element);
            int actual = mysearch.dosearch();

            Assert.AreEqual(expected, actual);
        }

    }
}
