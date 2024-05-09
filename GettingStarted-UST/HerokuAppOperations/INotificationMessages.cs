using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    public interface INotificationMessages
    {
        /// <summary>
        /// Retrieves the title of the current page 
        /// </summary>
        string GetTitle();

        /// <summary>
        /// Retrieves the content of the current page 
        /// </summary>
        string GetContent();

        /// <summary>
        /// Initiates a click action, typically used for notification popup
        /// </summary>
        void ClickHere();

        //<summary>
        ///
        ///
        bool IsNotificationBarisVisible();

        /// <summary>
        /// Retrieves the title of a notification.
        /// </summary>
        string GetNotificationMessage();

        /// <summary>
        /// Closes a notification.
        /// </summary>
        void CloseNotification();

    }
}
