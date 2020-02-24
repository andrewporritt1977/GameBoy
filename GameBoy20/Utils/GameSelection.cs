using GameBoy20.BlackJackGame;
using System;
using System.Collections.Generic;
using System.Text;
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
                    //HighLow
                    break;
                case 2:
                    return new NumberPokeGame();
                case 3:
                    return new BlackJack();
            }
            return null;

        }
    }
}
