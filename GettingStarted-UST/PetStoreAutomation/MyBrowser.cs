using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;


namespace PetStoreAutomation
{
    public class MyBrowser
    {
        IWebDriver driver;
        public MyBrowser()
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