using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarted_UST
{
    /// <summary>
    /// Example of different literals
    /// </summary>
    internal class UsingLiterals
    {
        /// <summary>
        /// Method to show the examples of literals
        /// </summary>
        public void ShowUsage()
        {

            // Integer Literals, TODO: value 89
            int decINt = 89;
            int hexInt = 0x59;
            int binInt = 0b1011001;

            // Floating-point Literals
            float doublefloat = 123.456f;
            float myFloat = 10.2f;
            float expfloat = 3.14E-2f;

            // Character Literals
            char myChar = 'M';
            char myChar1 = '\u0061';
            char myChar2 = '\n';

            // String Literals
            string myStr = "Hi Team!";
            string myStr1 = @"Hello Team!";

            //Null literal
            string? s;

            // Boolean Literals
            bool myBool = true;
            bool myBool1 = false;

            Console.WriteLine($" Integer value of Decimal 89 is {decINt}");
            Console.WriteLine($" Integer value of Hexa-Decimal 59 is {hexInt}");
            Console.WriteLine($" Integer value of Binary 1011001 is {binInt} \n");

            Console.WriteLine($" Float value of double 123.456 is {doublefloat}");
            Console.WriteLine($" Float value of float 10.2 is {myFloat}");
            Console.WriteLine($" Float value of exponential 3.14E-2 is {expfloat} \n");

            Console.WriteLine($" Character literal in single quote M is {myChar}");
            Console.WriteLine($" Character literal in unicode 0061 is {myChar1}");
            Console.WriteLine($" Character literal in Escape sequence new line is {myChar2} \n");

            // String Interpolation
            Console.WriteLine($" String literals in double quote is {myStr}");
            Console.WriteLine($" String literals in double quote with prefix of @ is {myStr1} \n");
            
            Console.WriteLine($" Boolean literals are {myBool} & {myBool1} \n");
        }
    }
}
