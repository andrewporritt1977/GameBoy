using GameBoy20.Cards;
using GameBoy20.Utils.Interfaces;

namespace GameBoy20.NumberGuessGame
{
    public class PlayNumberGuess : IGame
    {
        private readonly NumberGuess _numberGuess;
        private readonly ICardDeck _cardDeck;

        public PlayNumberGuess(NumberGuess numberGuess, ICardDeck cardDeck)
        {
            _numberGuess = numberGuess;
            _cardDeck = cardDeck;
        }

        public void LaunchGame()
        {
            _numberGuess.PlayGame(_cardDeck.TakeCard());
        }
    }
}
