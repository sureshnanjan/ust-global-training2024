namespace HerokuAppOperations
{
    /// <summary>
    ///  This provides access to all operations on heroku Home Page
    /// </summary>
    public interface IHomePage
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        string getTitle();
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns> 
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
