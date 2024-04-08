using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLIbrary;

namespace GettingStarted_UST
{
    delegate int typeIntTakeintStr(int param1, string some);
    //public delegate TResult Func<in T, out TResult>(T arg);
    public class MainProgram
    {

        // Fields
        // Properties
        // Methods
        // Events
        // Indexers
        // Operators

        public static void Main(string[] args)

        {
            //OperatorIndexerAssignment();

            GenericSimpleClass<int, string> genericSimpleClass = new GenericSimpleClass<int, string>();
            genericSimpleClass.MyCounter = 0;
            GenericSimpleClass<float, string> genericSimpleClass1 = new GenericSimpleClass<float, string>();
            genericSimpleClass1.MyCounter = 1.2f;
            Action<int, float, string> action1 = (a, b, c) => { };

        }

        private static void OperatorIndexerAssignment()
        {
            //EventsDemo();
            int aNumber = 10;
            int another = 100;
            int result = aNumber + another;
            SimpleClass class1 = new SimpleClass(10);
            SimpleClass class2 = new SimpleClass(100);
            // Assignemnt for Operators and Indexers
            /*
            var result = class1 + class2; // Operator 
            if (class2 > class1) 
            {
                Console.WriteLine();
            }

            int[] mysequence = { 1, 2, 3 };

            Console.WriteLine(mysequence[0]);
            SimpleCollection scCollection = new SimpleCollection();
            Console.WriteLine(scCollection[0]); // Indexer
            */
        }

        /// <summary>
        /// This method produces a Publisher Subscriber
        /// </summary>
        private static void EventsDemo()
        {
            Kitchen kfc = new Kitchen(); // Publisher
            Waiter waiter1 = new Waiter(1); // Consumers
            Waiter waiter2 = new Waiter(2);
            Waiter waiter3 = new Waiter(3);
            Cashier cashier = new Cashier(1);
            kfc.PlaceOrder(waiter1.ServeFood);
            kfc.PlaceOrder(waiter2.ServeFood);
            kfc.PlaceOrder(waiter3.ServeFood);
            kfc.PlaceOrder(cashier.CollectMoney);
            kfc.PrepareTheFood(); }

        private static void April06Demo()
        {
            //a0ril04Demo();
            //DelegatesDemo();
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, -9 };
            int result = numbers.Aggregate((arg1, arg2) => arg1 * arg2);
            Console.WriteLine(result);
            bool isallnumbersGT0 = numbers.All(x => x > 0);
            Console.WriteLine(isallnumbersGT0);
            Func<int, int, string> mystringCovertor = (param1, param2) => (param1 - param2).ToString();
        }

        private static void DelegatesDemo()
        {
            Func<int, bool> predicate = x => x > 3; // Lambda
            int[] mynumbers = { 1, 2, 3, 4, 5 };
            var results = mynumbers.Where(param => param > 3).ToList();

            foreach (int value in results)
            {
                Console.WriteLine(value);
            }
            results = mynumbers.Where(input => input < 3).ToList();
            foreach (int value in results)
            {
                Console.WriteLine(value);
            }

            results = mynumbers.Where(input => input == 3).ToList();
            foreach (int value in results)
            {
                Console.WriteLine(value);
            }

            SimpleClass myIns = new SimpleClass(10);
            typeIntTakeintStr pointer = myMethod;

            Func<int, string, int> myrefUsingFunc = myMethod;
            pointer(10, "");
            myrefUsingFunc = myIns.myIntReturningMethod;
            pointer(10, "");
            myrefUsingFunc = someOtherMethod;
            pointer(10, "");
        }

        static bool lessthn3Filter(int param) {
            // param => param < 3
            return param < 3;
        }

        static bool greaterthn3Filter(int param)
        {
            // param => param > 3
            return param > 3;
        }

        static bool get3Filter(int param)
        {
            //param => param == 3
            return param == 3;
        }

        static int myMethod(int para1, string param2) {
            Console.WriteLine("Execuring this inthe myMethod");
            return 0;
        }

        private static int someOtherMethod(int para, string para2) {
            Console.WriteLine("SOMEOTHER METHOD");
            return 0;
        }

        private static void a0ril04Demo()
        {
            SimpleClass cl1 = new SimpleClass(8, "zA");
            SimpleClass cl2 = new SimpleClass(2, "xB");
            SimpleClass cl3 = new SimpleClass(9, "oZ");
            SimpleClass cl4 = new SimpleClass(1, "AD");
            SimpleClass cl5 = new SimpleClass(3, "bB");
            SimpleClass[] mycoll = { cl1, cl1, cl3, cl4, cl5 };
            Console.WriteLine("Sorting Default");
            Array.Sort(mycoll);
            foreach (var item in mycoll)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Sorting By Name ");
            Array.Sort(mycoll, new NameSorter());
            foreach (var item in mycoll)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Sorting By Last Char ");
            Array.Sort(mycoll, new LastCharSorter()); // AAA-HR-1234
            foreach (var item in mycoll)
            {
                Console.WriteLine(item);
            }
        }

