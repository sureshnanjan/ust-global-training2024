namespace Test_GettingStarted
{
    /// <summary>
    /// Test class for binary search
    /// </summary>
    [TestClass]
    public class Test_BinarySearch
    {
        /// <summary>
        /// Test method once the search element is in the beginning of an array
        /// </summary>
        [TestMethod]
        public void test_for_existing_element_beginning()
        {

            int[] inputArray = { 4, 5, 6 };
            int key = 4;
            int expected = 1;
            BinarySearch mysearch = new BinarySearch(inputArray, key);
            int actual = mysearch.dosearch(inputArray, key);

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test method once the search element is in the middle of an array

        /// </summary>
        [TestMethod]
        public void test_for_existing_element_middle()
        {

            int[] inputArray = { 4, 5, 6 };
            int key = 5;
            int expected = 2;
            BinarySearch mysearch = new BinarySearch(inputArray, key);
            int actual = mysearch.dosearch(inputArray, key);

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test method once the search element is in the end of an array
        /// </summary>
        [TestMethod]
        public void test_for_existing_element_end()
        {

            int[] inputArray = { 4, 5, 6 };
            int key = 6;
            int expected = 3;
            BinarySearch mysearch = new BinarySearch(inputArray, key);
            int actual = mysearch.dosearch(inputArray, key);

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test method for non-existing element
        /// </summary>
        [TestMethod]
        public void test_for_nonexisting_element()
        {

            int[] inputArray = { 4, 5, 6 };
            int key = 2;
            int expected = ~1;
            BinarySearch mysearch = new BinarySearch(inputArray, key);
            int actual = mysearch.dosearch(inputArray, key);

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test method for non-existing element less than the array elements
        /// </summary>
        [TestMethod]
        public void test_for_nonexisting_element_less_than()
        {

            int[] inputArray = { 4, 5, 6 };
            int key = 2;
            int expected = ~1;
            BinarySearch mysearch = new BinarySearch(inputArray, key);
            int actual = mysearch.dosearch(inputArray, key);

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test method for non-existing element greater than the array elements
        /// </summary>
        [TestMethod]
        public void test_for_nonexisting_element_greater_than()
        {

            int[] inputArray = { 4, 5, 6 };
            int key = 7;
            int expected = ~(3+1);
            BinarySearch mysearch = new BinarySearch(inputArray, key);
            int actual = mysearch.dosearch(inputArray, key);

            Assert.AreEqual(expected, actual);
        }

    }
}
