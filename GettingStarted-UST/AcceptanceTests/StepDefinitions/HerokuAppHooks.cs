using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace AcceptanceTests.StepDefinitions
{
    [Binding]
    public class HerokuAppHooks
    {
        private ScenarioContext _scenarioContext;

        public HerokuAppHooks(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [BeforeScenario]
        public void SetupHerokuScenario()
        {
            Console.WriteLine("This is BEFORE Running My Scenario");
        }
        
        [AfterScenario]
        public void TearDownHerokuScenario()
        {
            Console.WriteLine("This is AFTER Running My Scenario");
        }
    }



}
