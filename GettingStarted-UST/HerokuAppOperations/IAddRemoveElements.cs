using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    internal interface IAddRemoveElements
    {
        /// <summary>
        /// This method helps to verify content on page
        /// </summary>
        /// <returns>content as a string value </returns>
        string pageContent();

        /// <summary>
        /// This method helps to verify Add Elements actionable button on the page
        /// </summary>
    
        void clickOnAddElements();

        /// <summary>
        /// This method helps to verify Delete actionable button presence on the page
        /// </summary>

        void checkForPresenceofDeleteButton();

        /// <summary>
        /// This method helps to verify Delete operation in the page
        /// </summary>
        void clickOnDelete();

    }
}
