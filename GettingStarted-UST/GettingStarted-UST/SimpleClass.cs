using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarted_UST
{
    public class SimpleClass: IComparable<SimpleClass>
    {
        int value; // simpleClass(1,2)  simpleClass(1,3), simple(0,1), simpl(1,0)
        int value2;
        public SimpleClass(int val1, int val2)
        {
            this.value = val1;
            this.value2 = val2;
            
        }

        public int MyValue { get { return this.value ; } }
        
        /// <summary>
        /// changed ToString
        /// </summary>
        
        public override string? ToString()
        {
            var returnValue = this.value.ToString() + "-" + this.value2.ToString();
            return returnValue;//SimpleClass(1,2) prints as  "value-value2"
        }

        public override bool Equals(object? obj)
        {
            return this.value.Equals(((SimpleClass)obj).MyValue);
        }

        public int CompareTo(SimpleClass other)
        {
            if(this.value.CompareTo(other.value)==0)
            {
                return this.value2.CompareTo(other.MyValue);
            }
            else
            {
                return this.value.CompareTo(other.MyValue);

            }
        }
    }
}
