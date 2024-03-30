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

            //TODO: value 89
            // Integer Literals
            int decINt = 89;
            int hexInt = 0x89;
            int binInt = 0b1011001;

            Console.WriteLine("decInt : " + decINt + "\n hexInt : " + hexInt + "\n binInt : " + binInt);

            // Floating-point Literals
            double doubvalue = 89.1;
            float flovalue = 89.2f;
            int x = 89;
            int y = 2;
            double expResult = Math.Pow(x,y);
            Console.WriteLine("double value :" + doubvalue + "\n float value : " + flovalue + "\n expResult :" + expResult);

            // Character Literals
            char ch  = 'a';
            char unicodeRepCh = '\u0061';
            char escch = '\b';

            Console.WriteLine("char :" +ch +"\n unicode Rep :" +unicodeRepCh +"\n escape ch" +escch);

            // String Literals
            String s = "Hello Print3";
            String s1 = @"Hello Print4";
           
            Console.WriteLine(s +"\n" + s1);

            String varname = "check";
            String value = $"the value of varname is {varname} ";
            Console.WriteLine(value);

            // Null Literals
            String sv = null;
            Console.WriteLine(sv);

            // Boolean Literals
            bool boolT=true;
            bool boolF=false;
            Console.WriteLine("Boolean Litetrals \n"+ boolT + "\n" + boolF);
             



        }


    }
}
