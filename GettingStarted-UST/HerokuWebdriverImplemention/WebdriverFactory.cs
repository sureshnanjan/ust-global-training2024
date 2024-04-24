using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using Utilities;

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
