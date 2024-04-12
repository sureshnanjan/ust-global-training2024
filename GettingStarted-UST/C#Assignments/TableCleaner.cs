using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Assignments
{
    /// <summary>
    /// Represents a cleaner responsible for cleaning tables in the restaurant.
    /// </summary>
    internal class TableCleaner
    {
        int id;
        string name;

        public TableCleaner(int id)
        {
            this.id = id;
            this.name = "Cleaner";
        }
        /// <summary>
        /// Cleans a table.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="args">Optional event arguments.</param>
        public void CleanTabe(object sender,EventArgs? args)
        {
            Console.WriteLine($"{this.name} {this.id} is cleaning the table.");
        }
    }
}
