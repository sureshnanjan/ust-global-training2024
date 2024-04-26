using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarted_UST
{
    public class LambdaAssignement
    {
        List<int> myNumber = new List<int>();

      public LambdaAssignement(List<int> number) 
        { 
            this.myNumber = number;
        }
        public void showList() 
        {
            Console.Write("Original List of numbers:");

            foreach (int number in myNumber)
            {
                Console.Write("  "+number);
            }
            Console.WriteLine();
        }
        /// <summary>
        /// Adding numbers in a list
        /// </summary>
        public void addNumbers()
        {          
            int result = myNumber.Aggregate((arg1,arg2) => arg1 + arg2);
            Console.WriteLine($"\nSum of list of numbers:\t {result}");
        }
        /// <summary>
        /// Subtracting numbers in a list
        /// </summary>
        public void subNumbers()
        {
            int result = myNumber.Aggregate((arg1, arg2) => arg1 - arg2);
            Console.WriteLine($"\nDifference of list of numbers: {result}");
        }
        /// <summary>
        /// Multiplying numbers in a list
        /// </summary>
        public void productOfNumbers() 
        {
            int result = myNumber.Aggregate((arg1, arg2) => arg1 * arg2);
            Console.WriteLine($"\nProduct of list of numbers: {result}");
        }
        /// <summary>
        ///Square of numbers in a list
        /// </summary>
        
        public void squareOfNumbers()
        {
            var result = myNumber.Select(arg => arg * arg);
            Console.Write("\nSquare of numbers: ");
            foreach (int number in result) 
            { 
                Console.Write("  "+number);
            }
        }
    }
}
