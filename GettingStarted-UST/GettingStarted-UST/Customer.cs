using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarted_UST
{
    /// <summary>
    /// Customer  added as a Part of Kitchen - Waiter Events Assignment
    /// </summary>
    internal class Customer
    {
        string name;
        string orderId;
        int id;

        public Customer(int id)
        {
            this.id = id;
          
          
        }


        public void Havefood(object sender, EventArgs? args)
        {
            
            Console.WriteLine($"{this.id} is having the Food");
        }
    }
}
