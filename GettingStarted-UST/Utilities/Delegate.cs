using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Delegate declaration
/// </summary>
public delegate int NumberMath(int n);

namespace GettingStarted_UST
{
    public class Delegate
    {
        static int num = 10;

        /// <summary>
        /// Method for addition
        /// </summary>
       
        public static int addNum(int n1)
        {
            num += n1;
            return num;
        }

        /// <summary>
        /// Method for addition
        /// </summary>
        public static int multNum(int n2)
        {
            num *= n2;
            return num;
        }

        /// <summary>
        /// Method for addition
        /// </summary>
        public static int subNum(int n3)
        {
            num -= n3;
            return num;
        }

        public static int getNum() 
        {
            return num;
        }
    }
}
