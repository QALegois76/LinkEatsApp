namespace LinkEatsApp
{
    public interface IFormRGPDUser
    {
        public string TitleForm { get; set; }

        public bool ActifAccount { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastUpdatedAt { get; set; }
    }
}
