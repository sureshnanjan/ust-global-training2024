namespace HerokuAppOperations
{
    public interface IFrameOperations

    {
        /// <summary>
        /// This method verifies the title of the page
        /// </summary>
        string getTitle();

        /// <summary>
        /// This method verifies the items displayed on the page like nested frames
        /// </summary>
        List<string> verifyItems(string itemName);

        /// <summary>
        /// This method to click on the item on the page
        /// </summary>
        void clickOnItem(string itemName);

        /// <summary>
        /// This method verifies the nested frames count
        /// </summary>
        int countTheNestedFrames();

        /// <summary>
        /// This method verifies the text displayed in each frame
        /// </summary>
        List<string> VerifyNestedFramesText();

        /// <summary>
        /// This method verifies the text displayed in the Iframe 
        /// </summary>
        string getIframesTitle();

        /// <summary>
        /// This method verifies if the text editor displayed or not
        /// </summary>
        bool isTextEditorDisplayed();

        /// <summary>
        /// This method captures all the menu items displayed in the text editor
        /// </summary>
        List<string> getTheMenuItems();

        /// <summary>
        /// This method captures all the menu items displayed in the text editor
        /// </summary>
        List<string> getSubmenuItems(string mainMenuName);


        /// <summary>
        /// This method helps to select the sub menus of text editor
        /// </summary>
        void doAction(string subMenu);

        /// <summary>
        /// This method lists the text editor tools displayed
        /// </summary>
        List<string> getTextEditorTools();

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
        /// </summary>
        string setHeadingStyle(string headingText);

        /// <summary>
        /// This method for choosing Inline style
        /// </summary>
        string setInline(string inlineText);

        /// <summary>
        /// This method for choosing blocks style
        /// </summary>
        string setBlocks(string text);

        /// <summary>
        /// Method for choosing left/right/center/justify
        /// alignStyles - Enum for Aling styles
        /// </summary>
        string setAlign(AlignStyle textToAlign);

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