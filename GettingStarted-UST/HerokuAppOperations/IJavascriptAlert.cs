using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    public interface IJavascriptAlert :IHerokuAppOperations
    {
        ///<summary>
        ///Get the Title
        ////<summary>
        public string GetTitle();

        /// <summary>
        /// Click for JS Alert
        /// </summary>
        public void ClickAndAcceptJSAlert();

        /// <summary>
        /// Click and Accept the JS confirm
        /// </summary>
        public void ClickAndAcceptJSConfirm();
        /// <summary>
        /// Click and Cancel the JS Confirm
        /// </summary>
        public void ClickAndCancelJSConfirm();
        /// <summary>
        /// Click on JS Prompt and enter the string 
        /// </summary>
        public void ClickJSPromt(string prompt);
        /// <summary>
        /// Get the result section content 
        /// </summary>
        /// <returns>Result message</returns>
        public string getResult();
        void CloseBrowser();
    }
}
