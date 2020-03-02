using System;
using System.Collections.Generic;
using System.Text;

namespace GameBoy20.BlackJackGame.Messages
{
    internal class BlackJackMessages : IBlackJackMessages
    {
        public void InformDealerBlackJack(string dealerHandContents)
        {
            Console.WriteLine("BlackJack for dealer, you lose" + " with their hand of: " + dealerHandContents);
        }

        public void InformDealerBust(string dealerHandContents)
        {
            Console.WriteLine("The dealer has gone bust, you win." + " with their hand of: " + dealerHandContents);
        }

        public void InformDealerCardsExcludingHidden(int dealerHandTotal, string dealerHandContents)
        {
            Console.WriteLine("The dealer's cards, excluding hidden card, total " + dealerHandTotal +
                              " with their hand of: " + dealerHandContents);
        }

        public void InformDealerCardsIncludingHidden(string dealerHiddenCard, int dealerHandTotal, string dealerHandContents)
        {
            Console.WriteLine("The dealer's hidden card is: " + dealerHiddenCard + ", making their total at: " +
                              dealerHandTotal + " with their hand of: " + dealerHandContents);
        }

        public void InformDealerLoss(int dealerHandTotal, int playerHandTotal)
        {
            Console.WriteLine("The dealer has a lesser hand than you at: " + dealerHandTotal +
                              ", you win with your hand of: " + playerHandTotal);
        }

        public void InformDealerTakeCard(int dealerHandTotal, string dealerHandContents)
        {
            Console.WriteLine("The dealer has taken another card to now total: " + dealerHandTotal + " with their hand of: " + dealerHandContents);
        }

        public void InformDealerWin(int dealerHandTotal, int playerHandTotal)
        {
            Console.WriteLine("The dealer has a greater hand than you at: " + dealerHandTotal +
                              ", you lose with your hand of: " + playerHandTotal);
        }

        public void InformPlayerBlackJack()
        {
            Console.WriteLine("BlackJack! You win!");
        }

        public void InformPlayerBust(int playerHandTotal, string playerHandContents)
        {
            Console.WriteLine("You lose, your hand is : " + playerHandTotal +
                              " with your hand of: " + playerHandContents);
        }

        public void InformPlayerCards(int playerHandTotal, string playerHandContents)
        {
            Console.WriteLine("Your hand is " + playerHandTotal + " with your hand of: " + playerHandContents);
        }

        public void InformWelcome()
        {
            Console.WriteLine("Welcome to blackjack");
        }

        public string ObtainTakeHandConfirmation()
        {
            Console.WriteLine("Would you like to take a hand? (y/n)");
            return Console.ReadLine();
        }
    }
}
