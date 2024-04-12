using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarted_UST
{
    public delegate int AddNum(int param1, int param2);
    public delegate int Product(int param1, int param2);

    public class DelegateDemo
    {
        public int Add(int param1, int param2)
        {
            int sum = param1 + param2;
            Console.WriteLine($"{param1} + {param2} = {sum}");
            return sum;
        }

        public int Mutliply(int param1, int param2)
        {
            int prodOfNumbers = param1 * param2;
            Console.WriteLine($"{param1} * {param2} = {prodOfNumbers}");
            return prodOfNumbers;
        }

    }
}
