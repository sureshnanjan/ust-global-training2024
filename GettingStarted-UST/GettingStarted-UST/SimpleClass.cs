using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarted_UST
{
    public class SimpleClass: IComparable<SimpleClass>, ICloneable
    {

        {
         }
        {

        }
        public SimpleClass(int val)
        {
            this.value1 = val;
            this.value2 = val;
            this.name = String.Empty;
        }
        public int Value { get { return this.value1; } }

        public string Name { get { return this.name; } }

        {
        }

        {
        }

        /// <summary>
        /// Overriden method to perform comparison of items
        /// </summary>
        /// <param name="other">object of SimpleClass</param>
        /// <returns>Returns value after comparison</returns>
        public int CompareTo(SimpleClass? other)
        {
        {
        }
        }


    }
}
