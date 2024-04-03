using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore
{
    /// <summary>
    /// Category details
    /// </summary>
    public class Category
    {
        private long id;
        private string itemname; 
            public void getattributes()
        {
            id = 10;
            itemname = "Fish";
            Console.WriteLine("id=" + id + "itemname=" + itemname);   
                }
    }
}
