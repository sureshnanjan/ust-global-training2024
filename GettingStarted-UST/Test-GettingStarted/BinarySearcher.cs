
namespace Test_GettingStarted
{
    /// <summary>
    /// Handling Binary search inside an Array
    /// </summary>
    internal class BinarySearcher
    {
        private int[] myinputArray;
        private int searchTerm;
        private int[,] myinputArray1;
        private float[] myinputArray2;

        
        //Constructor to load values
        public BinarySearcher(int[] myinputArray, int searchTerm)
        {
            this.myinputArray = myinputArray;
            this.searchTerm = searchTerm;
        }

        // Constructor to handle multi dimentional array 
        public BinarySearcher(int[,] myinputArray1, int searchTerm)
        {
            throw new RankException();
        }

        //Constructor to search invalid search element type
        public BinarySearcher(int[] myinputArray2, float searchTerm)
        {
            throw new ArgumentException();
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

        //Method declartion for invalid call
        internal int doSearchandCompare()
        {
            throw new InvalidOperationException();
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