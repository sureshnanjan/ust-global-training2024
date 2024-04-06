using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLIbrary;

namespace GettingStarted_UST
{
    public class MainProgram
    {
        public static void Main(string[] args) {
            SimpleClass[] myInstances = { new SimpleClass(1,2), new SimpleClass(1,3) , new SimpleClass(0,1) , new SimpleClass(1,0)};
            Console.WriteLine("Original Values in My Instances");
            foreach (var item in myInstances)
            {
                    Console.Write($"{item} , ");

            }
            Array.Sort(myInstances);
            Console.WriteLine("\n AFTER SORTING  Values in MYINSTANCES ");
            foreach (var item in myInstances)
            {
                Console.Write($"{item} , ");

            }

        }
    }
}
