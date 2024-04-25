using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    /// <summary>
    /// 
    /// </summary>
    public interface IChallengingDomOperations : IHerokuAppOperations
    {

        /// <summary>
        /// This method fetched the current Url opened in the browser.
        /// </summary>
        /// <returns> The fetched URL is as string</returns>
        string getURL();

        /// <summary>
        /// This method fetched the title opened in the browser.
        /// </summary>
        /// <returns> The fetched title as string</returns>
        string getTitle();

        /// <summary>
        /// This method fetches the main content in the page 
        /// </summary>
        /// <returns> The fetched main content is as string</returns>
        string getMainContent();

        /// <summary>
        /// This method performs operations for the first button.
        /// </summary>
        /// <returns></returns>
        void doOperation1();

        /// <summary>
        /// This method retireves the label text of the first button.
        /// </summary>
        /// <returns> The button label text as string</returns>
        string getOperation1Label();

        /// <summary>
        /// This method performs operations for the second button.
        /// </summary>
        /// <returns></returns>
        void doOperation2();

        /// <summary>
        /// This method retireves the label text of the second button.
        /// </summary>
        /// <returns> The button label text as string</returns>
        string getOperation2Label();

        /// <summary>
        /// This method performs operations for the third button.
        /// </summary>
        /// <returns></returns>
        void doOperation3();

        /// <summary>
        /// This method retireves the label text of the third button.
        /// </summary>
        /// <returns> The button label text as string</returns>
        string getOperation3Label();

        /// <summary>
        /// This method retireves the value of Answer for the actions performed 
        /// </summary>
        /// <returns> The answer value as string</returns>
        string getResult();

        /// <summary>
        /// This method retireves the table headings in the table  
        /// </summary>
        /// <returns> The table headings are returned as array string</returns>
        string[] getTableHeadings();

        /// <summary>
        /// This method performs edit action on the row 
        /// </summary>
        /// <param name="rownum"/> The row number which needs to be edited </param>
        /// <returns> </returns>
        void editRow(int rownum);

        /// <summary>
        /// This method performs delete action on the row 
        /// </summary>
        /// <param name="rownum"/> The row number which needs to be deleted </param>
        /// <returns> </returns>
        void deleteRow(int rownum);

        /// <summary>
        /// This method retrieves the data information of the row
        /// </summary>
        /// <param name="rownum"/> The row number for which data has to be fetched </param>
        /// <returns> the row data as a string array </returns>
        string[] getRowData();
    }
}