using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStoreProject
{
    /// <summary>
    /// Capturing order related details like id, petId,quantity,shipDate and complete
    /// </summary>
    internal partial class Order
    {
        public long id;
        public long petId;
        public int quantity;
        public DateTime shipDate;
        public Boolean complete;
        public enum status
        {
            placed,
            approved,
            delivered
        }

        public Order(int id)
        {
            this.id = id;

        }

    }
}