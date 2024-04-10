using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_GettingStarted
{
    /// <summary>
    /// Class Sample to hold an integer value 
    /// </summary>
    public class ClassSample
    {
        public int val1;
        public bool val2;

        //Constructor with integer type
        public ClassSample(int v)
        {
            this.val1 = v;
        }
        //Constructor with boolean type
        public ClassSample(bool v)
        {
            this.val2 = v;
        }

        public int Value { get { return this.val1; } }

        // Overloading for - operator
        public static ClassSample operator -(ClassSample a, ClassSample b)
        {
            return new ClassSample(a.val1 - b.val1);
        }

        // Overloading for + operator
        public static ClassSample operator +(ClassSample a, ClassSample b)
        {
            return new ClassSample(a.val1 + b.val1);
        }

        // Overloading for > operator
        public static ClassSample operator >(ClassSample a, ClassSample b)
        {
            return new ClassSample(a.val1 > b.val1);
        }

        // Overloading for < operator
        public static ClassSample operator <(ClassSample a, ClassSample b)
        {
            return new ClassSample(a.val1 < b.val1);
        }
    }
}
