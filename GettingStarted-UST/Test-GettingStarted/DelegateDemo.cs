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
        
        public DelegateDemo() 
        {
            Action<bool> display = DisplayValue;
            DisplayValue(false);

        }

        private void DisplayValue(bool val1)
        {
            Console.WriteLine($"Value is {val1}");
        }
    }
}
