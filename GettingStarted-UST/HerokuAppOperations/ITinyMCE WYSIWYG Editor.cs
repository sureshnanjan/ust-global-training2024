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
        /// This method lists the text editor tools
        /// </summary>
        List<string> editorToolbarElements();

        /// <summary>
        /// This method for Redo operation
        /// </summary>
        void redoOperation();

        /// <summary>
        /// This method for Undo operation
        /// </summary>
        void undoOperation();

        /// <summary>
        /// This method for Paragraph operation
        /// </summary>
        void setParagraph();

        /// <summary>
        /// This method for choosing heading style
        /// headingStyles - Enum for Heading styles
        /// </summary>
        string setHeadingStyle(headingStyles headingText);

        /// <summary>
        /// This method for choosing Inline style
        /// inlineStyles - Enum for Inline styles
        /// </summary>
        string setInline(inlineStyles inlineText);

        /// <summary>
        /// This method for choosing blocks style
        /// blockStyles - Enum for Blocks styles
        /// </summary>
        string setBlocks(blocksStyles text);

        /// <summary>
        /// Method for choosing left/right/center/justify
        /// alignStyles - Enum for Aling styles
        /// </summary>
        string setAlign(alignStyle textToAlign);

        /// <summary>
        /// Method for converting slected text into blod
        /// </summary>
        string setBold(string boldText);

        /// <summary>
        /// Method for converting slected text into italics
        /// </summary>
        string setItalics(string italicsText);

        /// <summary>
        /// Method for Aligning text to Left
        /// </summary>
        void setAlignLeft();

        /// <summary>
        /// Method for Aligning text to Right
        /// </summary>
        void setAlignRight();

        /// <summary>
        /// Method for Aligning text to Center
        /// </summary>
        void setAlignCenter();

        /// <summary>
        /// Method for Aligning text to Justify
        /// </summary>
        void setAlignJustify();

        /// <summary>
        /// Method for inceasing intent of text
        /// </summary>
        void setIncreaseIntent();

        /// <summary>
        /// This method verifies whether text can be entered
        /// </summary>
        void getEditorContent();

    }
}