using System;

namespace GameBoy
{
    //Class Setup
    public abstract class Participant
    {
        public int Hand { get; set; }

        public bool Stand { get; set; }

        public string TakeCard()
        {
            Hand = Hand + CardDeck.TakeCard();
            if (Hand == 21)
            {
                return "Blackjack";
            }
            if (Hand > 21)
            {
                return "Bust";
            }
            return "Continue";
        }
    }

    public class Player : Participant
    {
        public bool? Win { get; set; }
    }

    public class Dealer : Participant
    {
        public Dealer()
        {
            Random random = new Random();
            HiddenCard = CardDeck.TakeCard();
        }

        public int HiddenCard { get; set; }
    }

    public static class CardDeck
    {
        public static int TakeCard()
        {
            Random random = new Random();
            return random.Next(1, 11);
        }

    }
    // Game Logic
    class BlackJack
    {
        static void Main(string[] args)
        {   
            //initial step
            Dealer dealer = new Dealer();
            dealer.TakeCard();
            Player player = new Player();
            player.TakeCard();
            player.TakeCard();
            //play
            Console.WriteLine("Welcome to blackjack");
            Console.WriteLine("The dealer's cards, excluding hidden card, total " + dealer.Hand);
            //dealer start
            //player turn
            while (!player.Stand)
            {
                Console.WriteLine("Your hand is " + player.Hand);
                Console.WriteLine("Would you like to take a hand? (y/n)");
                var confirmation = Console.ReadLine();
                if (confirmation.Equals("y"))
                {
                    player.TakeCard();
                    if (player.Hand == 21)
                    {
                        player.Win = true;
                        player.Stand = true;
                        Console.WriteLine("BlackJack! You win!");
                    }
                    else if (player.Hand > 21)
                    {
                        player.Win = false;
                        player.Stand = true;
                        Console.WriteLine("You lose, your hand is : " + player.Hand);
                    }
                }
                else
                {
                    player.Stand = true;
                }
            }
            //Dealers turn
            if (!player.Win.HasValue)
            {
                dealer.Hand = dealer.Hand + dealer.HiddenCard;
                Console.WriteLine("The dealer's hidden card is: " + dealer.HiddenCard + ", making their total at: " +
                                  dealer.Hand);
                while (dealer.Hand < 17)
                {
                    dealer.TakeCard();
                    Console.WriteLine("The dealer has taken another card to now total: " + dealer.Hand);
                }
                if (dealer.Hand > 21)
                {
                    player.Win = true;
                    Console.WriteLine("The dealer has gone bust, you win.");
                }
                else if (dealer.Hand == 21)
                {
                    player.Win = false;
                    Console.WriteLine("BlackJack for dealer, you lose.");
                }
                else if (dealer.Hand > player.Hand)
                {
                    player.Win = false;
                    Console.WriteLine("The dealer has a greater hand than you at: " + dealer.Hand +
                                      ", you lose with your hand of: " + player.Hand);
                }
                else if (player.Hand > dealer.Hand)
                {
                    player.Win = true;
                    Console.WriteLine("The dealer has a lesser hand than you at: " + dealer.Hand +
                                      ", you win with your hand of: " + player.Hand);
                }
            }
        }
    }
}
