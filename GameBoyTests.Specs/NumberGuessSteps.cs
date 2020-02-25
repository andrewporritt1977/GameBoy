using System;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameBoy20.NumberGuessGame;


namespace GameBoy20.tests
{
    [Binding]
    public class NumberGuessSteps
    {
        private string result;
        private NumberGuessSetup setup = new NumberGuessSetup();
        
        [Given(@"I have a target number (.*)")]
        public void GivenIHaveATargetNumber(int target)
        {
            setup.Target = target;
        }

        [Given(@"I guess (.*)")]
        public void GivenIGuess(int guess)
        {
            setup.Guess = guess;
        }
        
        [Then(@"the game result will be (.*)")]
        public void ThenTheGameResultWillBe(string expectedGameResult)
        {
            result = setup.Result();
            Assert.AreEqual(expectedGameResult, result);
        }

    }
}
