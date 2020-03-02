namespace GameBoy20.NumberGuessGame
{
    public interface INumberGuessMessages
    {
        public string ObtainGuess();

        public void ObtainWinConfirmation();

        public void NotifyIncorrectGuess();

        public void NotifyGameLoss(string targetCard);
    }
}