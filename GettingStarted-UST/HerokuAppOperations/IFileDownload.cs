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
        /// This method helps to verify whether correct URL loaded or not
        /// </summary>       
        string getURL();
        string getTitle();
        /// <summary>
        /// Verify the title of the  page
        /// </summary>
        /// <returns></returns>

        List<string> getAvailableFiles();
        /// <summary>
        /// Verify the list of different kind of files available for download
        /// </summary>
        /// <returns></returns>
        void downloadFile(string fileName);

        /// <summary>
        /// Verify whether the listed element is clickable
        /// </summary>
        /// 
        void downloadFilebyPosition(int pos);

        void verifyDownloadstatus(string exp);

    }
}
