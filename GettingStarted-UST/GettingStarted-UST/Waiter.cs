using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarted_UST
{
    public class Waiter 
    {
        //Capture Waiter and Order details
        string name;
        string orderId;
        int id;
        public string notification;
        public Waiter(int id)
        {
            this.id = id;
            this.name = "Pizza";
            this.orderId = "001";
        }

        // Captures the status of Food Serve
        public void ServeFood(object sender, EventArgs? args)
        {
            Console.WriteLine($"Waiter {this.id} is Serving the Food");
            notification = $"Waiter {this.id} is Serving the Food";
            //Console.WriteLine($"Waiter {this.id} is Cleaning the Table");
        }


    }
}
