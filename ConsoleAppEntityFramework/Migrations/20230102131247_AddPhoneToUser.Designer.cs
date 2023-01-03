﻿// <auto-generated />
using System;
using ConsoleAppEntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ConsoleAppEntityFramework.Migrations
{
    [DbContext(typeof(EFContext))]
    [Migration("20230102131247_AddPhoneToUser")]
    partial class AddPhoneToUser
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ConsoleAppEntityFramework.Models.Address", b =>
                {
                    b.Property<Guid>("AddressID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AddressValue")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ClientUserID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("AddressID");

                    b.HasIndex("ClientUserID");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("ConsoleAppEntityFramework.Models.Client", b =>
                {
                    b.Property<Guid>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ClientCurrentXP")
                        .HasColumnType("int");

                    b.Property<string>("ClientFirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClientLastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ClientLevel")
                        .HasColumnType("int");

                    b.Property<bool>("ClientLinkerFeatureEnabled")
                        .HasColumnType("bit");

                    b.Property<int>("ClientNextLevelXP")
                        .HasColumnType("int");

                    b.Property<Guid?>("ClientUserID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ClientWallet")
                        .HasColumnType("int");

                    b.Property<DateTime>("RgpdObjectCreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("RgpdObjectIsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("RgpdObjectLastWrite")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserLogin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserRegistreryTokenRegistreryTokenID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("UserRole")
                        .HasColumnType("int");

                    b.HasKey("UserID");

                    b.HasIndex("ClientUserID");

                    b.HasIndex("UserRegistreryTokenRegistreryTokenID");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("ConsoleAppEntityFramework.Models.DeliveryComment", b =>
                {
                    b.Property<Guid>("DeliveryCommentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ClientUserID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DeliveryCommentComent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DeliveryCommentRate")
                        .HasColumnType("int");

                    b.Property<Guid?>("DeliverymanUserID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("DeliveryCommentID");

                    b.HasIndex("ClientUserID");

                    b.HasIndex("DeliverymanUserID");

                    b.ToTable("DeliveryComment");
                });

            modelBuilder.Entity("ConsoleAppEntityFramework.Models.Deliveryman", b =>
                {
                    b.Property<Guid>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("DeliverymanActionRange")
                        .HasColumnType("real");

                    b.Property<string>("DeliverymanFirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeliverymanIBAN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("DeliverymanIsActif")
                        .HasColumnType("bit");

                    b.Property<string>("DeliverymanLastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("DeliverymanStars")
                        .HasColumnType("real");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.Property<DateTime>("RgpdObjectCreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("RgpdObjectIsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("RgpdObjectLastWrite")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserLogin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserRegistreryTokenRegistreryTokenID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("UserRole")
                        .HasColumnType("int");

                    b.HasKey("UserID");

                    b.HasIndex("UserRegistreryTokenRegistreryTokenID");

                    b.ToTable("Deliverymen");
                });

            modelBuilder.Entity("ConsoleAppEntityFramework.Models.Discount", b =>
                {
                    b.Property<Guid>("DiscountID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("DiscountAdd")
                        .HasColumnType("int");

                    b.Property<string>("DiscountDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("OrderID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("DiscountID");

                    b.HasIndex("OrderID");

                    b.ToTable("Discounts");
                });

            modelBuilder.Entity("ConsoleAppEntityFramework.Models.Order", b =>
                {
                    b.Property<Guid>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("OrderClientUserID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("OrderDeliveryAddressAddressID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("OrderDeliveryCost")
                        .HasColumnType("int");

                    b.Property<Guid>("OrderDeliverymanUserID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("OrderFinalPrice")
                        .HasColumnType("int");

                    b.Property<int>("OrderLinkEatsPart")
                        .HasColumnType("int");

                    b.Property<string>("OrderPaymentInfo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrderRestaurantPart")
                        .HasColumnType("int");

                    b.Property<Guid>("OrderRestaurantUserID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("OrderStatus")
                        .HasColumnType("int");

                    b.Property<int>("OrderTips")
                        .HasColumnType("int");

                    b.Property<int>("OrderTotalPrice")
                        .HasColumnType("int");

                    b.Property<DateTime>("RgpdObjectCreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("RgpdObjectIsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("RgpdObjectLastWrite")
                        .HasColumnType("datetime2");

                    b.HasKey("OrderID");

                    b.HasIndex("OrderClientUserID");

                    b.HasIndex("OrderDeliveryAddressAddressID");

                    b.HasIndex("OrderDeliverymanUserID");

                    b.HasIndex("OrderRestaurantUserID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("ConsoleAppEntityFramework.Models.RegistreryToken", b =>
                {
                    b.Property<Guid>("RegistreryTokenID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("RegistreryTokenEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTime>("RegistreryTokenExpiredDate")
                        .HasColumnType("datetime2");

                    b.HasKey("RegistreryTokenID");

                    b.ToTable("RegistreryToken");
                });

            modelBuilder.Entity("ConsoleAppEntityFramework.Models.Restaurant", b =>
                {
                    b.Property<Guid>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RestaurantAddressAddressID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("RestaurantDeliveryRange")
                        .HasColumnType("real");

                    b.Property<string>("RestaurantIBAN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RestaurantImgBannerPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RestaurantImgIdentityPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("RestaurantIsOpen")
                        .HasColumnType("bit");

                    b.Property<string>("RestaurantName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RestaurantSiren")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RestaurantSiret")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("RestaurantStars")
                        .HasColumnType("real");

                    b.Property<DateTime>("RgpdObjectCreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("RgpdObjectIsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("RgpdObjectLastWrite")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserLogin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserRegistreryTokenRegistreryTokenID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("UserRole")
                        .HasColumnType("int");

                    b.HasKey("UserID");

                    b.HasIndex("RestaurantAddressAddressID");

                    b.HasIndex("UserRegistreryTokenRegistreryTokenID");

                    b.ToTable("Restaurants");
                });

            modelBuilder.Entity("ConsoleAppEntityFramework.Models.RestoComment", b =>
                {
                    b.Property<Guid>("RestoCommentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ClientUserID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("RestaurantUserID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("RestoCommentComent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RestoCommentRate")
                        .HasColumnType("int");

                    b.HasKey("RestoCommentID");

                    b.HasIndex("ClientUserID");

                    b.HasIndex("RestaurantUserID");

                    b.ToTable("RestoComment");
                });

            modelBuilder.Entity("ConsoleAppEntityFramework.Models.Address", b =>
                {
                    b.HasOne("ConsoleAppEntityFramework.Models.Client", null)
                        .WithMany("ClientAddresses")
                        .HasForeignKey("ClientUserID");
                });

            modelBuilder.Entity("ConsoleAppEntityFramework.Models.Client", b =>
                {
                    b.HasOne("ConsoleAppEntityFramework.Models.Client", null)
                        .WithMany("ClientFriends")
                        .HasForeignKey("ClientUserID");

                    b.HasOne("ConsoleAppEntityFramework.Models.RegistreryToken", "UserRegistreryToken")
                        .WithMany()
                        .HasForeignKey("UserRegistreryTokenRegistreryTokenID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserRegistreryToken");
                });

            modelBuilder.Entity("ConsoleAppEntityFramework.Models.DeliveryComment", b =>
                {
                    b.HasOne("ConsoleAppEntityFramework.Models.Client", null)
                        .WithMany("ClientDeliveryComments")
                        .HasForeignKey("ClientUserID");

                    b.HasOne("ConsoleAppEntityFramework.Models.Deliveryman", null)
                        .WithMany("DeliverymanComments")
                        .HasForeignKey("DeliverymanUserID");
                });

            modelBuilder.Entity("ConsoleAppEntityFramework.Models.Deliveryman", b =>
                {
                    b.HasOne("ConsoleAppEntityFramework.Models.RegistreryToken", "UserRegistreryToken")
                        .WithMany()
                        .HasForeignKey("UserRegistreryTokenRegistreryTokenID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserRegistreryToken");
                });

            modelBuilder.Entity("ConsoleAppEntityFramework.Models.Discount", b =>
                {
                    b.HasOne("ConsoleAppEntityFramework.Models.Order", null)
                        .WithMany("OrderDiscounts")
                        .HasForeignKey("OrderID");
                });

            modelBuilder.Entity("ConsoleAppEntityFramework.Models.Order", b =>
                {
                    b.HasOne("ConsoleAppEntityFramework.Models.Client", "OrderClient")
                        .WithMany()
                        .HasForeignKey("OrderClientUserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConsoleAppEntityFramework.Models.Address", "OrderDeliveryAddress")
                        .WithMany()
                        .HasForeignKey("OrderDeliveryAddressAddressID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConsoleAppEntityFramework.Models.Deliveryman", "OrderDeliveryman")
                        .WithMany()
                        .HasForeignKey("OrderDeliverymanUserID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("ConsoleAppEntityFramework.Models.Restaurant", "OrderRestaurant")
                        .WithMany()
                        .HasForeignKey("OrderRestaurantUserID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("OrderClient");

                    b.Navigation("OrderDeliveryAddress");

                    b.Navigation("OrderDeliveryman");

                    b.Navigation("OrderRestaurant");
                });

            modelBuilder.Entity("ConsoleAppEntityFramework.Models.Restaurant", b =>
                {
                    b.HasOne("ConsoleAppEntityFramework.Models.Address", "RestaurantAddress")
                        .WithMany()
                        .HasForeignKey("RestaurantAddressAddressID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConsoleAppEntityFramework.Models.RegistreryToken", "UserRegistreryToken")
                        .WithMany()
                        .HasForeignKey("UserRegistreryTokenRegistreryTokenID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RestaurantAddress");

                    b.Navigation("UserRegistreryToken");
                });

            modelBuilder.Entity("ConsoleAppEntityFramework.Models.RestoComment", b =>
                {
                    b.HasOne("ConsoleAppEntityFramework.Models.Client", null)
                        .WithMany("ClientRestaurantComments")
                        .HasForeignKey("ClientUserID");

                    b.HasOne("ConsoleAppEntityFramework.Models.Restaurant", null)
                        .WithMany("RestaurantComments")
                        .HasForeignKey("RestaurantUserID");
                });

            modelBuilder.Entity("ConsoleAppEntityFramework.Models.Client", b =>
                {
                    b.Navigation("ClientAddresses");

                    b.Navigation("ClientDeliveryComments");

                    b.Navigation("ClientFriends");

                    b.Navigation("ClientRestaurantComments");
                });

            modelBuilder.Entity("ConsoleAppEntityFramework.Models.Deliveryman", b =>
                {
                    b.Navigation("DeliverymanComments");
                });

            modelBuilder.Entity("ConsoleAppEntityFramework.Models.Order", b =>
                {
                    b.Navigation("OrderDiscounts");
                });

            modelBuilder.Entity("ConsoleAppEntityFramework.Models.Restaurant", b =>
                {
                    b.Navigation("RestaurantComments");
                });
#pragma warning restore 612, 618
        }
    }
}
