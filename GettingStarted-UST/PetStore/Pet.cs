using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore
{
    public class Pet : Category
    {
        long id;
        string name;
        string petStatus;
    }

    internal enum petStatus
    {
        available, pending, sold
    }
}
