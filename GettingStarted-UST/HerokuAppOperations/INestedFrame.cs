using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    public interface INestedFrame
    {
        /// <summary>
        /// Verfiy page title
        /// </summary>    
        void pageUrl();

        /// <summary>
        /// Verfiy frame content
        /// </summary>  
        string getNestedFrameContent();



    }
}