using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Test_GettingStarted
{
    public class DataOperations
    {
        public int value;
        public Boolean outcome;

        Func<int, bool> isEven = CheckEven;

        public static bool CheckEven(int number)
        {

            return number % 2 == 0;

        }


    }


}
