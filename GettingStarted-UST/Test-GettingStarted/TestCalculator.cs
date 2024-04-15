using GettingStarted_UST;

namespace Test_GettingStarted
{
    [TestClass]
    public class TestCalculator
    {
        int expected, actual;

        [TestMethod]
        public void ValidateAddition()
        {
            // Test PASS
            expected = 30;
            actual = AddTwo(10, 20);
            Console.WriteLine("VAlidatiing the addition : ");
            Console.WriteLine("The test Passed the answer is :" + actual);
            Assert.AreEqual(expected, actual);

            // Test Fail

            expected = 40;
            actual = AddTwo(15, 20);
            Console.WriteLine("The test failed the answer is :" + actual);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateSubtraction()
        {
            // Test PASS
            expected = 30;
            actual = SubtractTwo(50, 20);
            Console.WriteLine("VAlidatiing the Subtraction : ");
            Console.WriteLine("The test Passed the answer is :" + actual);
            Assert.AreEqual(expected, actual);

            // Test Fail
            expected = 40;
            actual = SubtractTwo(80, 20);
            Console.WriteLine("The test failed the answer is :" + actual);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMultiplication()
        {
            // Test PASS
            expected = 30;
            actual = MultTwo(6, 5);
            Console.WriteLine("VAlidatiing the Multiplication : ");
            Console.WriteLine("The test Passed the answer is :" + actual);
            Assert.AreEqual(expected, actual);

            // Test Fail
            expected = 40;
            actual = MultTwo(6, 6);
            Console.WriteLine("The test failed the answer is :" + actual);
            Assert.AreEqual(expected, actual);
        }
        //  calculator methods

        public int AddTwo(int firstNum, int secNum)
        {
            return firstNum + secNum;
        }
        //subtraction
        public int SubtractTwo(int firstNum, int secNum)
        {
            return firstNum - secNum;
        }

        //Multiplication
        public int MultTwo(int firstNum, int secNum)
        {
            return firstNum * secNum;
        }

    }
}