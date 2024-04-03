using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petstore
{
    /// <summary>
    /// Pet details
    /// </summary>
    public class Pet : Category
    {
        private long id;
        private string name;
        private string photoUrls;
        private string petstatus;

    }

    /// <summary>
    /// status of pets availability
    /// </summary>


    internal enum petstatus
    {
         available,pending,sold
    }
}
