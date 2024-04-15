using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarted_UST
{
    /// <summary>
    /// Class to showcase Operator Overloading
    /// </summary>
    public class OperatorOverloading
    {
        private int number, number1, number2;

        /// <summary>
        /// Constructor with single parameter
        /// </summary>
        /// <param name="num">Number</param>
        public OperatorOverloading(int num)
        {
            this.number = num;
        }

        /// <summary>
        /// Constructor with no parameters
        /// </summary>
        public OperatorOverloading()
        {
        }

        /// <summary>
        /// Overloading of Binary "+" operator
        /// </summary>
        /// <param name="Calc1">First object of OperatorOverloading class</param>
        /// <param name="Calc2">Second object of OperatorOverloading class</param>
        /// <returns></returns>
        public static OperatorOverloading operator +(OperatorOverloading Calc1,
                                             OperatorOverloading Calc2)
        {
            OperatorOverloading Calc3 = new OperatorOverloading(0);
            Calc3.number = Calc2.number + Calc1.number;
            return Calc3;
        }

        /// <summary>
        /// Overloading of Unary "-" operator
        /// </summary>
        /// <param name="Calc1">First object of OperatorOverloading class</param>
        /// <param name="Calc2">Second object of OperatorOverloading class</param>
        /// <returns></returns>
        public static OperatorOverloading operator -(OperatorOverloading Calc1)
        {
            OperatorOverloading Calc2= new OperatorOverloading(0);
            Calc2.number = -Calc1.number;
            return Calc2;
        }

        /// <summary>
        /// Function to display result
        /// </summary>
        public void display()
        {
            Console.WriteLine("{0}", number);
        }

    }
}
