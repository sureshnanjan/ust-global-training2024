using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    public interface IExitIntent
    {
        ///<summary>
        ///Get the Title
        ///<summary>
        public void GetTitle();

        /// <summary>
        /// Get the Description
        /// </summary>
        public void GetDescription();

        public void MoveMouseOutOfViewPort();

        public string GetNotificationTitle();

        public string GetNotificationDescription();

        public void HandleNotificationMessage(bool sayOK = true);
    }
}
