using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace MyAndroidAutomation
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            AndroidDriver<AndroidElement> _driver = null;

            var serverUri = new Uri("https://hub-cloud.browserstack.com:443/wd/hub");
            var options = new AppiumOptions();
            options.AddAdditionalCapability("platformName", "Android");
            options.AddAdditionalCapability("appium:automationname", "uiautomator2");
            options.AddAdditionalCapability("appium:app", "bs://5ae61a4c2cb64739d1bd5c8d9c17ed07a6529c30");
            options.AddAdditionalCapability("appium:deviceName", "Pixel 6 Pro v12.0");
            options.AddAdditionalCapability("appium:osversion", "9.0");
            options.AddAdditionalCapability("appium:device", "Google Pixel 3");
            options.AddAdditionalCapability("appium:ensureWebviewsHavePages", true);
            options.AddAdditionalCapability("browserstack.user", "manisha_E98woD");
            options.AddAdditionalCapability("browserstack.key", "EzgAiZsxW8zNtsrqFzff");
            options.AddAdditionalCapability("appium:nativeWebScreenshot", true);
            options.AddAdditionalCapability("bstack:options", new Dictionary<string, dynamic> { { "source", "appiumdesktop" } });
            options.AddAdditionalCapability("appium:newCommandTimeout", 3600);
            options.AddAdditionalCapability("appium:connectHardwareKeyboard", true);

            _driver = new AndroidDriver<AndroidElement>(serverUri, options);

            String ActualTitle = _driver.FindElement(MobileBy.AndroidUIAutomator("new UiSelector().text(\"API Demos\")")).Text;
            Console.WriteLine(ActualTitle);


        }
    }
}
