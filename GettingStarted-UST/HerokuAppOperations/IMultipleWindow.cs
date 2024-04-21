using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    public interface IMultipleWindow
    {
        /// <summary>
        /// This method helps to verifies that whether URL loaded or not
        /// </summary>       
        string getURL();
        /// <summary>
        /// This method verifies the title displayed correctly
        /// </summary>
        string getTitle();
        /// <summary>
        /// This method helps to verify the link
        /// </summary>
        string verifyLink();
        /// <summary>
        /// This method helps to verify new window
        /// </summary>
        string verifyNewWindow();
        /// <summary>
        /// This method verifies the title in new window
        /// </summary>




    }
}
