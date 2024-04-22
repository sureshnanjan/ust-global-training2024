namespace HerokuAppOperations
{
    /// <summary>
    /// Holds the Properties and Operations of Floating Menu page 
    /// </summary>
    internal interface IFloatingMenuPage
    {
        /// <summary>
        /// Get the Title of the Page
        /// </summary>
        /// <returns>Title as String</returns>
        string getTitle();

        /// <summary>
        /// Get the webpage URL 
        /// </summary>
        /// <returns>URL as String</returns>
        string getURL();

        /// <summary>
        /// Get the Heading of the webpage
        /// </summary>
        /// <returns>Heading as String</returns>
        string getHeading();

        /// <summary>
        /// Get the number of Menu Options
        /// </summary>
        /// <returns>Count as Int</returns>
        int getMenuOptionCount();

        /// <summary>
        /// Get all the Menu Options in the Page
        /// </summary>
        /// <returns>List of Menu options</returns>
        List<string> getAllMenuOptions();

        /// <summary>
        /// Click on the specified menu
        /// </summary>
        /// <param name="menu"></param>
        void clickOnSpecificMenu(string menu);

        /// <summary>
        /// Scroll down for the specified number of pages
        /// </summary>
        /// <param name="n"></param>
        void performNScroll(int n);

        /// <summary>
        /// Get the visibility status of the Menu Item
        /// </summary>
        /// <param name="item">Menu Item</param>
        /// <returns>Staus as True or False</returns>
        bool getMenuItemVisibilityStatus(string item = "All");

    }
}