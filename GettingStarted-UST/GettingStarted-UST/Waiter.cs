using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarted_UST
{
    internal class Waiter
    {
        int Waiterid;
        string name;
        string orderId;

        public Waiter(int Waiterid, string name, string orderId)
        {
            this.Waiterid = Waiterid;
            this.name = name;
            this.orderId = orderId;
        }
        public void ServeFood(object sender, EventArgs? args) 
        {
            Console.WriteLine($"Waiter {this.Waiterid} is serving {this.name} for order {this.orderId}");
        }

        public void CleanTable(object sender, EventArgs? args)
        {
            Console.WriteLine($"Waiter {this.Waiterid} is cleaning the table");

        }
    }
}
