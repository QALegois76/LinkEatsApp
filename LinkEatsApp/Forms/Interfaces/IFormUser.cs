namespace LinkEatsApp
{
    public interface IFormUser : IFormRGPDUser
    {
        public event EventHandler UserSaved;
        public event EventHandler UserChangePassword;

        public bool MailValidated { get; set; }

        public string IdUser { get; set; }
        public string LoginUser { get; set; }
        public string EmailClient { get; set; }
        public string PhoneClient { get; set; }
    }
}
