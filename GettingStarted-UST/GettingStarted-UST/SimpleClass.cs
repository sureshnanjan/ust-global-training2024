using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarted_UST
{
    public class SimpleClass: IComparable<SimpleClass>, ICloneable
    {
        int value1; // simpleClass(1,2)  simpleClass(1,3), simple(0,1), simpl(1,0)
        int value2;
        string name;

        
        public SimpleClass(int val, string name)
        {
            this.value1 = val;

            this.name = name;

        }
        public SimpleClass(int val, int val1)
        {
            this.value1 = val;

            this.value2 = val1;

        }
        public SimpleClass(int val)
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
            return this.value1.Equals(((SimpleClass)obj).Value);
        }

        public int CompareTo(SimpleClass? other)
        {
            return this.value1.CompareTo(other.Value);  //SimpleClass(1,2) SimpleClass(1,0),SimpleClass(2,2) SimpleClass(3,0),
        }

        public object Clone()
        {
            
            return new SimpleClass(this.value1);
        }

        public int myIntReturningMethod(int param1, string param2) {
            Console.WriteLine("Execuring this inthe SimpleClass.myINtReturn Method");
            return 0;
        }


    }
}
