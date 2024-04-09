using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_GettingStarted
{
    /// <summary>
    /// Sorting of the Array
    /// </summary>


    [TestClass]
    public class TestSortingA
    {

        [TestMethod]
        // Verify the format of v1-v2
        public void verifyFormat()
        {
            SortingA simpleClass = new(2, 3);
            string sExpected = "2-3";
            Assert.AreEqual(sExpected, simpleClass.ToString());
        }


        [TestMethod]
        // Verify when there is no Dublicate 
        public void uniqueSorting()
        {

            SortingA[] myInputArray = { new SortingA(1, 9), new SortingA(5, 4), new SortingA(4, 2), new SortingA(3, 1), new SortingA(8, 6), };
            //SortingA[] expectedArray = { new SortingA(1, 9), new SortingA(5, 4), new SortingA(4, 2), new SortingA(3, 1), new SortingA(8, 6), };
            Console.WriteLine("Original Values in My Instances");
            foreach (var item in myInputArray)
            {
                Console.Write($"{item} , ");

            }
            Array.Sort(myInputArray);
            Console.WriteLine("\n AFTER SORTING  Values ");
            foreach (var item in myInputArray)
            {
                Console.Write($"{item} , ");

            }
        }

        [TestMethod]
        //TC to verify sorting when first value is duplicate
        public void firstValueDuplicateSorting()
        {

            SortingA[] myInputArray = { new SortingA(1, 1), new SortingA(5, 4), new SortingA(1, 2), new SortingA(3, 1), new SortingA(8, 6), };
            Console.WriteLine("Original Values in My Instances");
            foreach (var item in myInputArray)
            {
                Console.Write($"{item} , ");

            }
            Array.Sort(myInputArray);
            Console.WriteLine("\n AFTER SORTING  Values ");
            foreach (var item in myInputArray)
            {
                Console.Write($"{item} , ");

            }
        }
        [TestMethod]
        //TC to verify sorting when both values duplicate
        public void bothValuesDuplicateSorting()
        {

            SortingA[] myInputArray = { new SortingA(1, 1), new SortingA(5, 4), new SortingA(4, 2), new SortingA(5, 4), new SortingA(8, 6), };
            Console.WriteLine("Original Values in My Instances");
            foreach (var item in myInputArray)
            {
                Console.Write($"{item} , ");

            }
            Array.Sort(myInputArray);
            Console.WriteLine("\n AFTER SORTING  Values ");
            foreach (var item in myInputArray)
            {
                Console.Write($"{item} , ");

            }
        }
        [TestMethod]
        //TC to verify sorting when second value is duplicate
        public void secondValueDuplicateSorting()
        {

            SortingA[] myInputArray = { new SortingA(1, 1), new SortingA(5, 4), new SortingA(9, 2), new SortingA(3, 1), new SortingA(8, 6), };
            Console.WriteLine("Original Values in My Instances");
            foreach (var item in myInputArray)
            {
                Console.Write($"{item} , ");

            }
            Array.Sort(myInputArray);
            Console.WriteLine("\n AFTER SORTING  Values ");
            foreach (var item in myInputArray)
            {
                Console.Write($"{item} , ");

            }
        }
    }
}