using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore
{
    /// <summary>
    /// Represents a order in the pet store.
    /// </summary>
    internal class Order
    {
        private long id;
        private long petId;
        private int quantity;
        private DateTime shipDate;
        private string? status;
        private bool compelete;

        /// <summary>
        /// Gets or sets the ID of the order.
        /// </summary>
        public long Id
        {
            get { return id; }
            set { id = value; }
        }

        /// <summary>
        /// Gets or sets the Id of the pet associated with the order.
        /// </summary>
        public long PetId
        {
            get { return petId; }
            set { petId = value; }
        }

        /// <summary>
        /// Gets or sets the quantity of pets in the order.
        /// </summary>
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        /// <summary>
        /// Gets or sets the date and time when the order is shipped.
        /// </summary>
        public DateTime ShipDate
        {
            get { return shipDate; }
            set { shipDate = value; }
        }

        /// <summary>
        /// Gets or sets the status of the order.
        /// </summary>
        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        /// <summary>
        /// possible status values for an order.
        /// </summary>
        public enum OrderStatus
        {
            Placed,
            Approved,
            Delivered
        }

        /// <summary>
        /// Indicates whether the order is complete.
        /// </summary>
        public bool Complete {
            get { return compelete; }
            set { compelete = value; }
        }
    }
}
