using System;
using ExampleForSpecflow;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Example.SpecFlow.Test
{
    [Binding]
    public class CalculatorSteps
    {
        private int result { get; set; }
        private Calculator calcultor = new Calculator();
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            calcultor.FirstNumber = p0;
            //ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheCalculator(int p0)
        {
            calcultor.SecondNumber = p0;
            //ScenarioContext.Current.Pending();
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            result = calcultor.Add();
            //ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int expectedResult)
        {
            Assert.AreEqual(expectedResult,result);
            //ScenarioContext.Current.Pending();
        }
    }
}
