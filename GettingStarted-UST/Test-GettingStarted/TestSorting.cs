using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GettingStarted_UST;

namespace Test_GettingStarted
{
    /// <summary>
    /// Validate Sorting of Elements
    /// </summary>
    [TestClass]
    public class TestSorting
    {
        /// <summary>
        /// Test case to validate first element sorting
        /// </summary>
        [TestMethod]
        public void default_sort_works() {
            // AAA
            SimpleClass cl1 = new SimpleClass(8, "zA");
            SimpleClass cl2 = new SimpleClass(2, "xB");
            SimpleClass cl3 = new SimpleClass(9, "oZ");
            SimpleClass cl4 = new SimpleClass(1, "AD");
            SimpleClass cl5 = new SimpleClass(3, "bB");
            SimpleClass[] mycoll = { cl1, cl1, cl3, cl4, cl5 };
            Array.Sort(mycoll);
            string actual = null;
            foreach (var item in mycoll)
            {
                Console.Write($"{item} , ");
                actual += $"{item} , ";
            }
            Assert.AreEqual("1-AD , 3-bB , 8-zA , 8-zA , 9-oZ , ", actual);
            Console.WriteLine(actual);
            
        }

        /// <summary>
        /// Validate sorting of elements by name
        /// </summary>
        [TestMethod]
        public void sort_works_with_name() {
            // AAA
            SimpleClass cl1 = new SimpleClass(8, "zA");
            SimpleClass cl2 = new SimpleClass(2, "xB");
            SimpleClass cl3 = new SimpleClass(9, "oZ");
            SimpleClass cl4 = new SimpleClass(1, "AD");
            SimpleClass cl5 = new SimpleClass(3, "bB");
            SimpleClass[] mycoll = { cl1, cl1, cl3, cl4, cl5 };
            string actual = null;
            NameSorter sorter = new NameSorter();
            // Act
            Array.Sort(mycoll,sorter);
            //CollectionAssert TDD
            foreach (var item in mycoll)
            {
                Console.Write($"{item} , ");
                actual += $"{item} , ";
            }
            Assert.AreEqual("1-AD , 3-bB , 9-oZ , 8-zA , 8-zA , ", actual);
        }
    }
}
