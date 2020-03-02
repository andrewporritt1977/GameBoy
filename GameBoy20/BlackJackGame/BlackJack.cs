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

        private Dealer SetupDealer()
        {
            Dealer dealer = new Dealer(_cardDeck);
            dealer.TakeCard();
            return dealer;
        }

        private Player SetupPlayer() {
            Player player = new Player(_cardDeck);
            player.TakeCard();
            player.TakeCard();
            return player;
        }

        private void WelcomePlayer(Dealer dealer)
        {
            _messages.InformWelcome();
            _messages.InformDealerCardsExcludingHidden(dealer.HandTotal(), dealer.HandContents());
        }

        private Player PlayerTurn(Player player)
        {
            while (!player.Stand)
            {
                if (player.HandTotal() == 21)
                {
                    player.NonStandardWin = true;
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
                        player.NonStandardWin = true;
                        player.Stand = true;
                        _messages.InformPlayerBlackJack();
                    }
                    else if (player.HandTotal() > 21)
                    {
                        player.NonStandardWin = false;
                        player.Stand = true;
                        _messages.InformPlayerBust(player.HandTotal(), player.HandContents());
                    }
                }
                else
                {
                    player.Stand = true;
                }
            }

            return player;
        }

        private Dealer DealerTurn(Dealer dealer)
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
                _messages.InformDealerBust(dealer.HandContents());
                dealer.NonStandardWin = false;
            }
            else if (dealer.HandTotal() == 21)
            {
                _messages.InformDealerBlackJack(dealer.HandContents());
                dealer.NonStandardWin = true;
            }
            return dealer;
        }

        private void FindStandardWin(Player player, Dealer dealer)
        {
            //work out wins
            if (dealer.HandTotal() > player.HandTotal())
            {
                _messages.InformDealerWin(dealer.HandTotal(), player.HandTotal());
            } 
            else if (player.HandTotal() > dealer.HandTotal()) 
            {
                _messages.InformDealerLoss(dealer.HandTotal(), player.HandTotal());
            } else
            {
                //draw
            }


        }

        public void LaunchGame()
        {
            Dealer dealer = SetupDealer();
            Player player = SetupPlayer();

            WelcomePlayer(dealer);

            player = PlayerTurn(player);
            if (!player.NonStandardWin.HasValue)
            {
                dealer = DealerTurn(dealer);
            }
            if (!player.NonStandardWin.HasValue || !dealer.NonStandardWin.HasValue)
            {
                FindStandardWin(player, dealer);
            }
        }
    }
}
