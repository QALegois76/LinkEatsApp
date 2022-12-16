using Microsoft.EntityFrameworkCore;

namespace ConsoleAppEntityFramework.Models
{
    //[Keyless]
    public class RgpdObject
    {
        public bool RgpdObjectIsDeleted { get; set; }
        public DateTime RgpdObjectCreatedAt { get; set; }
        public DateTime RgpdObjectLastWrite { get; set; }
    }
}
