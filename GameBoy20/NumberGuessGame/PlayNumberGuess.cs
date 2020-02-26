using GameBoy20.Cards;
using GameBoy20.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBoy20.NumberGuessGame
{
    public class PlayNumberGuess : IGame
    {
        private readonly NumberGuess _numberGuess;

        public PlayNumberGuess(NumberGuess numberGuess)
        {
            _numberGuess = numberGuess;
        }

        public void LaunchGame()
        {
            _numberGuess.PlayGame();
        }
    }
}
