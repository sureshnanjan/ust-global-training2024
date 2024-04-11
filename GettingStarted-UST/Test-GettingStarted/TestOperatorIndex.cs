using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GettingStarted_UST;

namespace Test_GettingStarted
{
    [TestClass]
    public class TestOperatorIndex
    {
        /// <summary>
        /// Testing values in an string array- Indexer overloading
        /// </summary>
        
        [TestMethod]
        public void testOperatorIndexerOverloadingFirstindex()
        {
            string[] name = new string[3];
            OperatorIndexer index = new OperatorIndexer();
            index[0] = "Apple";
            index[1] = "Orange";
            index[2] = "Grapes";
            string expected = index[0];
            string actual = index[0];
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void testOperatorIndexerOverloadingSecondindex()
        {
            string[] name = new string[3];
            OperatorIndexer index = new OperatorIndexer();
            index[0] = "Apple";
            index[1] = "Orange";
            index[2] = "Grapes";
            string expected = index[1];
            string actual = index[1];
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void testOperatorIndexerOverloadingLastindex()
        {
            string[] name = new string[3];
            OperatorIndexer index = new OperatorIndexer();
            index[0] = "Apple";
            index[1] = "Orange";
            index[2] = "Grapes";
            string expected = index[2];
            string actual = index[2];
            Assert.AreEqual(expected, actual);

        }

    }
}
