using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarted_UST
{
    /// <summary>
    /// Class of cook
    /// </summary>
    internal class Cook
    {
        
        private string orderId;
        private string name;
        private string cookName;
        private int waiterId;

        /// <summary>
        /// Method of cook
        /// </summary>
        /// <param name="orderId">Id of Order</param>
        /// <param name="name">Name of Food</param>
        /// <param name="cookName">Name of Chef</param>
        /// <param name="waiterId">Id of Waiter</param>
        public Cook(string orderId, string name, string cookName, int waiterId)
        {
            this.orderId = orderId;
            this.name = name;
            this.cookName = cookName;
            this.waiterId = waiterId;
        }

        /// <summary>
        /// Method Event caller
        /// </summary>
        /// <param name="sender">Object of sender</param>
        /// <param name="args">Object of EventArgs</param>
        public void PrepareFood(object sender, EventArgs? args) 
        {
            Console.WriteLine($"{this.cookName} is starting preparation of order {this.orderId}");
            Console.WriteLine($"Food preparation for order {this.orderId} is complete and passing food to Waiter {this.waiterId}");
        }
    }
}
