﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarted_UST
{
    internal interface IHttp
    {
        void send(string data);
        string receive();
    }
}
