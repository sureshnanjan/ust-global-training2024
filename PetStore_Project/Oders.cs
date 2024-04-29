using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore_Project
{
    /// <summary>
    /// Order details parameter declaration
    /// </summary>
    public class Oders
    {
        private long orderId;
        private long petId;
        private int quantity;
        private string shipDate;
        private string orderStatus;
        private bool orderComplete;

    }
    /// <summary>
    /// Order status details
    /// </summary>
    internal enum orderStatus
    {
        placed, 
        approved, 
        delivered
    }
}
