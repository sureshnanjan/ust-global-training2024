using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GettingStarted_UST;

namespace Test_GettingStarted
{
    internal class ArraySortedClass :IComparable<ArraySortedClass>
    {
        int value1;
        int value2;

        public ArraySortedClass(int val1, int val2)
        {
            this.value1 = val1;
            this.value2 = val2;
        }

        public int Value1 { get {return this.value1; } }
        public int Value2 { get {return this.value2; } }

        public override string ToString()
        {
            ///Prints value1-value2
            return this.value1.ToString() + '-' + this.value2.ToString();
        }

        public override bool Equals(object? obj)
        {
            return this.value1.Equals(obj as ArraySortedClass);
        }
        public int CompareTo(ArraySortedClass? other)
        {
            return this.value1.CompareTo(other.Value1);
        }
    }
}
