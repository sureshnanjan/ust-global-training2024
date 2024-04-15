﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    public interface IHomepage_DynamicControl
    {
        /// <summary>
        /// Verify the title displayed
        /// </summary>
        /// <param name="name"></param>
        public void VerifyTitle(String name);

        /// <summary>
        /// Add/Remove the button by passing the argument
        /// </summary>
        /// <action> </action>
        public void PerformOpertion();

        /// <summary>
        /// Click on the checkbox option
        /// </summary>
        /// <returns></returns>
        public void ClickonCheckbox();
        /// <summary>
        /// Add the option
        /// </summary>
        /// <action> Add the Checkbox  </action>
        public void ClickAddButton();
        
        /// <summary>
        /// Click on the Enable button and verify
        /// </summary>
        /// <returns></returns>
        public void ClickonEnableOption();

        /// <summary>
        /// Click on the Disable button and verify
        /// </summary>
        /// <returns></returns>
        public void ClickonDisableOption();

        /// <summary>
        /// Method to verify if the field "Enable/Disable" is enabled/Disabled
        /// </summary>
        /// <returns>Returns True or False based on if field is enabled/disabled</returns>
        public bool GetFieldEnabledOption();


        /// <summary>
        /// Verify the error message displayed on the any functionality
        /// </summary>
        /// <returns>True or false based on Message match</returns>
        public bool GetMessage(String errmsg);
    }
}
