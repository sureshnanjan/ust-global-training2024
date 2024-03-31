using GettingStarted_UST;

namespace Test_GettingStarted
{
    [TestClass]
    public class TestCalculator
    {
        [TestMethod]
        public void additionof10and20shouldbe30()
        {
            Calculator calculator = new Calculator();
            int expected = 30;
            int actual = calculator.add(10, 20);
            Assert.AreEqual(expected, actual);
            Console.WriteLine("Result 30 ddisplayed");
        }

        [TestMethod]
        public void additionof100000and20000shouldbe300000()
        {
            Calculator calculator = new Calculator();
            int expected = 30000;
            int actual = calculator.add(10000, 20000);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void subtracting10and8shouldbe2()
        {
            Calculator calculator = new Calculator();
            int expected = 2;
            int actual = calculator.subtract(10,8);
            Assert.AreEqual(expected, actual);
        }

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