using System;
using System.Collections.Generic;
using System.Linq;


using System.Runtime.InteropServices;

using System.Text;
using System.Threading.Tasks;

namespace GettingStarted_UST
{

    public class SimpleClass : IComparable<SimpleClass>
    {
        int value; // simpleClass(1,2)  simpleClass(1,3), simple(0,1), simpl(1,0)
        int value2;
        public SimpleClass(int val)
        {
            this.value = val;

        }

        public SimpleClass(int val, string v) : this(val)
        {
        }

        public int Value { get { return this.value; } }

        public object Name { get; internal set; }

        public int CompareTo(GettingStarted_UST.SimpleClass? other)
        {
            throw new NotImplementedException();
        }

        public override string? ToString()
        {
            return this.value.ToString(); // SimpleClass(1,2) prints as  "value-value2"
        }

        internal int myIntReturningMethod(int arg1, string arg2)
        {
            throw new NotImplementedException();
        }

        public class SimpleClass1 : IComparable<SimpleClass1>, ICloneable
        {
            int value1; // simpleClass(1,2)  simpleClass(1,3), simple(0,1), simpl(1,0)
            int value2;
            string name;
            private object other;
            private object value;

            public SimpleClass1(int val, string name)
            {
                this.value1 = val;

                this.name = name;

            }
            public SimpleClass1(int val)
            {
                this.value1 = val;
                this.value2 = val;
                this.name = String.Empty;
            }
            public int Value { get { return this.value1; } }

            public string Name { get { return this.name; } }

            public override string? ToString()
            {
                return $"{this.value1}-{this.name}"; // SimpleClass(1,2) prints as  "value1-value2"

            }

            public override bool Equals(object? obj)
            {

                return this.value.Equals(((SimpleClass1)obj).Value);

                return this.value1.Equals(((SimpleClass1)obj).Value);

            }

            public int CompareTo(SimpleClass1? other)
            {
                return this.value.CompareTo(other.Value);
            }

            internal int MyIntReturningMethod(int arg1, string arg2)
            {
                {
                    throw new NotImplementedException();
                }
            }

            public object Clone()
            {

                return new SimpleClass1(this.value1);
            }

            public static int myIntReturningMethod(int param1, string param2)
            {
                Console.WriteLine("Execuring this inthe SimpleClass.myINtReturn Method");
                return 0;
            }

            public override int GetHashCode()
            {
                throw new NotImplementedException();
            }

            public static bool operator ==(SimpleClass1 left, SimpleClass1 right)
            {
                if (ReferenceEquals(left, null))
                {
                    return ReferenceEquals(right, null);
                }

                return left.Equals(right);
            }

            public static bool operator !=(SimpleClass1 left, SimpleClass1 right)
            {
                return !(left == right);
            }

            public static bool operator <(SimpleClass1 left, SimpleClass1 right)
            {
                return ReferenceEquals(left, null) ? !ReferenceEquals(right, null) : left.CompareTo(right) < 0;
            }

            public static bool operator <=(SimpleClass1 left, SimpleClass1 right)
            {
                return ReferenceEquals(left, null) || left.CompareTo(right) <= 0;
            }

            public static bool operator >(SimpleClass1 left, SimpleClass1 right)
            {
                return !ReferenceEquals(left, null) && left.CompareTo(right) > 0;
            }

            public static bool operator >=(SimpleClass1 left, SimpleClass1 right)
            {
                return ReferenceEquals(left, null) ? ReferenceEquals(right, null) : left.CompareTo(right) >= 0;
            }
        }
    }
}
