using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarted_UST
{
    public class NameSorter : IComparer<SimpleClass>
    {
        public int Compare(SimpleClass? x, SimpleClass? y) => x.Name.CompareTo(y.Name);
    }
}
