using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_GettingStarted
{
    /// <summary>
    /// Test Class to validate operator and Indexer overloading
    /// </summary>
    [TestClass]
    public class TestOperatorAndIndex
    {

        //Test case to validate - operator overloading
        [TestMethod]
        public void MinusOperatorOverloading()
        {
            ClassSample element1 = new ClassSample(50);
            ClassSample element2 = new ClassSample(30);
            var actualResult = element1 - element2;
            Assert.AreEqual(actualResult.val1,20);
        }

        //Test case to validate + operator overloading
        [TestMethod]
        public void PlusOperatorOverloading()
        {
            ClassSample element1 = new ClassSample(50);
            ClassSample element2 = new ClassSample(50);
            var actualResult = element1 + element2;
            Assert.AreEqual(actualResult.val1, 100);
        }

        //Test case to validate < operator overloading
        [TestMethod]
        public void LessOperatorOverloading()
        {
            ClassSample element1 = new ClassSample(10);
            ClassSample element2 = new ClassSample(20);
            if( (element1 < element2).val2)
            {
                Console.WriteLine(element1.val1 + " is less than " + element2.val1);
            }
            else
            {
                Console.WriteLine(element1.val1 + " is greater than " + element2.val1);
            }
           
        }

        //Test case to validate > operator overloading
        [TestMethod]
        public void GreaterOperatorOverloading()
        {
            ClassSample element1 = new ClassSample(50);
            ClassSample element2 = new ClassSample(20);
            if ((element1 < element2).val2)
            {
                Console.WriteLine(element1.val1 + " is greater than " + element2.val1);
            }
            else
            {
                Console.WriteLine(element1.val1 + " is less than " + element2.val1);
            }

        }

    }
}
