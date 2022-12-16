using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace ConsoleAppEntityFramework.Models
{
    //[Keyless]
    public class DeliveryComment
    {
        [Key]
        public Guid DeliveryCommentID { get; set; }

        public string DeliveryCommentComent { get; set; }

        //[AllowNull]
        //public Client DeliveryCommentClient { get; set; }
        //[AllowNull]
        //public Deliveryman DeliveryCommentDelivery { get; set; }

        [Range(0, 5)]
        public int DeliveryCommentRate { get; set; } = 0;
    }
}
