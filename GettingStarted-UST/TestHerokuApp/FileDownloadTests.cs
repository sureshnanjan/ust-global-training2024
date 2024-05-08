using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;
using HerokuWebdriverImplemention;
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
        /// Launch home page & redirect to File Download page
        /// </summary>
        [SetUp]
        public void start()
        {
            IHomePage page = new HomePage();
            page.goToExample("FileDownloadPage");
        }

        /// <summary>
        /// To verify the URL of page is correct
        /// </summary>
        [Test]
        public void UrlOfPageIsCorrect()
        {
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
            int expected = 17;
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
            string[] expected = { "sample-zip-file.zip", "snickers2.jpg", "headphones.png", "puppy_and_kitten.jpg", "upload-me.txt", "gridserver.log", "foto.png", "foto2.png", "7d2c5299e08a3426d5a9d62cfd8d285a1c7cb0d7 Build report.pdf", "olli-the-polite-cat.jpg", "Jpeg_with_exif.jpeg", "selenium-snapshot.png", "LambdaTest.txt", "random_data.txt", "Kotobati-_D8B9D982D8AFD983D8A7D984D986D981D8B3D98AD8A9D8B3D8ACD986D983D8A7D984D8A3D8A8D8AFD98A_.pdf", "some-file.txt", "E card.pdf" };         
            List<string> actual = fileDownload.getAvailableFiles();
            bool res = false;
            for (int i = 0; i < 17; i++)
            {
                res = actual.Contains(expected[i]);
                if (res == false)
                {
                    return;
                }
            }
            if (res == false)
            {
                Assert.Fail();
            }
            else
            {
                Assert.Pass();
            }
        }

        /// <summary>
        /// To verify whether file download is successful by clicking on name of file
        /// </summary>
        [TestCase("sample-zip-file.zip")]
        [TestCase("snickers2.jpg")]
        [TestCase("headphones.png")]
        [TestCase("puppy_and_kitten.jpg")]
        [TestCase("upload-me.txt")]
        [TestCase("gridserver.log")]
        [TestCase("foto.png")]
        [TestCase("foto2.png")]
        [TestCase("7d2c5299e08a3426d5a9d62cfd8d285a1c7cb0d7 Build report.pdf")]
        [TestCase("olli-the-polite-cat.jpg")]
        [TestCase("Jpeg_with_exif.jpeg")]
        [TestCase("selenium-snapshot.png")]
        [TestCase("LambdaTest.txt")]
        [TestCase("random_data.txt")]
        [TestCase("Kotobati-_D8B9D982D8AFD983D8A7D984D986D981D8B3D98AD8A9D8B3D8ACD986D983D8A7D984D8A3D8A8D8AFD98A_.pdf")]
        [TestCase("some-file.txt")]
        [TestCase("E card.pdf")]
        public void DownloadByNameIsSuccess(string filename)
        {
            IFileDownload fileDownload = null;
            fileDownload.downloadFile(filename);
            string res = fileDownload.isFileExists(filename);
            Assert.Equals(res, filename);
        }

        /// <summary>
        /// To verify whether file download is successful by clicking based on the position of file
        /// </summary>
        [TestCase(0)]

        public void DownloadByPosistionIsSuccess(int pos)
        {
            IFileDownload fileDownload = null;
            string[] fileNames = { "sample-zip-file.zip", "snickers2.jpg", "headphones.png", "puppy_and_kitten.jpg", "upload-me.txt", "gridserver.log", "foto.png", "foto2.png", "7d2c5299e08a3426d5a9d62cfd8d285a1c7cb0d7 Build report.pdf", "olli-the-polite-cat.jpg", "Jpeg_with_exif.jpeg", "selenium-snapshot.png", "LambdaTest.txt", "random_data.txt", "Kotobati-_D8B9D982D8AFD983D8A7D984D986D981D8B3D98AD8A9D8B3D8ACD986D983D8A7D984D8A3D8A8D8AFD98A_.pdf", "some-file.txt", "E card.pdf" };
            for (int i = 0; i < 17; i++)
            {
                fileDownload.downloadFilebyPosition(pos);
                string res = fileDownload.isFileExists(fileNames[i]);
                Assert.Equals(res, fileNames[i]);
            }
        }

    }
}
