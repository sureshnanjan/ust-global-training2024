using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{

    /// <summary>
    /// To perform operations in Secure File Download page
    /// </summary>
    internal interface ISecureFileDownload
    {

        /// <summary>
        /// Directs to Secure File Download URL from Home Page
        /// </summary>
        /// <returns></returns>
        string SignInStatus();

        /// <summary>
        /// Action to be performed on clicking signin button using the username and Password provided in the textboxes of Secure File download page
        /// </summary>
        /// <param name="userName">Username of User in Secure File download page</param>
        /// <param name="password">Password of User in Secure File download page</param>
        /// <param name="doCancel">Value of Cancel</param>
        /// <example></example>
        void DoSignIn(string userName, string password, bool doCancel = false);

        /// <summary>
        /// Gets Title of the Secure File download Web Page opened after successful signin of Secure File download page Web Page
        /// </summary>
        /// <returns>Title of Secure File download Webpage</returns>
        string GetTitle();

        /// <summary>
        /// Fetches all the available links in Secure File Download Web Page
        /// </summary>
        /// <returns>List of Links</returns>
        string[] GetAvailableLinksInSecureFileDownload();

        /// <summary>
        /// Download Files based on name
        /// </summary>
        /// <param name="fileName">Name of link available in Secure File Download</param>
        void DownloadFileByName(string fileName);

        /// <summary>
        /// Download Files based on position
        /// </summary>
        /// <param name="filePosition">Position of link available in Secure File Download</param>
        void DownloadFileByPosition(string filePosition);

        /// <summary>
        /// To get status of Download
        /// </summary>
        /// <param name="status">Download status</param>
        string GetDownloadStatus(string status);
    }
}
