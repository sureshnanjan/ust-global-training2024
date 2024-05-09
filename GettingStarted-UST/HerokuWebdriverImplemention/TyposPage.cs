using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;

namespace HerokuWebdriverImplemention
{
    public class TyposPage : HerokuApp, ITypos
    {
        string ITypos.getTitle()
        {
            throw new NotImplementedException();
        }

        string ITypos.pageContent()
        {
            throw new NotImplementedException();
        }
    }
}
