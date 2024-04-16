using HerokuAppOperations;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuWebdriverImplemention
{
    public class HerokuApp : IHerokuAppOperations
    {
        private ITakesScreenshot browser;

        public void closeBrowser()
        {
            throw new NotImplementedException();
        }

        public string getFooterDetails()
        {
            throw new NotImplementedException();
        }

        public string getRepoDetails()
        {
            throw new NotImplementedException();
        }

        public bool getStatus(string locator)
        {
            // Take screen shopt as part of this operation
            //throw new NotImplementedException();
            ITakesScreenshot mycamera = (ITakesScreenshot) this.browser;
            mycamera.GetScreenshot();
            return true;
        }

        public void goToHome()
        {
            throw new NotImplementedException();
        }
    }
}
