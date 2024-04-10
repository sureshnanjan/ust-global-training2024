
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;

namespace ImplementPetStore
{
    public class SudhaBrowser
    {
        IWebDriver driver;

        public SudhaBrowser()
        {
            //this.driver = new RemoteWebDriver(new Uri("http://localhost:6565"), new FirefoxOptions());
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
