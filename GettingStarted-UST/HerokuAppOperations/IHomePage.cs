namespace HerokuAppOperations
{
    /// <summary>
    ///  This provides access to all operations on heroku Home Page
    /// </summary>
    public interface IHomePage
    {
        /// <summary>
        /// Get the titke of the Page 
        /// </summary>
        /// <returns>Title</returns>
        string getTitle();
        /// <summary>
        /// Get the sub title of the page 
        /// </summary>
        /// <returns>SubTitle</returns> 
        string getSubTitle();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="exampleName"></param>
        void goToExample(string exampleName);
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        string[] getAvailableExamples();

    }
}
