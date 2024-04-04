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

        public void conceretMethod() {
            Console.WriteLine("I am doing some common tasks");
        } 
    }

    // Move
    // Sound
    // Wash
    // Type A is a  Type b
    // fish is a pet
    // dog is a vehicle 
    // has a 
    // fish has a capability to wash
    // 
    class Vehicle { }
    class PetS { }

    class Ingredient { }

    
}

