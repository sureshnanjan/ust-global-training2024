using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarted_UST
{
    internal class Cook
    {
        
        private string orderId;
        private string name;
        private string CookName;
        private int Waiterid;

        public Cook(string orderId, string name, string CookName, int Waiterid)
        {
            this.orderId = orderId;
            this.name = name;
            this.CookName = CookName;
            this.Waiterid = Waiterid;
        }

        public void PrepareFood(object sender, EventArgs? args) 
        {
            Console.WriteLine($"{this.CookName} is starting preparation of order {this.orderId}");
            Console.WriteLine($"Food preparation for order {this.orderId} is complete and passing food to Waiter {this.Waiterid}");
        }
    }
}
