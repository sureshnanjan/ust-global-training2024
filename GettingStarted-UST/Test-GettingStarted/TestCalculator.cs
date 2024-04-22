using GettingStarted_UST;

namespace Test_GettingStarted
{
    /// <summary>
    /// Test class for calculator
    /// </summary>
    [TestClass]
    public class TestCalculator
    {
        /// <summary>
        /// Addition of 10 and 20
        /// </summary>
        [TestMethod]
        public void Additionof10and20shouldbe30()
        {
            Calculator calculator = new Calculator();
            int expected = 30;
            int actual = calculator.Add(10, 20);
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Addition of 10000 and 20000
        /// </summary>

        /// <summary>
        /// Test method for addition of 100000 & 200000
        /// </summary>
        [TestMethod]
        public void Additionof100000and20000shouldbe300000()
        {
            Calculator calculator = new Calculator();
            int expected = 30000;
            int actual = calculator.Add(10000, 20000);
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Substraction of 10 and 8
        /// </summary>

        /// <summary>
        /// Test method for subtraction of 10 & 8
        /// </summary>
        [TestMethod]
        public void Subtracting10and8shouldbe2()
        {
            Calculator calculator = new Calculator();
            int expected = 2;
            int actual = calculator.Subtract(10,8);
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Substracting 0 and 2
        /// </summary>

        /// <summary>
        /// Test method for subtraction of 0 & 2
        /// </summary>
        [TestMethod]
        public void Subtracting0and2shouldbeminus2()
        {
            Calculator calculator = new Calculator();
            int expected = -2;
            int actual = calculator.Subtract(0, 2);
            Assert.AreEqual(expected, actual);
        }

    }
}