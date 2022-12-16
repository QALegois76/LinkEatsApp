using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace ConsoleAppEntityFramework.Models
{
    [PrimaryKey(nameof(UserID))]
    public class Deliveryman : User
    {
        public Deliveryman()
        {
            //this.DeliverymanComments = new HashSet<DeliveryComment>();
        }

        public bool DeliverymanIsActif { get; set; } = false;

        public string DeliverymanFirstName { get; set; }
        public string DeliverymanLastName { get; set; }
        public string DeliverymanIBAN { get; set; }

        [Range(0f, 5f)]
        public float DeliverymanStars { get; set; } = 0;
        public float DeliverymanActionRange { get; set; } = 5;

        public double Latitude { get; set; } = 0;
        public double Longitude { get; set; } = 0;


        [AllowNull]
        public ICollection<DeliveryComment> DeliverymanComments { get; set; }
        //public List<DeliveryComment> DeliverymanComments { get; set; }
    }
}
