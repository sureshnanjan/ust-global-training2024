using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    /// <summary>
    /// Interface to do operations in Digest Authentication page
    /// </summary>
    internal interface IDigestAuthentication
    {

        /// <summary>
        /// Directs to Digest Authentication URL from Home Page
        /// </summary>
        /// <returns></returns>
        string GetSignInStatus();

        /// <summary>
        /// Action to be performed on clicking signin button using the username and Password provided in the textboxes
        /// </summary>
        /// <param name="userName">Username of User in Digest Authentication Web Page</param>
        /// <param name="password">Password of User in Digest Authentication Web Page</param>
        /// <param name="doCancel">For Cancel</param>
        /// <example></example>
        void DoSignIn(string userName, string password, bool doCancel = false);

        /// <summary>
        /// Gets Title of the Digest Authentication Web Page opened after successful signin of Digest Authentication Web Page
        /// </summary>
        /// <returns>Title of Digest Authentication Webpage</returns>
        string GetTitle();

    }
}
