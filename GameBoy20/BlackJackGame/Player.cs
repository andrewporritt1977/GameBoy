using GameBoy20.Cards;

namespace GameBoy20.BlackJackGame
{
    public class Player : Participant
    {
        public Player(ICardDeck cardDeck) : base(cardDeck)
        {
            
        }
        public bool? Win { get; set; }
    }

}
