using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;
using NUnit.Framework.Constraints;
using NUnit.Framework.Legacy;

namespace TestHerokuApp
{
    /// <summary>
    /// Test cases for File Download page
    /// </summary>
    [TestFixture]
    public class FileDownloadTests
    {

        /// <summary>
        /// To verify the URL of page is correct
        /// </summary>
        [Test]
        public void UrlOfPageIsCorrect()
        {
            /// AAA
            /// HomePage
            /// NavigatetoExample
            /// 
            IFileDownload fileDownload = null;
            string expectedUrl = "https://the-internet.herokuapp.com/download";
            string actualUrl = fileDownload.getURL();
            Assert.That(actualUrl, Is.EqualTo(expectedUrl));
        }

        /// <summary>
        /// To Verify the title of page is correct
        /// </summary>
        [Test]
        public void TitleOfPageIsCorrect()
        {
            IFileDownload fileDownload = null;
            string expectedTitle = "File Downloader";
            string actualTitle = fileDownload.getTitle();
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
        }

        /// <summary>
        /// To verify the number of Files available in the page
        /// </summary>
        [Test]
        public void NumberOfFilesIsCorrect()
        {
            IFileDownload fileDownload = null;
            int expected = 129;
            int actual = fileDownload.getAvailableFiles().Count();
            Assert.That(actual, Is.EqualTo(expected));
        }

        /// <summary>
        /// To verify the List of Files is correct
        /// </summary>
        [Test]
        public void ListOfFilesIsCorrect()
        {
            IFileDownload fileDownload = null;
            List<string> expected = new List<string>();
            List<string> actual = fileDownload.getAvailableFiles();
            CollectionAssert.AreEquivalent(expected, actual);
        }

        /// <summary>
        /// To verify whether file download is successful by clicking on name of file
        /// </summary>
        [Test]
        public void DownloadByNameIsSuccess()
        {
            IFileDownload fileDownload = null;
            string expectedMsg = "Success";
            string actualMsg = fileDownload.downloadFile("First File");
            Assert.That(actualMsg, Is.EqualTo(expectedMsg));
        }

        /// <summary>
        /// To verify whether file download is successful by clicking based on the position of file
        /// </summary>
        [Test]
        public void DownloadByPosistionIsSuccess()
        {
            IFileDownload fileDownload = null;
            string expectedMsg = "Success";
            string actualMsg = fileDownload.downloadFilebyPosition(3);
            Assert.That(actualMsg, Is.EqualTo(expectedMsg));
        }

        /// <summary>
        /// To verify the downlod status of files by their names
        /// </summary>
        [Test]
        public void DownloadByPositionIsSuccess()
        {
            IFileDownload fileDownload = null;
            string expectedMsg = "Success";
            string actualMsg = fileDownload.getDownloadstatus("File name");
            Assert.That(actualMsg, Is.EqualTo(expectedMsg));
        }
    }
}
