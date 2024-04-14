using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    public interface ITinyMCEWYSIWYGEditor
    {

        /// <summary>
        /// This method verifies the title of the page
        /// </summary>
        string getTitle();

        /// <summary>
        /// This method verifies whether the text editor is enabled
        /// </summary>
        void getEditorWindowEnabled();

        /// <summary>
        /// This method verifies the main menu of text editor
        /// </summary>       
        string getMenu();

        /// <summary>
        /// This method verifies the sub menu status of text editor
        /// </summary>
        string getMenuStatus(string locator);

        /// <summary>
        /// This method helps to select the sub menus of text editor
        /// </summary>
        void doAction(string locator);

        /// <summary>
        /// This method verifies the text editor tools
        /// </summary>
        void doCheckEditorTools();

        /// <summary>
        /// This method verifies whether text can be entered in text editor
        /// </summary>
        void contentEditor();

    }
}
