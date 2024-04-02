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
        public static void Main(string[] args)
        {
            /* Calculator calculator = new Calculator();
              int result = calculator.add(10000,20000);
              int result1 = calculator.subtract(2,1);

              Console.WriteLine($"When I add 1,2 the resut is {result} when i subtract 2, 1 the result is {result1}");
            */
            MyClassDemo inst = new MyClassDemo("Red", 40, 20);
            inst.Move(10);
            MyClassDemo inst1 = new MyClassDemo("Green", 40, 25);
            inst1.Move(10);
            Console.WriteLine($"{MyClassDemo.NoOfObjects} are created");
            MyClassDemo inst2 = new MyClassDemo("Grey", 40, 25);
            inst2.Move(10);
            MyClassDemo.CommonMethod();
        }
    }
}
