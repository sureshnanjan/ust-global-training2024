using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using GettingStarted_UST;
using static GettingStarted_UST.MainProgram;

namespace Test_GettingStarted
{

    /// <summary>
    /// Test Class of Delegate
    /// </summary>
    [TestClass]
    public class Test_Delegate
    {
        /// <summary>
        /// Test to count repeated values in an array
        /// </summary>
        [TestMethod]
        public void TestForCountOfRepeatedValues()
        {
            int[] ListOfElements = { 3, 0, 2, 8, 6, 0, 1 };
            int expected = ListOfElements.Where(x => x == 0).Count();
            int actual = 2;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test to get count of values greater than 1
        /// </summary>
        [TestMethod]
        public void TestForGreaterThanOperation()
        {
            int[] ListOfElements = { 3, 0, 2, 8, 6, 0, 1 };
            int expected = ListOfElements.Where(x => x > 1).Count();
            int actual = 4;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test to get count of values less than 2
        /// </summary>
        [TestMethod]
        public void TestForLessThanOperation() 
        {
            int[] ListOfElements = { 3, 0, 2, 8, 6, 0, 1 };
            int expected = ListOfElements.Where(x => x < 2).Count();
            int actual = 3;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test to get result of addition
        /// </summary>
        [TestMethod]
        public void TestForAdditionOperation() 
        {
            int[] ListOfElements = { 3, 0, 2};
            int expected = ListOfElements.Aggregate((x,y)=> x + y);
            int actual = 5;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test to get value after subtraction
        /// </summary>
        [TestMethod]
        public void TestForSubtractionOperation() 
        {
            int[] ListOfElements = { 3, 2 };
            int expected = ListOfElements.Aggregate((x, y) => x - y);
            int actual = 1;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test to get product of values
        /// </summary>
        [TestMethod]
        public void TestForMultiplicationOperation() 
        {
            int[] ListOfElements = { 3, 2 };
            int expected = ListOfElements.Aggregate((x, y) => x * y);
            int actual = 6;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test to get value after division
        /// </summary>
        [TestMethod]
        public void TestForDivisionOperation() 
        {
            int[] ListOfElements = { 4, 2 };
            int expected = ListOfElements.Aggregate((x, y) => x / y);
            int actual = 2;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test to get reminder value after division
        /// </summary>
        [TestMethod]
        public void TestForRemainderOperation()
        {
            int[] ListOfElements = { 4, 2 };
            int expected = ListOfElements.Aggregate((x, y) => x % y);
            int actual = 0;
            Assert.AreEqual(expected, actual);
        }
    }
}
