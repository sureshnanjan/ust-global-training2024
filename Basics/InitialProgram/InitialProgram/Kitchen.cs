//  Assignment on Event //
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialProgram
{
    internal class Kitchen
    {
        //int value;
        public event Action<object, EventArgs> FoodISReady;
        // Notify that the food is ready
        // Publisher
        private string[] ordersWaiting;

        public void ReceiveOrder(string name, string orderid) { }

        public void PrepareTheFood()
        {
            Thread.Sleep(2000);
            Console.WriteLine("Step1");
            Thread.Sleep(3000);
            Console.WriteLine("Step2");
            Thread.Sleep(5000);
            Console.WriteLine("Plate the food");
            FoodISReady?.Invoke(this, EventArgs.Empty);
        }

        public void PlaceOrder(Action<object, EventArgs> handler)
        {

            FoodISReady += handler;
        }


    }
}
