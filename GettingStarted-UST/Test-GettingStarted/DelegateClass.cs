

namespace Test_GettingStarted
{
    /// <summary>
    /// Supports Delegate functionality Testing scenarios
    /// </summary>
    internal class DelegateClass
    {
        //Displays given 2 values
        internal void displayValues(int v1, int v2)
        {
            Console.WriteLine($"first Value: {v1}  and Second Value: {v2}");
        }

        //Return true if the given value is less than 5, else false
        internal bool lessThan5(int v1)
        {
            return v1 < 5;
        }
    }
}