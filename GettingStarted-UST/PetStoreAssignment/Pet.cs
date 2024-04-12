using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStoreAssignment
{
    internal class Pet : Category
    {
        /// <summary>
        /// Contians Pet details like id, name, photourl where id and name can be inherited 
        /// </summary>

        private long id = 10;
        private string name;
        private string photourls;
    }
}
