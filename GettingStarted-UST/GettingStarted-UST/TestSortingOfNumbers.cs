using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GettingStarted_UST
{
    [TestClass]
    public class TestSortingOfNumbers
    {
        [TestMethod]
        public void TestDefaultSorting()
        {
            SimpleTestCalss cls1 = new SimpleTestCalss(9, "pQ");
            SimpleTestCalss cls2 = new SimpleTestCalss(0, "st");
            SimpleTestCalss cls3 = new SimpleTestCalss(11, "pR");
            SimpleTestCalss cls4 = new SimpleTestCalss(4, "RQ");
            SimpleTestCalss[] testCol = { cls1, cls2, cls3, cls4 };

            //Sorting default
            Array.Sort(testCol);

            //printing result
            foreach (var item in testCol)
            {
                Console.WriteLine(item);
            }


        }

        [TestMethod]
        public void TestSortingByName()
        {

            SimpleTestCalss cls1 = new SimpleTestCalss(9, "pQ");
            SimpleTestCalss cls2 = new SimpleTestCalss(0, "st");
            SimpleTestCalss cls3 = new SimpleTestCalss(11, "pR");
            SimpleTestCalss cls4 = new SimpleTestCalss(4, "RQ");
            SimpleTestCalss[] testCol = { cls1, cls2, cls3, cls4 };

            //Sorting by name
             
            Array.Sort(testCol);

            //printing result
            foreach (var item in testCol)
            {
                Console.WriteLine(item);
            }


        }

    }

}
