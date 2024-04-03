using System;
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
        public void test_for_existing_values_inbeginning() 
        {
            int[] myinputArray = { 1, 2, 3 };
            int searchTerm = 1;
            int expected = 1;
            BinarySearcher searcher = new BinarySearcher(myinputArray, searchTerm);
            int actual = searcher.doSearch();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void test_for_non_existing_items() {
            int[] myinputArray = { 1, 2, 3 };
            int searchTerm = 4;
            int expected = ~4;
            BinarySearcher searcher = new BinarySearcher(myinputArray, searchTerm);
            int actual = searcher.doSearch();
            Assert.AreEqual(expected, actual);

        }

        /*public void nullInputArray_arrgumentnullException()
        {
            int[] inptut = null;
            int searchTrem = 0;
            BinarySearcher searcher = new BinarySearcher(inptut, searchTrem);
            Assert.ThrowsException<ArgumentNullException>(() => { searcher.doSearch(); });

        }*/

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
    }
}
