using GameBoy20.Cards;
using System.Linq;
using GameBoy20.NumberPokeGame.Enums;
using GameBoy20.NumberPokeGame.Messages.Interfaces;
using GameBoy20.Utils.Interfaces;

namespace GameBoy20.NumberPokeGame
{
    public class NumberPoke
    {
        private readonly INumberPokeMessages _messages;
        private readonly ICardDeck _cardDeck;

        public NumberPoke(INumberPokeMessages messages, ICardDeck cardDeck)
        {
            _messages = messages;
            _cardDeck = cardDeck;
        }

        private Hand RedrawCards(Hand hand)
        {
            //collects which cards the user wants to not redraw
            string heldCards = _messages.ObtainCardsToHold();
            int[] held = heldCards.Split(',').Select(int.Parse).ToArray();
            _messages.InformNewLine();

            //redraws non held cards
            if (!held.Contains(1)) hand.CardOne = _cardDeck.TakeCard();
            if (!held.Contains(2)) hand.CardTwo = _cardDeck.TakeCard();
            if (!held.Contains(3)) hand.CardThree = _cardDeck.TakeCard();
            return hand;
        }

        private void WinStatus(Hand hand)
        {
            _messages.InformCards(hand);
            switch (hand.GetWinStatus())
            {
                case (GameResultEnum.SuperWin):
                    _messages.InformSuperWin();
                    break;
                case (GameResultEnum.Win):
                    _messages.InformWin();
                    break;
                case (GameResultEnum.Lose):
                    _messages.InformLose();
                    break;
            }
        }

        public void PlayGame(Hand hand)
        {  
            // Hand hand = new Hand(_cardDeck.TakeHand(3));
            _messages.InformCards(hand);
            hand = RedrawCards(hand);
            WinStatus(hand);
        }
    }
}
