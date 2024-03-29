using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarted_UST
{
    public class MainProgram
    {
        public static void Main(string[] args) {
            // call all your demo methods here
            Console.WriteLine("C# literals declaration");
            UsingLiterals mypgm = new UsingLiterals();
            mypgm.showUsage();
        
        }
    }
}
