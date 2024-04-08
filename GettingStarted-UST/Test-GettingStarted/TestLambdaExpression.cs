using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_GettingStarted
{
    [TestClass]
    public class TestLambdaExpression
    {

        [TestMethod]
        public void testAddition()
        {
            int[] array = { 1,2,3,4};
            int expected = 10;
            int actual = array.Aggregate((arg1,arg2)=>arg1+ arg2);
            Console.WriteLine($"Addition : { actual}");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void testSubtraction()
        {
            int[] array = { 1, 2, 3, 4 };
            int expected = -8;
            int actual = array.Aggregate((arg1, arg2) => arg1 - arg2);
            Console.WriteLine($"Subtraction : {actual}");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void testMultipilcation()
        {
            int[] array = { 1, 2, 3, 4 };
            int expected = 24;
            int actual = array.Aggregate((arg1, arg2) => arg1 * arg2);
            Console.WriteLine($"Multiplication : {actual}");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void testSquare()
        {
            int[] array = { 1, 2, 3, 4 };
            int[] expected = { 1, 4, 9, 16 } ;
            var actual = array.Select(arg => arg * arg);
            foreach(var num in actual)
            {
                Assert.AreEqual(expected, num);
            }
            //Console.WriteLine($"Square : {actual}");
            
        }
    }
}
