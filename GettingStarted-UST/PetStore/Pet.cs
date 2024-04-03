using System;
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
        private long id;
        private string name;
        private string photoUrls;
        private string petStatus;
    }

    /// <summary>
    /// Status of Pets availability
    /// </summary>
    internal enum petStatus
    {
        available, pending, sold
    }
}
