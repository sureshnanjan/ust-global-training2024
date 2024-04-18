using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    internal interface IJavascriptAlert
    {
        ///<summary>
        ///Get the Title
        ////<summary>
        public void GetTitle();

        /// <summary>
        /// Get the Description
        /// </summary>
        public void GetDescription();

        /// <summary>
        /// Click for JS Alert
        /// </summary>
        public void ClickJSAlert();

        /// <summary>
        /// Click for JS confirm
        /// </summary>
        public void ClickJSConfirm();

        /// <summary>
        /// Click for JS Prompt
        /// </summary>
        public void ClickJSPromt();
    }
}
