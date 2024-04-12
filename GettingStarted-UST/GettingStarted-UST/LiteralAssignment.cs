using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarted_UST
{
    internal class LiteralAssignment
    {
        /// <summary>
        /// Literals types in C#.
        /// </summary>

        //Integer Literals
        //Decimal literals (Base 10)
        //Hexa-decimal literals (Base 16)
        //Binary literals (Base 2)
        //Floating-point Literals
        //Character Literals
        //Single quote
        //Unicode Representation
        //Escape Sequence
        //String Literals
        //Boolean Literals

        /// <summary>
        /// Usage of various types of literals in C#
        /// </summary>
        internal class UsingLiterals
        {
            // Integer Literals
            int decInt = 21;               // Decimal literals (Base 10)
            int hexInt = 0x21;            // Hexa-decimal literals (Base 16)
            int binint = 0b101;          // Binary literals (Base 2)

            // Floating-point Literals
            double myDouble = 3.1415;    // double
            float myFloat = 2.3f;        // float
                                         // exponential
                                         // Character Literals
            char myChar = 'A';            // Single quote
            string unicodeNeetu = "\u00d1\u00e9\u00e9\u0074\u00fb";  // Unicode Representation
            string newline = "This is first line \n This is second line";   // Escape Sequence
                                                                            // String Literals
            string myString = "Hello Neets";   // ""

            string interpolationString = "The value of myFloat is :{myFloat}";    // string interpolation "The value of varname is :{varname}"


            // Method to print literals
            public void showUsage()
            {

                Console.WriteLine(decInt);
                Console.WriteLine(hexInt);
                Console.WriteLine(binint);
                Console.WriteLine(myFloat);
                Console.WriteLine(myDouble);
                Console.WriteLine(myChar);
                Console.WriteLine(unicodeNeetu);
                Console.WriteLine(myString);
                Console.WriteLine(interpolationString);


            }

        }
    }
}
