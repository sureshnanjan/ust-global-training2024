using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarted_UST
{
    public delegate int AddNum(int param1, int param2);
    public delegate int Product(int param1, int param2);

    /// <summary>
    /// Class for the usage of Delegate
    /// </summary>
    public class DelegateDemo
    {
        /// <summary>
        /// Method to add integers
        /// </summary>
        /// <param name="param1">First integer</param>
        /// <param name="param2">Second integer</param>
        /// <returns></returns>
        public int Add(int param1, int param2)
        {
            int sum = param1 + param2;
            Console.WriteLine($"{param1} + {param2} = {sum}");
            return sum;
        }

        /// <summary>
        /// Method to multiply Integers
        /// </summary>
        /// <param name="param1">First Integer</param>
        /// <param name="param2">Second Integer</param>
        /// <returns></returns>
        public int Mutliply(int param1, int param2)
        {
            int prodOfNumbers = param1 * param2;
            Console.WriteLine($"{param1} * {param2} = {prodOfNumbers} \n");
            return prodOfNumbers;
        }

    }
}
