using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    /// <summary>
    /// Represents the interface for HoverPage.
    /// </summary>
    public interface IHoverPage
    {
        /// <summary>
        /// Gets the title of the hover page.
        /// </summary>
        /// <returns>The title of the hover page.</returns>
        string GetTitle();

        /// <summary>
        /// Gets the subtitle of the hover page.
        /// </summary>
        /// <returns>The subtitle of the hover page.</returns>
        string GetSubtitle();

        /// <summary>
        /// Method to perform hover action on a specific image based on its number.
        /// </summary>
        /// <param name="imageNumber">The number of the image to hover over.</param>
        void DoHover(string imageNumber);

        /// <summary>
        /// Gets the user name from a specific image based on its number and.
        /// </summary>
        /// <param name="imageNumber">The number of the image to hover over.</param>
        /// <returns>The hover text of the image.</returns>
        string GetUserName(string imageNumber);

        /// <summary>
        /// Methods to perform click action on view profile.
        /// </summary>
        /// <param name="imageNumber">The number of the image.</param>

        void ClickOnViewProfile(string imageNumber);
    }
}
