
namespace Test_GettingStarted
{
    /// <summary>
    /// Handling Binary search inside an Array
    /// </summary>
    internal class BinarySearcher
    {
        private int[] myinputArray;
        private int searchTerm;

        //Constructor to load values
        public BinarySearcher(int[] myinputArray, int searchTerm)
        {
            this.myinputArray = myinputArray;
            this.searchTerm = searchTerm;
        }

        //Perform search action
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

        //Verify given array is sorted or not
        private bool confirmsortedarray(int[] myinputArray)
        {
            for(int i = 1;i< myinputArray.Length; i++)
                if (myinputArray[i - 1] > myinputArray[i])
                    return false;
            return true;
        }
    }
}