using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore_Project
{
    /// <summary>
    /// Pets details declaration
    /// </summary>
    public abstract class Pets : Category
    {
        private long id;
        private string name;
        private string petsphotoUrls;
        private string petsStatus;


    }
    /// <summary>
    /// Pets Status details declaration
    /// </summary>
    internal enum petsStatus
    {
        available,
        pending,
        sold
    }
}
