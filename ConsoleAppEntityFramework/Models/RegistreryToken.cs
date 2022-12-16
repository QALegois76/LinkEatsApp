using System.ComponentModel.DataAnnotations;

namespace ConsoleAppEntityFramework.Models
{
    public class RegistreryToken
    {
        public bool RegistreryTokenEnabled { get; set; } = false;

        [Key]
        public Guid RegistreryTokenID { get; set; }

        public DateTime RegistreryTokenExpiredDate { get; set; }
    }
}
