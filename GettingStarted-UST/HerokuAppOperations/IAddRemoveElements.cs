namespace HerokuAppOperations
{
    public interface IAddRemoveElements : IHerokuAppOperations
    {
        /// <summary>
        /// This method helps to verify content on page
        /// </summary>
        /// <returns>content as a string value </returns>
        bool verifyPageContent();

        /// <summary>
        /// This method helps to verify Add Elements actionable button on the page
        /// </summary>

        void clickOnAddElements(int i);

        /// <summary>
        /// This method helps to verify Delete actionable button presence on the page
        /// </summary>

        bool checkForPresenceofDeleteButton();

        /// <summary>
        /// This method helps to verify Delete operation in the page
        /// </summary>
        void clickOnDelete(int i);

        /// <summary>
        ///  this method captures and prints the time it was called.
        /// </summary>
        string getTime();

        /// <summary>
        ///  this method clicks on the Add Remove Elemetns link present on the homepage.
        /// </summary>
        void clickAddRemoveElementLink();
        void closeBrowser();
    }
}