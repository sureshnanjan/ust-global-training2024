using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_InitialProgram
{
    /// <summary>
    /// Assignment of Delegate and Lambda
    /// </summary>
    /// 
    [TestClass]
    public class Test_Delegate
    {
        /// <summary>
        /// Add all values with In Line Lambda expression
        /// </summary>
        [TestMethod]
        public void Aggregation_TestAddition_Lambda()
        {
            int[] numbers = { 20, 10, 30, 55, 115 };
            int actual = numbers.Aggregate((a, b) => a + b);
            Console.WriteLine($"Total Aggregated value: {actual}");
            Assert.AreEqual(230, actual);
        }

        /// <summary>
        /// Multiply all values with In Line Lambda expression
        /// </summary>
        [TestMethod]
        public void Aggregation_TestMultiply_Lambda()
        {
            int[] numbers = { 10, 10, 30, 10 };
            int actual = numbers.Aggregate((b, c) => b * c);
            Console.WriteLine($"Multiplication of Values: {actual}");
            Assert.AreEqual(30000, actual);

        }

        /// <summary>
        /// Display values with the help of Action Delegate
        /// </summary>
        [TestMethod]
        public void DelegateTestAction_StringMerge()
        {
            Delegate_Class dc = new Delegate_Class();
            Action<int, int> display = dc.displayValues;
            display(2, 10);
            display(2, 20);

        }

        /// <summary>
        ///  Find values less than 10 with Func Delegate
        /// </summary>
        [TestMethod]
        public void DelegateTestFunc_Lessthan10Values()
        {
            Delegate_Class dc = new Delegate_Class();
            int[] inputArray = { 1, 2, 2, 3, 5, 4, 2, 100, 12 };
            int[] expected = { 1, 2, 2, 5, 4, 2 };
            Func<int, bool> pointer = dc.lessThan5;
            var actual = inputArray.Where(pointer).ToArray();
            foreach (var item in actual)
            {
                Console.WriteLine(item);
            }
            Array.Equals(expected, actual);
        }
      
    }
}