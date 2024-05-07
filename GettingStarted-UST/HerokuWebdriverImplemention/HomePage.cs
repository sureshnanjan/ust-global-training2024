using HerokuAppOperations;
using OpenQA.Selenium;

namespace HerokuWebdriverImplemention
{
    public class HomePage : HerokuApp, IHomePage
    {
        private By headingLocator;
        private By subHeadingLocator;
        private By exampleLocator;
        private By repositoryLocator;
        private By footerLocator;
        public HomePage() {
            this.headingLocator = By.TagName("h1");
            this.subHeadingLocator = By.TagName("h2");
            this.exampleLocator = By.XPath("//*[@id=\"content\"]/ul/li");
            this.repositoryLocator = By.LinkText("Fork me on github");
        }
        public string[] getAvailableExamples()
        {
            List<string> result = new List<string> { };
            foreach (var item in this.driver.FindElements(exampleLocator))
            {
                result.Add(item.Text);

            }

            return result.ToArray();

        }

        public bool getStatus(string locator)
        {
            // Take screen shopt as part of this operation
            //throw new NotImplementedException();
            ITakesScreenshot mycamera = (ITakesScreenshot) this.driver;
            mycamera.GetScreenshot();
            return true;

        }

        public string getSubTitle()
        {
            throw new NotImplementedException();
        }

        public string getTitle()
        {
            return this.driver.Title;
        }

        bool IHomePage.GetStatus(string locator)
        {
            throw new NotImplementedException();
        }

        IHerokuAppOperations IHomePage.goToExample(string exampleName)
        {
            switch (exampleName)
            {
                
                case "AddRemoveElements":
                    return new AddRemoveElementsPage();
                default: throw new NotImplementedException();

            }
        }
    }
}
