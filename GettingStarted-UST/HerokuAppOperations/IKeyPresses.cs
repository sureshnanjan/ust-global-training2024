using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    public interface IKeyPresses
    {
        /// <summary>
        /// Get the tite of the page
        /// </summary>
        /// <returns>Title</returns>
        string getTitle();

        /// <summary>
        /// Get the content present on the screen
        /// </summary>
        /// <returns>Content</returns> 
        string getPageContent();

        /// <summary>
        /// Get the Input Message on the Key Press screen
        /// </summary>
        /// <returns>Input Message</returns> 
        string getInputMessage();

        /// <summary>
        /// Get the Numeric Input Value on the Key Press screen
        /// </summary>
        /// <returns></returns>
        public int getNumericInputValue(int n);

        /// <summary>
        /// Get the Text Input Value on the Key Press screen
        /// </summary>
        /// <returns></returns>
        public void getTextInputValue(string keyValue);
    }
}
