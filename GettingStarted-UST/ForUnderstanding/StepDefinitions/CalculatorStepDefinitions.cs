namespace ForUnderstanding.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        private readonly ScenarioContext _scenarioContext;
        public CalculatorStepDefinitions(ScenarioContext ctx)
        {

            this._scenarioContext = ctx;
        }

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 

            this._scenarioContext.Add("first", number);
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic

            this._scenarioContext.Add("second", number);
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            //TODO: implement act (action) logic
            Calculator aut = new Calculator(Int32.Parse(_scenarioContext["first"].ToString()), Int32.Parse(_scenarioContext["second"].ToString()));
            this._scenarioContext["actual"] = aut.getResult();
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            this._scenarioContext["result"].Should().Be(result);
            10.Should().Be(result);
            "suresh".Should().BeUpperCased();
        }
    }

    class Calculator{
        int result = default;
        public Calculator(int number1, int number2) {
            this.result = number1 + number2;
        }

        public int getResult() {
            return result;
        }
    }
}
