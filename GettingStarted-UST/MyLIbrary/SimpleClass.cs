using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLIbrary
{

    public class SimpleClass
    {

        private int value1;
        private int value2;

        public SimpleClass(int testValue1, int testValue2) {

            this.value1 = value1;
            this.value2 = value2;
        }
  

        public String GetFormattedValue()
        {
            //return "value1" + value1 + "-value2" + value2;
            return string.Format(value1 + "-" + value2);
        }
    }
}
