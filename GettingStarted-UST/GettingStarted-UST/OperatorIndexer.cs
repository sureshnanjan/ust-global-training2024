using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarted_UST
{
    public class OperatorIndexer
    {
        public string[] val = new string[7];

        public string this[int index]
        {
            get
            {// get Accessor
             // retrieving the values 
             // stored in val[] array
             // of strings
                return val[index];
            }
            set
            {

                // value keyword is used
                // to define the value 
                // being assigned by the
                // set indexer. 
                val[index] = value;
            }

        }

    }
}