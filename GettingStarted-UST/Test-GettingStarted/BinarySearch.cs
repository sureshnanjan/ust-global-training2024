
namespace Test_GettingStarted
{
    /// <summary>
    /// Class to perform binary search
    /// </summary>
    internal class BinarySearch
    {
        private int[] inputArray;
        private int key;

        /// <summary>
        /// Constructor of binary search
        /// </summary>
        /// <param name="inputArray">Array in which search needs to be done</param>
        /// <param name="key">Element to be searched for</param>
        public BinarySearch(int[] inputArray, int key)
        {
            this.inputArray = inputArray;
            this.key = key;
        }

        /// <summary>
        /// Method to perform binary search
        /// </summary>
        /// <param name="inputArray">Search Array</param>
        /// <param name="key">Search Element</param>
        /// <returns></returns>
        public int dosearch(int[] inputArray, int key)
        {
            int min = 0;
            int max = inputArray.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (key == inputArray[mid])
                {
                    return ++mid;
                }
                else if (key < inputArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return 0;
        }
    }
}