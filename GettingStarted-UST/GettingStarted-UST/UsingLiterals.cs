using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarted_UST
{
    internal class UsingLiterals
    {
        // Integer Literals
            // Decimal literals (Base 10)
            // Hexa-decimal literals (Base 16)
            // Binary literals (Base 2)
        // Floating-point Literals
            // double 123.45 
            // float
            // exponential
        // Character Literals
            // Single quote
            // Unicode Representation
            // Escape Sequence
        // String Literals
            // ""
            // @""
            // string interpolation "The value of varname is :{varname}"
        // Null Literals
        // Boolean Literals
        public void showUsage() {

            //TODO: value 89
            /// <summary>
            /// Declaration of Integer literals value
            /// </summary>

            int decINt = 89; // 4 byte - max mim // 1010 - 4 bytes 
            int hexInt = 0x1F; // 15 X16 ^0 + 1 X 16 ^1
           
            int binaryInt = 1011001;
            /// <summary>
            /// Float literral declaration
            /// </summary>

            double mydbl = 123.45;
            float nyflt = 123.45f;
            long mylong = 0; // 8 bytes // 1020 - 1029, 1021, 1022, 1024, --- 1028
            
            
            //float @float 
            //null != "null";
            char newline = '\u0D19'; //1000  a 97 A 65 
            string mynameinmalayalam = "\u0d19\u0d19";

            List<string> students = new List<string>();

            for (int studnum = 0; studnum < students.Count; studnum++)
            {
                Console.WriteLine(students[studnum]);
            }

            foreach (var item in students)
            {
                
            }

        }


    }
}
