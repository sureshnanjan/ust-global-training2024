using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    internal interface IHome_KeyPresses
    {
        /// <summary>
        /// Get the tite of the page
        /// </summary>
        /// <returns></returns>
       public void GetKeyPresses();

        ///<summary>
        ///get the value entered inthe box
        ///</summary>

        public void GeTextBoxContent();

    }
}
