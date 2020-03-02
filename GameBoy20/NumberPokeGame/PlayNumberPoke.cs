using System;
using GameBoy20.Cards;
using GameBoy20.Utils.Interfaces;

namespace GameBoy20.NumberPokeGame
{
    public class PlayNumberPoke : IGame
    {
        private readonly NumberPoke _numberPoke;
        private readonly ICardDeck _cardDeck;

        public PlayNumberPoke(NumberPoke numberPoke, ICardDeck cardDeck)
        {
            _numberPoke = numberPoke;
            _cardDeck = cardDeck;
        }

        public void LaunchGame()
        {
            _numberPoke.PlayGame(new Hand(_cardDeck.TakeHand(3)));
        }
    }
}