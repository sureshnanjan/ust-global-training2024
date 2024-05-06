using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RestAPIProject;

namespace RestAPIProject
{
    [TestFixture]
    public class TestPostReq
    {       

        [Test]
        public void CallReq()
        {
            AuthRequest obj = new AuthRequest();
            obj.postReq();

        }
    }
}
