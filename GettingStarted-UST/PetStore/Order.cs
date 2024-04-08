﻿using System;
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
            long id;
            long petId;
            int quantity;
            DateTime shipDate;
            string status;
            Boolean complete;
    }

}