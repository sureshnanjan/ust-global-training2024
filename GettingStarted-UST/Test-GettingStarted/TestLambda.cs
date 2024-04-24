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
        /// <summary>
        /// Lambda aggregate addition
        /// </summary>
        [TestMethod]
        public void Lamda_Aggregate_Addition()
        {
            int[] numbers = { 2, 4, 5, 7 };
<<<<<<< HEAD
            int actual = numbers.Aggregate((x, y) => x + y);
            int expected = 18;
            Console.WriteLine($" Total Aggregate value: {actual}");
            Assert.AreEqual(expected, actual);
=======
            int actual = numbers.Aggregate((x,y) => x+y);
            int expected = 18;
            Console.WriteLine($" Total Aggregate value: {actual}");
            Assert.AreEqual( expected, actual );
>>>>>>> intermediate-branch

        }
        /// <summary>
        /// Multiplication using Lambda
        /// </summary>
        [TestMethod]
        public void Lambda_Multiplication()
        {
            int[] numbers = { 2, 4, 5, 7 };
            int actual = numbers.Aggregate((x, y) => x * y);
            int expected = 280;
            Console.WriteLine($" Total Aggregate Multiplication value: {actual}");
            Assert.AreEqual(expected, actual);

        }
        /// <summary>
        /// Substraction using Lambda
        /// </summary>
        [TestMethod]
        public void Lambda_Substraction()
        {
            int[] numbers = { 2, 4, 5, 7 };
            int actual = numbers.Aggregate((x, y) => x - y);
            int expected = -14;
            Console.WriteLine($" Total Substraction value: {actual}");
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Squares of number using Lambda
        /// </summary>
        [TestMethod]
        public void Lambda_Square()
        {
<<<<<<< HEAD
            List<int> numbers = new List<int>() { 1, 2, 5, 6 };
=======
            List<int> numbers = new List<int>(){ 1, 2, 5, 6 };
>>>>>>> intermediate-branch
            var square = numbers.Select(x => x * x);
            Console.Write("\n Squares : ");
            foreach (int number in square)
            {
                Console.Write("  " + number);
            }
<<<<<<< HEAD
            int[] expected = { 1, 4, 25, 36 };
            Assert.AreEqual(square, expected);
        }
    }
}
=======
            int [] expected = {1, 4, 25, 36 };
            Assert.AreEqual(square, expected);
        }
    }
}
>>>>>>> intermediate-branch
