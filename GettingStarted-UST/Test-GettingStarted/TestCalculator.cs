using GettingStarted_UST;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_GettingStarted
{
    /// <summary>
    /// Test cases for Calculator Functional Check 
    /// </summary>
    [TestClass]
    public class TestCalculator
    {
        [TestMethod]
        //TC1 - Verify 10+20 =30
        public void additionof10and20shouldbe30()
        {
            Calculator calculator = new Calculator();
            int expected = 30;
            int actual = calculator.add(10, 20);
            Assert.AreEqual(expected, actual);
            Console.WriteLine("Result 30 ddisplayed");
        }

        [TestMethod]
        //TC2 - Verify 10000+20000 =30000
        public void additionof100000and20000shouldbe300000()
        {
            Calculator calculator = new Calculator();
            int expected = 30000;
            int actual = calculator.add(10000, 20000);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        //TC3 - Verify 10-8 =2
        public void subtracting10and8shouldbe2()
        {
            Calculator calculator = new Calculator();
            int expected = 2;
            int actual = calculator.subtract(10,8);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        ////TC4 - Verify 0-2 =-2
        public void subtracting0and2shouldbeminus2()
        {
            Calculator calculator = new Calculator();
            int expected = -2;
            int actual = calculator.subtract(0, 2);
            Assert.AreEqual(expected, actual);
        }
    }
}