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
            // double
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

            /// <summary>
            /// Integer Literals
            /// </summary>

            int decINt = 89;
            int hexInt = 0x89;
            int binInt = 1011001;

            /// <summary>
            /// Floating-point Literals
            /// </summary>

            double doubleNum = 89.9;
            float floatNum = 89.1f;

            double baseNum = 89;
            double exponentNum = 2;
            double result = Math.Pow(baseNum, exponentNum); // Exponential Value           

            /// <summary>
            /// Character Literals
            /// </summary>

            char myChar = 'R';
            char unicodeRep = '\u0061';
            char escapeSeq = '\n';            

            /// <summary>
            /// String Literals
            /// </summary>
            
            string firstName = "Renjitha";
            string pathVar = @"C:\Users\Administrator\ust-global-training2024\MyFristAssaignment";
            string lastName = "Jayan";
            string fullName = $"Hello.... {firstName} {lastName}";            

            // Null Literals

            string s = null;

            // Boolean Literals

            bool boolT = true;
            bool boolF = false;

            Console.WriteLine("Decimal literal    :\t" + decINt + "\nHex-decimal literal:\t" + hexInt + "\nBinary literal     :\t" + binInt);
            Console.WriteLine("Double literal     :\t" + doubleNum + "\nFloat literal      :\t" + floatNum + "\nExponential Value  :\t" + result);
            Console.WriteLine("Single Quote       :\t" + myChar + "\nUnicode Representation:"   + unicodeRep + "\nEscape Sequence    :\t" + escapeSeq);
            Console.WriteLine("String Value       :\t" + firstName + "\nPath Declaration   :\t" + pathVar + "\nString Interpolation:\t" + fullName);
            Console.WriteLine("Null Literal       :\t" + s + "\nBoolean Literals   :\t" + boolT+  "&"  +boolF);
        }


    }
}
