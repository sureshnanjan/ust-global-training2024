using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore
{
    /// <summary>
    /// Represents a pet in the pet store.
    /// </summary>
    public class Pet
    {
        private int id;
        private Category? category;
        private string? name;
        private string? photoUrls;
        private Tag? tags;

        /// <summary>
        /// Gets or sets the ID of the pet.
        /// </summary>
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        /// <summary>
        /// Gets or sets the category of the pet.
        /// </summary>
        public Category? Category
        {
            get { return category; }
            set { category = value; }
        }

        /// <summary>
        /// Gets or sets the name of the pet.
        /// </summary>
        public string? Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Gets or sets the photo URLs of the pet.
        /// </summary>
        public string? PhotoUrls
        {
            get { return photoUrls; }
            set { photoUrls = value; }
        }

        /// <summary>
        /// Gets or sets the tags.
        /// </summary>
        public Tag? Tags
        {
            get { return tags; }
            set { tags = value; }
        }


    }
}
