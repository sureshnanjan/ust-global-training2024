namespace HerokuAppOperations
{
    /// <summary>
    /// Provides access to all operations on JavaScript Alert Page
    /// </summary>
    public interface IJavaScriptAlertPage : IHerokuAppOperations
    {
        /// <summary>
        /// Accepts the JavaScript alert dialog
        /// </summary>
        void AcceptAlert();

        /// <summary>
        /// Dismisses the JavaScript alert dialog
        /// </summary>
        void DismissAlert();

        /// <summary>
        /// Gets the text from the JavaScript alert dialog
        /// </summary>
        /// <returns>The text from the JavaScript alert dialog</returns>
        string GetAlertText();

        /// <summary>
        /// Accepts the JavaScript confirm dialog
        /// </summary>
        void AcceptConfirm();

        /// <summary>
        /// Dismisses the JavaScript confirm dialog
        /// </summary>
        void DismissConfirm();

        /// <summary>
        /// Gets the text from the JavaScript confirm dialog
        /// </summary>
        /// <returns>The text from the JavaScript confirm dialog</returns>
        string GetConfirmText();

        /// <summary>
        /// Enters the specified text into the JavaScript prompt dialog and accepts it
        /// </summary>
        /// <param name="text">The text to enter into the prompt dialog</param>
        void EnterPromptTextAndAccept(string text);

        /// <summary>
        /// Enters the specified text into the JavaScript prompt dialog and dismisses it
        /// </summary>
        /// <param name="text">The text to enter into the prompt dialog</param>
        void EnterPromptTextAndDismiss(string text);

        /// <summary>
        /// Gets the text from the JavaScript prompt dialog
        /// </summary>
        /// <returns>The text from the JavaScript prompt dialog</returns>
        string GetPromptText();
    }
}
