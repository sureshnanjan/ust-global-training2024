//  Assignment on Event //
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialProgram
{
    internal class Customer
    {
        string name;
        string orderId;
        int id;

        public Customer(int id)
        {
            this.id = id;
            this.name = "Pizza";
            this.orderId = "001";
        }


        public void EatingFood(object sender, EventArgs? args)
        {
            Console.WriteLine($"{this.id} is eating the Food");
        }
    }
}
