using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarted_UST
{
    internal class Waiter 
    {
        string name;
        string orderId;
        int id;

        public Waiter(int id)
        {
            this.id = id;
            this.name = "Pizza";
            this.orderId = "001";
        }

        
    // Wait for a order completion
    // Consumer - Receiver - Subscriber  - Pub-Sub - Chat


    public void ServeFood(object sender , EventArgs? args) {
        Console.WriteLine($"{this.id} is Serving the Food");
            Console.WriteLine($"{this.id } is Cleaning the Table");
        }

       
    }
}
