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
        [TestMethod]
        public void default_sort_works() {
            // AAA
            SimpleClass cl1 = new SimpleClass(8, "zA");
            SimpleClass cl2 = new SimpleClass(2, "xB");
            SimpleClass cl3 = new SimpleClass(9, "oZ");
            SimpleClass cl4 = new SimpleClass(1, "AD");
            SimpleClass cl5 = new SimpleClass(3, "bB");
            SimpleClass[] mycoll = { cl1, cl1, cl3, cl4, cl5 };
            // form the expected result 
            String actual = "Test";
            // Act
            Array.Sort(mycoll);
            //printing result
            Console.WriteLine("The Default sorting is : ");  
            foreach (var myitem in mycoll)
            {
                Console.WriteLine(myitem);
            }
            // assert that the result is as per expectation

            Assert.AreEqual(mycoll.Length, actual.Length);
        }
        [TestMethod]
        public void sort_works_with_name() {
            // AAA
            SimpleClass cl1 = new SimpleClass(8, "zA");
            SimpleClass cl2 = new SimpleClass(2, "xB");
            SimpleClass cl3 = new SimpleClass(9, "oZ");
            SimpleClass cl4 = new SimpleClass(1, "AD");
            SimpleClass cl5 = new SimpleClass(3, "bB");
            SimpleClass[] mycoll = { cl1, cl1, cl3, cl4, cl5 };
             
            NameSorter sorter = new NameSorter();
            // Act
            Array.Sort(mycoll,sorter);
            // form the expected result 
            String actual = null;
                        
            //printing result
            Console.WriteLine("The Default sorting is : ");
            foreach (var myitem in mycoll)
            {
                Console.WriteLine(myitem);
            }
            // assert that the result is as per expectation

            Assert.AreEqual(mycoll.Length, actual.Length);
        }




    }
}
