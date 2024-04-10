using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Petstore_Automation
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
