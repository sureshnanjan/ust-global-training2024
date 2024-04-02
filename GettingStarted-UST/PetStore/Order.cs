using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore
{
    public class Order
    {
        public static void Main(string[] args)
        {
            long id;
            long petId;
            int quantity;
            DateTime shipDate;
            string status;
            Boolean complete;

            /*foreach (string name in Enum.GetNames(typeof(status)))
            {
                Console.WriteLine(name);
            }*/

        }        
    }

    internal enum Status
    {
        placed, approved, delivered
    }

}
