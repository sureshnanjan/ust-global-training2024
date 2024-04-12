using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarted_UST
{
    public class UsingLiterals
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
            int decINt = 89; // 4 byte - max mim // 1010 - 4 bytes 
            long mylong = 0; // 8 bytes // 1020 - 1029, 1021, 1022, 1024, --- 1028
            int hexInt = 0x1F; // 15 X16 ^0 + 1 X 16 ^1
            double mydbl = 123.45;
            float nyflt = 123.45f;
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
        public void myAssignment()
        {
            /// <summary>
            ///  This is first assignmet
            /// </summary>

            //handling int, float, double
            double dNum = 45.2;
            int iNum = 12;
            float fNum = 55.5f;
            Console.WriteLine("Floating Literals- \n 1. double \t: " + dNum + "\n2.float \t: " + fNum + "\n 3.int \t\t: " + iNum);

            //handling characters 
            Char myChar = 'Z';
            char newlline = '\u0D19';
            Console.WriteLine("Character Literals -\n 1. Char :  \t" + myChar + "\n 2. New line \t" + newlline);

            // String interpolation:
            string myName = "Manisha";
            var date = DateTime.Now;
            Console.WriteLine("\n String interpolation: \n" + $"Hello, My name is  {myName}! Today is {date.DayOfWeek}, it's {date:HH:mm} now.\n");

            //handling boolean
            bool b1 = true;
            bool b2 = false;
            Console.WriteLine("Boolean Literals : \n " + "1. \t" + b1 + "\n 2. \t" + b2);


            //handling null
            string myNull = null;
            Console.WriteLine("This is Null value   : " + myNull);

        
        }


    }
}
