using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarted_UST
{
    public class OperatorIndexer
    {
        string[] names = new string[3];
        
        
        /// <summary>
        /// Indexer declaration
        /// </summary>
        public string this[int index] 
        {
            get {  return names[index]; }

            set { names[index] = value; }
        }

        /// <summary>
        /// Operator overloading
        /// </summary>    
        
    }
}
