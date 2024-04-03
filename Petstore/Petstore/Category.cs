using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petstore
{
    /// <summary>
    /// Category Details
    /// </summary>
    public class Category
    {
        private long id;
        private string name;
        public void getattributes()
        {
            id = 10;
            name = "fish";
            Console.WriteLine("id ="+ id +"name ="+name );
          }
    }
}
