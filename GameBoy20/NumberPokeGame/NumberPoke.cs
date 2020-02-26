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
            var heldCards = _ui.ObtainCardsToHold();

            //refreshes non held cards
            //needs to be able to tell which cards are not held
            //then needs to be able to refresh all not held cards

            //tell whether the user has lost, won, or super-won
                //done by checking the new refreshed cards (including the held cards)

            //list of ints of which cards are held
            //e.g. the cards held 2 and 3, heldList == 2,3 is true
            List<int> heldList = heldCards.Split(',').Select(int.Parse).ToList();



            // NumberPokeLogic numberPokeGame = new NumberPokeLogic(new CardDeck());
            // numberPokeGame.DrawCards();
            //
            // _ui.InformYourCards(numberPokeGame.CardOne, numberPokeGame.CardTwo, numberPokeGame.CardThree);
            // var heldCards = _ui.ObtainCardsToHold();
            // numberPokeGame.HoldCards(heldCards);
            // numberPokeGame.DrawCards();
            // _ui.InformYourCards(numberPokeGame.CardOne, numberPokeGame.CardTwo, numberPokeGame.CardThree);
            // _ui.InformWinStatus(numberPokeGame.WinStatus());
        }
    }
}