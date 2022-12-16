using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEntityFramework.Models
{

    public class Order : RgpdObject
    {
        // primary key
        [Key]
        public Guid OrderID { get; set; }

        [NotNull]
        public Client OrderClient { get; set; }
        //[ForeignKey(nameof(OrderClientID))]
        //public Guid OrderClientID { get; set; }

        //[ForeignKey(nameof(OrderAddressID))]
        //public Guid OrderAddressID { get; set; }
        [AllowNull]
        public Address OrderDeliveryAddress { get; set; }

        //[ForeignKey(nameof(OrderRestaurantID))]
        //public Guid OrderRestaurantID { get; set; }
        [AllowNull]
        [DeleteBehavior(DeleteBehavior.NoAction)]
        public Restaurant OrderRestaurant { get; set; }

        //[ForeignKey(nameof(OrderDeliverymanID))]
        //public Guid OrderDeliverymanID { get; set; }
        [AllowNull]
        [DeleteBehavior(DeleteBehavior.NoAction)]
        public Deliveryman OrderDeliveryman { get; set; }

        public EState OrderStatus { get; set; }

        public int OrderFinalPrice { get; set; } = 0;
        public int OrderTotalPrice { get; set; } = 0;
        public int OrderRestaurantPart { get; set; } = 0;
        public int OrderLinkEatsPart { get; set; } = 0;
        public int OrderDeliveryCost { get; set; } = 0;
        public int OrderTips { get; set; }
        public ICollection<Discount> OrderDiscounts { get; set; }

        public string OrderPaymentInfo { get; set; }
    }
}
