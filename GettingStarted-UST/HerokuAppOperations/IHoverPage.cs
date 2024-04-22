namespace HerokuAppOperations
{
    /// <summary>
    /// Represents the interface for HoverPage.
    /// </summary>
    internal interface IHoverPage
    {
        /// <summary>
        /// Gets the title of the hover page.
        /// </summary>
        /// <returns>The title of the hover page.</returns>
        string GetTitle();

        /// <summary>
        /// Gets the subtitle of the hover page.
        /// </summary>
        /// <returns>The subtitle of the hover page.</returns>
        string GetSubtitle();

        /// <summary>
        /// Performs the hover action on the page.
        /// </summary>
        /// <returns>True if the hover action was successful; otherwise, false.</returns>
        bool DoHover();

        /// <summary>
        /// Checks whether the user name is visible on the hover page.
        /// </summary>
        /// <returns>True if the user name is visible; otherwise, false.</returns>
        bool IsUserNameVisible();
    }
}
