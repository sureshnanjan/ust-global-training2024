using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;
using OpenQA.Selenium;

namespace HerokuWebdriverImplemention
{
    public class DynamicContentPage : HerokuApp, IDynamicContent
    {
        public DynamicContentPage(IWebDriver driver)
        {
            this.
        }

        public void clickHereButton()
        {
            throw new NotImplementedException();
        }

        public string getPageContent()
        {
            throw new NotImplementedException();
        }

        public void getPageTitle()
        {
            throw new NotImplementedException();
        }
    }
}
