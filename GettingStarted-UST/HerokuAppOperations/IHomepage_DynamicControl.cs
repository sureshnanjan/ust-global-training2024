using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    public interface IHomepage_DynamicControl
    {
        /// <summary>
        /// This method helps to verify whether correct URL loaded or not
        /// </summary>       
        string getURL();
        /// <summary>
        /// Verify the title displayed
        /// </summary>
        /// <param name="name"></param>
        string getTitle();

        /// <summary>
        /// Remove the option
        /// </summary>
        /// <action> Removing the Checkbox available </action>
        public string ClickRemoveButton();

        /// <summary>
        /// Click on the checkbox option
        /// </summary>
        /// <returns></returns>
        public bool ClickonCheckbox();

        /// <summary>
        /// Click on the Enable button and verify
        /// </summary>
        /// <returns></returns>
        public string ClickonEnableOption();

        /// <summary>
        /// Click on the Disable button and verify
        /// </summary>
        /// <returns></returns>
        public string ClickonDisableOption();

        /// <summary>
        /// Perform add operations
        /// </summary>
        /// <returns></returns>
        string PerformAddOpertion();
    }
}
