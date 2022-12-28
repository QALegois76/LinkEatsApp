namespace LinkEatsApp
{
    public interface IFormClient : IFormUser
    {
        public string FirstNameClient { get; set; }
        public string LastNameClient { get; set; }

        public int LevelClient { get; set; }
        public int XPClient { get; set; }
        public int XPNextLevelClient { get; set;}
        public int WalletClient { get; set; }
    }
}
