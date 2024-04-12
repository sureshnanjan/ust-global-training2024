using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarted_UST
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
