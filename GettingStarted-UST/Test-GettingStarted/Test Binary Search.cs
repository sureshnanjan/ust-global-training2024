using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_GettingStarted
{
    [TestClass]
    public class Test_Binary_Search
    {
        private object searchterm;

        public void test_for_existing_values() 
        {
            int[] myinputArray = { 1, 2, 3 };
            int searchTerm = 3;
            int expected = 3;
            Binarysearcher searcher = new Binarysearcher(myinputArray, searchterm);
            int actual = searcher.dosearch;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void test_for_non_existing_values() 
        {
            int[] myinputArray = { 1, 2, 3 };
            int searchTerm = 4;
            int expected = ~4;
            Binarysearcher searcher = new Binarysearcher(myinputArray, searchterm);
            int actual = searcher.dosearch;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void non_existing_item()
        {
            int[] myinputArray = { 1, 2, 3 };
            int searchTerm = 0;
            int expected = ~1;
            Binarysearcher searcher = new Binarysearcher(myinputArray, searchterm);
            int actual = searcher.dosearch;
            Assert.AreEqual(expected, actual);
        }
    }
}
