using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Delegate initialization
public delegate int Number(int n);
namespace Test_GettingStarted
{
    [TestClass]
    public class Test_Delegate
    {
        /// <summary>
        /// Evaluating delegate greater than value
        /// </summary>
        [TestMethod]
        public void TestDelegateGreaterthan()
        {
            Func<int, bool> predicate = x => x > 3; // Lambda
            int[] mynumbers = { 1, 2, 3, 4, 5 };
            List<int> actual = mynumbers.Where(input => input > 3).ToList();
            //int[] result = new int[actual.Count];
            List<int> expected = new List<int>{4,5};
            Console.WriteLine($" Add Delegate value: {actual}");
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Delegate Less than value analysis
        /// </summary>
        [TestMethod]
        public void TestDelegateLessthan()
        {
            Func<int, bool> predicate = x => x > 3; // Lambda
            int[] mynumbers = { 1, 2, 3, 4, 5 };
            List<int> actual = mynumbers.Where(input => input > 3).ToList();
            //int[] result = new int[actual.Count];
            List<int> expected = new List<int> { 1, 2 };
            Console.WriteLine($" Add Delegate value: {actual}");
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Analysing delegate equal to value
        /// </summary>
        [TestMethod]
        public void TestDelegateEqualTo()
        {
            Func<int, bool> predicate = x => x > 3; // Lambda
            int[] mynumbers = { 1, 2, 3, 4, 5 };
            List<int> actual = mynumbers.Where(input => input > 3).ToList();
            //int[] result = new int[actual.Count];
            List<int> expected = new List<int> { 3, 3};
            Console.WriteLine($" Add Delegate value: {actual}");
            Assert.AreEqual(expected, actual);
        }

    }
}
