
namespace Test_GettingStarted
{
    internal class BinarySearch
    {
        private int[] inputArray;
        private int key;

        public BinarySearch(int[] inputArray, int key)
        {
            this.inputArray = inputArray;
            this.key = key;
        }

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