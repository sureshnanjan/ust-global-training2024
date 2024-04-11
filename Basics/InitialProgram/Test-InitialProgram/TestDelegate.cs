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
        [TestMethod]
        //Add all values with In Line Lambda expression
        public void Aggregation_TestAddition_Lambda()
        {
            int[] numbers = { 20, 10, 30, 55, 115 };
            int actual = numbers.Aggregate((a, b) => a + b);
            Console.WriteLine($"Total Aggregated value: {actual}");
            Assert.AreEqual(230, actual);
        }

        [TestMethod]
        public void Aggregation_TestMultiply_Lambda()
        {
            int[] numbers = { 10, 10, 30, 20 };


        }

        [TestMethod]
        // Display values with the help of Action Delegate
        public void DelegateTestAction_StringMerge()
        {
            Delegate_Class dc = new Delegate_Class();
            Action<int, int> display = dc.displayValues;
            display(2, 10);
            display(2, 20);

        }

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