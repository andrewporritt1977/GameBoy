using System.Collections.Generic;
using System.Linq;
using GameBoy20.BlackJackGame;
using GameBoy20.Cards;

namespace GameBoy20.NumberPokeGame

{
    class Setup
    {
        public Setup(ICardDeck cardDeck) 
        {
            _cardDeck = cardDeck;
        }

        private ICardDeck _cardDeck;

        public string CardOne { get; set; }
        public string CardTwo { get; set; }
        public string CardThree { get; set; }
        
        private bool CardOneHeld { get; set; }
        private bool CardTwoHeld { get; set; }
        private bool CardThreeHeld { get; set; }

        public void DrawCards()
        {
            if (!CardOneHeld) CardOne = _cardDeck.TakeCard();
            if (!CardTwoHeld) CardTwo = _cardDeck.TakeCard();
            if (!CardThreeHeld) CardThree = _cardDeck.TakeCard();
        }

        public void HoldCards(string heldCardsString)
        {
            List<int> heldCards = heldCardsString.Split(',').Select(int.Parse).ToList();
            foreach (var card in heldCards)
            {
                switch (card) 
                {
                    case 1:
                        CardOneHeld = true;
                        break;
                    case 2:
                        CardTwoHeld = true;
                        break;
                    case 3:
                        CardThreeHeld = true;
                        break;
                }
            }
        }

        public string WinStatus()
        {
            if (CardOne == CardTwo && CardTwo == CardThree)
            {
                return "Super-win";
            }
            if (CardOne == CardTwo || CardTwo == CardThree || CardOne == CardThree)
            {
                return "Win";
            }
            return "Lose";
        }
    }
}
