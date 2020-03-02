using System;
using System.Collections.Generic;
using System.Text;

namespace GameBoy20.BlackJackGame.Messages
{
    public interface IBlackJackMessages
    {
        public void InformWelcome();
        public void InformDealerCardsExcludingHidden(int dealerHandTotal, string dealerHandContents);
        public void InformPlayerCards(int playerHandTotal, string playerHandContents);
        public string ObtainTakeHandConfirmation();
        public void InformPlayerBlackJack();
        public void InformPlayerBust(int playerHandTotal, string playerHandContents);
        public void InformDealerCardsIncludingHidden(string dealerHiddenCard, int dealerHandTotal, string dealerHandContents);
        public void InformDealerTakeCard(int dealerHandTotal, string dealerHandContents);
        public void InformDealerBust(string dealerHandContents);
        public void InformDealerBlackJack(string dealerHandContents);
        public void InformDealerWin(int dealerHandTotal, int playerHandTotal);
        public void InformDealerLoss(int dealerHandTotal, int playerHandTotal);
    }
}
