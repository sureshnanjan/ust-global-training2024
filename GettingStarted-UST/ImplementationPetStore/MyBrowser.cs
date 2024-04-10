using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Firefox;
namespace ImplementationPetStore
{
    public class MyBrowser
    {
        IWebDriver driver;

        public MyBrowser()
        {
            this.driver = new ChromeDriver();
        }
        public void Openurl(string url) 
        {
            driver.Navigate().GoToUrl(url);
        }

        public void CloseWebsite(string url)
        {
            driver.Quit();
        }

        public string GetTitle() 
        {
            return String.Empty;
        }
    }
}
