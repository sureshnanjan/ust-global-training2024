using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Test_GettingStarted
{
    [TestClass]
    public class ArraySorted
    {
        /// <summary>
        ///Sorted Array assignment - Sort Array - Linked to  Simple Class in Getting Startest- UST 
        /// </summary>

        /// <summary>
        /// Test for No Duplicate in Array
        /// </summary
        [TestMethod]
        public void NoDuplicateInArray()
        {
            /// int[,] multinumbers ={{0,1}, {7,1}, {1,5}}
            ArraySortedClass[] myArray = { new ArraySortedClass(0, 1), new ArraySortedClass(7, 6), new ArraySortedClass(2, 5) };

            Console.WriteLine("Original Values in My Array");
            foreach (var item in myArray)
            {
                Console.WriteLine($"{item}, ");
            }
            Array.Sort(myArray);
            Console.WriteLine("\n After Sorting Values in My Array");
            foreach (var item in myArray)
            {
                Console.WriteLine($"{item}, ");
            }
        }


        /// <summary>
        /// Test for First Element Duplicate in Array
        /// </summary>
        [TestMethod]
        public void FirstElementDuplicateInArray()
        {
            /// int[,] multinumbers ={{0,1}, {7,1}, {1,5}}
            ArraySortedClass[] myArray = { new ArraySortedClass(0, 1), new ArraySortedClass(5, 0), new ArraySortedClass(7, 1), new ArraySortedClass(5, 5), new ArraySortedClass(2, 3) };

            Console.WriteLine("Original Values in My Array");
            foreach (var item in myArray)
            {
                Console.WriteLine($"{item}, ");
            }
            Array.Sort(myArray);
            Console.WriteLine("\n After Sorting Values in My Array");
            foreach (var item in myArray)
            {
                Console.WriteLine($"{item}, ");
            }
        }

        /// <summary>
        /// Test for Second Element Duplicates in Array
        /// </summary>
        [TestMethod]
        public void SecondElementDuplicatesInArray()
        {

            ArraySortedClass[] myArray = { new ArraySortedClass(0,1), new ArraySortedClass(7,1) , new ArraySortedClass(5,0) , new ArraySortedClass(5,5),
            new ArraySortedClass(1,5) , new ArraySortedClass(2,4)};

            Console.WriteLine("Original Values in My Array");
            foreach (var item in myArray)
            {
                Console.Write($"{item} , ");

            }
            Array.Sort(myArray);
            Console.WriteLine("\n After Sorting Values in My Array ");
            foreach (var item in myArray)
            {
                Console.Write($"{item} , ");

            }
        }

        /// <summary>
        /// Test for Sorted Array with Both the Duplicate Values
        /// </summary>
        [TestMethod]
        public void sortArraywithbothduplicatevalues()
        {

            ArraySortedClass[] myArray = { new ArraySortedClass(0,1), new ArraySortedClass(4,1) , new ArraySortedClass(5,0) , new ArraySortedClass(7,1),
            new ArraySortedClass(1,5) , new ArraySortedClass(5,0)};

            Console.WriteLine("Original Values in My Array");
            foreach (var item in myArray)
            {
                Console.Write($"{item} , ");

            }
            Array.Sort(myArray);
            Console.WriteLine("\n After Sorting Values in My Array ");
            foreach (var item in myArray)
            {
                Console.Write($"{item} , ");

            }
        }
    }
}
