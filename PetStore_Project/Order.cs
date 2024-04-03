using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore_Project
{
    public class Order
    {
        private long orderId;
        private long petId;
        private int quantity;
        private string shipDate;
        private string orderStatus;
        private bool OrderComplete;

    }
    /// <summary>
    /// order status details
    /// </summary>
    internal enum orderStatus
    {
        Placed,
        Approved,
        Delivered
    }
}
