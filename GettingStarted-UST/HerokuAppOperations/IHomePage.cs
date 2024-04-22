using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    /// <summary>
    ///  This provides access to all operations on heroku Home Page
    /// </summary>
    public interface IHomePage: IHerokuAppOperations
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        string getTitle(); // zget Title // Print The document // saving title to some report
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns> 
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
        bool GetStatus(string locator);

        //string GetStatus(string locator);
        
    }
}
