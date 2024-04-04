using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarted_UST
{
    public class SimpleClass : IComparable<SimpleClass>
    {
        int value; // simpleClass(1,2)  simpleClass(1,3), simple(0,1), simpl(1,0)
        int value2;
        public SimpleClass(int val, int val1)
        {
            this.value = val;
            this.value2 = val1;
        }

        public int Value { get { return this.value2; } }
        //public int Value1 { get {return this.value2; } }

        public override string? ToString()
        {
            return this.value.ToString() + "-" + this.value2.ToString();// SimpleClass(1,2) prints as  "value-value2"
        }

        public override bool Equals(object? obj)
        {
            return this.value.Equals(((SimpleClass)obj).Value);
        }

        public int CompareTo(SimpleClass? other)
        {
            if (this.value.CompareTo(other.Value) == 0)
            {
                return this.Value.CompareTo(other.Value);
            }
            return this.value.CompareTo(other.Value);
        }
    }
}
