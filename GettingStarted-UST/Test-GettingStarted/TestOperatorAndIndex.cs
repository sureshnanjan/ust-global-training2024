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
        /// </summary>
        //Test method to validate - operator overloading
        /// </summary>
        [TestMethod]
        public void MinusOperatorOverloading()
        {
            ClassSample element1 = new ClassSample(50);
            ClassSample element2 = new ClassSample(30);
            var actualResult = element1 - element2;
            Assert.AreEqual(actualResult.val1,20);
        }

        /// </summary>
        //Test method to validate + operator overloading
        /// </summary>
        [TestMethod]
        public void PlusOperatorOverloading()
        {
            ClassSample element1 = new ClassSample(50);
            ClassSample element2 = new ClassSample(50);
            var actualResult = element1 + element2;
            Assert.AreEqual(actualResult.val1, 100);
        }

        /// </summary>
        //Test method to validate < operator overloading
        /// </summary>
        [TestMethod]
        public void LessOperatorOverloading()
        {
            ClassSample element1 = new ClassSample(10);
            ClassSample element2 = new ClassSample(20);
            if( (element1 < element2).val2)
            {
                Console.WriteLine(element1.val1 + " is less than " + element2.val1);
                Assert.IsTrue((element1 < element2).val2);
            }
            else
            {
                Console.WriteLine(element1.val1 + " is greater than " + element2.val1);
                
            }
           
        }

        /// </summary>
        //Test method to validate > operator overloading
        /// </summary>
        [TestMethod]
        public void GreaterOperatorOverloading()
        {
            ClassSample element1 = new ClassSample(50);
            ClassSample element2 = new ClassSample(20);
            if ((element1 > element2).val2)
            {
                Console.WriteLine(element1.val1 + " is greater than " + element2.val1);
                Assert.IsTrue((element1 > element2).val2);
            }
            else
            {
                Console.WriteLine(element1.val1 + " is less than " + element2.val1);
               
            }

        }

        /// <summary>
        /// Test Method for IndexOverLoading
        /// </summary> 
        [TestMethod]
        public void IndexOverloading()
        {
            int[] total = { 1, 2, 3, 4, 5};
            CollectionSample sample = new CollectionSample();

            for (int counter = 0; counter < total.Length; counter++)
            {
                Console.WriteLine($"Values of Collection: {sample[counter].val1}");
                Assert.AreEqual(total[counter], sample[counter].val1);

            }  
        }

    }
}
