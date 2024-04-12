using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace GettingStarted_UST
{
    internal class Chrome : IHttp
    {
        public string receive()
        {
            throw new NotImplementedException();
        }

        public void send(string data)
        {
            throw new NotImplementedException();
        }
    }

    class FireFox : IHttp
    {
        public string receive()
        {
            throw new NotImplementedException();
        }

        public void send(string data)
        {
            throw new NotImplementedException();
        }
    }
}