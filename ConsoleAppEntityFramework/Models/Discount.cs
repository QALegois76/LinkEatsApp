using System.ComponentModel.DataAnnotations;

namespace ConsoleAppEntityFramework.Models
{
    public class Discount
    {
        [Key]
        public Guid DiscountID { get; set; }
        public int DiscountAdd { get; set; }
        public string DiscountDescription { get; set; }
    }
}
