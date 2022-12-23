using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace ConsoleAppEntityFramework.Models
{
    [PrimaryKey(nameof(UserID))]
    public class Client : User
    {
        public Client()
        {
            // this.ClientDeliveryComments = new HashSet<DeliveryComment>();
            // this.ClientRestaurantComments = new HashSet<RestoComment>();

        }

        // experimental
        public bool ClientLinkerFeatureEnabled { get; set; } = false;

        public string ClientLastName { get; set; }
        public string ClientFirstName { get; set; }

        public int ClientCurrentXP { get; set; } = 0;
        public int ClientNextLevelXP { get; set; } = 0;
        public int ClientLevel { get; set; } = 0;

        public int ClientWallet { get; set; } = 0;

        public ICollection<Address> ClientAddresses { get; set; }

        public ICollection<Client> ClientFriends { get; set; }

        [AllowNull]
        public ICollection<RestoComment> ClientRestaurantComments { get; set; }
        //public List<RestoComment> ClientRestaurantComments { get; set; }
        [AllowNull]
        public ICollection<DeliveryComment> ClientDeliveryComments { get; set; }
        //public List<DeliveryComment> ClientDeliveryComments { get; set; }
    }
}
