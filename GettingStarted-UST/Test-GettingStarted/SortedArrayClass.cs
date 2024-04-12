using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GettingStarted_UST;

namespace Test_GettingStarted
{
    internal class SortedArrayClass : IComparable<SortedArrayClass>
    {
        int value; // simpleClass(1,2)  simpleClass(1,3), simple(0,1), simpl(1,0)
        int value2;
        public SortedArrayClass(int val, int val1)
        {
            this.value = val;
            this.value2 = val1;

        }