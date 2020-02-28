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
            Hand hand = new Hand();
            
            //grabs 3 cards
            hand.CardOne = _cardDeck.TakeCard();
            hand.CardTwo = _cardDeck.TakeCard();
            hand.CardThree = _cardDeck.TakeCard();
            
            
            _ui.InformCards(hand);


            //collects which cards the user wants to not redraw
            string heldCards = _ui.ObtainCardsToHold();
            int[] held = heldCards.Split(',').Select(int.Parse).ToArray();
            _ui.InformNewLine();

            //redraws non held cards
            if (!held.Contains(1)) hand.CardOne = _cardDeck.TakeCard();
            if (!held.Contains(2)) hand.CardTwo = _cardDeck.TakeCard();
            if (!held.Contains(3)) hand.CardThree = _cardDeck.TakeCard();

            _ui.InformCards(hand);
            switch (hand.GetWinStatus())
            {
                case ((int)GameResultEnum.SuperWin):
                    _ui.InformSuperWin();
                    break;
                case ((int)GameResultEnum.Win):
                    _ui.InformWin();
                    break;
                case ((int)GameResultEnum.Lose):
                    _ui.InformLose();
                    break;
            }
        }
    }
}