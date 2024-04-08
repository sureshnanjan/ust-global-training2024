using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLIbrary;

namespace GettingStarted_UST
{
    /// <summary>
    /// Main class with the entry point of GettingStarted-UST project
    /// </summary>
    public class MainProgram
    {
        /// <summary>
        /// Entry point of execution
        /// </summary>
        /// <param name="args">Arguments</param>
        public static void Main(string[] args)
        {
            UsingLiterals usingLiterals = new UsingLiterals();
            usingLiterals.ShowUsage();
            //InstancesSort();
            DelegateDemo();

        }
        /// <summary>
        /// Example of delegate usage
        /// </summary>
        private static void DelegateDemo()
        {
            int[] mynumbers = { 1, 2, 3, 4, 5, 6, 7, 4, 8, 9 };
            Func<int, bool> predicate = x => x == 4; // Lambda

            int results = mynumbers.Where(predicate).Count();
            Console.WriteLine($"Count of repeated element 4 is {results}");

            int results1 = mynumbers.Aggregate((arg1, arg2) => (arg1 + arg2));
            Console.WriteLine($"Addition of all elements in mynumbers is {results1}");
        }

        /// <summary>
        /// To sort instances
        /// </summary>
        private static void InstancesSort()
        {
            SimpleClass[] myInstances = { new SimpleClass(1, 2), new SimpleClass(1, 3), new SimpleClass(0, 1), new SimpleClass(1, 0) };
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
