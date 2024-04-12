
using Microsoft.VisualStudio.TestPlatform.ObjectModel;

namespace Test_GettingStarted
{
    /// <summary>
    /// Class to perform binary search
    /// </summary>
    public class BinarySearch
    {
        //private const int V = 0;
        private int[] inputArray;
        private int key;
        private int[,] inputArray1;

        /// <summary>
        /// Constructor of Single Dimensional Array
        /// </summary>
        /// <param name="inputArray">Array in which search needs to be done</param>
        /// <param name="key">Element to be searched for</param>
        public BinarySearch(int[] inputArray, int key)
        {
            this.inputArray = inputArray;
            this.key = key;
        }

        /// <summary>
        /// Constructor of Multi-Dimensional Array
        /// </summary>
        /// <param name="inputArray1">Array in which search needs to be done</param>
        /// <param name="key">Element to be searched for</param>
        public BinarySearch(int[,] inputArray1, int key)
        {
            this.inputArray1 = inputArray1;
            this.key = key;
        }


        /// <summary>
        /// Method to perform binary search on Single dimensional array
        /// </summary>
        /// <param name="inputArray">Search Array</param>
        /// <param name="key">Search Element</param>
        /// <returns></returns>
        public int DoSearch(int[] inputArray, int key)
        {
            int res = Array.BinarySearch(inputArray, key);
            if (inputArray ==  null)
            {
                throw new ArgumentNullException("Array is cempty");
            }
            /*else if(inputArray.Rank > 1)
            {
                throw new RankException("Array is Multidimensional");

            }*/
            else if (res < 0)
            {
                Console.WriteLine("\nThe element to search for " + "({0}) is not found.", key);
            }

            else
            {
                Console.WriteLine("The element to search for "
                                      + "({0}) is at index {1}.",
                                  key, res);
            }
            return res;
        }

        /// <summary>
        /// Determines if int array is sorted from 0 -> Max
        /// </summary>
        public int IsSorted(int[] inputArray)
        {
            for (int i = 1; i < inputArray.Length; i++)
            {
                if (inputArray[i - 1] > inputArray[i])
                {
                    return -1;
                }
            }
            return 0;
        }

        /// <summary>
        /// To catch Multi-dimensional array exception
        /// </summary>
        /// <param name="inputArray1">Multi-dimensional Array</param>
        /// <returns></returns>
        /// <exception cref="RankException">To throw Multi-dimensional Array</exception>
        public string MultiException(int[,] inputArray1)
        {
            if(inputArray1.Rank != 1)
            {
                throw new RankException("Array is Multi-dimensional");
            }
            return "Array is Multi-dimensional";
        }

    }
}