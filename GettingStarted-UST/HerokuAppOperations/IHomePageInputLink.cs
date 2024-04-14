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
    public interface IHomePageInputLink
    {
        /// <summary>
        /// Test method to validate - Input Increase Value
        /// </summary>
        /// <returns></returns>
        int InputIncreaseValue();

        /// <summary>
        /// Test method to validate - Input Decrease Value
        /// </summary>
        /// <returns></returns>
        int InputDecreaseValue();

    }
}
