using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Assignments
{
    public class CustomSortArray:IComparable<CustomSortArray>
    {
        /// <summary>
        /// Gets or Sets first value.
        /// </summary>
        public int FirstValue { get; set; } // simpleClass(1,2)  simpleClass(1,3), simple(0,1), simpl(1,0)
        /// <summary>
        /// Gets or Sets second value.
        /// </summary>
        public int SecondValue { get; set; }
        /// <summary>
        /// Initializes a new instance of the SimpleClass class.
        /// </summary>
        /// <param name="firstValue">The first integer value.</param>
        /// <param name="secondValue">The second integer value.</param>
        public CustomSortArray(int firstValue, int secondValue)
        {
            FirstValue = firstValue;
            SecondValue = secondValue;

        }
        /// <summary>
        ///  This Function returns a string in the format "FirstValue-SecondValue".
        /// </summary>
        /// <returns>Returns a string</returns>
        public override string? ToString()
        {
            return $"{FirstValue}-{SecondValue}"; // SimpleClass(1,2) prints as  "value-value2"
        }
        /// <summary>
        /// Compares the current instance with another CustomSortArray object and returns an integer .
        /// </summary>
        /// <param name="other">The CustomSortArray object to compare with current instance.</param>
        public int CompareTo(CustomSortArray? other)
        {
            int result = FirstValue.CompareTo(other.FirstValue);

            if (result == 0)
            {
                result = SecondValue.CompareTo(other.SecondValue);
            }
            return result;
        }
    }
}
