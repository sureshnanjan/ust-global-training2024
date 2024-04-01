
using System.Collections;

namespace Test_GettingStarted
{
    internal class BinarySearcher
    {
        private int[] myinputArray;
        private int searchItem;

        public BinarySearcher(int[] myinputArray, int searchItem)
        {
            this.myinputArray = myinputArray;
            this.searchItem = searchItem;
        }

        internal int doSearch()
        {
            // 
            int itemSearch = Array.BinarySearch(myinputArray, searchItem);
            if (itemSearch >= 0)
            {
                return itemSearch + 1;
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}