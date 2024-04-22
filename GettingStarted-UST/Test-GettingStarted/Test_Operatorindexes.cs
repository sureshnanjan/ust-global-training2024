using GettingStarted_UST;

namespace Test_GettingStarted
{
    [TestClass]
    public class Test_Operatorindexes
    {
        /// <summary>
        /// Operatorindexer overloading
        /// </summary>
        [TestMethod]
        public void IndexerOperatorMiddle()
        {
           string[] name = new string[7];
            OperatorIndexer index = new OperatorIndexer();
            index[0] = "D";
            index[1] = "arf";
            index[2] = "asdf";
            string actual = index[1];
            string expected = index[1];
            Assert.AreEqual(expected, actual);

        }
        /// <summary>
        /// First value from index
        /// </summary>
        [TestMethod]
        public void IndexerFirstValue()
        {
            string[] name = new string[7];
            OperatorIndexer index = new OperatorIndexer();
            index[0] = "D";
            index[1] = "arf";
            index[2] = "asdf";
            string actual = index[0];
            string expected = index[0];
            Assert.AreEqual(expected, actual);

        }
        /// <summary>
        /// Second value from indexer
        /// </summary>
        [TestMethod]
        public void IndexerLastValue()
        {
            string[] name = new string[7];
            OperatorIndexer index = new OperatorIndexer();
            index[0] = "D";
            index[1] = "arf";
            index[2] = "asdf";
            string actual = index[2];
            string expected = index[2];
            Assert.AreEqual(expected, actual);

        }

    }
}
