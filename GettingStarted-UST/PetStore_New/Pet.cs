using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore_New
{
    internal class Pet
    {
        private long id = 10;
        private string name;
        private string photourls;
        Category category = new Category();
        Tags tags = new Tags();
        OrderStatus status = new OrderStatus();
    }
}
