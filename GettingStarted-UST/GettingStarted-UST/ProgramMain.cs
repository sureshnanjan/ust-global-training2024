using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLIbrary;

namespace GettingStarted_UST
{
    /*
    //delegate
    delegate int typeIntTakeinStr(int param1, string some); */
    public class ProgramMain
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

            

            // Program for Event Main Program 


            Kitchen kfc = new Kitchen(); // Publisher
            Waiter waiter1 = new Waiter(1); // Consumers
            Waiter waiter2 = new Waiter(2);
            Waiter waiter3 = new Waiter(3);
            Cashier cashier = new Cashier(1);
            kfc.PlaceOrder(waiter1.ServeFood);
            kfc.PlaceOrder(waiter2.ServeFood);
            kfc.PlaceOrder(waiter3.ServeFood);
            kfc.PlaceOrder(cashier.CollectMoney);
            kfc.PrepareTheFood();


        }
    }
}
