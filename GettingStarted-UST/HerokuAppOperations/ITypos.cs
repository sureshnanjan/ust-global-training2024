using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    public interface ITypos
    {
        /// <summary>
        /// This method helps to verify Title of the Typos Page
        /// </summary>
        /// <returns>Title as a string value </returns>
        string getTitle();

        /// <summary>
        /// This method helps to verify Page content
        /// </summary>
        /// <returns>Content of page as a string value </returns>
        string pageContent();
    }
}