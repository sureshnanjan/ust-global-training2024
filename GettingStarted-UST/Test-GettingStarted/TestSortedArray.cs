using GettingStarted_UST;

namespace Test_GettingStarted
{

    /// <summary>
    /// Sorted array test cases - 
    /// </summary>
    [TestClass]
    public class TestSortedArray

    {
        /// <summary>
        /// sorting of array correctly
        /// </summary>
        [TestMethod]
        public void sorting_array_correctly()
        {

            SimpleClass[] myInstances = { new SimpleClass(1, 7), new SimpleClass(3, 2), new SimpleClass(0, 1), new SimpleClass(9, 7) };
            SimpleClass[] Expected = { new SimpleClass(0, 1), new SimpleClass(1, 7), new SimpleClass(3, 2), new SimpleClass(9, 7) };
            Array.Sort(myInstances);
            //string actual = myInstances.ToString();
            Assert.AreEqual(myInstances, Expected);
        }
        /// <summary>
        /// Display results in 1-2 format
        /// </summary>
        [TestMethod]

        public void correctformat()
        {
            SimpleClass simpleClasses = new(0, 9);
            string expected = "0-9" ;
            string actual = simpleClasses.ToString();
            Assert.AreEqual(expected, actual);


        }
        /// <summary>
        /// Sorting of first value equals from an array
        /// </summary>
        [TestMethod]

        public void sorting_first_value_equal()
        {
            SimpleClass[] myInstances = { new SimpleClass(1, 7), new SimpleClass(1, 2), new SimpleClass(1, 8) };
            SimpleClass[] Expected = { new SimpleClass(1, 2), new SimpleClass(1, 7), new SimpleClass(1, 8) };
            Array.Sort(myInstances);
            Assert.AreEqual(myInstances, Expected);

        }
        /// <summary>
        /// Sorting of second value equals from an array
        /// </summary>
        [TestMethod]
        public void sorting_second_value_equal()
        {
            SimpleClass[] myInstances = { new SimpleClass(1, 2), new SimpleClass(3, 2), new SimpleClass(2, 2) };
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
            SimpleClass[] Expected = { new SimpleClass(0, 1), new SimpleClass(0, 2), new SimpleClass(0, 5) };
            Array.Sort(myInstances);
            Assert.AreEqual(myInstances, Expected);
        }
    }
}