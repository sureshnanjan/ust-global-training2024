namespace HerokuAppOperations
{
    /// <summary>
    ///  This provides access to all operations on heroku Home Page
    /// </summary>
    public interface IHomePage: IHerokuAppOperations
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
        IHerokuAppOperations goToExample(string exampleName);
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        string[] getAvailableExamples();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="locator"> This is a patterns which will identify nested elemensts eg level1: level2: ... levelN</param>
        /// .<example>
        /// If there are 3 level of Menu item please refer <paramref name="locator"> enabled/download/pdf
        /// </paramref>
        /// </example>
        /// <returns></returns>
        bool getStatus(string locator);

    }
}
