using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_GettingStarted
{
    [TestClass]
    public class TestLambda
    {
        [TestMethod]
        public void Lamda_Aggregate_Addition()
        {
            int[] numbers = { 2, 4, 5, 7 };
            int actual = numbers.Aggregate((x,y) => x+y);
            int expected = 18;
            Console.WriteLine($" Total Aggregate value: {actual}");
            Assert.AreEqual( expected, actual );

        }
        [TestMethod]
        public void Lambda_Multiplication()
        {
            int[] numbers = { 2, 4, 5, 7 };
            int actual = numbers.Aggregate((x, y) => x * y);
            int expected = 280;
            Console.WriteLine($" Total Aggregate Multiplication value: {actual}");
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Lambda_Substraction()
        {
            int[] numbers = { 2, 4, 5, 7 };
            int actual = numbers.Aggregate((x, y) => x - y);
            int expected = -14;
            Console.WriteLine($" Total Substraction value: {actual}");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Lambda_Square()
        {
            List<int> numbers = new List<int>(){ 1, 2, 5, 6 };
            var square = numbers.Select(x => x * x);
            Console.Write("\n Squares : ");
            foreach (int number in square)
            {
                Console.Write("  " + number);
            }
            int [] expected = {1, 4, 25, 36 };
            Assert.AreEqual(square, expected);
        }
    }
}
