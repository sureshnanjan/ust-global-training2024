using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    /// <summary>
    /// Represents the interface for a forgot password page.
    /// </summary>
    public interface IForgotPasswordPage
    {
        /// <summary>
        /// Gets the title of the forgot password page.
        /// </summary>
        /// <returns>The title of the forgot password page as a string.</returns>
        string GetTitle();

        /// <summary>
        /// Gets the label associated with the email input field.
        /// </summary>
        /// <returns>The label for the email input field as a string.</returns>
        string GetLabel();

        /// <summary>
        /// Enters the specified email into the email input field.
        /// </summary>
        /// <param name="email">The email to be entered.</param>
        /// <returns>True if the email is successfully entered; otherwise, false.</returns>
        bool EnterEmail(string email);

        /// <summary>
        /// Clicks on the 'Retrieve Password' button to initiate the password retrieval process.
        /// </summary>
        /// <returns>True if the button is successfully clicked; otherwise, false.</returns>
        bool ClickOnRetrievePassword();
    }

}
