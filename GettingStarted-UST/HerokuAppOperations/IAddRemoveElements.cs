namespace HerokuAppOperations
{
    public interface IAddRemoveElements
    {
        /// <summary>
        /// This method helps to verify content on page
        /// </summary>
        /// <returns>content as a string value </returns>
        bool pageContent();

        /// <summary>
        /// This method helps to verify Add Elements actionable button on the page
        /// </summary>

        void clickOnAddElements();

        /// <summary>
        /// This method helps to verify Delete actionable button presence on the page
        /// </summary>

        bool checkForPresenceofDeleteButton();

        /// <summary>
        /// This method helps to verify Delete operation in the page
        /// </summary>
        void clickOnDelete();

    }
}