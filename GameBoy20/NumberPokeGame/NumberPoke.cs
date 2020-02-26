using GameBoy20.Cards;
using GameBoy20.Utils;

namespace GameBoy20.NumberPokeGame
{
    public class NumberPoke : IGame
    {
        private readonly INumberPokeUi _ui;

        public NumberPoke(INumberPokeUi ui)
        {
            _ui = ui;
        }

        public void LaunchGame()
        {
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