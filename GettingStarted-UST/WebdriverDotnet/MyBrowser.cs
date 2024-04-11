
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;

namespace WebdriverDotnet
{
    public class MyBrowser
    {
        IWebDriver driver;

        public MyBrowser()
        {
            //this.driver = new RemoteWebDriver(new Uri("http://localhost:6565"), new FirefoxOptions());
            this.driver = new ChromeDriver();

                
        }
        public void OpenWebsite(string url) { 
        
            driver.Navigate().GoToUrl(url); 
        }

        public void CloseWebsite(string url) { 
            driver.Quit();
        }

        public string GetTitle() {
            return driver.Title;
        }

    }
}
