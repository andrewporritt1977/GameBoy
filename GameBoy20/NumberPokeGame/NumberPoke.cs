using GameBoy20.Cards;
using GameBoy20.Utils;
using System;
using System.Linq;

namespace GameBoy20.NumberPokeGame
{
    public class NumberPoke : IGame
    {
        private readonly INumberPokeUi _ui;
        private readonly ICardDeck _cardDeck;

        public NumberPoke(INumberPokeUi ui, ICardDeck cardDeck)
        {
            _ui = ui;
            _cardDeck = cardDeck;
        }

        public void LaunchGame()
        {
            //grabs 3 cards
            var cards = _cardDeck.TakeHand(3);
            _ui.InformCards(cards);


            //collects which cards the user wants to not redraw
            int[] held = _ui.ObtainCardsToHold().Split(',').Select(int.Parse).ToArray();
            _ui.InformNewLine();

            //redraws non held cards
            for (int i = 0; i < cards.Length; i++)
            {
                if (!held.Contains(i + 1))
                {
                    cards[i] = _cardDeck.TakeCard();
                }
            }

            _ui.InformCards(cards);

            if (cards[0] == cards[1] && cards[1] == cards[2])
            {
                _ui.InformSuperWin();
            }
            else if (cards[0] == cards[1] || cards[1] == cards[2] || cards[0] == cards[2])
            {
                _ui.InformWin();
            } else
            {
                _ui.InformLose();
            }
        }
    }
}