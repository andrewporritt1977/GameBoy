using GameBoy20.Cards;

namespace GameBoy20.NumberGuessGame
{
    // Game Logic
    public class NumberGuess
    {
        private readonly INumberGuessMessages _messages;

        public NumberGuess(INumberGuessMessages messages)
        {
            _messages = messages;
        }

        public void PlayGame(string target)
        {
            // Setup new game
            const int playCount = 5;
            for (var i = 0; i < playCount; i++)
            {
                if(target == _messages.ObtainGuess())
                {
                    _messages.ObtainWinConfirmation();
                    return;
                }
                _messages.NotifyIncorrectGuess();
            }
            _messages.NotifyGameLoss(target);
        }
    }
}
