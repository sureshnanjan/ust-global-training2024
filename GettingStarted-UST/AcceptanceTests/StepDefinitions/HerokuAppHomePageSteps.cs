using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using HerokuAppOperations;
using HerokuWebdriverImplemention;
using SpecFlow.Internal.Json;


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
            foreach (var item in ctx.Keys)
            {
                Console.WriteLine(item);
            }

        }

        [Given(@"context")]
        public void GivenContext()
        {
            _app = new HerokuWebdriverImplemention.HomePage();
            _app.goToHome();
        }

        [When(@"action")]
        public void WhenAction()
        {
            availableExamples = _app.getAvailableExamples();
            this._scenarioContext.Add("actualresult", availableExamples.Length);
        }

        [Then(@"outcome")]
        public void ThenOutcome()
        {
            Console.WriteLine($"There are {availableExamples.Length} Examples on the Home Page");
            
        }

        [Given(@"I have ""(.*)"" Examples")]
        public void GivenIHaveExamples(string p0)
        {
            Console.WriteLine($"The values for argument os {p0}");
        }

        [Given(@"I have the following table of data")]
        public void GivenIHaveTheFollowingTableOfData(Table table)
        {
            Console.WriteLine(table.Header.ToJson());
        }

        [Given(@"I have a long multiline string")]
        public void GivenIHaveALongMultilineString(string multilineText)
        {
            Console.WriteLine(multilineText);
        }
    }
}
