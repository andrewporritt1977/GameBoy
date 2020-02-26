using GameBoy20.Cards;

namespace GameBoy20.BlackJackGame
{
    public class Dealer : Participant
    {
        public Dealer(ICardDeck cardDeck) : base(cardDeck)
        {
           HiddenCard = _cardDeck.TakeCard();
        }


        public string HiddenCard { get; }

        public void RevealHiddenCard()
        {
            Hand.Add(HiddenCard);
        }
    }

}
