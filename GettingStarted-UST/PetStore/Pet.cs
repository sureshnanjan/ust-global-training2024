﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore
{
    /// <summary>
    /// Pet details
    /// </summary>
    public class Pet : Category
    {
        long id;
        string name;
        string photoUrls;
        string petStatus;
    }

    /// <summary>
    /// Status of Pets availability
    /// </summary>
    internal enum PetStatus
    {
        available, pending, sold
    }
}