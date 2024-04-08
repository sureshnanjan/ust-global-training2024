using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GettingStarted_UST;

namespace Test_GettingStarted
{
    internal class SampleCollection : IEnumerable<SampleClass>
    {
        List<SampleClass> list;

        public SampleCollection()
        {
            list = new List<SampleClass>();
            list.Add(new SampleClass(1));
            list.Add(new SampleClass(2));
            list.Add(new SampleClass(3));
            list.Add(new SampleClass(4));
            list.Add(new SampleClass(5));
        }
        
        public SampleClass this[int i]
        {
            get => list[i];
            set => list[i] = value;

        }

        IEnumerator<SampleClass> IEnumerable<SampleClass>.GetEnumerator()
        {
            return list.GetEnumerator();
        }

        public IEnumerator GetEnumerator()
        {
            return list.GetEnumerator();
        }
    }
}
