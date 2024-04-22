using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestHerokuApp
{
    /// <summary>
    /// Tests to be done in File Download page
    /// </summary>
    [TestFixture]
    public class FileDownloadTests
    {

        IWebDriver driver;

        public FileDownloadTests()
        {
            this.driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/");
        }

        /// <summary>
        /// Test case to check the loaded URL
        /// </summary>
        [Test]
        public void URLIsCorrect()
        {
            IFileDownload fileDownload = null;
            string actualUrl = fileDownload.getURL();
            string expectedUrl = "https://the-internet.herokuapp.com/download";
            Assert.That(actualUrl, Is.EqualTo(expectedUrl));
        }

        /// <summary>
        /// Test case to check the Title of File Download Page
        /// </summary>
         /*[Test]
        public void FileDownloadPageTitleIsCorrect()
        {
            IFileDownload fileDownload = null;
            string actualTitle = fileDownload.getTitle();
            string expectedTitle = "File Downloader";
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
        }

        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void ListOfFilesIsCorrect()
        {
            //IFileDownload listDownload = null;
        }*/

    }
}
