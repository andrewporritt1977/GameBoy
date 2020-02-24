using GameBoy20.BlackJackGame;
using GameBoy20.NumberGuessGame;
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

                    return new NumberGuess();
                case 2:
                    break;
                case 3:
                    return new BlackJack();
                default:
                    break;
            }
            return null;

        }
    }
}
