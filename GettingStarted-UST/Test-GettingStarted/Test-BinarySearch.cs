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
        public void TestForExistingElementBeginning()
        {

            int[] inputArray = { 4, 5, 6 };
            int key = 4;
            int expected = 0;
            BinarySearch mysearch = new BinarySearch(inputArray, key);
            int actual = mysearch.DoSearch(inputArray, key);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test method once the search element is in the middle of an array
        /// </summary>
        [TestMethod]
        public void TestForExistingElementMiddle()
        {

            int[] inputArray = { 4, 5, 6 };
            int key = 5;
            int expected = 1;
            BinarySearch mysearch = new BinarySearch(inputArray, key);
            int actual = mysearch.DoSearch(inputArray, key);

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test method once the search element is in the end of an array
        /// </summary>
        [TestMethod]
        public void TestForExistingElementEnd()
        {

            int[] inputArray = { 4, 5, 6 };
            int key = 6;
            int expected = 2;
            BinarySearch mysearch = new BinarySearch(inputArray, key);
            int actual = mysearch.DoSearch(inputArray, key);

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test method for non-existing element
        /// </summary>
        [TestMethod]
        public void TestForNonexistingElement()
        {

            int[] inputArray = { 4, 5, 6 };
            int key = 1;
            int expected = ~0;
            BinarySearch mysearch = new BinarySearch(inputArray, key);
            int actual = mysearch.DoSearch(inputArray, key);

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test method for non-existing element less than all array elements
        /// </summary>
        [TestMethod]
        public void TestForNonexistingElementLessThanAllArrayElements()
        {
            int[] inputArray = { 4, 5, 6 };
            int key = 2;
            int expected = ~0;
            BinarySearch mysearch = new BinarySearch(inputArray, key);
            int actual = mysearch.DoSearch(inputArray, key);

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test method for non-existing element less than 2 array elements
        /// </summary>
        [TestMethod]
        public void TestForNonexistingElementLessThanTwoArrayElements()
        {
            int[] inputArray = { 2, 5, 7 };
            int key = 3;
            int expected = ~1;
            BinarySearch mysearch = new BinarySearch(inputArray, key);
            int actual = mysearch.DoSearch(inputArray, key);

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test method for non-existing element less than 1 array elements
        /// </summary>
        [TestMethod]
        public void TestForNonexistingElementLessThanOneArrayElements()
        {
            int[] inputArray = { 2, 5, 7 };
            int key = 6;
            int expected = ~2;
            BinarySearch mysearch = new BinarySearch(inputArray, key);
            int actual = mysearch.DoSearch(inputArray, key);

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test method for non-existing element greater than all array elements
        /// </summary>
        [TestMethod]
        public void TestForNonexistingElementGreaterThanAllArrayElements()
        {

            int[] inputArray = { 4, 5, 6 };
            int key = 7;
            int expected = ~(2+1);
            BinarySearch mysearch = new BinarySearch(inputArray, key);
            int actual = mysearch.DoSearch(inputArray, key);

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test method for non-existing element greater than 2 array elements
        /// </summary>
        [TestMethod]
        public void TestForNonexistingElementGreaterThanTwoArrayElements()
        {

            int[] inputArray = { 2, 4, 6 };
            int key = 5;
            int expected = ~(1 + 1);
            BinarySearch mysearch = new BinarySearch(inputArray, key);
            int actual = mysearch.DoSearch(inputArray, key);

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test method for non-existing element greater than 1 array element
        /// </summary>
        [TestMethod]
        public void TestForNonexistingElementGreaterThanAOneArrayElements()
        {

            int[] inputArray = { 2, 4, 6 };
            int key = 3;
            int expected = ~(0 + 1);
            BinarySearch mysearch = new BinarySearch(inputArray, key);
            int actual = mysearch.DoSearch(inputArray, key);

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test method for non-sorted array even if element is present in the array elements
        /// </summary>
        [TestMethod]
        public void TestForNonSortedArrayEvenIfKeyIsPresent()
        {
            int[] inputArray = { 6, 2, 4 };
            int key = 2;
            int expected = -1;
            BinarySearch mysearch = new BinarySearch(inputArray, key);
            int actual = mysearch.IsSorted(inputArray);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test method for non-sorted array even if element is not present in the array elements
        /// </summary>
        [TestMethod]
        public void TestForNonSortedArrayEvenIfKeyIsNotPresent()
        {
            int[] inputArray = { 6, 2, 4 };
            int key = 1;
            int expected = -1;
            BinarySearch mysearch = new BinarySearch(inputArray, key);
            int actual = mysearch.IsSorted(inputArray);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test method for exception thrown for null array
        /// </summary>
        [TestMethod]
        public void TestForNullArray()
        {
            int[] inputArray = {};
            int key = 7;
            string expected = "Array is Empty";
            BinarySearch mysearch = new BinarySearch(inputArray, key);
            int actual = mysearch.DoSearch(inputArray, key);
            Equals(expected, actual);
        }

        /// <summary>
        /// Test method for exception thrown for multidimensional array
        /// </summary>
        [TestMethod]
        public void TestForMultiDimensionalArray()
        {
            int[,] inputArray = { { 1, 2, 3} , { 4, 5, 6} };
            int key = 7;
            string expected = "Array is Multi-dimensional";
            BinarySearch mysearch = new BinarySearch(inputArray, key);
            string actual = mysearch.MultiException(inputArray);
            Equals(expected, actual);
        }

        /// <summary>
        /// Exception to be thrown for Argument
        /// </summary>
        [TestMethod]
        public void TestForArgumentException()
        {
            int[] inputArray = { 3 };
            int key = 2;
            string expected = "Argument not valid";
            BinarySearch mysearch = new BinarySearch(inputArray, key);
            int actual = mysearch.DoSearch(inputArray, key);
            Equals(expected, actual);
        }

        /// <summary>
        /// Exception to be thrown for Operation
        /// </summary>
        [TestMethod]
        public void TestForInvalidOperationException()
        {
            int[] inputArray = { 1 };
            int key = 4;
            string expected = "Operation not valid";
            BinarySearch mysearch = new BinarySearch(inputArray, key);
            //int actual = mysearch.OperationExcep(inputArray, key);
            Assert.AreEqual(expected, mysearch);
        }
    }
}
