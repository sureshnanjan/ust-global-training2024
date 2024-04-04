using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_GettingStarted
{
    /// <summary>
    /// Sorting of the Array
    /// </summary>
    
    
    [TestClass]
    public class TestSortedArrayDualValue
    {

        [TestMethod]
        public  void verifyFormat()
        {
            SortingClass simpleClass = new(2, 3);
            string sExpected = "2-3";
            Assert.AreEqual(sExpected, simpleClass.ToString());
        }
        
        
        [TestMethod]
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
