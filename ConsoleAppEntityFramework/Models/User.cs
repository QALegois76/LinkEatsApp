using System.ComponentModel.DataAnnotations;

namespace ConsoleAppEntityFramework.Models
{
    public class User : RgpdObject
    {
        [Key]
        public Guid UserID { get; set; }

        public string UserLogin { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }

        public ERole UserRole { get; set; }

        public RegistreryToken UserRegistreryToken { get; set; }
    }
}
