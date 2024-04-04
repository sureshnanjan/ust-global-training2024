using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_GettingStarted
{
    /// <summary>
    /// Sorted Array Test Cases
    /// </summary>
    [TestClass]
    public class TestSortedArray
    {
        [TestMethod]
        //By default sorting will be based on the first element 
        public void Sorting_FirstElementBased()
        {
            //Array of Integers
            int[] intArray = new int[] { 9, 2, 4, 3, 1, 5 };
            Console.WriteLine("Sorted Array");
            //Array.Sort takes Array as an input and sorts the array in ascending order 
            Array.Sort(intArray);
            foreach (int i in intArray)
            {
                Console.WriteLine(i + "");
            }
        }

        //if first value is equal sort happens based on the second value

        //Expected result should be Sorted Array
    }
}
