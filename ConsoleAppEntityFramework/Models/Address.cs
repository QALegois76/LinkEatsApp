using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ConsoleAppEntityFramework.Models
{
   // [Keyless]
    public class Address
    {
        public Guid AddressID { get; set; }
        public string AddressValue { get; set; }
    }
}
