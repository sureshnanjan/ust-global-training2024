using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_GettingStarted
{
    internal class DelegateDemo
    {
        /// <summary>
        /// Demo os Delegate usage
        /// </summary>
        public DelegateDemo() 
        {
            Action<bool> display = DisplayValue;
            DisplayValue(false);

        }

        /// <summary>
        /// Method to display values
        /// </summary>
        /// <param name="val1"></param>
        private void DisplayValue(bool val1)
        {
            Console.WriteLine($"Value is {val1}");
        }
    }
}
