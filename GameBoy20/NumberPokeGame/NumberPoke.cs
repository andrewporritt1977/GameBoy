using GameBoy20.Cards;
using GameBoy20.Utils;

namespace GameBoy20.NumberPokeGame
{
    public class NumberPoke : IGame
    {
        private readonly INumberPokeUi _ui;
        private readonly ICardDeck _cardDeck;

        public NumberPoke(INumberPokeUi ui, ICardDeck cardDeck)
        {
            _ui = ui;
            _cardDeck = cardDeck;
        }

        public void LaunchGame()
        {
            //grabs 3 cards
            var cards = _cardDeck.TakeHand(3);
            
            //asks which to hold
            

            //refreshes non held cards

            NumberPokeLogic numberPokeGame = new NumberPokeLogic(new CardDeck());
            numberPokeGame.DrawCards();
            
            _ui.InformYourCards(numberPokeGame.CardOne, numberPokeGame.CardTwo, numberPokeGame.CardThree);
            var heldCards = _ui.ObtainCardsToHold();
            numberPokeGame.HoldCards(heldCards);
            numberPokeGame.DrawCards();
            _ui.InformYourCards(numberPokeGame.CardOne, numberPokeGame.CardTwo, numberPokeGame.CardThree);
            _ui.InformWinStatus(numberPokeGame.WinStatus());
        }
    }
}