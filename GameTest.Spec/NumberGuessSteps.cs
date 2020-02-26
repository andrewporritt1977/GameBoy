using GameBoy20.Cards;
using GameBoy20.NumberGuessGame;
using Moq;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace GameTest.Spec
{
    [Binding]
    public class NumberGuessSteps
    {
        private readonly Mock<INumberGuessUi> _mockUi;
        private Mock<ICardDeck> _mockCardDeck;
        private readonly PlayNumberGuess _numberGuess;
        public NumberGuessSteps()
        {
            _mockUi = new Mock<INumberGuessUi>();
            _numberGuess = new PlayNumberGuess(_mockCardDeck.Object,
                new NumberGuess(_mockUi.Object));
        }

        public void Setup() 
        {
            _mockCardDeck.Setup(u => u.TakeCard()).Returns("4");
        }

        [When(@"I have started the game")]
        public void WhenIHaveStartedTheGame()
        {
            _numberGuess.LaunchGame();
        }

        [Given(@"I guess the incorrect card")]
        public void GivenIGuessTheIncorrectCardTimes()
        {
            _mockUi.Setup(u => u.ObtainGuess()).Returns("5");
        }

        [Given(@"I guess the correct card")]
        public void GivenIGuessTheCorrectCard()
        {
            _mockUi.Setup(u => u.ObtainGuess()).Returns("4");
        }

        [Then(@"the game result will be Lose")]
        public void ThenTheGameResultWillBeLose()
        {
            _mockUi.Verify(u => u.NotifyGameLoss(It.IsAny<string>()), Times.Once);
            _mockUi.Verify(u => u.ObtainWinConfirmation(), Times.Never);
        }

        [Then(@"the game result will be Win")]
        public void ThenTheGameResultWillBeWin()
        {
            //check that the you win the game
        }



    }
}
