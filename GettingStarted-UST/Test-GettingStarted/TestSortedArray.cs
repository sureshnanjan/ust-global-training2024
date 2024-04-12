
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_GettingStarted
{
    /// <summary>
    /// Test Cases to check sorted array
    /// </summary>
    [TestClass]
    public class TestSortedArray
    {

        [TestMethod]
        //Expecting result as a Sorted Array 
        public void SortedArray()
        {
            //Integers Array
            int[] intArray = new int[] { 9, 2, 4, 3, 1, 5 };
            Console.WriteLine("Sorted Array");
            //Array.Sort takes Array as an input and sorts the array in order 
            Array.Sort(intArray);
            foreach (int i in intArray)
            {
                Console.WriteLine(i + "");
            }
        }

        [TestMethod]
        //By default sorting will be based on first element considering first element as the smallest element 
        public void Sorting_FromFirstElement()
        {
            //Integers Array
            int[] intArray = new int[] { 9, 2, 4, 3, 1, 5 };
            //If array length is 6 elements then by default sorting will be based on 1st element
            //Sort the array till the last element. If first value is found to be equal then sort happens based on the second value and so on

            Array.Sort(intArray, 1, 5);
            foreach (int i in intArray)
            {
                Console.WriteLine(i + "");
            }
        }


    }
}
