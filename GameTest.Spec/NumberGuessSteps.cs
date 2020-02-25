//using System;
//using TechTalk.SpecFlow;
//using GameBoy20.NumberGuessGame;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//namespace GameTest.Spec
//{
//    [Binding]
//    public class NumberGuessSteps
//    {
//        public string result;
//        RandomCard numberGuessSetup = new RandomCard();


//        [Given(@"I have a target number (.*)")]
//        public void GivenIHaveATargetNumber(string target)
//        {
//            numberGuessSetup.Target = target;
//        }

//        [Given(@"I guess (.*)")]
//        public void GivenIGuess(string guess)
//        {
//            numberGuessSetup.Guess = guess;
//        }

//        [Then(@"the game result will be (.*)")]
//        public void ThenTheGameResultWillBeLose(string expectedResult)
//        {
//            result = numberGuessSetup.Result();
//            Assert.AreEqual(expectedResult, result);
//        }
//    }   
//}
