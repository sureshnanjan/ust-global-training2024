using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialProgram;

namespace Test_InitialProgram
{
    [TestClass]
    public class TestBinarySearch
    {
        [TestMethod]

        public void TestForExistingValues()
        {
            int[] myinputArray = {1, 2, 3};
            int expected = 2;
            int searchItem = 2;
            BinarySearcher searcher = new BinarySearcher(myinputArray, searchItem);
            int actual = searcher.doSearch();
            Assert.AreEqual(expected, actual);
        }
    }
}
