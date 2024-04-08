//  Assignment on Event //
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialProgram
{
    internal class Cashier
    {
        string name;
        string orderId;
        int id;

        public Cashier(int id)
        {
            this.id = id;
        }


        // Wait for a order completion
        // Consumer - Receiver - Subscriber  - Pub-Sub - Chat


        public void CollectMoney(object sender, EventArgs? args)
        {
            Console.WriteLine($"{this.id} is collecting the Money");
            //Console.WriteLine($"{this.id} is Cleaning the Table");
        }
    }
}
