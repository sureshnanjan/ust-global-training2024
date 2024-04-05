using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_GettingStarted
{
    /// <summary>
    /// Assignment to validate Delegate and Lambda
    /// </summary>
    [TestClass]
    public class Test_Delegate
    {
        [TestMethod]
        //Add all values with In Line Lambda expression
        public void Lambda_Aggregation_TestAddition()
        {
            int[] numbers = { 10, 20, 30, 55, 115 };
            int actual = numbers.Aggregate((a, b) => a + b);
            Console.WriteLine($"Total Aggregated value: {actual}");
            Assert.AreEqual(230, actual);
        }
        [TestMethod]
        //Multiply all values with In Line Lambda expression
        public void Lambda_Aggregation_TestMultiplication() {
            int[] numbers = { 10, 20, 30, 10 };
            int actual  =   numbers.Aggregate((b, c) => b * c);
            Console.WriteLine($" Multiplication of All values: {actual}" );
            Assert.AreEqual(60000,actual);
        }
        [TestMethod]
        //Find values less than 10 with Func Delegate
        public void DelegateTestFunc_Lessthan10Values() { 
            DelegateClass dc = new DelegateClass();
            int[] inputArray = { 1, 2, 2, 3, 5, 4, 2, 6, 17, 28, 59, 12 };
            int[] expected = { 1, 2, 2, 3, 5, 4, 2, 6 };
            Func<int, bool> pointer = dc.lessThan5;
            var actual = inputArray.Where(pointer).ToArray();
            foreach (var item in actual)
            {
                Console.WriteLine( item);
            }
            Array.Equals(expected, actual);
        }
        [TestMethod]
        // Display values with the help of Action Delegate
        public  void DelegateTestAction_StringMerge()
        {
            DelegateClass dc = new DelegateClass();
            Action<int, int> display = dc.displayValues;
            display(2, 10);
            display(2, 20);

        }
    }
}
