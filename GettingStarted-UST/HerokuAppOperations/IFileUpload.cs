using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    /// <summary>
    ///  This provides operations on File Upload Link 
    /// </summary>
    public interface IFileUpload
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
        public void ChooseFile();

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
