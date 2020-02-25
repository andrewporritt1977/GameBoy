using System;
using GameBoy20.Utils;

namespace GameBoy20.NumberGuessGame
{
    // Game Logic
    public class NumberGuess : IGame
    {
        private INumberGuessUi _ui;

        public NumberGuess(INumberGuessUi ui)
        {
            _ui = ui;
        }

        public void LaunchGame()
        {
            // Setup new game
            RandomCard randomCard = new RandomCard();

            const int playCount = 5;
            for (int i = 0; i < playCount; i++)
            {
                if(randomCard.PlayRound(_ui.ObtainGuess()))
                {
                    Console.WriteLine(NumberGuessConstants.Win);
                    Console.ReadLine();
                    return;
                }
            }
            _ui.LoseMessage(randomCard.Target);

        }
    }
}
