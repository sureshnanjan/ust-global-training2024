using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore_Project
{
    public abstract class Pet 
    {
        int petId;
        string petName;
        string photoUrls;
        public enum status { available, pending, sold }
        Category petCategory = new Category();
        Tags petTags = new Tags();
        


    }
}
