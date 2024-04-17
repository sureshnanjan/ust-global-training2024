using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    public interface IJqueryMenu
    {
        /// <summary>
        /// This method fetched the current Url opened in the browser.
        /// </summary>
        /// <returns></returns>
        string getURL();
        /// <summary>
        /// This method verify the title of the page.
        /// </summary>
        string getTitle();
        /// <summary>
        /// This method helps to verify the main content.
        /// </summary>
        string getMainContent();
        /// <summary>
        /// This method helps to select the menu Enabled or disabled.
        /// </summary>
        string getMenuStatus(string locator);
        /// <summary>
        /// This method helps to select the sub menus
        /// </summary>        
        void doAction(string locator);

    }
}