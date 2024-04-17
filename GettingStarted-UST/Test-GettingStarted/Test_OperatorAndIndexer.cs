using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GettingStarted_UST;

namespace Test_GettingStarted
{
    /// <summary>
    /// Test class to verify Operator & Indexer Overloading
    /// </summary>
    [TestClass]
    public class Test_OperatorAndIndexer
    {
        /// <summary>
        /// To check Operator Overloading of Binary Operator "+"
        /// </summary>
        [TestMethod]
        public void OperatorAdditionIsCorrect()
        {
            OperatorOverloading Calcu1 = new OperatorOverloading(10);
            OperatorOverloading Calcu2 = new OperatorOverloading(20);
            var actual = Calcu1 + Calcu2;
            var expected = 30;
            Equals(expected, actual);
        }

        /// <summary>
        /// To check Operator Overloading of Unary Operator "-"
        /// </summary>
        [TestMethod]
        public void OperatorNegativeIsCorrect()
        {
            OperatorOverloading Calcu1 = new OperatorOverloading(10);
            var actual = -Calcu1;
            var expected = -10;
            Equals(expected, actual);
        }

        /// <summary>
        /// To check Indexer Overloading
        /// </summary>
        [TestMethod]
        public void ToCheckIndexOverloading()
        {
            IndexerOverloading OndexObj = new IndexerOverloading();
            OndexObj[0] = "Hi";
            OndexObj[1] = " Trainer";
            string actual = OndexObj[0] + OndexObj[1];
            string expected = "Hi Trainer";
            Equals(expected, actual);
        }
    }
}
