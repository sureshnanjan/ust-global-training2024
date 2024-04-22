using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace HerokuWebdriverImplemention
{
    public class WebdriverFactory
    {
        public static IWebDriver getBrowser() {
            string browsername = Utilities.BrowserUtil.getBrowser();
            switch (browsername)
            {
                case "chrome":
                    return new ChromeDriver();
                case "firefox":
                    return new FirefoxDriver();
                default: return new ChromeDriver();

            }



        }
    }
}
