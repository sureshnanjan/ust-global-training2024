

namespace Test_GettingStarted
{
    /// <summary>
    /// Supports Delegate functionality Testing scenarios
    /// </summary>
    internal class DelegateClass
    {
        public string displayMessage = null;
        /// <summary>
        /// Displays given 2 values
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        internal void displayValues(int v1, int v2)
        {
            Console.WriteLine($"first Value: {v1}  and Second Value: {v2}");
            displayMessage = $"first Value: {v1}  and Second Value: {v2}";
        }

        /// <summary>
        /// validate given value is less than 5
        /// </summary>
        /// <param name="v1"></param>
        /// <returns>Bool true or False</returns>
        internal bool lessThan5(int v1)
        {
            return v1 < 5;
        }
    }
}