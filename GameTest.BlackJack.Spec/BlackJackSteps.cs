using GameBoy20.BlackJackGame.Messages;
using GameBoy20.Cards;
using GBBlackJack = GameBoy20.BlackJackGame;

using Moq;
using TechTalk.SpecFlow;
using System;

namespace GameTest.BlackJack.Spec
{
    [Binding]
    public class BlackJackSteps
    {
        private readonly Mock<IBlackJackMessages> _mockMessages;
        private readonly Mock<ICardDeck> _mockCardDeck;
        private readonly GBBlackJack.BlackJack _blackJack;

        public BlackJackSteps()
        {
            _mockMessages = new Mock<IBlackJackMessages>();
            _mockCardDeck = new Mock<ICardDeck>();
            _blackJack = new GBBlackJack.BlackJack(_mockMessages.Object, _mockCardDeck.Object);

        }

        [Given(@"the top cards are ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void GivenTheTopCardsAre(string p0, string p1, string p2, string p3, string p4, string p5, string p6, string p7, string p8, string p9)
        {
            _mockCardDeck.SetupSequence(u => u.TakeCard())
                .Returns(p0)
                .Returns(p1)
                .Returns(p2)
                .Returns(p3)
                .Returns(p4)
                .Returns(p5)
                .Returns(p6)
                .Returns(p7)
                .Returns(p8)
                .Returns(p9)
                .Returns(p0)
                .Throws(new InvalidOperationException());
        }

        [When(@"the player does not take a card")]
        public void WhenThePlayerDoesNotTakeACard()
        {
            _mockMessages.Setup(u => u.ObtainTakeHandConfirmation()).Returns("n");
        }

        [When(@"when the player takes a card")]
        public void WhenWhenThePlayerTakesACard()
        {
            _mockMessages.Setup(u => u.ObtainTakeHandConfirmation()).Returns("y");
        }

        [Then(@"the result is Dealer Loss")]
        public void ThenTheResultIsDealerLoss()
        {
            _mockMessages.Verify(u => u.InformDealerLoss(It.IsAny<int>(), It.IsAny<int>()), Times.Once);
        }

        [Then(@"the result is Dealer Win")]
        public void ThenTheResultIsDealerWin()
        {
            _mockMessages.Verify(u => u.InformDealerWin(It.IsAny<int>(), It.IsAny<int>()), Times.Once);
        }

        [Then(@"the result is Dealer BlackJack")]
        public void ThenTheResultIsDealerBlackJack()
        {
            _mockMessages.Verify(u => u.InformDealerBlackJack(It.IsAny<string>()), Times.Once);
        }

        [Then(@"the result is Dealer Bust")]
        public void ThenTheResultIsDealerBust()
        {
            _mockMessages.Verify(u => u.InformDealerBust(It.IsAny<string>()), Times.Once);
        }

        [When(@"the game is launched\.")]
        public void WhenTheGameIsLaunched_()
        {
            _blackJack.LaunchGame();
        }

        [Then(@"the result is Player Bust")]
        public void ThenTheResultIsPlayerBust()
        {
            _mockMessages.Verify(u => u.InformPlayerBust(It.IsAny<int>(), It.IsAny<string>()), Times.Once);
        }

        [Then(@"the result is Player BlackJack")]
        public void ThenTheResultIsPlayerBlackJack()
        {
            _mockMessages.Verify(u => u.InformPlayerBlackJack(), Times.Once);
        }

        [When(@"when the player takes a card and then does not take a card\.")]
        public void WhenWhenThePlayerTakesACardAndThenDoesNotTakeACard_()
        {
            _mockMessages.SetupSequence(u => u.ObtainTakeHandConfirmation())
                .Returns("y")
                .Returns("n");
        }

    }
}
