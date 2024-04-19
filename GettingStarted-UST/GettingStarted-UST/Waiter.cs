using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_GettingStarted
{
    /// <summary>
    /// </summary>
    public class Waiter
    {
        string name;
        string orderId;
        {
        }

        // Captures the status of Food Serve
        public void ServeFood(object sender, EventArgs? args)
        {
        }

        public void CleanTable(object sender, EventArgs? args)
        {
            Console.WriteLine($"Waiter {this.waiterId} is cleaning the table");

    }
}
}
