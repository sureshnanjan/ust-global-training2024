using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{

    public interface IFileDownload
    {
        /// <summary>
        /// This method helps to verifies that whether URL loaded or not
        /// </summary>       
        string getURL();

        /// <summary>
        /// This method verifies the title displayed correctly
        /// </summary>
        string getTitle();

        /// <summary>
        /// Verify the list of different type of files available
        /// </summary>
        List<string> getAvailableFiles();

        /// <summary>
        /// Verify whether the listed element is clickable
        /// </summary> 
        void downloadFile(string fileName);

        /// <summary>
        /// This method verifies whether the file has been downloaded or not
        /// </summary>  
        void verifyFileDownloaded(string fileName);
      


    }
}
