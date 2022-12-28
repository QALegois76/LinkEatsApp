using System.ComponentModel.DataAnnotations;

namespace LinkEatsApp
{
    public interface IFormRestaurant : IFormUser
    {
        public string RestaurantSiret { get; set; }
        public string RestaurantSiren { get; set; }
        public string RestaurantName { get; set; }

        public string RestaurantIBAN { get; set; }

        public string RestaurantImgIdentityPath { get; set; }
        public string RestaurantImgBannerPath { get; set; }


        [Range(0f, 1f)]
        public float RestaurantStars { get; set; }
        public float RestaurantDeliveryRange { get; set; }
    }
}
