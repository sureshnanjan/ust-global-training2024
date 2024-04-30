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
    public interface ICheckboxes
    {
        /// <summary>
        /// Method to click the checkbox link
        /// </summary>

        public void clickCheckBoxLink();

        /// <summary>
        /// Check the title of Checkbox page
        /// </summary>
        public string getTitle();

        /// <summary>
        /// To provide the functionality of marking checbox checked
        /// </summary>
        public void EnableCheckBox1();

        /// <summary>
        /// To provide the functionality of marking checbox unchecked
        /// </summary>
        public void disableBothCheckbox();

    }
}
