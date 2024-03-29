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
        /// <summary>
        /// 
        /// </summary>
        public void showUsage()
        {

            //TODO: value 89
            /// <summary>
            /// Integer literral declaration
            /// </summary>

            int decINt = 89;
            int hexInt = 0x89;
            int binaryInt = 1011001;
           
            /// <summary>
            /// Floating-point Literals
            /// </summary>

            double numDouble = 89.9;
            float myFloat = 89.7f;
            double baseNum = 89;
            double exponNum = 2;
            double reSult = Math.Pow(baseNum, exponNum);
           
            /// <summary>
            /// Character Literals
            /// </summary>

            Char myChar = 'C';
            Char uniCode = '\u0061';
            Char escSequence = '\0';            

            /// <summary>
            /// String Literals
            /// </summary>

            string myString = "Chandni";
            string newPath = @"C:\Users\Administrator\ust-global-training2024\BasicProgram";
            string firstString = "Gopalakrishnan";
            string lastName = "Nair";
            string name = $"{myString} {firstString} {lastName} ";
            
            /// <summary>
            /// Null Literals
            /// </summary>
            string s = null;            

            /// <summary>
            /// Boolean Literals
            /// </summary>
             
            bool gG = true;
            bool rR = false;

            /// <summary>
            /// Printing C# Litterrals
            /// </summary>
             
            Console.WriteLine("Integer -Decimal literals \t\t     : " + decINt + " \nInteger- Hexa-decimal literals \t\t     : " + hexInt + " \nInteger- Binary literals \t\t     : " + binaryInt);
            Console.WriteLine("Floating Literals- double \t\t     : " + numDouble + "\nFloating Literals- float \t\t     : " + myFloat + "\nFloating Literals- Exponentialvalue \t     : " + reSult);
            Console.WriteLine("Character Literals - Single quote \t     : " + myChar + "\nCharacter Literals - Unicode Representation : " + uniCode + "\nCharacter Literals - Escape Sequence\t   : " + escSequence);
            Console.WriteLine("String Literals -single \t\t   : " + myString + "\nString Literals -Path declaration\t   :" + newPath + "\nString Literals - Interpolation \t   : " + name);
            Console.WriteLine("Null Literals\t\t\t\t   : " + s);
            Console.WriteLine("Boolean Literals \t\t\t   : " + gG + "\nBoolean Literals\t\t\t   : " + rR);

        }

    }
}
