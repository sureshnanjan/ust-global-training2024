using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarted_UST
{
    /// <summary>
    /// Class for Cashier
    /// </summary>
    internal class Cashier
    {
        private string cashierId;

        /// <summary>
        /// Constructor of Cashier
        /// </summary>
        /// <param name="cashierId"> Id of cashier</param>
        public Cashier(string cashierId)
        {
            this.cashierId = cashierId;
        }

        /// <summary>
        /// Method for collecting money
        /// </summary>
        /// <param name="sender">First Parameter of the object Sender</param>
        /// <param name="args">Object of Events</param>
        public void CollectMoney(object sender, EventArgs? args)
        {
            Console.WriteLine($"Cashier {this.cashierId} is collecting money");
        }
    }
}
