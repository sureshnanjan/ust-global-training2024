using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace ImplementPetStore
{
    /// <summary>
    /// Main class of PetStore
    /// </summary>
    public class GBrowser
    {
        IWebDriver driver;

        /// <summary>
        /// Constructor of class creating instance of Chrome driver
        /// </summary>
        public GBrowser()
        {
            //this.driver = new RemoteWebDriver(new Uri("http://localhost:6565"), new FirefoxOptions());
            this.driver = new ChromeDriver();


        }

        /// <summary>
        /// Method to open website
        /// </summary>
        /// <param name="url">URL of webpage to be opened</param>
        public void OpenWebsite(string url)
        {

            driver.Navigate().GoToUrl(url);
        }

        /// <summary>
        /// Method to CLose browser 
        /// </summary>
        /// <param name="url">URL of webpage to be opened</param>
        public void CloseWebsite(string url)
        {
            driver.Quit();
        }

        /// <summary>
        /// Method to get the title
        /// </summary>
        /// <returns>Title of the webpage</returns>
        public string GetTitle()
        {
            return driver.Title;
        }

    }
}
