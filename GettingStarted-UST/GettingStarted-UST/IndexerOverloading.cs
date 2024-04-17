using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarted_UST
{
    /// <summary>
    /// Index Overloading Class
    /// </summary>
    public class IndexerOverloading
    {
        private string[] word = new string[2];

        /// <summary>
        /// this indexer gets executed when IndexOver[0] gets executed 
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        public string this[int flag]
        {

            // using get accessor 
            get
            {
                string temp = word[flag];
                return temp;
            }

            // using set accessor 
            set
            {
                word[flag] = value;
            }
        }

        /// <summary>
        ///  This is an Overloaded indexer which will execute when IndexOver[1.0f] gets executed 
        /// </summary>
        /// <param name="flag">Method parameter</param>
        /// <returns></returns>
        public string this[float flag]
        {

            // using get accessor 
            get
            {
                string temp = word[1];
                return temp;
            }

            // using set accessor 
            set
            {

                // it will set value of the private string assigned in main 
                word[1] = value;
            }
        }
    }
}
