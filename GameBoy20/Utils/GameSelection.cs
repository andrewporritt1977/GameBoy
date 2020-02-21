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
                    //HighLow
                    break;
                case 2:
                    return new NumberGuess();
                case 3:
                    return new BlackJack();
                default:
                    break;
            }
            return null;

        }
    }
}
