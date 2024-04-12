﻿
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


            int searchValue = Array.BinarySearch(myinputArray, searchTerm);
            
            
                if (searchValue >= 0)
                {
                    return searchValue + 1;
                }
                else
                {
                    return searchValue - 1;
                }
            
            
            throw new NotImplementedException();
        }
    }
}