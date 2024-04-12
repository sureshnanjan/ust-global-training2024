using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PetStoreImplementation
{
    /// <summary>
    /// Main class of PetStore
    /// </summary>
    public class HomePage
    {

        IWebDriver driver;

        /// <summary>
        /// Constructor of class creating instance of Chrome driver
        /// </summary>
        public HomePage()
        {
            this.driver = new ChromeDriver();
        }

        /// <summary>
        /// Method to launch website
        /// </summary>
        /// <param name="url">URL of webpage to be opened</param>
        public void OpenWebsite(string url) 
        {
            driver.Navigate().GoToUrl(url);
        }

        /// <summary>
        /// Method to close website
        /// </summary>
        /// <param name="url">URL of webpage to be closed</param>
        public void CloseWebsite(string url) 
        {
            driver.Quit();
        }

        /// <summary>
        /// Method to get the title of website
        /// </summary>
        /// <returns>Website title</returns>
        public string GetTitle()
        {
            return driver.Title;
        }
    }
}
