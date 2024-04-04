using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectPetStore
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
        public Order(int id)
        {
            this.id = id;
        }
    }
}

