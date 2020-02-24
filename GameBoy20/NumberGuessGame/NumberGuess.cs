using System;
using System.Collections.Generic;
using System.Text;
using GameBoy20.Utils;

namespace GameBoy20.NumberGuessGame
{
    // Game Logic
    class NumberGuess : IGame
    {
        public void LaunchGame()
        {
            // Setup new game
            Setup setup = new Setup
            {
                Round = 1
            };
            setup.Target = setup.NumberGuess();
            setup.PlayRound();
        }
    }
}
