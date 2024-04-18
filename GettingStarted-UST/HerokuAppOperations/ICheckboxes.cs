using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{       /// <summary>
        /// This provides details on functionality of checkbox in HerokuApp
        /// </summary>
        /// <returns></returns>
    internal interface ICheckboxes
    {
        /// <summary>
        /// Method to read title of the page
        /// </summary>
        /// <returns></returns>
        public string getTitle();
        
        /// <summary>
        /// To provide the functionality of marking checbox checked
        /// </summary>
        public void checkCheckBox();

        /// <summary>
        /// To provide the functionality of marking checbox unchecked
        /// </summary>
        public void unCheckCheckbox();
        /// <summary>
        /// To get the current status of checkbox
        /// </summary>   
        public void getCurrentStatus();

        
       

    }
}
