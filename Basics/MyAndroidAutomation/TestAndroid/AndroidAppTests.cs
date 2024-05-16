using MyAndroidAutomation;
namespace TestAndroid
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void verifyAppLaunch()
        {
            AndroidAppDemo androidAppDemo = new AndroidAppDemo();
            androidAppDemo.getBatteryStatus();
            string ExpectedTitle = "API Demos";
            string ActualTitle = androidAppDemo.getAppTitle();
            Assert.AreEqual(ExpectedTitle, ActualTitle);
            Console.WriteLine("Title displayed as API Demos");
            androidAppDemo.launchSections();
        }
    }
}