using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_GettingStarted
{
    public class SampleClass
    {
        public int value1; // simpleClass(1,2)  simpleClass(1,3), simple(0,1), simpl(1,0)
        public bool v;
        
        public SampleClass(int val)
        {
            this.value1 = val;
                       
        }
        public SampleClass(bool val)
        {
            this.v = val;
        }

       public int Value { get { return this.value1; } }

        public static SampleClass operator *(SampleClass a, SampleClass b)
        {
            return new SampleClass(a.value1 * b.value1);
        }

        public static SampleClass operator < (SampleClass a, SampleClass b)
        {
            
                return new SampleClass(a.value1 > b.value1);
            
            
        }

        public static SampleClass operator >(SampleClass a, SampleClass b)
        {
            return new SampleClass(a.value1 > b.value1);
        }
    }
}
