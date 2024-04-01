using InitialProgram;

namespace Test_InitialProgram
{
    [TestClass]
    public class TestCalculator
    {
        [TestMethod]
        public void Additionof10and20shouldbe30()
        {
            Calculator calculator = new Calculator();
            int expected = 30;
            int actual = calculator.add(10, 20);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Additionof10000and20000shouldbe30000()
        {
            Calculator calculator = new Calculator();
            int expected = 30000;
            int actual = calculator.add(10000, 20000);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Subtracting10and8shouldbe2()
        {
            Calculator caluclator = new Calculator();
            int expected = 2;
            int actual = caluclator.subtract(10, 8);
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