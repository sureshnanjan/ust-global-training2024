using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GettingStarted_UST;

namespace Test_GettingStarted
{
    internal class SortedArray : IComparable<SortedArray>
    {
        int value; // simpleClass(1,2)  simpleClass(1,3), simple(0,1), simpl(1,0)
        int value2;
        public SortedArray(int val, int val1)
        {
            this.value = val;
            this.value2 = val1;

        }

        public int Value { get { return this.value; } }
        public int Value2 { get { return this.value2; } }
        public override string? ToString()
        {

            return this.value.ToString() + "-" + this.value2.ToString(); // SimpleClass(1,2) prints as  "value-value2"

            //return this.value.ToString(); // SimpleClass(1,2) prints as  "value-value2"
        }

        public override bool Equals(object? obj)
        {
            return this.value.Equals(((SortedArray)obj).Value);
        }

        public int CompareTo(SortedArray? other)
        {

            return this.value.CompareTo(other.Value);
        }
    }
}