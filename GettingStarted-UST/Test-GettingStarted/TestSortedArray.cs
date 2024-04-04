using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GettingStarted_UST;

namespace Test_GettingStarted
{
    [TestClass]
    public class TestSortedArray
    {
        /// <summary>
        /// testing whether the array is sorted
        /// </summary>
        
        [TestMethod]
        public void testSortedArray()        
        {
            SimpleClass[] myInstances = { new SimpleClass(3, 2), new SimpleClass(1,2),new SimpleClass(3,4)};
            
            SimpleClass[] expected = { new SimpleClass(1, 2), new SimpleClass(3, 2), new SimpleClass(3, 4) };
           
            Array.Sort(myInstances);
            
            Assert.AreEqual(expected, myInstances);
           
        }
        /// <summary>
        /// Testing array format
        /// </summary>
        
        [TestMethod]
        public void testArrayFormat() 
        {
            SimpleClass myInstances = new SimpleClass(1, 2);

            String expected = "1-2";

            String  actual = myInstances.ToString();

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Sort array if first values are equal
        /// </summary>
        
        [TestMethod]
        public void testSortedArrayFirstValueEqual()
        {
            SimpleClass[] myInstances = { new SimpleClass(1, 4), new SimpleClass(1, 2)};
            SimpleClass[] expected = { new SimpleClass(1, 2), new SimpleClass(1, 4) };

            Array.Sort(myInstances);

            Assert.AreEqual (myInstances, expected);
        }

        /// <summary>
        /// Sort array if first values are zero
        /// </summary>

        [TestMethod]
        public void testSortedArrayFirstValueZero()
        {
            SimpleClass[] myInstances = { new SimpleClass(0, 2), new SimpleClass(0, 4) };
            SimpleClass[] expected = { new SimpleClass(0, 2), new SimpleClass(0, 4) };
            
            Array.Sort(myInstances);

            Assert.AreEqual(myInstances, expected);
        }

        /// <summary>
        /// Sort array if second values are equal
        /// </summary>

        [TestMethod]
        public void testSortedArraySecondValueEqual()
        {
            SimpleClass[] myInstances = { new SimpleClass(1, 2), new SimpleClass(3, 2) };
            SimpleClass[] expected = { new SimpleClass(1, 2), new SimpleClass(3, 2) };

            Array.Sort(myInstances);

            Assert.AreEqual(myInstances, expected);
        }
    }
}
