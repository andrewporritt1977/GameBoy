using GameBoy20.BlackJackGame;
using GameBoy20.NumberGuessGame;
using GameBoy20.NumberPoke;

namespace GameBoy20.Utils
{
    class GameSelection
    {
        public IGame SelectGame(int gameNumber)
        {
            switch (gameNumber)
            {
                case 1:
                    return new PlayNumberGuess(new CardDeck(), new NumberGuess(new NumberGuessUi()));
                case 2:
                    return new NumberPoke.NumberPoke();
                case 3:
                    return new BlackJack();
                default:
                    break;
            }
            return null;

        }
    }
}
