using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarted_UST
{
    /// <summary>
    /// Class to perform comparison and string conversion
    /// </summary>
    public class SimpleClass : IComparable<SimpleClass>
    {
        int value, value2;
        private int v;

        /// <summary>
        /// constructor with 2 parameters
        /// </summary>
        /// <param name="val"></param>
        /// <param name="val2"></param>
        public SimpleClass(int val, int val2)
        {
            this.value = val;
            this.value2 = val2;
        }

        /// <summary>
        /// Constructor with single parameter
        /// </summary>
        /// <param name="v"></param>
        public SimpleClass(int v)
        {
            this.v = v;
        }

        /// <summary>
        /// To get Value3
        /// </summary>
        public int Value3 
        { 
            get 
            { 
                return this.value; 
            } 
        }

        /// <summary>
        /// To get Value4
        /// </summary>
        public int Value4 
        { 
            get 
            {
                return this.value2; 
            } 
        }

        /// <summary>
        /// Overriden method to perform string conversion
        /// </summary>
        /// <returns>Returns string in the format item-item</returns>
        public override string? ToString()
        {
            return this.value.ToString() + "-" + this.value2.ToString();
        }

        /// <summary>
        /// Overriden method to perform comparison of items
        /// </summary>
        /// <param name="other">object of SimpleClass</param>
        /// <returns>Returns value after comparison</returns>
        public int CompareTo(SimpleClass? other)
        {
            if ((value.CompareTo(other.value)) == 0)
            {
                return value2.CompareTo(other.value2);
            }
            return value.CompareTo(other.value);
        }
    }
}
