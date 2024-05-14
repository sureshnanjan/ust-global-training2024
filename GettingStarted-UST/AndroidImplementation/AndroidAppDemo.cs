using System;
using System.Drawing;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Appium.Service.Options;
namespace AndroidImplementation
{
    public class AndroidAppDemo
    {
        private AppiumDriver<AppiumWebElement>? _driver;

        public AndroidAppDemo()
        {
            /*
            DesiredCapabilities capabilities = new DesiredCapabilities();
            capabilities.SetCapability("appium: udid", "emulator-5554");
            capabilities.SetCapability("appium: automationName", "UIAutomator2");
            capabilities.SetCapability("platformName", "Android");
            capabilities.SetCapability("appium:platformVersion", "13.0")l
            */

            var capabilities = new AppiumOptions();
            capabilities.PlatformName = "Android";
        //capabilities.

       /// bs://d12e634be1fba516084c27ea8aa98341b1a64bf5 - copied content from BS

            capabilities.AddAdditionalCapability("appium:udid", "emulator-5554");
            capabilities.AddAdditionalCapability("appium:app", "bs://d12e634be1fba516084c27ea8aa98341b1a64bf5");
            capabilities.AddAdditionalCapability("appium:automationName", "UIAutomator2");// = AutomationName.AndroidUIAutomator2;
            capabilities.AddAdditionalCapability("appium:platformVersion", "13.0");// = "Android Emulator";
            //capabilities.App = app;
            _driver = new AndroidDriver<AppiumWebElement>(
                           new Uri("http://127.0.0.1:4723/"),capabilities);



        }


        public void getBatteryStatus() {
            /*
            _driver.ExecuteScript("mobile: pressKey", new Dictionary<string, dynamic> { { "keycode", 3 }, { "metastate", "undefined" }, { "flags", "undefined" } });
            _driver.ExecuteScript("mobile: startActivity", new Dictionary<string, dynamic> { { "appPackage", "com.android.settings" }, { "appActivity", ".Settings" }, { "appWaitPackage", "undefined" }, { "intentAction", "undefined" }, { "intentCategory", "undefined" }, { "intentFlags", "undefined" }, { "optionalIntentArguments", "undefined" }, { "dontStopAppOnReset", "undefined" } });
            _driver.ExecuteScript("mobile: pressKey", new Dictionary<string, dynamic> { { "keycode", 187 }, { "metastate", "undefined" }, { "flags", "undefined" } });
            _driver.ExecuteScript("mobile: pressKey", new Dictionary<string, dynamic> { { "keycode", 187 }, { "metastate", "undefined" }, { "flags", "undefined" } });
            */
            var packageName = _driver.ExecuteScript("mobile: getCurrentPackage");
            var sessionDetails = _driver.SessionDetails;
            Console.WriteLine(packageName);
            //Console.WriteLine(sessionDetails);
            foreach (var item in sessionDetails)
            {
                Console.WriteLine(item);
            }
        }



    }
}
