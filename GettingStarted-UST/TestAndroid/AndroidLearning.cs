using System;
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
namespace TestAndroid
{
    public class AndroidLearning
    {
    
        private AppiumDriver<AppiumWebElement>? _driver;

        public AndroidLearning()
            {
            AndroidDriver<AndroidElement> driver = null;
            var serveruri = new Uri("https://hub-cloud.browserstack.com:443/wd/hub");
            var capabilities = new AppiumOptions();
            capabilities.PlatformName = "Android";
            /// bs://d12e634be1fba516084c27ea8aa98341b1a64bf5 - copied content from BS

            capabilities.AddAdditionalCapability("appium:platformName", "Android");
            capabilities.AddAdditionalCapability("appium:app", "bs://d12e634be1fba516084c27ea8aa98341b1a64bf5");
            capabilities.AddAdditionalCapability("appium:automationName", "UIAutomator2");// = AutomationName.AndroidUIAutomator2;
            capabilities.AddAdditionalCapability("appium:osVersion", "9.0");// = "Android Emulator";
            capabilities.AddAdditionalCapability("appium:deviceName", "Pixel 6 pro v12.0");
            capabilities.AddAdditionalCapability("appium:ensureWebviewsHavePages", "true"); //capabilities.App = app;
            _driver = new AndroidDriver<AppiumWebElement>(
                               new Uri("http://127.0.0.1:4723/"), capabilities);



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



        }
    }

}
}
