using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;
using NUnit.Framework.Constraints;

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
            IFileDownload fileDownload = null;
            string expectedUrl = "https://the-internet.herokuapp.com/download";
            string actualUrl = fileDownload.getURL();
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
            List<string> actual = new List<string>();
            foreach (var item in actual)
            {
                Assert.That(actual, Is.EqualTo(expected));
            }
        }

        /// <summary>
        /// To verify whether file download is successful by clicking on name
        /// </summary>
        [Test]
        public void DownloadByNameIsSuccess()
        {
            IFileDownload fileDownload = null;
            string expectedMsg = "Success";
            string fileStatus = fileDownload.downloadFile("");
            string actualMsg = fileDownload.getDownloadstatus(fileStatus);
            Assert.That(actualMsg, Is.EqualTo(expectedMsg));

        }
    }
}
