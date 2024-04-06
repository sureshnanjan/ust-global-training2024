using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarted_UST
{
    public class SimpleClass : IComparable<SimpleClass>
    {
        int value, value2;

        public SimpleClass(int val, int val2)
        {
            this.value = val;
            this.value2 = val2;
        }

        public int Value { get { return this.value; } }
        public int Value2 { get { return this.value2; } }

        public override string? ToString()
        {
            return this.value.ToString() + "-" + this.value2.ToString();
        }

        public int CompareTo(SimpleClass? other)
        {
            if ((value.CompareTo(other.Value)) == 0)
            {
                return value2.CompareTo(other.Value2);
            }
            return value.CompareTo(other.Value);
        }
    }
}
