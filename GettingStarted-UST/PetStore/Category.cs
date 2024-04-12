using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore
{
    /// <summary>
    /// Represents a category for pets in the pet store.
    /// </summary>
    public class Category
    {
        private int id;

        private string? name;

        /// <summary>
        /// Gets or sets the ID of the category.
        /// </summary>
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        /// <summary>
        /// Gets or sets the Name of the category.
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }



    }
}
