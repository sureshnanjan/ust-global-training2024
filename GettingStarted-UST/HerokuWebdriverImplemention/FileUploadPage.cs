using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;
using OpenQA.Selenium;

namespace HerokuWebdriverImplemention
{
    public class FileUploadPage : HerokuApp, IFileUploadPage
    {
        /// <summary>
        /// Properties
        /// </summary>

        private By heading;
        private By chooseFile;
        private By upload;
        private By message;

        /// <summary>
        /// File Upload Page construction web elements
        /// </summary>
        /// <param name="driver"></param>

        public FileUploadPage(IWebDriver driver) : base(driver) {
            this.heading = By.XPath("//*[@id=\"content\"]/div[1]/h3");
            this.chooseFile = By.XPath("//*[@id=\"file-upload\"]");
            this.upload = By.XPath("//*[@id=\"file-submit\"]");
            this.message = By.XPath("//*[@id=\"content\"]/div/h3");
        }

        /// <summary>
        /// Test Method to get Title
        /// </summary>
        /// <returns></returns>
        public string getTitle()
        {
            return driver.FindElement(heading).Text;

        }

        /// <summary>
        /// Test method to validate - Choose File Button
        /// </summary>
        /// <returns></returns>
        public void ChooseFile(string filePath)
        {
            driver.FindElement(chooseFile).Click();
            Thread.Sleep(3000);
        }

        /// <summary>
        /// Test method to validate - Upload Button
        /// </summary>
        /// <returns></returns>
        public void DoUpload()
        {
            driver.FindElement(upload).Click();
            Thread.Sleep(3000);

        }

        /// <summary>
        /// Test method to validate - Upload File Message
        /// </summary>
        /// <returns></returns>
        public string getUploadedFileMessage()
        {
            return driver.FindElement(message).Text;
        }
    }
}
