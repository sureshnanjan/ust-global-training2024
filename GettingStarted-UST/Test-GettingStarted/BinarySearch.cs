
using Microsoft.VisualStudio.TestPlatform.ObjectModel;

namespace Test_GettingStarted
{
    internal class BinarySearch
    {
        private int[] inPutArray;
        private int[,] inputArray;
        private int searchItem;
        private int key;

        public BinarySearch(int[] inPutArray, int searchItem)
        {
            this.inPutArray = inPutArray;
            this.searchItem = searchItem;
        }

        public BinarySearch(int[,] inputArray, int key)
        {
            this.inputArray = inputArray;
            this.key = key;
        }

        internal int doSearch(int[] inputArray, int key)
        {
            throw new NotImplementedException();
        }

        internal int IsSorted(int[] inputArray)
        {
            throw new NotImplementedException();
        }

        internal string MultiException(int[,] inputArray)
        {
            throw new NotImplementedException();
        }
    }
}