using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GettingStarted_UST;

namespace Test_GettingStarted
{
    [TestClass]
    public class TestSorting
    {
        /// <summary>
        /// Default sort of array
        /// </summary>
        [TestMethod]
        public void default_sort_works()
        {
            // AAA
            SimpleClass cl1 = new SimpleClass(8, "zA");
            SimpleClass cl2 = new SimpleClass(2, "xB");
            SimpleClass cl3 = new SimpleClass(9, "oZ");
            SimpleClass cl4 = new SimpleClass(1, "AD");
            SimpleClass cl5 = new SimpleClass(3, "bB");
            SimpleClass[] mycoll = { cl1, cl1, cl3, cl4, cl5 };
            // form the expected result
            // Act
            Array.Sort(mycoll);
            // assert that the result is as per expectation
        }
        /// <summary>
        /// Sort the array with name
        /// </summary>
        [TestMethod]
        public void sort_works_with_name()
        {
            // AAA
            SimpleClass cl1 = new SimpleClass(8, "zA");
            SimpleClass cl2 = new SimpleClass(2, "xB");
            SimpleClass cl3 = new SimpleClass(9, "oZ");
            SimpleClass cl4 = new SimpleClass(1, "AD");
            SimpleClass cl5 = new SimpleClass(3, "bB");
            SimpleClass[] mycoll = { cl1, cl1, cl3, cl4, cl5 };
            NameSorter sorter = new NameSorter();
            // Act
            Array.Sort(mycoll, sorter);
            //CollectionAssert TDD

        }




    }
}