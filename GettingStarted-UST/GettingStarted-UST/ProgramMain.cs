using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarted_UST
{
    //delegate
    delegate int typeIntTakeinStr(int param1, string some);
    internal class ProgramMain
    {
        public static void Main(string[] args) 
        {
            //Func<int,bool> represents some kind of type in system
            Func<int,bool> predicate = x => x == 3;
            int[] mynumbers = { 1, 2, 3, 4, 5 };
            var results = mynumbers.Where(predicate).ToList();
            foreach (int value in results)
            {
                Console.WriteLine(value);
            }

            
        }
    }
}
