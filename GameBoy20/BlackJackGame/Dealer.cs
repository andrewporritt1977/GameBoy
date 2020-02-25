namespace GameBoy20.BlackJackGame
{
    public class Dealer : Participant
    {
        public Dealer()
        {
            HiddenCard = CardDeck.TakeCard();
        }

        public string HiddenCard { get; }

        public void RevealHiddenCard()
        {
            Hand.Add(HiddenCard);
        }
    }

}
