using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarted_UST
{
    public class SortedArray : IComparable<SortedArray>
    {
        
        int value;
        int value1;
        
        public SortedArray (int val, int val1 )
        {
            this.value = val;
            this.value1 = val1;
        }
        public int MyValue { get { return value; } }

        public override string ToString()
        {
            return this.value.ToString() + "-" + this.value1.ToString();
        }

        public override bool Equals(object? obj)
        {
            return this.value.Equals(((SortedArray)obj).MyValue);
        }

        public int CompareTo(SortedArray? other)
        {
            if(this.value.CompareTo(other.MyValue)==0)
            {
                return this.value1.CompareTo(other.MyValue);
            }
            return this.value.CompareTo(other.MyValue);
        }
    }
}
