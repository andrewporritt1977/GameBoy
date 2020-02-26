using System;
using GameBoy20.BlackJackGame;
using GameBoy20.Cards;
using GameBoy20.Utils;

namespace GameBoy20.NumberGuessGame
{
    // Game Logic
    public class NumberGuess
    {
        private readonly INumberGuessUi _ui;

        public NumberGuess(INumberGuessUi ui)
        {
            _ui = ui;
        }

        public void PlayGame(string target)
        {
            // Setup new game
            const int playCount = 5;
            for (var i = 0; i < playCount; i++)
            {
                if(target == _ui.ObtainGuess())
                {
                    _ui.ObtainWinConfirmation();
                    return;
                }
            }
            _ui.NotifyGameLoss(target);

        }
    }
}
