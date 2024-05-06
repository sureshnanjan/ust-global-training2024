using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    /// <summary>
    /// Represents the interface for SlowResourcePage.
    /// </summary>
    public interface ISlowResourcePage : IHerokuAppOperations
    {
        /// <summary>
        /// Gets the title of the Slow Resource Page.
        /// </summary>
        /// <returns>The title of the Slow resource page as a string.</returns>
        public string getTitle();

        /// <summary>
        /// Gets the context of the Slow Resource Page.
        /// </summary>
        /// <returns>The context of the Slow resource page as a string.</returns>
        public string getContext();


    }
}