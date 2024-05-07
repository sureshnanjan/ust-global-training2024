using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    /// <summary>
    /// Holds the Infinite Scroll page Elelments and Actions
    /// </summary>
    internal interface IInfiniteScrollPage
    {
        /// <summary>
        /// Get the Title of the Page
        /// </summary>
        /// <returns>Title as String</returns>
        string getTitle();

        /// <summary>
        /// Get the webpage URL 
        /// </summary>
        /// <returns>URL as String</returns>
        string getURL();

        /// <summary>
        /// Get the Heading of the webpage
        /// </summary>
        /// <returns>Heading as String</returns>
        string getHeading();

        /// <summary>
        /// Scroll down for the specified number of pages
        /// </summary>
        /// <param name="n">Number of scrolls</param>
        void performNScroll(int n);

        /// <summary>
        /// Get the specific paragraph content 
        /// </summary>
        /// <param name="n">Specified Paragraph</param>
        /// <returns>Paragraph Content as String</returns>
        string getNthParagraph(int n);

    }
}