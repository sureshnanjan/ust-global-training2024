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
            private long id;
            private long petId;
            private int quantity;
            private DateTime shipDate;
            private string status;
            private Boolean complete;
    }

}
