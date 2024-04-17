using HerokuAppOperations;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V121.Debugger;
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

        public void CloseBrowser()
        {
            throw new NotImplementedException();
        }

        public void closeBrowser()
        {
            throw new NotImplementedException();
        }

        public string GetFooterDetails()
        {
            throw new NotImplementedException();
        }

        public string getFooterDetails()
        {
            throw new NotImplementedException();
        }

        public string GetRepoDetails()
        {
            throw new NotImplementedException();
        }

        public string getRepoDetails()
        {
            throw new NotImplementedException();
        }

        public bool GetStatus(string locator)
        {
            throw new NotImplementedException();
        }

        public bool GetStatus()
        {
            // Take screen shopt as part of this operation
            //throw new NotImplementedException();
            ITakesScreenshot mycamera = (ITakesScreenshot) this.browser;
            mycamera.GetScreenshot();
            return true;
            
        }

        public string getStatus(string locator)
        {
            throw new NotImplementedException();
        }

        public void GoToHome()
        {
            throw new NotImplementedException();
        }

        public void goToHome()
        {
            throw new NotImplementedException();
        }

        string IHerokuAppOperations.GetStatus(string locator)
        {
            throw new NotImplementedException();
        }
    }
}
