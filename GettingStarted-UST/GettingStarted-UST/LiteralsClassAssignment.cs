using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarted_UST
{
    internal class LiteralsClassAssignment
    {
        /// <summary>
        /// Literals - Assignment
        /// </summary>
        public void showUsage()
        {

            
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
            double numDouble = 89.9;
            float myFloat = 89.7f;
            double baseNum = 89;
            double exponNum = 2;
            double reSult = Math.Pow(baseNum, exponNum);

            //float @float 
            //null != "null";
            

            List<string> students = new List<string>();

            for (int studnum = 0; studnum < students.Count; studnum++)
            {
                Console.WriteLine(students[studnum]);
            }

            foreach (var item in students)
            {

            }

           /// <summary>
            /// Character type -  Literals
            /// </summary>

            Char myChar = 'C';
            Char uniCode = '\u0061';
            Char escSequence = '\0';
            char newline = '\u0D19'; //1000  a 97 A 65 
           
            /// <summary>
            /// String Literals
            /// </summary>

            string myString = "Ragasudha";
            string newPath = @"C:\Users\Administrator\ust-global-training2024\";
            string lastName = "Thirumalaisamy";
            string name = $"{myString} {lastName} ";
            string mynameinmalayalam = "\u0d19\u0d19";

            /// <summary>
            /// Null type Literals
            /// </summary>
            string s = null;

            /// <summary>
            /// Boolean type Literals
            /// </summary>

            bool gG = true;
            bool rR = false;

            /// <summary>
            /// Printing C# Literals
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
