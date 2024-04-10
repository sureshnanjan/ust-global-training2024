using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GettingStarted_UST;

namespace Test_GettingStarted
{
    /// <summary>
    /// CollectionSample to maintain List of Sample class objects
    /// </summary>
    internal class CollectionSample: IEnumerable<ClassSample>
    {
        List<ClassSample> list;

        //Constructor of CollectionSample
        public CollectionSample()
        {
            list = new List<ClassSample>();
            list.Add(new ClassSample(1));
            list.Add(new ClassSample(2));
            list.Add(new ClassSample(3));
            list.Add(new ClassSample(4));
            list.Add(new ClassSample(5));
        }

        //Overloading the Index Specifier
        public ClassSample this[int index] 
        {
            get => list[index];
            set => list[index] = value;
        }

        IEnumerator<ClassSample> IEnumerable<ClassSample>.GetEnumerator() 
        {
            return list.GetEnumerator();
        }

        public IEnumerator GetEnumerator() 
        { 
            return list.GetEnumerator();
        }

    }
}
