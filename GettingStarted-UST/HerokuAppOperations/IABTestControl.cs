namespace HerokuAppOperations
{
    public interface IABTestControl
    {
        /// <summary>
        /// This method verifies the title of the page
        /// </summary>

        string getTitle();

        /// <summary>
        /// This method verifies the content of page
        /// </summary>
        string getMainContent();
    }
}