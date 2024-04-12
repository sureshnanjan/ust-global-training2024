using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarted_UST
{
    public class SimpleTestCalss : IComparable<SimpleTestCalss>, ICloneable

    {

        int num1 = 10;
        int num2 = 0;
        String str;

        public SimpleTestCalss(int num1, string str)
        {
            this.num1 = num1;
            this.str = str;
        }

        public int CompareTo(SimpleTestCalss other)
        {
            return num1 - other.num1;

        }
        public object Clone()
        {
            throw new NotImplementedException();
        }
    }

     
}
