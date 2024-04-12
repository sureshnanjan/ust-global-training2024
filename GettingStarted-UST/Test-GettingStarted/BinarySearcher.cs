
using System.Collections;

namespace Test_GettingStarted
{
    internal class BinarySearcher
    {
        private int[] myinputArray;
        private int searchTerm;

        public BinarySearcher(int[] myinputArray, int searchTerm)
        {
            this.myinputArray = myinputArray;
            this.searchTerm = searchTerm;
        }

        // Constructor to handle Rank exception 
        public BinarySearcher(int[,] myinputArray1, int searchTerm)
        {
            throw new RankException();
        }

        //Constructor to handle Argument exception
        public BinarySearcher(int[] myinputArray2, float searchTerm)
        {
            throw new ArgumentException();
        }

        internal int doSearch()
        {
            int searchValue = Array.BinarySearch(myinputArray, searchTerm);
            if (confirmsortedarray(myinputArray))
            {
                if (searchValue >= 0)
                {
                    return searchValue + 1;
                }
                else
                {
                    return searchValue - 1;
                }
            }
            return -1;
        }
        //Method declartion for invalid call
        internal int doSearchandCompare()
        {
            throw new InvalidOperationException();
        }
        private bool confirmsortedarray(int[] myinputArray)
        {
            for (int i = 1; i < myinputArray.Length; i++)
                if (myinputArray[i - 1] > myinputArray[i])
                    return false;
            return true;
        }
    }
}