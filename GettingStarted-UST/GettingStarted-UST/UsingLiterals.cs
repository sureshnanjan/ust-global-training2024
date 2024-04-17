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
            char mychar = 'M';
            char mychar1 = '\u0061';
            char mychar2 = '\n';

            // String Literals
            string mystr = "Hi Team!";
            string mystr1 = @"Hello Team!";

            //Null literal
            string? s;

            // Boolean Literals
            bool mybool = true;
            bool mybool1 = false;

     //      Second assignment on Literals

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

            string myString = "Pooja";
            string newPath = @"C:\Users\Administrator\ust-global-training2024\BasicProgram";
            string firstString = "Padmappa";
            string lastName = "Salian";
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

            //Console.WriteLine("Integer -Decimal literals \t\t     : " + decINt + " \nInteger- Hexa-decimal literals \t\t     : " + hexInt + " \nInteger- Binary literals \t\t     : " + binaryInt);
            Console.WriteLine("Floating Literals- double \t\t     : " + numDouble + "\nFloating Literals- float \t\t     : " + myFloat + "\nFloating Literals- Exponentialvalue \t     : " + reSult);
            Console.WriteLine("Character Literals - Single quote \t     : " + myChar + "\nCharacter Literals - Unicode Representation : " + uniCode + "\nCharacter Literals - Escape Sequence\t   : " + escSequence);
            Console.WriteLine("String Literals -single \t\t   : " + myString + "\nString Literals -Path declaration\t   :" + newPath + "\nString Literals - Interpolation \t   : " + name);
            Console.WriteLine("Null Literals\t\t\t\t   : " + s);
            Console.WriteLine("Boolean Literals \t\t\t   : " + gG + "\nBoolean Literals\t\t\t   : " + rR);

        }



    }


    
}
