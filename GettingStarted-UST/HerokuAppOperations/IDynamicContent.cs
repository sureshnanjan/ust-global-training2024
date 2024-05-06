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
        /// This method verifies the title of the page
        /// </summary>
        /// 
        string getPageTitle();


        /// <summary>
        /// This method helps to verify the main content.
        /// </summary>
        string getMainContent();

        /// <summary>
        /// This method helps to verify the link
        /// </summary>
        string verifyLink();

        /// <summary>
        /// This method verifies the Click here button
        /// </summary>


        void clickHereButton();

        /// <summary>
        /// This method verifies the content in the page
        /// </summary>

        string getDynamicPageContent();

    }
}
