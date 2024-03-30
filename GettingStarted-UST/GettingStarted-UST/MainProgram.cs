using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLIbrary;

namespace GettingStarted_UST
{
    public class MainProgram
    {
        public static void Main(string[] args) {

            // call all your demo methods here
            Console.WriteLine("C# literals declaration");
            UsingLiterals mypgm = new UsingLiterals();
            mypgm.showUsage();
        

           Calculator calculator = new Calculator();
            int result = calculator.add(10000,20000);
            int result1 = calculator.subtract(2,1);

            Console.WriteLine($"When I add 1,2 the resut is {result} when i subtract 2, 1 the result is {result1}");



        }
    }
}
