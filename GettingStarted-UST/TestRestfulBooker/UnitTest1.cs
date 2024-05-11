using RestfulBookerAPI;
namespace TestRestfulBooker
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void DemoWorksOK()
        {
           RestfulBooker.DoTestDemo();
        }
    }
}