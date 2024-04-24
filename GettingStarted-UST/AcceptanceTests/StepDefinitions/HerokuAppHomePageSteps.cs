using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using HerokuAppOperations;
using HerokuWebdriverImplemention;


namespace AcceptanceTests.StepDefinitions
{
    [Binding]
    public class HerokuAppHomePageSteps
    {
        private readonly ScenarioContext _scenarioContext;
        IHomePage _app;
        string[] availableExamples;

        public HerokuAppHomePageSteps(ScenarioContext ctx)
        {
            this._scenarioContext = ctx;
        }
        
        [Given(@"\[context]")]
        public void GivenContext()
        {
            _app = new HerokuWebdriverImplemention.HomePage();
            _app.goToHome();
        }

        [When(@"\[action]")]
        public void WhenAction()
        {
            availableExamples = _app.getAvailableExamples();
        }

        [Then(@"\[outcome]")]
        public void ThenOutcome()
        {
            Console.WriteLine($"There are {availableExamples.Length} Examples on the Home Page");
        }
    }
}
