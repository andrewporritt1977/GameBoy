using GameBoy20.Cards;

namespace GameBoy20.NumberGuessGame
{
    // Game Logic
    public class NumberGuess
    {
        private readonly INumberGuessUi _ui;
        private readonly ICardDeck _cardDeck;

        public NumberGuess(INumberGuessUi ui, ICardDeck cardDeck)
        {
            _ui = ui;
            _cardDeck = cardDeck;
        }

        public void PlayGame()
        {
            // Setup new game
            const int playCount = 5;
            var target = _cardDeck.TakeCard();
            for (var i = 0; i < playCount; i++)
            {
                if(target == _ui.ObtainGuess())
                {
                    _ui.ObtainWinConfirmation();
                    return;
                }
                _ui.NotifyIncorrectGuess();
            }
            _ui.NotifyGameLoss(target);
        }
    }
}
