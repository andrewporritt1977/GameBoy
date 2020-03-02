using GameBoy20.BlackJackGame.Messages;
using GameBoy20.Cards;
using GameBoy20.Utils.Interfaces;

namespace GameBoy20.BlackJackGame
{
    // Game Logic
    public class BlackJack : IGame
    {
        public BlackJack(IBlackJackMessages messages, ICardDeck cardDeck)
        {
            _messages = messages;
            _cardDeck = cardDeck;
        }

        private readonly IBlackJackMessages _messages;
        private readonly ICardDeck _cardDeck;

        public void LaunchGame()
        {   
            //initial step
            Dealer dealer = new Dealer(_cardDeck);
            dealer.TakeCard();
            Player player = new Player(_cardDeck);
            player.TakeCard();
            player.TakeCard();

            //play
            _messages.InformWelcome();
            _messages.InformDealerCardsExcludingHidden(dealer.HandTotal(), dealer.HandContents());

            //player turn
            while (!player.Stand)
            {
                if (player.HandTotal() == 21)
                {
                    player.Win = true;
                    player.Stand = true;
                    _messages.InformPlayerBlackJack();
                }

                _messages.InformPlayerCards(player.HandTotal(), player.HandContents());
                var confirmation = _messages.ObtainTakeHandConfirmation();
                if (confirmation.Equals("y"))
                {
                    player.TakeCard();
                    if (player.HandTotal() == 21)
                    {
                        player.Win = true;
                        player.Stand = true;
                        _messages.InformPlayerBlackJack();
                    }
                    else if (player.HandTotal() > 21)
                    {
                        player.Win = false;
                        player.Stand = true;
                        _messages.InformPlayerBust(player.HandTotal(), player.HandContents());
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
                _messages.InformDealerCardsIncludingHidden(dealer.HiddenCard, dealer.HandTotal(), dealer.HandContents());
                while (dealer.HandTotal() < 17)
                {
                    dealer.TakeCard();
                    _messages.InformDealerTakeCard(dealer.HandTotal(), dealer.HandContents());
                }
                if (dealer.HandTotal() > 21)
                {
                    player.Win = true;
                    _messages.InformDealerBust(dealer.HandContents());
                }
                else if (dealer.HandTotal() == 21)
                {
                    player.Win = false;
                    _messages.InformDealerBlackJack(dealer.HandContents());
                }
                else if (dealer.HandTotal() > player.HandTotal())
                {
                    player.Win = false;
                    _messages.InformDealerWin(dealer.HandTotal(), player.HandTotal());
                }
                else if (player.HandTotal() > dealer.HandTotal())
                {
                    player.Win = true;
                    _messages.InformDealerLoss(dealer.HandTotal(), player.HandTotal());
                }
            }
        }
    }
}
