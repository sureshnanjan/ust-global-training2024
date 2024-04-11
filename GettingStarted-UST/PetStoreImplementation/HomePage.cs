using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PetStoreImplementation
{
    public class HomePage
    {

        IWebDriver driver;

        public HomePage()
        {
            this.driver = new ChromeDriver();
        }

        public void OpenWebsite(string url) 
        {
            driver.Navigate().GoToUrl(url);
        }

        public void CloseWebsite(string url) 
        {
            driver.Quit();
        }

        public string GetTitle()
        {
            return driver.Title;
        }
    }
}
