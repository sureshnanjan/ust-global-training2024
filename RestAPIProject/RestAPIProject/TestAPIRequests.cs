using NUnit.Framework;

namespace RestAPIProject
{
    [TestFixture]
    public class TestAPIRequests
    {       

        [Test]
        public   void TestAuthRequestPost()
        {
            AuthRequestPost obj = new AuthRequestPost();
          
            Console.WriteLine("Test started");
            obj.postReq();

        }
    }
}
