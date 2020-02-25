using GameBoy20.Cards;
using GameBoy20.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBoy20.NumberGuessGame
{
    public class PlayNumberGuess : IGame
    {
        private ICardDeck _cardDeck;
        private NumberGuess _numberGuess;

        public PlayNumberGuess(ICardDeck cardDeck, NumberGuess numberGuess)
        {
            _cardDeck = cardDeck;
            _numberGuess = numberGuess;
        }

        public void LaunchGame()
        {
            _numberGuess.PlayGame(_cardDeck.TakeCard());
        }
    }
}
