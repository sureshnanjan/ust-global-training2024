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

            var options = new AppiumOptions();
            options.PlatformName = "Android";
            //capabilities.
            /*
            capabilities.AddAdditionalCapability("appium:udid", "emulator-5554");
            capabilities.AddAdditionalCapability("appium:automationName", "UIAutomator2");// = AutomationName.AndroidUIAutomator2;
            capabilities.AddAdditionalCapability("appium:platformVersion", "13.0");// = "Android Emulator";
            */
            //capabilities.App = app;
            options.AddAdditionalCapability("appium:automationName", "UIAutomator2");
            options.AddAdditionalCapability("platformName", "Android");
            options.AddAdditionalCapability("appium:udid", "emulator-5556");
            options.AddAdditionalCapability("appium:platformversion", "13.0");
            options.AddAdditionalCapability("appium:deviceName", "Google Pixel 7");
            options.AddAdditionalCapability("appium:adbExecTimeout", "500000000");
            options.AddAdditionalCapability("appium:uiautomator2ServerLaunchTimeout", "500000000");
            options.AddAdditionalCapability("appium:appPackage", "io.appium.android.apis");
            options.AddAdditionalCapability("appium:appActivity", ".ApiDemos");
            options.AddAdditionalCapability("appium:ensureWebviewsHavePages", true);
            options.AddAdditionalCapability("appium:nativeWebScreenshot", true);
            options.AddAdditionalCapability("appium:newCommandTimeout", 3600);
            options.AddAdditionalCapability("appium:connectHardwareKeyboard", true);


            _driver = new AndroidDriver<AppiumWebElement>(
                           new Uri("http://127.0.0.1:4723/"),options);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(300);
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

        public void launchAlerts()
        {
            //_driver.ExecuteScript("mobile: startActivity", new Dictionary<string, dynamic> { { "appPackage", "com.android.chrome" }, { "appActivity", "com.google.android.apps.chrome.Main" }});
            //_driver.ExecuteScript("mobile: startActivity", new Dictionary<string, dynamic> { { "appPackage", "io.appium.android.apis" }, { "appActivity", ".ApiDemos" } });
            /*
            var el1 = _driver.FindElement(MobileBy.AccessibilityId("Accessibility"));
            el1.Click();
            var el2 = _driver.FindElement(MobileBy.AccessibilityId("Custom View"));
            el2.Click();
            var el3 = _driver.FindElement(MobileBy.AndroidUIAutomator("new UiSelector().text(\"Off\").instance(0)"));
            el3.Click();
            _driver.ExecuteScript("mobile: pressKey", new Dictionary<string, dynamic> { { "keycode", 4 }});
            _driver.ExecuteScript("mobile: pressKey", new Dictionary<string, dynamic> { { "keycode", 4 }});
            */
            var el4 = _driver.FindElement(MobileBy.AccessibilityId("App"));
            el4.Click();
            var el5 = _driver.FindElement(MobileBy.AccessibilityId("Alert Dialogs"));
            el5.Click();
            var el6 = _driver.FindElement(MobileBy.AccessibilityId("List dialog"));
            el6.Click();
            var el7 = _driver.FindElement(MobileBy.AndroidUIAutomator("new UiSelector().text(\"Command one\")"));
            el7.Click();
            

            var context = _driver.Context;
            Console.WriteLine( context);
        }

        public string getAppTitle()
        {
            var el8 = _driver.FindElement(MobileBy.AndroidUIAutomator("new UiSelector().text(\"API Demos\")"));
            return el8.Text;
        }
    }
}
