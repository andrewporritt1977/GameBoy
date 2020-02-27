using GameBoy20.BlackJackGame;
using GameBoy20.Cards;
using GameBoy20.NumberGuessGame;
using GameBoy20.NumberPokeGame;

namespace GameBoy20.Utils
{
    class GameSelection
    {
        public IGame SelectGame(int gameNumber)
        {
            switch (gameNumber)
            {
                case 1:
                    return new PlayNumberGuess(new NumberGuess(new NumberGuessUi(), new CardDeck()));
                case 2:
                    return new NumberPoke(new NumberPokeUi(), new CardDeck());
                case 3:
                    return new BlackJack();
                default:
                    break;
            }
            return null;
        }
    }
}
