using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarted_UST
{
    public class IndexerOverloading
    {
        private string[] word = new string[2];

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
