using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarted_UST
{
    internal class OperatorOverloading
    {
        private int number;

        public OperatorOverloading(int num)
        {
            this.number = num;
        }

        public OperatorOverloading()
        {
        }

        // Overloading of Binary "+" operator
        public static OperatorOverloading operator +(OperatorOverloading Calc1,
                                             OperatorOverloading Calc2)
        {
            OperatorOverloading Calc3 = new OperatorOverloading(0);
            Calc3.number = Calc2.number + Calc1.number;
            return Calc3;
        }

        // function to display result
        public void display()
        {
            Console.WriteLine("{0}", number);
        }

    }
}
