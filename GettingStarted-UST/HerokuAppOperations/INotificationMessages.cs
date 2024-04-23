using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    internal interface INotificationMessages
    {
        /// <summary>
        /// Retrieves the title of the current page 
        /// </summary>
        void GetTitle();

        /// <summary>
        /// Retrieves the content of the current page 
        /// </summary>
        void GetContent();

        /// <summary>
        /// Initiates a click action, typically used for notification popup
        /// </summary>
        void ClickHere();

        /// <summary>
        /// Retrieves the title of a notification.
        /// </summary>
        void GetNotificationTitle();

        /// <summary>
        /// Closes a notification.
        /// </summary>
        void CloseNotification();

    }
}
