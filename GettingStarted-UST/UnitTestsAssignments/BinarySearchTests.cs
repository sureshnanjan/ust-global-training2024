using C_Assignments;

namespace UnitTestsAssignments
{
    /// <summary>
    /// Contains unit tests for the BinarySearcher class, testing various scenarios.
    /// </summary>
    [TestClass]
    public class BinarySearchTests
    {

        /// <summary>
        /// Tests binary search for an existing value in the array.
        /// </summary>
        [TestMethod]
        public void Test_for_existing_values()
        {

            int[] myinputArray = { 1, 2, 3 };
            int searchTerm = 3;
            int expected = 3;
            BinarySearch searcher = new BinarySearch(myinputArray, searchTerm);
            int actual = searcher.DoSearch();
            Assert.AreEqual(expected, actual);

        }
        /// <summary>
        /// Tests binary search for an existing value at the beginning of the input array.
        /// </summary>
        [TestMethod]
        public void Test_for_existing_values_inbeginning()
        {
            int[] myinputArray = { 1, 2, 3 };
            int searchItem = 1;
            int expected = 1;
            BinarySearch searcher = new BinarySearch(myinputArray, searchItem);
            int actual = searcher.DoSearch();
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Tests binary search for an existing value in the middle of the input array.
        /// </summary>
        [TestMethod]
        public void Test_for_existing_values_inmiddle()
        {
            int[] myinputArray = { 1, 2, 3 };
            int searchItem = 2;
            int expected = 2;
            BinarySearch searcher = new BinarySearch(myinputArray, searchItem);
            int actual = searcher.DoSearch();
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Tests binary search for an existing value at the end of the input array.
        /// </summary>
        [TestMethod]
        public void Test_for_existing_values_inend()
        {
            int[] myinputArray = { 1, 2, 3 };
            int searchItem = 3;
            int expected = 3;
            BinarySearch searcher = new BinarySearch(myinputArray, searchItem);
            int actual = searcher.DoSearch();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests binary search for an non existing value in the input array.
        /// </summary>
        [TestMethod]
        public void Test_for_non_existing_items()
        {
            int[] myinputArray = { 1, 2, 3 };
            int searchTerm = 4;
            int expected = ~4;
            BinarySearch searcher = new BinarySearch(myinputArray, searchTerm);
            int actual = searcher.DoSearch();
            Assert.AreEqual(expected, actual);

        }

        /// <summary>
        /// Tests binary search for an non existing value in the input array.
        /// </summary>
        [TestMethod]
        public void Testing_non_existent_item()
        {

            // If value is not found and value is less than one or more elements in array, the negative number returned is the
            // bitwise complement of the index of the first element that is larger than value. 
            int[] myinputArray = { 1, 2, 3 };
            int searchTerm = 0;
            int expected = ~1;
            BinarySearch searcher = new BinarySearch(myinputArray, searchTerm);
            int actual = searcher.DoSearch();
            Assert.AreEqual(expected, actual);

        }

        /// <summary>
        /// Throws ArgumentNullException when the input array is null.
        /// </summary>
        public void Nullinputarray_throws_ArgumentNullException()
        {
            int[] input = null;
            int searchTerm = 0;
            BinarySearch searcher = new BinarySearch(input, searchTerm);

            Assert.ThrowsException<ArgumentNullException>(() => { searcher.DoSearch(); });


        }

        /// <summary>
        /// Tests if an ArgumentException is thrown when the search term is of a type that is not compatible with the elements of the array.
        /// </summary>
        [TestMethod]
        public void DoSearch_ValueTypeIncompatibleWithArray_ArgumentExceptionThrown()
        {
            
            int[] inputArray = { 1, 2, 3 };
            string searchTerm ="value" ; // Using a string which is not compatible with int array
            BinarySearch searcher = new BinarySearch(inputArray, searchTerm);

            Assert.ThrowsException<ArgumentException>(() => searcher.DoSearch());
        }
    }
}