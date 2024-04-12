using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Assignments
{
    /// <summary>
    /// Contains examples of various types of literals in C#.
    /// </summary>
    internal class UsingLiterals
    {
        // Integer Literals
        int decInt = 89;              // Decimal literals (Base 10)
        int hexInt = 0x89;            // Hexa-decimal literals (Base 16)
        int binint = 0b1010;          // Binary literals (Base 2)
        // Floating-point Literals
        double myDouble = 3.1415;    // double
        float myFloat = 2.3f;        // float
                                     // exponential
                                     // Character Literals
        char myChar = 'A';            // Single quote
        string unicodeGokul = "\u0917\u094b\u0915\u0941\u0932";  // Unicode Representation
        string newline = "This is first line \n This is second line";   // Escape Sequence
                                                                        // String Literals
        string myString = "Hello World";   // ""
        string myStringTwo = @"Hello World";    // @""
        string interpolationString = "The value of myFloat is :{myFloat}";    // string interpolation "The value of varname is :{varname}"


        /// <summary>
        /// Method to demonstrate usage of different types of literals.
        /// </summary>
        public void ShowUsage()
        {

            Console.WriteLine(decInt);
            Console.WriteLine(hexInt);
            Console.WriteLine(binint);
            Console.WriteLine(myFloat);
            Console.WriteLine(myDouble);
            Console.WriteLine(myChar);
            Console.WriteLine(unicodeGokul);
            Console.WriteLine(newline);
            Console.WriteLine(myString);
            Console.WriteLine(myStringTwo);
            Console.WriteLine(interpolationString);


        }
    }
}
