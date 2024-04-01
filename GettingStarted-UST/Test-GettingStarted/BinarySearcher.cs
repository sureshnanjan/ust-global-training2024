
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

        internal int doSearch()
        {
            // 
            int searchitem = Array.BinarySearch(myinputArray, searchTerm);
            if (searchitem >= 0)
            { 
                return searchitem + 1;
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}