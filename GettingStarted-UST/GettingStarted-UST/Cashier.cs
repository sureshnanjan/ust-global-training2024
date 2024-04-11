using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarted_UST
{
    internal class Cashier
    {
        private string cashierid;

        public Cashier(string cashierid)
        {
            this.cashierid = cashierid;
        }

        public void CollectMoney(object sender, EventArgs? args)
        {
            Console.WriteLine($"Cashier {this.cashierid} is collecting money");
        }
    }
}
