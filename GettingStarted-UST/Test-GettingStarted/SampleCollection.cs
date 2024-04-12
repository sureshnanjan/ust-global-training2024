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
    /// Sample CLass to maintain List of Sample class objects
    /// </summary>
    internal class SampleCollection : IEnumerable<SampleClass>
    {
        List<SampleClass> list;

        /// <summary>
        /// Constructor for sample collection
        /// </summary>
        public SampleCollection()
        {
            list = new List<SampleClass>();
            list.Add(new SampleClass(1));
            list.Add(new SampleClass(2));
            list.Add(new SampleClass(3));
            list.Add(new SampleClass(4));
            list.Add(new SampleClass(5));
        }

        /// <summary>
        /// Overloadin the index specifier
        /// </summary>
        /// <param name="i"></param>
        /// <returns>i value</returns>
        public SampleClass this[int i]
        {
            get => list[i];
            set => list[i] = value;
        }
        /// <summary>
        /// Get the enumerator details of sample class
        /// </summary>
        /// <returns>enumerator from List</returns>
        IEnumerator<SampleClass> IEnumerable<SampleClass>.GetEnumerator()
        {
            return list.GetEnumerator();
        }

        /// <summary>
        /// Overload the GetEnumerator method
        /// </summary>
        /// <returns>Enumenator from the list</returns>
        public IEnumerator GetEnumerator()
        {
            return list.GetEnumerator();
        }
    }
}
