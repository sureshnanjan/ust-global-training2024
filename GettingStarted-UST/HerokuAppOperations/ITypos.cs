using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    public interface ITypos
    {
        /// <summary>
        /// This method verifies the title of the page
        /// </summary>

        string getPageTitle();

        /// <summary>
        /// This method verifies the page content
        /// </summary>

        string getPageContent();

    }
}
