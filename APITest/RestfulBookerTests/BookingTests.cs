using RestFul_Booker;

namespace RestfulBookerTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CreateBooking()
        {
            AppDemo.CreateBooking();
        }

        [Test]
        public void updatebooking()
        {
            //AppDemo appDemo = new AppDemo();
            AppDemo.Update();
        }

    }
}