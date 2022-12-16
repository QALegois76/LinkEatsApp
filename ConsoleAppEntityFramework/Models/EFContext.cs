using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEntityFramework.Models
{
    public class EFContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Deliveryman> Deliverymen { get; set; }
        public DbSet<Discount> Discounts { get; set; }


        // constructor
        public EFContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(AppSetting.CONNECTION_STRING);
            //base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //// CLIENT
            //modelBuilder.Entity<Client>().HasMany(c => c.ClientDeliveryComments)
            //    .WithOne()
            //    .IsRequired(false)
            //    .OnDelete(DeleteBehavior.SetNull);

            //modelBuilder.Entity<Client>()
            //    .HasMany(c => c.ClientRestaurantComments)
            //    .WithOne()
            //    .IsRequired(false)
            //    .OnDelete(DeleteBehavior.SetNull);

            //// RESTAURANT
            //modelBuilder.Entity<Restaurant>()
            //    .HasMany(r => r.RestaurantComments)
            //    .WithOne()
            //    .IsRequired(false)
            //    .OnDelete(DeleteBehavior.SetNull);

            ////DELIVERYMAN
            //modelBuilder.Entity<Deliveryman>()
            //    .HasMany(d => d.DeliverymanComments)
            //    .WithOne()
            //    .IsRequired(false)
            //    .OnDelete(DeleteBehavior.SetNull);


            //// RESTO_COMMENT

            //modelBuilder.Entity<RestoComment>()
            //    .HasOne(rc => rc.RestoCommentClient)
            //    .WithOne()
            //    .IsRequired();

            //modelBuilder.Entity<RestoComment>()
            //    .HasOne(rc => rc.RestoCommentRestaurant)
            //    .WithOne()
            //    .IsRequired();

            //// DELIVERY_COMMENT
            //modelBuilder.Entity<DeliveryComment>()
            //    .HasOne(dc => dc.DeliveryCommentClient)
            //    .WithOne()
            //    .IsRequired();

            //modelBuilder.Entity<DeliveryComment>()
            //    .HasOne(dc => dc.DeliveryCommentClient)
            //    .WithOne()
            //    .IsRequired();

            
            //modelBuilder.Entity<Restaurant>().HasOne(c => c.RestaurantComments).WithMany().OnDelete(DeleteBehavior.Restrict);
            //modelBuilder.Entity<Deliveryman>().HasOne(c => c.DeliverymanComments).WithMany().OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<DeliveryComment>().HasOne(com => com.DeliveryCommentClient).WithOne().OnDelete(DeleteBehavior.NoAction);
            //modelBuilder.Entity<DeliveryComment>().HasOne(com => com.DeliveryCommentDelivery).WithOne().OnDelete(DeleteBehavior.NoAction);
            
            //modelBuilder.Entity<RestoComment>().HasOne(com => com.RestoCommentClient).WithOne().OnDelete(DeleteBehavior.NoAction);
            //modelBuilder.Entity<RestoComment>().HasOne(com => com.RestoCommentRestaurant).WithOne().OnDelete(DeleteBehavior.NoAction);

        }



    }
}
