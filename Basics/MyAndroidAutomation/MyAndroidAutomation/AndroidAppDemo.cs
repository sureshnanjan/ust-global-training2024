using System;
using System.Drawing;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Appium.Service.Options;
namespace MyAndroidAutomation
{
    public class AndroidAppDemo
    {
        private AppiumDriver<AppiumWebElement>? _driver;
        public AndroidAppDemo()
        {
            var options = new AppiumOptions();
            options.PlatformName = "Android";
            //AndroidDriver<AndroidElement> _driver = null;
            //var serverUri = new Uri("https://hub-cloud.browserstack.com:443/wd/hub");
            options.AddAdditionalCapability("appium:automationName", "UIAutomator2");
            options.AddAdditionalCapability("platformName", "Android");
            options.AddAdditionalCapability("appium:app", "bs://16df86b5c5ff00ff06bc1106245506f2176aa5af");
            options.AddAdditionalCapability("appium:deviceName", "Pixel 6 Pro v12.0");
            options.AddAdditionalCapability("appium:osVersion", "9.0");
            options.AddAdditionalCapability("appium:device", "Google Pixel 3");
            options.AddAdditionalCapability("appium:ensureWebviewsHavePages", true);
            options.AddAdditionalCapability("browserstack.user", "poojasalian_g7V9Sj");
            options.AddAdditionalCapability("browserstack.key", "n2ry4CxuVszXbdVz35UK");
            options.AddAdditionalCapability("appium:nativeWebScreenshot", true);
            options.AddAdditionalCapability("bstack:options", new Dictionary<string, dynamic> { { "source", "appiumdesktop" } });
            options.AddAdditionalCapability("appium:newCommandTimeout", 3600);
            options.AddAdditionalCapability("appium:connectHardwareKeyboard", true);


            _driver = new AndroidDriver<AppiumWebElement>(
                               new Uri("http://127.0.0.1:4723/"), options);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(300);
            // _driver = new AndroidDriver<AndroidElement>(serverUri, options);
            // string ActualTitle = _driver.FindElement(MobileBy.AndroidUIAutomator("new UiSelector().text(\"API Demos\")")).Text;
            // Console.WriteLine(ActualTitle);
        }

        public string getAppTitle()
        {
            var ActualTitle = _driver.FindElement(MobileBy.AndroidUIAutomator("new UiSelector().text(\"API Demos\")"));
            return ActualTitle.Text;
        }
        public void getBatteryStatus()
        {
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

        public void launchSections()
        {
            var element = _driver.FindElement(MobileBy.AccessibilityId("App"));
            element.Click();
            var context = _driver.Context;
            Console.WriteLine(context);
        }
    }
}

