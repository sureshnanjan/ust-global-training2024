using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Assignments
{
    /// <summary>
    /// Represents a simple class with a single integer property and an overloaded addition operator.
    /// </summary>
    internal class SimpleClass
    {
        /// <summary>
        /// Gets or sets the value of the property.
        /// </summary>
        public int ValueOne {  get; set; }

        /// <summary>
        /// Initializes a new instance of the SimpleClass class with the specified value.
        /// </summary>
        /// <param name="valueOne">The value to assign to the property.</param>
        public SimpleClass(int valueOne)
        {
            ValueOne= valueOne;

        }


        /// <summary>
        /// Overloaded addition operator to add two SimpleClass instances.
        /// </summary>
        /// <param name="classOne">The first SimpleClass instance.</param>
        /// <param name="classTwo">The second SimpleClass instance.</param>
        /// <returns>The sum of the ValueOne properties of the two SimpleClass instances.</returns>
        public static int operator +(SimpleClass classOne, SimpleClass classTwo)
        {
            return classOne.ValueOne + classTwo.ValueOne;
        }
    }
}
