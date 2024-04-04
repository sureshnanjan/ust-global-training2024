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
    public class TestSortedArrayDualValue
    {

        [TestMethod]
        // Verify the format of v1-v2
        public  void verifyFormat()
        {
            SortingClass simpleClass = new(2, 3);
            string sExpected = "2-3";
            Assert.AreEqual(sExpected, simpleClass.ToString());
        }
        
        
        [TestMethod]
        // Verify when there is no Dublicate 
        public void uniqueSorting(){

            SortingClass[] myInputArray = { new SortingClass(1, 9), new SortingClass(5, 4), new SortingClass(4, 2), new SortingClass(3, 1), new SortingClass(8, 6), };
            //SortingClass[] expectedArray = { new SortingClass(1, 9), new SortingClass(5, 4), new SortingClass(4, 2), new SortingClass(3, 1), new SortingClass(8, 6), };
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

            SortingClass[] myInputArray = { new SortingClass(1, 1), new SortingClass(5, 4), new SortingClass(1, 2), new SortingClass(3, 1), new SortingClass(8, 6), };
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

            SortingClass[] myInputArray = { new SortingClass(1, 1), new SortingClass(5, 4), new SortingClass(4, 2), new SortingClass(5, 4), new SortingClass(8, 6), };
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

            SortingClass[] myInputArray = { new SortingClass(1, 1), new SortingClass(5, 4), new SortingClass(9, 2), new SortingClass(3, 1), new SortingClass(8, 6), };
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
