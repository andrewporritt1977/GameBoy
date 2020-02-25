using GameBoy20.BlackJackGame;
using GameBoy20.NumberGuessGame;
using GameBoy20.NumberPokeGame;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBoy20.Utils
{
    class GameSelection
    {
        public IGame SelectGame(int gameNumber)
        {
            switch (gameNumber)
            {
                case 1:
                    return new NumberGuess(new NumberGuessUi());
                case 2:
                    return new NumberPoke();
                case 3:
                    return new BlackJack();
                default:
                    break;
            }
            return null;

        }
    }
}