        public static void comparableDemo()
        {
            int[] mynumbers = { 8, 3, 19, 21, 1, 2, 3, 4 };
            SimpleClass[] myInstances = { new SimpleClass(8), new SimpleClass(3) , new SimpleClass(19) , new SimpleClass(21),
            new SimpleClass(1), new SimpleClass(2) , new SimpleClass(3) , new SimpleClass(4)};

            string[] strings = { "\nA-One", "B-Two", "C-Three" };

            Array.Sort(strings);
            //strings.

            Console.WriteLine("Original Values in My Instances");
            foreach (var item in myInstances)
            {
                Console.Write($"{item} , ");

            }

            Console.WriteLine("\n Original Values in My Integer array mynumbers");
            foreach (var item in mynumbers)
            {
                Console.Write($"{item} , ");

            }

            Array.Sort(mynumbers);
            Console.WriteLine("\n AFTER SORTING  Values in My Integer array mynumbers");
            foreach (var item in mynumbers)
            {
                Console.Write($"{item} , ");

            }

            Array.Sort(myInstances);
            Console.WriteLine("\n AFTER SORTING  Values in My Integer MYINSTANCES ");
            foreach (var item in myInstances)
            {
                Console.Write($"{item} , ");

            }

        }
        /*
        private static void oeverridesDemo()
        {
            int test = 10;
            int another = 10;          
            SimpleClass scInstance = new SimpleClass(0,2);
            SimpleClass scInstance2 = new SimpleClass(10, 5);
            SimpleClass scInsstance3 = new SimpleClass(10,5);
            SimpleClass refer = scInsstance3;
            Console.WriteLine(test);
            Console.WriteLine(scInstance.ToString());
            Console.WriteLine(scInstance2.Equals(scInstance)); // False
            Console.WriteLine(scInsstance3.Equals(scInstance2));
            Console.WriteLine(refer.Equals(scInsstance3));
            Console.WriteLine(another.Equals(test));
        }

        */

        /* private static void demo03April()
             {
                 //showDemoforTypes();
                 // Launch a Browser
                 // Navigate to a url
                 // Find the link for logo OOPs
                 // Abstraction
                 // Encapsulation
                 // Hiding all the implementation deatils and exposing only the needed ineterface
                 // Inheritance
                 // Polymorphism - static 
                 //  dynamic / runtime 
                 // demoClassCreation();

                 //Pet mypet = new Pet();
                 Fish fish = new Fish();

                 List<Fish> mypets = new List<Fish>();
                 mypets.Add(fish);
                 mypets.Add(new Fish());



                 foreach (var item in mypets)
                 {
                     item.Feed();

                 }

                 // myBrosweer = chrome
                 // conside rall ingredenents and prepare for cookijg
                 // Salt, Rice, Fish, Oil  class Salt : Coo
                 List<IMoveable> allmymovingthings = new List<IMoveable>();
                 List<ICookable> ingredenients = new List<ICookable>();
                 ingredenients.Add(fish);
                 ingredenients.Add(new Rice());
                 //ingredenients.Add(new Salt())
                 foreach (var item in ingredenients)
                 {
                     item.GetCooked();
                 }
             }

             private static void Move(string direction)
             {

                 switch (direction)
                 {
                     case "left":
                     default:
                         break;
                 }

             }

             private static void Move(Directions dir)
             {
                 switch (dir)
                 {
                     case Directions.left:
                         break;
                     case Directions.right:
                         break;
                     case Directions.forward:
                         break;
                     case Directions.backward:
                         break;
                     default:
                         break;
                 }
             }



             private static void demoClassCreation()
             {
                 MyClassDemo inst = new MyClassDemo("Red", 40, 25);
                 inst.Move(10);
                 MyClassDemo inst1 = new MyClassDemo("Blue", 40, 25);
                 inst1.Move(10);
                 Console.WriteLine($"{MyClassDemo.NoOfObjects} are cteated");
                 MyClassDemo inst2 = new MyClassDemo("Grey", 40, 25);

                 MyClassDemo defparamInstance = new MyClassDemo();

                 inst2.Move(10);
                 MyClassDemo.CommonMethod();
             }

         private static void showDemoforTypes()
             {
                 UsingTypesClass myclass = new UsingTypesClass();
                 UsingTypesStruct mystruct = new UsingTypesStruct();
                 UsingTypesEnum mynumber = UsingTypesEnum.third;

                 int result = Int32.MaxValue;
                 int result1 = Int32.MinValue;
                 Console.WriteLine($"When I add 1,2 the resut is {result} when i subtract 2, 1 the result is {result1}");
                 Console.WriteLine(mynumber);


                 Months month = Months.february;

                 switch (month)
                 {
                     case Months.february: Console.WriteLine(); ; break;
                     case Months.january: Console.WriteLine(); ; break;
                 }
             }
         }

         class Human
         {
             int age;
             string skincolor;
             string nationality;
             string gender;
             string name;
         }

         class Employee
         {
             int age;
             //string skincolor;
             string nationality;
             string gender;
             string name;
             string emp_code;
             string skills;
             DateTime doj;
         }*/


   }
}
