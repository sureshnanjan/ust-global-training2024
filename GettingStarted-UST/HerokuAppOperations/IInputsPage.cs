using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    /// <summary>
    ///  This provides operations on Input Link 
    /// </summary>
    public interface IInputsPage
    {
        /// <summary>
        /// Test Method to get Title
        /// </summary>
        /// <returns></returns>
        string getTitle();
        /// <summary>
        /// Test method to validate - Input Increase Value
        /// </summary>
        /// <returns></returns>
        public int IncreaseValue();

        /// <summary>
        /// Test method to validate - Input Decrease Value
        /// </summary>
        /// <returns></returns>
        public int DecreaseValue();

    }
}