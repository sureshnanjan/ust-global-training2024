using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    public interface IBasicAuthOperations
    {
        string getHeading();

        void Authenticate(string uname, string pwd);

        string getStatusMessage();
    }
}
