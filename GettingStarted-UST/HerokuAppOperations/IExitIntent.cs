using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    internal interface IExitIntent
    {
        ///<summary>
        ///Get the Title
        ///<summary>
        public void GetTitle();

        /// <summary>
        /// Get the Description
        /// </summary>
        public void GetDescription();
    }
}
