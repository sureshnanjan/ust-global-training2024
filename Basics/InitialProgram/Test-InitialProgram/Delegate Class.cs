using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_InitialProgram
{
    /// <summary>
    /// Testing scenarios that supports Delegate Functionality 
    /// </summary>
    internal class Delegate_Class
    {
        //Displays given 2 values
        internal void displayValues(int val1, int val2)
        {
            Console.WriteLine($"first Value: {val1}  and Second Value: {val2}");
        }

        //Return true if the given value is less than 5, else false
        internal bool lessThan5(int val1)
        {
            return val1 < 5;
        }
    }
}
