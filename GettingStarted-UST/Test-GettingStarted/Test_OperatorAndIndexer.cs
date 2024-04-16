using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GettingStarted_UST;

namespace Test_GettingStarted
{
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


    }
}
