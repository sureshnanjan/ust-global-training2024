using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;
using NUnit.Framework;

namespace TestHerokuApp
{
    [TestFixture]
    internal class FileUploadTests
    {
        /// <summary>
        /// Test for Uploading the File
        /// </summary>
        [Test]
        public void UploadFile()
        {
            IFileUploadPage fileuploadpage = null;
            String expectedTitle = "File Uploader";
            String actualTitle = fileuploadpage.getTitle();
            Assert.Equals(expectedTitle, actualTitle);
        }
        /// <summary>
        /// Test for Verifying the upload file
        /// </summary>
        [Test]
        public void VerifyuploadedFileMessage()
        {
            IFileUploadPage fileuploadpage = null;
            String filepath = "Test";
            fileuploadpage.ChooseFile(filepath);
            fileuploadpage.DoUpload();
            String expectedresult = "File Uploaded";
            String actualresult = fileuploadpage.getUploadedFileMessage();
            Assert.Equals(actualresult, expectedresult);
        }
        /// <summary>
        /// Test for Verifying the upload functionality, when no file is chosen
        /// </summary>
        [Test]
        public void ClickingonUpload_NoFile()
        {
            IFileUploadPage fileuploadpage = null;
            String filepath = "";
            fileuploadpage.ChooseFile(filepath);
            String expectedresult = "File Uploaded";
            String actualresult = fileuploadpage.getUploadedFileMessage();
            Assert.Equals(actualresult, expectedresult);
        }

    }
}