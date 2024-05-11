using AndroidImplementation;
namespace TestAndroid
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            AndroidAppDemo androidAppDemo = new AndroidAppDemo();
            androidAppDemo.getBatteryStatus();
        }
    }
}