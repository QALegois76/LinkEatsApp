using System.ComponentModel.DataAnnotations;

namespace LinkEatsApp
{
    public interface IFormDeliveryman : IFormUser
    {
        public string FirstNameClient { get; set; }
        public string LastNameClient { get; set; }
        public string DeliverymanIBAN { get; set; }

        [Range(0,1)]
        public float PoucentRate { get; set; }
        public float ActionRange { get; set; }

        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
