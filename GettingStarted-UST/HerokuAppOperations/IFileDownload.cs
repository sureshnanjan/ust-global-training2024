namespace HerokuAppOperations
{

    public interface IFileDownload
    {
        /// <summary>
        /// This method helps to verify whether correct URL loaded or not
        /// </summary>       
        string getURL();
        /// <summary>
        /// This method verify the title displayed correctly
        /// </summary>
      
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
        /// <summary>
        /// This method verifies the download status
        /// </summary>        
        string getDownloadstatus(string fileStatus);


    }
}
