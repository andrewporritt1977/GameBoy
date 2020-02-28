using System;
using GameBoy20.NumberGuessGame;
using GameBoy20.Cards;
using Moq;
using TechTalk.SpecFlow;
using GBNumberGuessGame = GameBoy20.NumberGuessGame;

namespace GameTest.NumberGuess.Spec
{
    [Binding]
    public class NumberGuessSteps
    {
        private readonly Mock<INumberGuessMessages> _mockUi;
        private readonly Mock<ICardDeck> _mockCardDeck;
        private readonly PlayNumberGuess _numberGuess;

        public NumberGuessSteps()
        {
            _mockUi = new Mock<INumberGuessMessages>();
            _mockCardDeck = new Mock<ICardDeck>();
            _numberGuess = new PlayNumberGuess(new GBNumberGuessGame.NumberGuess(_mockUi.Object), _mockCardDeck.Object);
        }

        [Given(@"I have a target card ""(.*)""")]
        public void GivenIHaveATargetCard(string p0)
        {
            _mockCardDeck.Setup(u => u.TakeCard()).Returns(p0);
        }
        
        [Given(@"I guess ""(.*)""")]
        public void GivenIGuess(string p0)
        {
            _mockUi.Setup(u => u.ObtainGuess()).Returns(p0);
        }
        
        [Given(@"I guess multiple ""(.*)"", then ""(.*)"", then ""(.*)"", then ""(.*)"" then ""(.*)""")]
        public void GivenIGuessThenThenThenThen(string p0, string p1, string p2, string p3, string p4)
        {
            _mockUi.SetupSequence(u => u.ObtainGuess())
                .Returns(p0)
                .Returns(p1)
                .Returns(p2)
                .Returns(p3)
                .Returns(p4)
                .Throws(new InvalidOperationException());
        }

        [When(@"I launch the game")]
        public void WhenILaunchTheGame()
        {
            _numberGuess.LaunchGame();
        }
        
        [Then(@"the result will be Lose")]
        public void ThenTheResultWillBeLose()
        {
            _mockUi.Verify(u => u.NotifyGameLoss(It.IsAny<string>()), Times.Once);
            _mockUi.Verify(u => u.ObtainWinConfirmation(), Times.Never);
        }
        
        [Then(@"the result will be Win")]
        public void ThenTheResultWillBeWin()
        {
            _mockUi.Verify(u => u.ObtainWinConfirmation(), Times.Once);
            _mockUi.Verify(u => u.NotifyGameLoss(It.IsAny<string>()), Times.Never);
        }
    }
}
