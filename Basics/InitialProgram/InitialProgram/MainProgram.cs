using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InitialProgram
{
    public class MainProgram
    {
        public static void Main(string[] args)
        {
             Calculator calculator = new Calculator();
                int result = calculator.add(1,2);
                int result1 = calculator.subtract(2,1);
                Console.WriteLine($"when I add 1,2 the result is{result} when I subtract 2,1 the result is {result1}");
            
         

        }
    }
}
