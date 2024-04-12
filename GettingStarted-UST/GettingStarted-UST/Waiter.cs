using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarted_UST
{
    /// <summary>
    /// Class of Waiter
    /// </summary>
    internal class Waiter
    {
        int waiterId;
        string name;
        string orderId;

        /// <summary>
        /// Constructor of waiter
        /// </summary>
        /// <param name="waiterId">Id of Waiter</param>
        /// <param name="name">Name of food</param>
        /// <param name="orderId"></param>
        public Waiter(int waiterId, string name, string orderId)
        {
            this.waiterId = waiterId;
            this.name = name;
            this.orderId = orderId;
        }
        public void ServeFood(object sender, EventArgs? args) 
        {
            Console.WriteLine($"Waiter {this.waiterId} is serving {this.name} for order {this.orderId}");
        }

        public void CleanTable(object sender, EventArgs? args)
        {
            Console.WriteLine($"Waiter {this.waiterId} is cleaning the table");

        }
    }
}
