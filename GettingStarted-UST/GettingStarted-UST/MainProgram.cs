using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLIbrary;
using PetStoreImplementation;

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
            Console.WriteLine("Literals :");
            UsingLiterals usingLiterals = new UsingLiterals();
            usingLiterals.ShowUsage();

            Console.WriteLine("Sorting Instances :- ");
            InstancesSort();

            Console.WriteLine("Example of Lambda :- ");
            LambdaDemo();
            LambdaToGetList();

            Console.WriteLine("Example of Delegate :- ");
            DelegateUsage();

            Console.WriteLine("Operator Overloading :- ");
            OperatorOverloaded();

            Console.WriteLine("\nIndex Overloading :- ");
            IndexerOverloaded();

            Console.WriteLine("\nExample of Event handling :- ");
            EventHandlingDemo();

            Console.WriteLine("\nLauching website of JPet Store:- ");
            LaunchWebsiteDemo();
        }

        /// <summary>
        /// To sort instances
        /// </summary>
        private static void InstancesSort()
        {
            SimpleClass[] myInstances = { new SimpleClass(1, 2), new SimpleClass(1, 3), new SimpleClass(0, 1), new SimpleClass(1, 0) };
            Console.WriteLine("\n Original Values in My Instances");
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
            Console.WriteLine("\n");
        }

        /// <summary>
        /// Example of Lambda usage
        /// </summary>
        public static void LambdaDemo()
        {
            int[] value = { 1, 2, 3, 4, 5, 6, 7, 4, 8, 9 };
            Func<int, bool> predicate = x => x == 4; // Lambda

            int results = value.Where(predicate).Count();
            Console.WriteLine($"Count of repeated element 4 is {results}");

            int results1 = value.Aggregate((arg1, arg2) => (arg1 + arg2));
            Console.WriteLine($"Addition of all elements in mynumbers is {results1} \n");

        }

        /// <summary>
        /// Delegate demo
        /// </summary>
        /// <param name="param1">First argument</param>
        /// <param name="param2">Second argument</param>
        /// <returns></returns>
        public delegate int TypeIntTakeIntStr(int param1, string param2);

        /// <summary>
        /// Showcase the delagate usability
        /// </summary>
        private static void LambdaToGetList()
        {
            int[] myNumbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
            var result = myNumbers.Where(param => param>2).ToList();
            Console.Write("Resulting list is : ");
            foreach (var item in result)
            {
                Console.Write($"{item} ,");
            }
            Console.WriteLine("\n");

            // Pointing a method
            //Func<int, bool> func = x => x>2;
            //SimpleClass myIns = new SimpleClass(20);
            TypeIntTakeIntStr pointer = MyMethod;
            pointer(30, "");

        }

        /// <summary>
        /// Normal method
        /// </summary>
        /// <param name="param1">First Argument</param>
        /// <param name="param2">Second Argument</param>
        /// <returns></returns>
        public static int MyMethod(int param1, string param2)
        {
            Console.WriteLine("Executing in the myMethod \n");
            return 0;
        }

        /// <summary>
        /// To demonstrate usage of Delegate
        /// </summary>
        private static void DelegateUsage()
        {
            DelegateDemo delegateDemo = new DelegateDemo();
            AddNum SumOfNum = new AddNum(delegateDemo.Add);
            Product ProdOfNum = new Product(delegateDemo.Mutliply);
            SumOfNum(12, 2);
            ProdOfNum(12, 2);
        }

        /// <summary>
        /// Operator Overloading
        /// </summary>
        private static void OperatorOverloaded()
        {
            OperatorOverloading num1 = new OperatorOverloading(200);
            OperatorOverloading num2 = new OperatorOverloading(40);
            OperatorOverloading num3 = new OperatorOverloading();

            num3 = num1 + num2;

            num1.display(); // Displays 200

            num2.display(); // Displays 40

            num3.display(); // Displays 240
        }

        /// <summary>
        /// Indexer Overloading
        /// </summary>
        private static void IndexerOverloaded()
        {
            IndexerOverloading IndexOver = new IndexerOverloading();

            IndexOver[0] = "Hello"; // Value of word[0] 

            IndexOver[1.0f] = " Team"; // Value of word[1] 

            Console.WriteLine(IndexOver[0] + IndexOver[1.0f]);
        }

        /// <summary>
        /// To demonstrate Event handling mechanism
        /// </summary>
        private static void EventHandlingDemo()
        {
            Console.WriteLine("Event handling :- ");

            Kitchen kfc = new Kitchen();

            Cook cook1 = new Cook("kfc103", "Biriyani", "Cook1", 001);
            Cook cook2 = new Cook("kfc106", "Pizza", "Cook2", 002);
            Cook cook3 = new Cook("kfc109", "Pizza", "Cook3", 003);

            Waiter waiter1 = new Waiter(001, "Biriyani", "kfc103");
            Waiter waiter2 = new Waiter(002, "Pizza", "kfc106");
            Waiter waiter3 = new Waiter(003, "Soup", "kfc109");


            kfc.PlaceOrder(cook1.PrepareFood);
            kfc.PlaceOrder(cook2.PrepareFood);
            kfc.PlaceOrder(cook3.PrepareFood);

            kfc.PlaceOrder(waiter1.ServeFood);
            kfc.PlaceOrder(waiter2.ServeFood);
            kfc.PlaceOrder(waiter3.ServeFood);

            kfc.PlaceOrder(waiter1.CleanTable);
            kfc.PlaceOrder(waiter2.CleanTable);
            kfc.PlaceOrder(waiter3.CleanTable);

            Cashier cashier1 = new Cashier("C001");
            kfc.PlaceOrder(cashier1.CollectMoney);

            Cashier cashier2 = new Cashier("C002");
            kfc.PlaceOrder(cashier2.CollectMoney);

            Cashier cashier3 = new Cashier("C003");
            kfc.PlaceOrder(cashier3.CollectMoney);

            kfc.CollectOrder();
        }

        /// <summary>
        /// To Lauch & Close Website
        /// </summary>
        private static void LaunchWebsiteDemo()
        {
            HomePage homePage = new HomePage();
            homePage.OpenWebsite("https://petstore.octoperf.com/actions/Catalog.action");
            string title = homePage.GetTitle();
            Console.WriteLine($"Title is {title}");
            homePage.CloseWebsite("https://petstore.octoperf.com/actions/Catalog.action");
        }
    }
}
