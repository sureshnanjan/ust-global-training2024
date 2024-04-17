using System.Buffers;
using System.Collections;

namespace Test_GettingStarted
{
    /// <summary>
    /// Handling Binary search inside an Array
    /// </summary>
    internal class BinarySearcher
    {
        private int[] myinputArray;
        private int[,] myinputArray1;
        private int searchItem;
        private float[] myinputArray2;

        /// <summary>
        /// Constructor to load values
        /// </summary>
        /// <param name="myinputArray"></param>
        /// <param name="searchItem"></param>
        public BinarySearcher(int[] myinputArray, int searchItem)
        {
            this.myinputArray = myinputArray;
            this.searchItem = searchItem;
        }

        /// <summary>
        /// Constructor to handle multi dimentional array 
        /// </summary>
        /// <param name="myinputArray1"></param>
        /// <param name="searchItem"></param>
        /// <exception cref="RankException"></exception>
        public BinarySearcher(int[,] myinputArray1, int searchTerm)
        {
            throw new RankException();
        }

        /// <summary>
        /// Constructor to search invalid search element type
        /// </summary>
        /// <param name="myinputArray2"></param>
        /// <param name="searchItem"></param>
        /// <exception cref="ArgumentException"></exception>
        public BinarySearcher(int[] myinputArray2, float searchItem)
        {
            throw new ArgumentException();
        }

        /// <summary>
        /// Perform search action
        /// </summary>
        /// <returns> Positive 1 for greater than 0 values and -1 for rest all</returns>
        internal int doSearch()
        {

            int itemSearch = Array.BinarySearch(myinputArray, searchItem);
            if (confirmsortedarray(myinputArray))
            {
                if (itemSearch >= 0)
                {
                    return itemSearch + 1;
                }
                else
                {
                    return itemSearch - 1;
                }
            }

            return -1;
        }

        /// <summary>
        /// Method declartion for invalid call
        /// </summary>
        /// <returns>exception</returns>
        /// <exception cref="InvalidOperationException"></exception>
        internal int doSearchandCompare()
        {
            throw new InvalidOperationException();
        }

        /// <summary>
        /// Verify given array is sorted or not
        /// </summary>
        /// <param name="myinputArray"></param>
        /// <returns>bool true</returns>
        private bool confirmsortedarray(int[] myinputArray)
        {
            for (int i = 1; i < myinputArray.Length; i++)
                if (myinputArray[i - 1] > myinputArray[i])
                    return false;
            return true;
        }
    }

}