using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace ConsoleAppEntityFramework.Models
{
    [PrimaryKey(nameof(UserID))]
    public class Restaurant : User
    {
        public Restaurant()
        {
           //this.RestaurantComments = new HashSet<RestoComment>();
        }

        public string RestaurantSiret { get; set; }
        public string RestaurantSiren { get; set; }
        public string RestaurantName { get; set; }

        public string RestaurantIBAN { get; set; }

        public string RestaurantImgIdentityPath { get; set; }
        public string RestaurantImgBannerPath { get; set; }

        public bool RestaurantIsOpen { get; set; } = false;

        [Range(0f,5f)]
        public float RestaurantStars { get; set; } = 0;
        public float RestaurantDeliveryRange { get; set; }= 5f;

        public Address RestaurantAddress { get; set; }

        [AllowNull]
        public ICollection<RestoComment> RestaurantComments { get; set; }
        //public List<RestoComment> RestaurantComments { get; set; }
    }
}
