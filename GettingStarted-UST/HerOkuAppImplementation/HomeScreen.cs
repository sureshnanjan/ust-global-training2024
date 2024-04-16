using HerokuAppOperations;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HerokuAppWebdriverImplementation
{
    public class HomeScreen : IHomeScreen
    {
        private string herokuUrl;
        private IWebDriver browser;
        private By headingLocator;
        private By subHeadingLocator;
        private By exapleLocator;
        private By repositoryLocator;
        private By footerLocator;

        public HomeScreen()
        {
            this.herokuUrl = "https://the-internet.herokuapp.com/";
            this.browser = new ChromeDriver();
            this.headingLocator = By.TagName("h1");
            this.subHeadingLocator = By.TagName("h2");
            this.exapleLocator = By.XPath("//*[@id=\"content\"]/ul/li[2]/a");
            // #content > h1
            // JSPath document.querySelector("#content > h1")
            // XPath //*[@id="content"]/h1
            // /html/body/div[2]/div/h1
            // By.TagName("h1")
            // RelativeB
            //  /html/body/div[2]/div/h1
            // RelativeBy mylocaTrategy = RelativeBy.WithLocator(headingLocator);
            this.browser.Url = this.herokuUrl;
        }



        public string getTitle()
        {
            return browser.Title;
        }

        public string getSubTitle()
        {
            throw new NotImplementedException();
        }

        public void goToExample(string exampleName)
        {
            throw new NotImplementedException();
        }

        public string[] getAvailableExamples()
        {
            throw new NotImplementedException();
        }

       

    }
}
