using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    public interface IDynamicContent
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
        /// This method helps to verify the main content.
        /// </summary>
        string getMainContent();
        /// <summary>
        /// This method helps to verify the link
        /// </summary>
        string verifyLink();
        /// <summary>
        /// This method will return Dynamic content
        /// </summary>
        string getDynamicContent();



    }
}
