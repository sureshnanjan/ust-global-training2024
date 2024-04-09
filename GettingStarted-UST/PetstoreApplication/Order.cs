using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeststoreApplication
{
    internal class Order
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
        public Order(long id, long petId, int quantity)
        {
            this.id = id;
            this.petId = petId;
            this.quantity = quantity;
        }
    }
}