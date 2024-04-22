using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarted_UST
{
    /// <summary>
    /// Class of Waiter
    /// </summary>
    public class Waiter
    {
        int waiterId;
        string name;
        string orderId;
        private int v;

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

        public Waiter(int v)
        {
            this.v = v;
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
namespace Test_GettingStarted
{
    /// <summary>
    /// /Capturing the waiter details and Publishing the Order status
    /// </summary>
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