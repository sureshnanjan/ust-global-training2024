using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    public interface IHerokuAppOperations
    {
        void goToHome();

        void closeBrowser();

        string getRepoDetails();

        string getFooterDetails();
        bool getStatus(string locator);
    }
}
