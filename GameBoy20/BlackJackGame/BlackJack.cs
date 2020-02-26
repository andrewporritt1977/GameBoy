using GameBoy20.Utils;
using System;

namespace GameBoy20.BlackJackGame
{
    //Class Setup
    

    // Game Logic
    class BlackJack : IGame
    {
        public void LaunchGame()
        {   
            //initial step
            Dealer dealer = new Dealer(new CardDeck());
            dealer.TakeCard();
            Player player = new Player(new CardDeck());
            player.TakeCard();
            player.TakeCard();
            
            //play
            Console.WriteLine("Welcome to blackjack");
            Console.WriteLine("The dealer's cards, excluding hidden card, total " + dealer.HandTotal() + 
                              " with their hand of: " + dealer.HandContents());

            //player turn
            while (!player.Stand)
            {
                Console.WriteLine("Your hand is " + player.HandTotal() + " with your hand of: " + player.HandContents());
                Console.WriteLine("Would you like to take a hand? (y/n)");
                var confirmation = Console.ReadLine();
                if (confirmation.Equals("y"))
                {
                    player.TakeCard();
                    if (player.HandTotal() == 21)
                    {
                        player.Win = true;
                        player.Stand = true;
                        Console.WriteLine("BlackJack! You win!");
                    }
                    else if (player.HandTotal() > 21)
                    {
                        player.Win = false;
                        player.Stand = true;
                        Console.WriteLine("You lose, your hand is : " + player.HandTotal() + 
                                          " with your hand of: " + player.HandContents());
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
                dealer.RevealHiddenCard();
                Console.WriteLine("The dealer's hidden card is: " + dealer.HiddenCard + ", making their total at: " +
                                  dealer.HandTotal() + " with their hand of: " + dealer.HandContents());
                while (dealer.HandTotal() < 17)
                {
                    dealer.TakeCard();
                    Console.WriteLine("The dealer has taken another card to now total: " + dealer.HandTotal() + " with their hand of: " + dealer.HandContents());
                }
                if (dealer.HandTotal() > 21)
                {
                    player.Win = true;
                    Console.WriteLine("The dealer has gone bust, you win." + " with their hand of: " + dealer.HandContents());
                }
                else if (dealer.HandTotal() == 21)
                {
                    player.Win = false;
                    Console.WriteLine("BlackJack for dealer, you lose" + " with their hand of: " + dealer.HandContents());
                }
                else if (dealer.HandTotal() > player.HandTotal())
                {
                    player.Win = false;
                    Console.WriteLine("The dealer has a greater hand than you at: " + dealer.HandTotal() +
                                      ", you lose with your hand of: " + player.HandTotal());
                }
                else if (player.HandTotal() > dealer.HandTotal())
                {
                    player.Win = true;
                    Console.WriteLine("The dealer has a lesser hand than you at: " + dealer.HandTotal() +
                                      ", you win with your hand of: " + player.HandTotal());
                }
            }
        }
    }
}
