using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    /// <summary>
    /// Interface with operations that can be done on Heroku homepage
    /// </summary>
    public interface IHomePage
    {
        /// <summary>
        /// Fetches Title of HomePage
        /// </summary>
        /// <returns>Title in string format</returns>
        string GetTitle();

        /// <summary>
        /// Fetches Sub Title of HomePage
        /// </summary>
        /// <returns>Sub Title in string format</returns>
        string GetSubTitle();

        /// <summary>
        /// Redirects to other pages
        /// </summary>
        /// <param name="exampleName">Name of link available in HomePage</param>
        void GoToExample(string exampleName);

        /// <summary>
        /// Fetches all the available links in HomePage
        /// </summary>
        /// <returns>List of Links</returns>
        string[] GetAvailableExamples();
    }
}
