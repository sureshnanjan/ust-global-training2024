using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore
{

    /// <summary>
    /// Details of an order placed
    /// </summary>
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

    /// <summary>
    /// Status of Order
    /// </summary>
    internal enum Status
    {
        placed, approved, delivered
    }

}
