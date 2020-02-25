using GameBoy20.BlackJackGame;

namespace GameBoy20.NumberGuessGame
{
    //Game Setup
    public class RandomCard
    {
        public RandomCard()
        {
            Target = CardDeck.TakeCard();
        }

        public string Target { get; }

        public bool PlayRound(string guess) => guess == Target;
    }
}
