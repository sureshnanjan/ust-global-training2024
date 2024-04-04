using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarted_UST
{
    internal class NameSorter : IComparer<SimpleClass>
    {
        public int Compare(SimpleClass? x, SimpleClass? y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
