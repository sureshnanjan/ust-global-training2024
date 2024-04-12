using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Assignments
{
    internal class Manager
    {
        string name;
        int id;

        public Manager(int id)
        {
            this.id = id;
            this.name = "Manager";
        }

        public void ManageRestaurant(object sender, EventArgs? args)
        {
            Console.WriteLine($"{this.name} {this.id} is managing the restaurant.");
        }
    }
}
