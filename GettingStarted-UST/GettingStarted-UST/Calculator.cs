using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarted_UST
{
    /// <summary>
    /// To do Addition & Subtraction of integers
    /// </summary>
    public class Calculator
    {
        /// <summary>
        /// Method to perform addition of integers
        /// </summary>
        /// <param name="param1">First Integer of addition</param>
        /// <param name="param2">Second Integer of addition</param>
        /// <returns></returns>
        public int add(int param1, int param2) 
        { 
            return param1 + param2; 
        }

        /// <summary>
        /// Method to perform subtraction of integers
        /// </summary>
        /// <param name="param1">First Integer of subtraction</param>
        /// <param name="param2">Second Integer of subtraction</param>
        /// <returns></returns>
        public int subtract(int param1, int param2) 
        { 
            return param1 - param2; 
        } 
    }
}
