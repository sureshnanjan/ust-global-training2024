using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarted_UST
{
    internal abstract class Pet
    {
        public string name;
        public string color;
        public int id;

        public abstract void Feed();
        public abstract void Ship();
        
        public void concereteMethod()
        {
            Console.WriteLine("I am doing some common tasks");
        }

        
    }
}
