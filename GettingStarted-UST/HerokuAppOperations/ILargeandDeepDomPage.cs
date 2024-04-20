using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HerokuAppOperations
{


    public interface ILargeandDeepDomPage
    {

        /// <summary>
        /// Get the title displayed in the page
        /// </summary>
        public string Getpagetitle();
        /// <summary>
        /// Get list of elements in nth nest  - Deep -Document Object Model
        /// </summary>
        /// <param name="id">level from which the data needs to be fetched</param>
        /// <returns> List of the Values in nth level  </returns>
        public string AccessNthelement(int id);

        /// <summary>
        /// Get Element By Class Name in Siblings - Long  -Document Object Model the option
        /// </summary>
        /// <param name="column">Column value of the element</param>
        /// <param name="row">Row value of element</param>
        /// <action>Get an element using nth row and column value</action>
        /// <returns> Element Value at that row, column  </returns>
        public int getElementbyrowandcolumn(int row, int column);


    }
}