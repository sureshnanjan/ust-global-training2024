using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GettingStarted_UST;

namespace Test_GettingStarted
{
    [TestClass]
    public class OperatorandIndex
    {
        [TestMethod]

        /// <summary>
        /// Test Method for Index and Operator assignment
        /// </summary>   
        public void Multiplenumber()
        {
         SampleClass element1 = new SampleClass(10);
        SampleClass element2 = new SampleClass(100);
          var result1 = element1 * element2;
          Assert.AreEqual(result1.value1,1000);
         }
        [TestMethod]

        /// <summary>
        /// Test Method for GreaterOrLessernumber
        /// </summary>  
        public void GreaterOrLessernumber()
        {
            SampleClass element1 = new SampleClass(120);
            SampleClass element2 = new SampleClass(100);
            //var result1 = element1 * element2;
            if((element1 > element2).v)
            {
                Console.WriteLine(element1.value1 +" is greater than " + element2.value1);
            }
            else 
            { 
                Console.WriteLine(element1.value1 + " is lesser than " + element2.value1); 
            }
        }
        [TestMethod]

        /// <summary>
        /// Test Method for IndexOverLoading
        /// </summary>  
        public void IndexOverLoading()
        {
            int[] sum = { 1, 2, 3,4,5 };
            SampleCollection sample = new SampleCollection();
            if (sum.Length == 0)
            {
                Console.WriteLine("Empty Array");
            }
            else
            {
                for (int k = 0; sum.Length > k; k++)
                {
                    if (sample[k].value1 == sum[k])
                        Console.WriteLine($"{sample[k].value1}");
                }
            //Console.WriteLine(sample[0].value1);
             }
           
        }
    }
    }

