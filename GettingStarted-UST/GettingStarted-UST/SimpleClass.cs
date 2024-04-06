using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarted_UST
{
    internal class SimpleClass: IComparable<SimpleClass>
    {
        int value; // simpleClass(1,2)  simpleClass(1,3), simple(0,1), simpl(1,0)
        int value2;
        public SimpleClass(int val)
        {
            this.value = val;
            
        }

        public int Value { get { return this.value; } }

        public override string? ToString()
        {
            return this.value.ToString(); // SimpleClass(1,2) prints as  "value-value2"
        }

        public override bool Equals(object? obj)
        {
            return this.value.Equals(((SimpleClass)obj).Value);
        }

        public int CompareTo(SimpleClass? other)
        {
            return this.value.CompareTo(other.Value);
        }
    }
}
