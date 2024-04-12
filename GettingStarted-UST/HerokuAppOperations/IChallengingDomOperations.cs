using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    /// <summary>
    /// Heroku App Home page operation details
    /// </summary>
    public interface IChallengingDomOperations
    {
        /// <summary>
        /// This method fetched the current Url opened in the browser.
        /// </summary>
        /// <returns></returns>
        string getURL();
        /// <summary>
        /// This method gets the title of current page 
        /// </summary>
        /// <returns></returns>
        string getTitle();

        /// <summary>
        /// This method fetches the main content from the page 
        /// </summary>
        /// <returns></returns>
        string getMainContent();
        /// <summary>
        /// This method will perform Operation 1
        /// </summary>
        void doOperation1();

        /// <summary>
        /// This method will perform Operation 1
        /// </summary>
        /// <returns></returns>
        string getOperation1Label();

        /// <summary>
        /// This method will perform Operation 1
        /// </summary>
        void doOperation2();

        /// <summary>
        /// This method will perform Operation 1
        /// </summary>
        /// <returns></returns>
        string getOperation2Label();
        /// <summary>
        /// 
        /// </summary>
        void doOperation3();
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        string getOperation3Label();
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        string getResult();
        /// <summary>
        /// This method will get the heading of the Table
        /// </summary>
        /// <returns></returns>
        string[] getTableHeadings();
        /// <summary>
        /// This method will edit the respective row
        /// </summary>
        /// <param name="rownum"></param>
        void editRow(int rownum);

        /// <summary>
        /// This method will delete the Row
        /// </summary>
        /// <param name="rownum"></param>
        void deleteRow(int rownum);

        /// <summary>
        /// This method will get the data from respective row 
        /// </summary>
        /// <param name="rownum"></param>
        /// <returns></returns>
        string[] getRowData(int rownum);
    }
}
