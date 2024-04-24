using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GettingStarted_UST;

namespace Test_GettingStarted
{

    /// <summary>
    /// Sorted array test cases - 
    /// </summary>
    [TestClass]
    public class TestSortedArray

    {
<<<<<<< HEAD

        //Bydefault the sorting will be based on the first element

        //if first value is equal sort happens based on the second value
        // Expected result should be in sorted array 

=======
        /// <summary>
        /// sorting of array correctly
        /// </summary>
>>>>>>> intermediate-branch
        [TestMethod]
        public void sorting_array_correctly()
        {

            SimpleClass[] myInstances = { new SimpleClass(1, 7), new SimpleClass(3, 2), new SimpleClass(0, 1), new SimpleClass(9, 7) };
            SimpleClass[] Expected = { new SimpleClass(0, 1), new SimpleClass(1, 7), new SimpleClass(3, 2), new SimpleClass(9, 7) };
            Array.Sort(myInstances);
            //string actual = myInstances.ToString();
            Assert.AreEqual(myInstances, Expected);
<<<<<<< HEAD



        }
=======
        }
        /// <summary>
        /// Display results in 1-2 format
        /// </summary>
>>>>>>> intermediate-branch
        [TestMethod]

        public void correctformat()
        {
            SimpleClass simpleClasses = new(0, 9);
<<<<<<< HEAD
            string expected = "0-9";
=======
            string expected = "0-9" ;
>>>>>>> intermediate-branch
            string actual = simpleClasses.ToString();
            Assert.AreEqual(expected, actual);


        }
<<<<<<< HEAD
=======
        /// <summary>
        /// Sorting of first value equals from an array
        /// </summary>
>>>>>>> intermediate-branch
        [TestMethod]

        public void sorting_first_value_equal()
        {
            SimpleClass[] myInstances = { new SimpleClass(1, 7), new SimpleClass(1, 2), new SimpleClass(1, 8) };
            SimpleClass[] Expected = { new SimpleClass(1, 2), new SimpleClass(1, 7), new SimpleClass(1, 8) };
            Array.Sort(myInstances);
            Assert.AreEqual(myInstances, Expected);

        }
<<<<<<< HEAD
=======
        /// <summary>
        /// Sorting of second value equals from an array
        /// </summary>
>>>>>>> intermediate-branch
        [TestMethod]
        public void sorting_second_value_equal()
        {
            SimpleClass[] myInstances = { new SimpleClass(1, 2), new SimpleClass(3, 2), new SimpleClass(2, 2) };
<<<<<<< HEAD
            SimpleClass[] Expected = { new SimpleClass(1, 2), new SimpleClass(2, 2), new SimpleClass(3, 2) };
            Array.Sort(myInstances);
            Assert.AreEqual(myInstances, Expected);
        }
        [TestMethod]
        public void sorting_array_firstvalue_zero()
        {
            SimpleClass[] myInstances = { new SimpleClass(0, 5), new SimpleClass(0, 2), new SimpleClass(0, 1) };
=======
            SimpleClass[] Expected = { new SimpleClass(1, 2), new SimpleClass(2,2), new SimpleClass(3, 2) };
            Array.Sort(myInstances);
            Assert.AreEqual(myInstances, Expected);
        }
        /// <summary>
        /// Sorting of array first value as zero
        /// </summary>
        [TestMethod]
        public void sorting_array_firstvalue_zero()
        {
            SimpleClass[] myInstances = { new SimpleClass(0, 5), new SimpleClass(0, 2), new SimpleClass(0,1) };
>>>>>>> intermediate-branch
            SimpleClass[] Expected = { new SimpleClass(0, 1), new SimpleClass(0, 2), new SimpleClass(0, 5) };
            Array.Sort(myInstances);
            Assert.AreEqual(myInstances, Expected);
        }
    }
}