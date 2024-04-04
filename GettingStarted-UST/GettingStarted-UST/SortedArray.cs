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
        public int myValue { get { return value; } }

        public override string ToString()
        {
            return this.value.ToString() + "-" + this.value1.ToString();
        }

        public override bool Equals(object? obj)
        {
            return this.value.Equals(((SortedArray)obj).myValue);
        }

        public int CompareTo(SortedArray? other)
        {
            return this.value.CompareTo(other.myValue);
        }
    }
}
