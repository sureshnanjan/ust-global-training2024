
namespace Test_GettingStarted
{
    /// <summary>
    /// Performing binary search inside an array
    /// </summary>
    internal class BinarySearchOperation
    {
        private int[] myArray;
        private int searchTerm;

        //Constructor to initialise values to the variables
        public BinarySearchOperation(int[] myArray, int searchTerm)
        {
            this.myArray = myArray;
            this.searchTerm = searchTerm;
        }

        //Performing search operation
        internal int perfSearch()
        {
            int searchItem = Array.BinarySearch(myArray, searchTerm);
            if (confirmsortedarray(myArray))
            {
                if (searchItem >= 0)
                {
                    return searchItem + 1;
                }
                else
                {
                    return searchItem - 1;
                }
            }
            return -1;

        }

        //Verify given array is sorted or not
        private bool confirmsortedarray(int[] myinputArray)
        {
            for (int i = 1; i < myinputArray.Length; i++)
                if (myinputArray[i - 1] > myinputArray[i])
                    return false;
            return true;
        }
    }
}