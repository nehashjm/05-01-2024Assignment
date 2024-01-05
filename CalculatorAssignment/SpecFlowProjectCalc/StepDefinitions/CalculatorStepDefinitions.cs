using CalculatorAssignment;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProjectCalc.StepDefinitions
{
    [Binding]
    public class CalculatorStepDefinitions
    {
        private readonly ScenarioContext scenarioContext;
        private readonly Class1 Calc;
        private int result;

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
            this.Calc = new Class1();
        }

        [Given(@"the first number is (.*)")]
        public void GivenTheFirstNumberIs(int p0)
        {
          Calc.Fnum = p0;
        }

        [Given(@"the second number is (.*)")]
        public void GivenTheSecondNumberIs(int p0)
        {
            Calc.Snum = p0;
        }

        [When(@"the two numbers are Multiplied")]
        public void WhenTheTwoNumbersAreMultiplied()
        {
            result = Calc.Multiply();
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
           result.Should().Be(result);
        }

        [When(@"the two numbers are Substracted")]
        public void WhenTheTwoNumbersAreSubstracted()
        {
           result = Calc.Substract();
        }

        [When(@"the two numbers are Divided")]
        public void WhenTheTwoNumbersAreDivided()
        {
            result = Calc.Division();
        }
    }
}
