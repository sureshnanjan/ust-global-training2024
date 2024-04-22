namespace HerokuAppOperations
{
    /// <summary>
    ///  This provides operations on File Upload Link 
    /// </summary>
    public interface IFileUploadPage
    {
        /// <summary>
        /// Test Method to get Title
        /// </summary>
        /// <returns></returns>
        string getTitle();

        /// <summary>
        /// Test method to validate - Choose File Button
        /// </summary>
        /// <returns></returns>
        public void ChooseFile(string filePath)
        {

        }

        /// <summary>
        /// Test method to validate - Upload Button
        /// </summary>
        /// <returns></returns>
        public void DoUpload();


        /// <summary>
        /// Test method to validate - Upload File Message
        /// </summary>
        /// <returns></returns>
        string getUploadedFileMessage();

    }
}