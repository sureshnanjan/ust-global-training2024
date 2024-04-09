using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GettingStarted_UST;

namespace Test_GettingStarted
{
    [TestClass]
    public class SortedArray
    {
        /// <summary>
        ///Sorted Array assignment - Sort Array - Linked to  Simple Class in Getting Startest- UST 
        /// </summary>
        [TestMethod]
        public void NoDuplicatesinArray() 
        {
            
           //int[,] multinumbers = { { 0, 1 }, { 7, 1 }, { 5, 4 }, { 3, 1 }, { 1, 5 } };
            //  SimpleClass[] myInstances = { new SimpleClass(8), new SimpleClass(3) , new SimpleClass(19) , new SimpleClass(21),
            //  new SimpleClass(1), new SimpleClass(2) , new SimpleClass(3) , new SimpleClass(4)};
            SortedArrayClass[] myInstances = { new SortedArrayClass(0,1), new SortedArrayClass(7,1) , new SortedArrayClass(5,0) , new SortedArrayClass(3,1),
            new SortedArrayClass(1,5)};

            Console.WriteLine("Original Values in My Instances as Integer Values");
            foreach (var item in myInstances)
            {
                Console.Write($"{item} , ");

            }
            Array.Sort(myInstances);
            Console.WriteLine("\n AFTER SORTING  Values in My Integer MYINSTANCES ");
            foreach (var item in myInstances)
            {
                Console.Write($"{item} , ");

            }
        }
        [TestMethod]
        public void FirstelementDuplicatesinArray() 
        {
            
            //int[,] multinumbers = { { 0, 1 }, { 7, 1 }, { 5, 4 }, { 5, 1 }, { 5, 5 }, { 2, 3 } };
            //  SimpleClass[] myInstances = { new SimpleClass(8), new SimpleClass(3) , new SimpleClass(19) , new SimpleClass(21),
            //  new SimpleClass(1), new SimpleClass(2) , new SimpleClass(3) , new SimpleClass(4)};
            SortedArrayClass[] myInstances = { new SortedArrayClass(0,1), new SortedArrayClass(5,0) , new SortedArrayClass(7,1) , new SortedArrayClass(5,5),
            new SortedArrayClass(2,3) };

            
            Console.WriteLine("Original Values in My Instances as Integer Values");
            foreach (var item in myInstances)
            {
                Console.Write($"{item} , ");

            }
            Array.Sort(myInstances);
            Console.WriteLine("\n AFTER SORTING  Values in My Integer MYINSTANCES ");
            foreach (var item in myInstances)
            {
                Console.Write($"{item} , ");

            }
        }
        [TestMethod]
        public void secondelementDuplicatesinArray() 
        {
           
           // int[,] multinumbers = { { 0, 1 }, { 7, 1 }, { 5, 4 }, { 5, 5 }, { 1, 5 }, { 2, 4 } };
            //  SimpleClass[] myInstances = { new SimpleClass(8), new SimpleClass(3) , new SimpleClass(19) , new SimpleClass(21),
            //  new SimpleClass(1), new SimpleClass(2) , new SimpleClass(3) , new SimpleClass(4)};
            SortedArrayClass[] myInstances = { new SortedArrayClass(0,1), new SortedArrayClass(7,1) , new SortedArrayClass(5,0) , new SortedArrayClass(5,5),
            new SortedArrayClass(1,5) , new SortedArrayClass(2,4)};

            Console.WriteLine("Original Values in My Instances as Integer Values");
            foreach (var item in myInstances)
            {
                Console.Write($"{item} , ");

            }
            Array.Sort(myInstances);
            Console.WriteLine("\n AFTER SORTING  Values in My Integer MYINSTANCES ");
            foreach (var item in myInstances)
            {
                Console.Write($"{item} , ");

            }
        }

        [TestMethod]
        public void sortArraywithbothduplicatevalues()
        {
            //int[,] multinumbers = { { 0, 1 }, { 4, 1 }, { 5, 4 }, { 5, 1 }, { 1, 5 }, { 5, 4 } };
            //  SimpleClass[] myInstances = { new SimpleClass(8), new SimpleClass(3) , new SimpleClass(19) , new SimpleClass(21),
            //  new SimpleClass(1), new SimpleClass(2) , new SimpleClass(3) , new SimpleClass(4)};
            SortedArrayClass[] myInstances = { new SortedArrayClass(0,1), new SortedArrayClass(4,1) , new SortedArrayClass(5,0) , new SortedArrayClass(7,1),
            new SortedArrayClass(1,5) , new SortedArrayClass(5,0)};

            Console.WriteLine("Original Values in My Instances as Integer Values");
            foreach (var item in myInstances)
            {
                Console.Write($"{item} , ");

            }
            Array.Sort(myInstances);
            Console.WriteLine("\n AFTER SORTING  Values in My Integer MYINSTANCES ");
            foreach (var item in myInstances)
            {
                Console.Write($"{item} , ");

            }
        }
    }
}