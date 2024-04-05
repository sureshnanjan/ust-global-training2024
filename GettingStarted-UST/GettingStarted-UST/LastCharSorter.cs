using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarted_UST
{
    internal class LastCharSorter : IComparer<SimpleClass>
    {
        public int Compare(SimpleClass? x, SimpleClass? y)
        {
            return x.Name[x.Name.Length - 1].CompareTo(y.Name[y.Name.Length - 1]);
        }
    }
}
