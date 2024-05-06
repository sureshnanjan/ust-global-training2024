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
        /// This method verifies that whether URL is loaded or not
        /// </summary>       
        string getURL();

        /// <summary>
        /// This method verifies the title displayed correctly
        /// </summary>
        string getTitle();

        /// <summary>
        /// This method helps to verify the main content
        /// </summary>
        string getMainContent();

        /// <summary>
        /// This method helps to verify the link
        /// </summary>
        string verifyLink();

        /// <summary>
        /// This method will check if the image and content is changing dynamically
        /// </summary>
        string getContentText();



    }
}
