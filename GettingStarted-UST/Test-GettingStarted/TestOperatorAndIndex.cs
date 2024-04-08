using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GettingStarted_UST;

namespace Test_GettingStarted
{
    /// <summary>
    /// Test Class to validate operator and Indexer overloading
    /// </summary>
    [TestClass]
    public class TestOperatorAndIndex
    {
        //Test case to validate + operator overloading
        [TestMethod]
        public void verifyPlusOperatorOverloading()
        {
            SampleClass element1 = new SampleClass(10);
            SampleClass element2 = new SampleClass(20);
            var actual = element1 + element2;
            Assert.AreEqual(actual.number,30);

        }

        //Test case to validate < operator overloading
        [TestMethod]
        public void verifyLessOperatorOverloading()
        {
            SampleClass element1 = new SampleClass(10);
            SampleClass element2 = new SampleClass(20);
            if ((element1 < element2).status)
                Console.WriteLine("10 is less than 20");
            else
                Console.WriteLine("10 is grater than 20");

        }
        //Test case to validate > operator overloading
        [TestMethod]
        public void verifyGreaterOperatorOverloading()
        {
            SampleClass element1 = new SampleClass(300);
            SampleClass element2 = new SampleClass(20);
            var actual = element1 + element2;
            if ((element1 > element2).status)
                Console.WriteLine("300 is greater than 20");
            else
                Console.WriteLine("300 is less than 20");

        }


        //Test case to validate Indexer overloading
        [TestMethod]
        public void verifyIndexerOverloading()
        {
            int[] mySequence = { 1, 2, 3, 4, 5 };
            SampleCollection scColl  = new SampleCollection();
            
            for (int i = 0; i < mySequence.Length; i++)
            {
                Console.WriteLine($" Collection Value: {scColl[i].number} and Sequence Value: {mySequence[i]}");
                Assert.AreEqual(mySequence[i], scColl[i].number);

            }

        }
    }
}
