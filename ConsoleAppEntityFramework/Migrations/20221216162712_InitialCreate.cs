using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleAppEntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Discounts",
                columns: table => new
                {
                    DiscountID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DiscountAdd = table.Column<int>(type: "int", nullable: false),
                    DiscountDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discounts", x => x.DiscountID);
                });

            migrationBuilder.CreateTable(
                name: "RegistreryToken",
                columns: table => new
                {
                    RegistreryTokenID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RegistreryTokenEnabled = table.Column<bool>(type: "bit", nullable: false),
                    RegistreryTokenExpiredDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistreryToken", x => x.RegistreryTokenID);
                });

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClientLinkerFeatureEnabled = table.Column<bool>(type: "bit", nullable: false),
                    ClientLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientCurrentXP = table.Column<int>(type: "int", nullable: false),
                    ClientNextLevelXP = table.Column<int>(type: "int", nullable: false),
                    ClientLevel = table.Column<int>(type: "int", nullable: false),
                    ClientWallet = table.Column<int>(type: "int", nullable: false),
                    ClientUserID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    RgpdObjectIsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    RgpdObjectCreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RgpdObjectLastWrite = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserLogin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserRole = table.Column<int>(type: "int", nullable: false),
                    UserRegistreryTokenRegistreryTokenID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.UserID);
                    table.ForeignKey(
                        name: "FK_Client_Client_ClientUserID",
                        column: x => x.ClientUserID,
                        principalTable: "Client",
                        principalColumn: "UserID");
                    table.ForeignKey(
                        name: "FK_Client_RegistreryToken_UserRegistreryTokenRegistreryTokenID",
                        column: x => x.UserRegistreryTokenRegistreryTokenID,
                        principalTable: "RegistreryToken",
                        principalColumn: "RegistreryTokenID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Deliverymen",
                columns: table => new
                {
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DeliverymanIsActif = table.Column<bool>(type: "bit", nullable: false),
                    DeliverymanFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeliverymanLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeliverymanIBAN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeliverymanStars = table.Column<float>(type: "real", nullable: false),
                    DeliverymanActionRange = table.Column<float>(type: "real", nullable: false),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    Longitude = table.Column<double>(type: "float", nullable: false),
                    RgpdObjectIsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    RgpdObjectCreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RgpdObjectLastWrite = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserLogin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserRole = table.Column<int>(type: "int", nullable: false),
                    UserRegistreryTokenRegistreryTokenID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deliverymen", x => x.UserID);
                    table.ForeignKey(
                        name: "FK_Deliverymen_RegistreryToken_UserRegistreryTokenRegistreryTokenID",
                        column: x => x.UserRegistreryTokenRegistreryTokenID,
                        principalTable: "RegistreryToken",
                        principalColumn: "RegistreryTokenID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    AddressID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AddressValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientUserID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.AddressID);
                    table.ForeignKey(
                        name: "FK_Address_Client_ClientUserID",
                        column: x => x.ClientUserID,
                        principalTable: "Client",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "DeliveryComment",
                columns: table => new
                {
                    DeliveryCommentID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DeliveryCommentComent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeliveryCommentRate = table.Column<int>(type: "int", nullable: false),
                    ClientUserID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeliverymanUserID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryComment", x => x.DeliveryCommentID);
                    table.ForeignKey(
                        name: "FK_DeliveryComment_Client_ClientUserID",
                        column: x => x.ClientUserID,
                        principalTable: "Client",
                        principalColumn: "UserID");
                    table.ForeignKey(
                        name: "FK_DeliveryComment_Deliverymen_DeliverymanUserID",
                        column: x => x.DeliverymanUserID,
                        principalTable: "Deliverymen",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "Restaurants",
                columns: table => new
                {
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RestaurantSiret = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RestaurantSiren = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RestaurantName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RestaurantIBAN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RestaurantImgIdentityPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RestaurantImgBannerPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RestaurantIsOpen = table.Column<bool>(type: "bit", nullable: false),
                    RestaurantStars = table.Column<float>(type: "real", nullable: false),
                    RestaurantDeliveryRange = table.Column<float>(type: "real", nullable: false),
                    RestaurantAddressAddressID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RgpdObjectIsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    RgpdObjectCreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RgpdObjectLastWrite = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserLogin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserRole = table.Column<int>(type: "int", nullable: false),
                    UserRegistreryTokenRegistreryTokenID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurants", x => x.UserID);
                    table.ForeignKey(
                        name: "FK_Restaurants_Address_RestaurantAddressAddressID",
                        column: x => x.RestaurantAddressAddressID,
                        principalTable: "Address",
                        principalColumn: "AddressID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Restaurants_RegistreryToken_UserRegistreryTokenRegistreryTokenID",
                        column: x => x.UserRegistreryTokenRegistreryTokenID,
                        principalTable: "RegistreryToken",
                        principalColumn: "RegistreryTokenID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderClientUserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderDeliveryAddressAddressID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderRestaurantUserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderDeliverymanUserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderStatus = table.Column<int>(type: "int", nullable: false),
                    OrderFinalPrice = table.Column<int>(type: "int", nullable: false),
                    OrderTotalPrice = table.Column<int>(type: "int", nullable: false),
                    OrderRestaurantPart = table.Column<int>(type: "int", nullable: false),
                    OrderLinkEatsPart = table.Column<int>(type: "int", nullable: false),
                    OrderDeliveryCost = table.Column<int>(type: "int", nullable: false),
                    OrderTips = table.Column<int>(type: "int", nullable: false),
                    OrderPaymentInfo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RgpdObjectIsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    RgpdObjectCreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RgpdObjectLastWrite = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_Orders_Address_OrderDeliveryAddressAddressID",
                        column: x => x.OrderDeliveryAddressAddressID,
                        principalTable: "Address",
                        principalColumn: "AddressID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Client_OrderClientUserID",
                        column: x => x.OrderClientUserID,
                        principalTable: "Client",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Deliverymen_OrderDeliverymanUserID",
                        column: x => x.OrderDeliverymanUserID,
                        principalTable: "Deliverymen",
                        principalColumn: "UserID");
                    table.ForeignKey(
                        name: "FK_Orders_Restaurants_OrderRestaurantUserID",
                        column: x => x.OrderRestaurantUserID,
                        principalTable: "Restaurants",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "RestoComment",
                columns: table => new
                {
                    RestoCommentID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RestoCommentComent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RestoCommentRate = table.Column<int>(type: "int", nullable: false),
                    ClientUserID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    RestaurantUserID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestoComment", x => x.RestoCommentID);
                    table.ForeignKey(
                        name: "FK_RestoComment_Client_ClientUserID",
                        column: x => x.ClientUserID,
                        principalTable: "Client",
                        principalColumn: "UserID");
                    table.ForeignKey(
                        name: "FK_RestoComment_Restaurants_RestaurantUserID",
                        column: x => x.RestaurantUserID,
                        principalTable: "Restaurants",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Address_ClientUserID",
                table: "Address",
                column: "ClientUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Client_ClientUserID",
                table: "Client",
                column: "ClientUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Client_UserRegistreryTokenRegistreryTokenID",
                table: "Client",
                column: "UserRegistreryTokenRegistreryTokenID");

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryComment_ClientUserID",
                table: "DeliveryComment",
                column: "ClientUserID");

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryComment_DeliverymanUserID",
                table: "DeliveryComment",
                column: "DeliverymanUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Deliverymen_UserRegistreryTokenRegistreryTokenID",
                table: "Deliverymen",
                column: "UserRegistreryTokenRegistreryTokenID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OrderClientUserID",
                table: "Orders",
                column: "OrderClientUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OrderDeliveryAddressAddressID",
                table: "Orders",
                column: "OrderDeliveryAddressAddressID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OrderDeliverymanUserID",
                table: "Orders",
                column: "OrderDeliverymanUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OrderRestaurantUserID",
                table: "Orders",
                column: "OrderRestaurantUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Restaurants_RestaurantAddressAddressID",
                table: "Restaurants",
                column: "RestaurantAddressAddressID");

            migrationBuilder.CreateIndex(
                name: "IX_Restaurants_UserRegistreryTokenRegistreryTokenID",
                table: "Restaurants",
                column: "UserRegistreryTokenRegistreryTokenID");

            migrationBuilder.CreateIndex(
                name: "IX_RestoComment_ClientUserID",
                table: "RestoComment",
                column: "ClientUserID");

            migrationBuilder.CreateIndex(
                name: "IX_RestoComment_RestaurantUserID",
                table: "RestoComment",
                column: "RestaurantUserID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeliveryComment");

            migrationBuilder.DropTable(
                name: "Discounts");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "RestoComment");

            migrationBuilder.DropTable(
                name: "Deliverymen");

            migrationBuilder.DropTable(
                name: "Restaurants");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "RegistreryToken");
        }
    }
}
