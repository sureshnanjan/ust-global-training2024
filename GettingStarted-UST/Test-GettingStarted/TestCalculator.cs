using GettingStarted_UST;

namespace Test_GettingStarted
{
    [TestClass]
    public class TestCalculator
    {
        /// <summary>
        /// Addition of numbers  10 and 20
        /// </summary>
        [TestMethod]
        public void additionValueshouldbe30()
        {
            Calculator calculator = new Calculator();
            int expected = 30;
            int actual = calculator.add(10, 20);
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Addition of  numbers 10000 and 20000
        /// </summary>

        [TestMethod]
        public void additionValueshouldbe300000()
        {
            Calculator calculator = new Calculator();
            int expected = 30000;
            int actual = calculator.add(10000, 20000);
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Substraction of 10 and 8
        /// </summary>

        [TestMethod]
        public void subtracting10and8shouldbe2()
        {
            Calculator calculator = new Calculator();
            int expected = 2;
            int actual = calculator.subtract(10, 8);
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Substracting 0 and 2
        /// </summary>

        [TestMethod]
        public void subtracting0and2shouldbeminus2()
        {
            Calculator calculator = new Calculator();
            int expected = -2;
            int actual = calculator.subtract(0, 2);
            Assert.AreEqual(expected, actual);
        }
    }
}