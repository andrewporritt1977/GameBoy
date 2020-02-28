using Moq;
using System;
using TechTalk.SpecFlow;
using GameBoy20.Cards;
using GBNumberPokeGame = GameBoy20.NumberPokeGame;
using GameBoy20.Utils;

namespace GameTest.NumberPokeGame.Spec
{
    [Binding]
    public class NumberPokeSteps
    {
        private readonly Mock<GBNumberPokeGame.INumberPokeUi> _mockUi;
        private readonly Mock<ICardDeck> _mockCardDeck;
        private readonly IGame  _numberPoke;

        public NumberPokeSteps()
        {
            _mockUi = new Mock<GBNumberPokeGame.INumberPokeUi>();
            _mockCardDeck = new Mock<ICardDeck>();
            _numberPoke = new GBNumberPokeGame.NumberPoke(_mockUi.Object, _mockCardDeck.Object);
        }

        [Given(@"the top cards are ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void GivenTheTopCardsAre(string p0, string p1, string p2, string p3, string p4, string p5)
        {
            _mockCardDeck.SetupSequence(u => u.TakeCard())
                .Returns(p0)
                .Returns(p1)
                .Returns(p2)
                .Returns(p3)
                .Returns(p4)
                .Returns(p5)
                .Throws(new InvalidOperationException());
        }
        
        [When(@"I launch the game")]
        public void WhenILaunchTheGame()
        {
            _numberPoke.LaunchGame();
        }
        
        [Given(@"I hold cards ""(.*)""")]
        public void WhenIHoldCards(string p0)
        {
            _mockUi.Setup(u => u.ObtainCardsToHold()).Returns(p0);
        }
        
        [Then(@"the result will be ""(.*)""")]
        public void ThenTheResultWillBe(string p0)
        {
            switch(p0)
            {
                case "Lose":
                    _mockUi.Verify(u => u.InformLose(), Times.Once);
                    _mockUi.Verify(u => u.InformWin(), Times.Never);
                    _mockUi.Verify(u => u.InformSuperWin(), Times.Never);
                    break;
                case "Win":
                    _mockUi.Verify(u => u.InformLose(), Times.Never);
                    _mockUi.Verify(u => u.InformWin(), Times.Once);
                    _mockUi.Verify(u => u.InformSuperWin(), Times.Never);
                    break;
                case "Super-Win":
                    _mockUi.Verify(u => u.InformLose(), Times.Never);
                    _mockUi.Verify(u => u.InformWin(), Times.Never);
                    _mockUi.Verify(u => u.InformSuperWin(), Times.Once);
                    break;
            }
        }
    }
}
