
		 namespace HerokuAppOperations
{
    /// <summary>
    /// Provides access to all operations on the Heroku Exit Intent Page
    /// </summary>
    public interface IExitIntentPage : IHerokuAppOperations
    {
        /// <summary>
        /// Gets the title of the exit intent page
        /// </summary>
        /// <returns>The title of the exit intent page</returns>
        string GetTitle();

        /// <summary>
        /// Gets the subtitle of the exit intent page
        /// </summary>
        /// <returns>The subtitle of the exit intent page</returns>
        string GetSubTitle();

        /// <summary>
        /// Navigates to a specific example on the exit intent page
        /// </summary>
        /// <param name="exampleName">The name of the example to navigate to</param>
        /// <returns>The interface for the specified example</returns>
        IHerokuAppOperations GoToExample(string exampleName);

        /// <summary>
        /// Gets an array of available examples on the exit intent page
        /// </summary>
        /// <returns>An array of available examples</returns>
        string[] GetAvailableExamples();

        /// <summary>
        /// Gets the status of an element identified by the given locator pattern
        /// </summary>
        /// <param name="locator">The pattern used to identify the element</param>
        /// <returns>True if the element is enabled, false otherwise</returns>
        bool GetStatus(string locator);
    }
}

	 }
 }