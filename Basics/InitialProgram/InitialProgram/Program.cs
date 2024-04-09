//  Assignment on Event //

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoohLibrary;


namespace InitialProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GenerateReportAssignment();

        }

        /// <summary>
        /// Event Handling
        /// </summary> 
        private static void EventAssignment()
        {
            Kitchen kfc = new Kitchen(); // Publisher
            Waiter waiter1 = new Waiter(1); // Consumers
            Cashier cashier1 = new Cashier(1);
            Customer customer1 = new Customer(1);
            kfc.PlaceOrder(waiter1.ServeFood);
            kfc.PlaceOrder(customer1.EatingFood);
            kfc.PlaceOrder(cashier1.CollectMoney);
            Waiter waiter2 = new Waiter(2);
            Cashier cashier2 = new Cashier(2);
            Customer customer2 = new Customer(2);
            kfc.PlaceOrder(waiter2.ServeFood);
            kfc.PlaceOrder(customer2.EatingFood);
            kfc.PlaceOrder(cashier2.CollectMoney);
            kfc.PrepareTheFood();
        }

        /// <summary>
        /// Generate and Publish Report
        /// </summary>
        private static void GenerateReportAssignment()
        {
            Console.WriteLine("This is Main Dashboard");
            MyUtilityClass class1 = new MyUtilityClass();
            class1.Publish();
            class1.GenerateReport();
        }
    }
}