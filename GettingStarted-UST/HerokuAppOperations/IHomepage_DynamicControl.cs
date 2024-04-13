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
        /// Remove the option
        /// </summary>
        /// <action> Removing the Checkbox available </action>
        public void ClickRemoveButton();

        /// <summary>
        /// Click on the checkbox option
        /// </summary>
        /// <returns></returns>
        public void ClickonCheckbox();

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
    }
}
