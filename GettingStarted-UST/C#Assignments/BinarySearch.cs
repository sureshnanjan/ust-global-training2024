using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Assignments
{
    /// <summary>
    /// Represents a class for performing binary search on a sorted array.
    /// </summary>
    public class BinarySearch
    {
        private int[] myinputArray;
        private int searchTerm;

        /// <summary>
        /// Initializes a new instance of the BinarySearch class with the specified array and search item.
        /// </summary>
        /// <param name="myinputArray">The sorted one-dimensional array to search.</param>
        /// <param name="searchTerm">The value to search for.</param>
        public BinarySearch(int[] myinputArray, int searchTerm)
        {
            this.myinputArray = myinputArray;
            this.searchTerm = searchTerm;
        }

        public int DoSearch()
        {
            throw new NotImplementedException();
        }
    }
}
