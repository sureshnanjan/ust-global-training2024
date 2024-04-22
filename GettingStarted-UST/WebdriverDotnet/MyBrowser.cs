
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WebdriverDotnet
{
    public class MyBrowser
    {
        IWebDriver driver;

        public MyBrowser()
        {
            //this.driver = new RemoteWebDriver(new Uri("http://localhost:6565"), new FirefoxOptions());
            this.driver = new ChromeDriver(); // driver-manager
            //this.driver.

                
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
