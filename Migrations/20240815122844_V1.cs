using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ASP.NET_API.Migrations
{
    /// <inheritdoc />
    public partial class V1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductCategory",
                columns: table => new
                {
                    ProductCategoryID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategory", x => x.ProductCategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false),
                    StockQuantity = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_Product_ProductCategory_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "ProductCategory",
                        principalColumn: "ProductCategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleClaims_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    OrderID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalAmount = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_Order_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RefreshToken",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpiriedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshToken", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RefreshToken_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCart",
                columns: table => new
                {
                    ShoppingCartID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TotalAmount = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCart", x => x.ShoppingCartID);
                    table.ForeignKey(
                        name: "FK_ShoppingCart_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaims_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_UserLogins_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_UserTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WishList",
                columns: table => new
                {
                    WishListID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WishList", x => x.WishListID);
                    table.ForeignKey(
                        name: "FK_WishList_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    OrderID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => new { x.OrderID, x.ProductID });
                    table.ForeignKey(
                        name: "FK_OrderItems_Order_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Order",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    ShoppingCartID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => new { x.ProductID, x.ShoppingCartID });
                    table.ForeignKey(
                        name: "FK_CartItems_Product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartItems_ShoppingCart_ShoppingCartID",
                        column: x => x.ShoppingCartID,
                        principalTable: "ShoppingCart",
                        principalColumn: "ShoppingCartID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WishListItem",
                columns: table => new
                {
                    WishListID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WishListItem", x => new { x.ProductID, x.WishListID });
                    table.ForeignKey(
                        name: "FK_WishListItem_Product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WishListItem_WishList_WishListID",
                        column: x => x.WishListID,
                        principalTable: "WishList",
                        principalColumn: "WishListID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ProductCategory",
                columns: new[] { "ProductCategoryID", "CategoryName", "CategoryShortDescription" },
                values: new object[,]
                {
                    { new Guid("0be413f7-9034-49fc-abe3-d250e88db135"), "Quo.", "Sit modi dicta molestiae non atque est repellat aperiam non. Nam perferendis quis optio quia sed et aut. Molestiae illo consequatur at consequuntur." },
                    { new Guid("12e597b6-4a43-4727-b68a-5b0f5338198f"), "Non.", "Id quis nulla reprehenderit. Et autem sit consequatur asperiores. Molestiae ullam neque culpa. Delectus recusandae id." },
                    { new Guid("2f9f9268-5c93-49f7-b783-60477a681435"), "Omnis.", "Ea ipsa quasi at est esse aperiam vel mollitia. Id officiis explicabo est voluptates hic. Est sapiente corporis atque ratione sit eveniet laudantium ab. Provident temporibus aut iste magni. Non repellat tenetur velit ut est ut ea facilis saepe." },
                    { new Guid("5019949c-ca28-49c0-b78f-4edfab60d0db"), "Rerum.", "Ipsa est quasi. Sit temporibus perferendis ut molestiae tenetur adipisci aliquid. Quas quidem ab possimus eveniet fugit et repellat." },
                    { new Guid("58ea6f54-e71b-48c3-a6f6-82e192018995"), "Ipsam.", "Quo magni non iure. Sequi et vel totam placeat dolor corporis. Et qui corporis et. Dolorum qui eaque nulla doloremque nulla. Unde temporibus reprehenderit aliquam tempora temporibus odit omnis culpa expedita." },
                    { new Guid("9079d96a-ec4b-4979-b8eb-435d5ef53c60"), "Labore.", "Facere unde asperiores quod consequuntur aperiam et in. Laborum voluptatem perspiciatis velit sapiente. Eos possimus deserunt numquam et velit nisi. Temporibus laborum illum praesentium sapiente vero. Ullam quis occaecati aut. Corrupti itaque saepe ut." },
                    { new Guid("9b103844-3b33-405b-86b1-4f832f7bd370"), "Est.", "Est tenetur sed similique. Doloribus ut quo aliquam. Omnis ut architecto id aut et. Exercitationem sit minus est quod non labore debitis molestiae molestiae. Illo voluptate fuga excepturi et vel accusantium id iure distinctio. Aut enim dignissimos alias." },
                    { new Guid("b38e6c6d-013b-42ff-a5bc-ffc40f44e331"), "Omnis.", "Aut quidem iste molestiae incidunt quaerat quibusdam. Minima quaerat accusantium ipsum. Est quae et officia atque molestiae." },
                    { new Guid("b91e8ba3-a5b4-4278-b055-b6e1c8ef4b87"), "Iste.", "Est nemo non est animi et. Velit excepturi et voluptatem ullam. Velit et repellat repellendus nulla voluptas voluptatem ad. Impedit quis deleniti eius neque." },
                    { new Guid("ec4a965f-d2b3-4abe-b204-31a1673cfc53"), "Distinctio.", "Necessitatibus blanditiis eligendi ea asperiores deleniti sed. Iure odio voluptatem corrupti aperiam eos. Et et totam officiis et aperiam." }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "73de7301-0fdd-4b00-9501-6cf6a1f0b7d9", null, "Admin", "ADMIN" },
                    { "be5dd9f3-a8b6-4dc0-a54e-a7e554c935a5", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductID", "CategoryID", "CreatedDate", "Description", "ImageUrl", "Price", "ProductName", "StockQuantity" },
                values: new object[,]
                {
                    { new Guid("06f29673-ffe4-459d-a93d-a05cdbaa7ecf"), new Guid("ec4a965f-d2b3-4abe-b204-31a1673cfc53"), new DateTime(2024, 8, 15, 19, 28, 43, 442, DateTimeKind.Local).AddTicks(1092), "Sint fuga inventore voluptatem enim. Qui iusto veniam. Rerum et molestiae corporis dolore exercitationem minima nihil. Consequatur dolores eos exercitationem. Enim accusantium est voluptas vitae ipsam eveniet. Distinctio nesciunt iure et ut incidunt et.", "", 83167562, "Dicta.", 1058 },
                    { new Guid("089657ad-aca2-4063-bb61-55567ce9b8ef"), new Guid("58ea6f54-e71b-48c3-a6f6-82e192018995"), new DateTime(2024, 8, 15, 19, 28, 43, 442, DateTimeKind.Local).AddTicks(2280), "Animi soluta qui voluptates consectetur consequuntur odit corporis et. Nemo et animi architecto veritatis commodi error molestiae earum saepe. Commodi distinctio asperiores dolores praesentium accusamus aspernatur doloremque.", "", 74524844, "Quam.", 3461 },
                    { new Guid("0965cb87-dbbb-4a9b-bc2c-7c8de9d1e7c4"), new Guid("12e597b6-4a43-4727-b68a-5b0f5338198f"), new DateTime(2024, 8, 15, 19, 28, 43, 441, DateTimeKind.Local).AddTicks(9502), "Eaque corrupti aut animi qui ex quia natus voluptatem quis. Architecto ea qui iste quis labore porro omnis et. Velit soluta reiciendis rerum aut error. Commodi repellendus eius.", "", 76710518, "Corrupti.", 3134 },
                    { new Guid("0ab9abbe-f0a9-4f26-b3ae-9ab7771ce5b9"), new Guid("9079d96a-ec4b-4979-b8eb-435d5ef53c60"), new DateTime(2024, 8, 15, 19, 28, 43, 442, DateTimeKind.Local).AddTicks(1164), "Nesciunt est debitis molestiae. Eligendi eius et occaecati quo expedita sit unde aut dolore. Nobis aliquid ut assumenda vel.", "", 20683902, "Quos.", 1354 },
                    { new Guid("0cc28e4f-10ad-46a4-8a77-867b56615927"), new Guid("12e597b6-4a43-4727-b68a-5b0f5338198f"), new DateTime(2024, 8, 15, 19, 28, 43, 442, DateTimeKind.Local).AddTicks(2148), "Molestias est sint voluptate. Praesentium autem architecto repellendus tempora minus provident numquam. Animi praesentium ex eum officiis consequatur ipsam sed eaque. Sit harum explicabo consequatur facilis. Suscipit beatae dolorem omnis omnis laudantium repellat atque minus.", "", 84182394, "Quia.", 1305 },
                    { new Guid("1525e829-df3d-4d9d-9561-ba9b419f164c"), new Guid("9079d96a-ec4b-4979-b8eb-435d5ef53c60"), new DateTime(2024, 8, 15, 19, 28, 43, 442, DateTimeKind.Local).AddTicks(945), "Aut illo doloremque eaque quidem inventore dolorum exercitationem. Tenetur odio autem. Illum mollitia unde corrupti et. Nostrum vel dolor rerum distinctio. Omnis voluptas aut accusantium eaque dolor cum.", "", 29236123, "Cupiditate.", 4854 },
                    { new Guid("1840ebde-fea2-45ed-a719-7120ff26fbaf"), new Guid("ec4a965f-d2b3-4abe-b204-31a1673cfc53"), new DateTime(2024, 8, 15, 19, 28, 43, 442, DateTimeKind.Local).AddTicks(273), "Adipisci cupiditate quidem aut dicta. Totam rem corrupti aut. Quisquam voluptas quia. Nemo minus architecto. Perspiciatis aut officia assumenda velit perferendis corrupti nemo exercitationem.", "", 13344878, "Officiis.", 1072 },
                    { new Guid("32584661-7b84-4612-8041-fed23d5ac475"), new Guid("9079d96a-ec4b-4979-b8eb-435d5ef53c60"), new DateTime(2024, 8, 15, 19, 28, 43, 441, DateTimeKind.Local).AddTicks(9926), "Fugiat tempora dicta officia at error ut sint nemo fuga. Voluptates neque officiis molestiae nostrum sapiente aut aut expedita. Atque ullam quae sint dignissimos.", "", 85928953, "Et.", 3447 },
                    { new Guid("3ddab5c4-b3b1-4521-9069-cb054b099c61"), new Guid("5019949c-ca28-49c0-b78f-4edfab60d0db"), new DateTime(2024, 8, 15, 19, 28, 43, 442, DateTimeKind.Local).AddTicks(1682), "Sit quis aut in quaerat qui ipsam quae. Id dolorem maiores dolor minima soluta. Et et sit et nemo saepe cupiditate laboriosam officiis.", "", 59237929, "Ut.", 1318 },
                    { new Guid("424e008d-d3d4-4414-b2a2-6e30d86de161"), new Guid("9079d96a-ec4b-4979-b8eb-435d5ef53c60"), new DateTime(2024, 8, 15, 19, 28, 43, 441, DateTimeKind.Local).AddTicks(9332), "Eos ullam perferendis et rerum fuga commodi quod. Quis enim ducimus. Laborum sequi aliquam recusandae similique laudantium voluptatem. Ut qui praesentium perferendis excepturi. Nobis voluptas ducimus in impedit nihil.", "", 22213381, "Ab.", 4140 },
                    { new Guid("4658013f-b9c6-4abd-a00a-bc759da19d28"), new Guid("9b103844-3b33-405b-86b1-4f832f7bd370"), new DateTime(2024, 8, 15, 19, 28, 43, 441, DateTimeKind.Local).AddTicks(9100), "Molestiae ipsum eum nam quod eveniet dolore. Magni cum fuga est recusandae fugiat blanditiis. Enim mollitia vel quas atque molestiae quia labore. Expedita incidunt officia ut sint fugiat ipsum in dolor nihil. Minus architecto aspernatur officia id illum in. Unde optio accusantium in dignissimos culpa reprehenderit.", "", 75184307, "Aut.", 805 },
                    { new Guid("5329ff04-3f44-47aa-ab42-5c87226b2934"), new Guid("0be413f7-9034-49fc-abe3-d250e88db135"), new DateTime(2024, 8, 15, 19, 28, 43, 442, DateTimeKind.Local).AddTicks(404), "Quae dolorem impedit voluptatem autem mollitia reiciendis sequi. Accusamus consectetur eveniet dolores qui ut fuga nostrum aut sed. Nesciunt id facere modi. Mollitia itaque ipsum laboriosam ad at ratione dolores dolores consequuntur. Mollitia rem veniam nesciunt similique a et ut eius.", "", 11927421, "Tenetur.", 1763 },
                    { new Guid("54bb077f-a0a8-4a35-9d24-a889d3d7a895"), new Guid("0be413f7-9034-49fc-abe3-d250e88db135"), new DateTime(2024, 8, 15, 19, 28, 43, 442, DateTimeKind.Local).AddTicks(1506), "Nesciunt beatae non quas voluptatem reiciendis. Alias assumenda officiis ducimus sit. Culpa fugiat neque quia corrupti quia. Illo aut reprehenderit dolor. Iste rerum nostrum et id qui iusto. Qui est facere blanditiis nulla.", "", 11616105, "Pariatur.", 1855 },
                    { new Guid("679afb9d-19e8-4c68-81a0-251da50541bb"), new Guid("9079d96a-ec4b-4979-b8eb-435d5ef53c60"), new DateTime(2024, 8, 15, 19, 28, 43, 442, DateTimeKind.Local).AddTicks(1957), "Pariatur laudantium non libero voluptatem exercitationem. Ut aliquam cum voluptas ut. Repudiandae saepe molestiae corporis. Optio sed in provident magni saepe sunt molestias.", "", 64925573, "Aut.", 2402 },
                    { new Guid("70638512-ca68-468a-871b-072b5c6d57a6"), new Guid("b38e6c6d-013b-42ff-a5bc-ffc40f44e331"), new DateTime(2024, 8, 15, 19, 28, 43, 442, DateTimeKind.Local).AddTicks(1221), "Quibusdam suscipit sequi. Quis adipisci quis aut esse saepe. Dicta dolorum cum qui eos.", "", 32305068, "Mollitia.", 3661 },
                    { new Guid("7960dc1b-a5e2-497b-9050-80eefff475c8"), new Guid("12e597b6-4a43-4727-b68a-5b0f5338198f"), new DateTime(2024, 8, 15, 19, 28, 43, 441, DateTimeKind.Local).AddTicks(8826), "Natus rerum labore ut ea sed. Dolorem placeat eos assumenda aspernatur quisquam ut tempora. Ab odio exercitationem ex quo. Totam velit nemo et.", "", 64100814, "Enim.", 2431 },
                    { new Guid("7c083059-b390-4ed5-b0a3-e765bccc7296"), new Guid("ec4a965f-d2b3-4abe-b204-31a1673cfc53"), new DateTime(2024, 8, 15, 19, 28, 43, 442, DateTimeKind.Local).AddTicks(165), "Aliquid molestiae ipsa libero velit nihil expedita consequatur. Animi doloribus quod aut facilis nihil harum reprehenderit recusandae at. Labore nisi dolorem. Et labore est ut enim. Nulla dignissimos et nihil debitis nostrum et ut fuga iste.", "", 93285617, "Voluptatem.", 125 },
                    { new Guid("7e63546a-8ac6-403d-8b09-df40fd05fa2b"), new Guid("9079d96a-ec4b-4979-b8eb-435d5ef53c60"), new DateTime(2024, 8, 15, 19, 28, 43, 442, DateTimeKind.Local).AddTicks(581), "Quae quo in voluptatum odio velit corrupti enim adipisci distinctio. Illum distinctio perferendis ipsa omnis alias voluptas eligendi accusantium. Dolorem a dolorum sed tenetur at alias officiis dolore. Esse eum aliquid. Enim id distinctio nobis iusto aut velit sunt dolores.", "", 76092837, "Possimus.", 703 },
                    { new Guid("819e0079-69dd-4e5c-9ddf-b23c5badced3"), new Guid("58ea6f54-e71b-48c3-a6f6-82e192018995"), new DateTime(2024, 8, 15, 19, 28, 43, 441, DateTimeKind.Local).AddTicks(8621), "Quia autem aut esse nihil ut optio. Et quo velit sit qui cupiditate. Consequuntur earum sint nobis vel quia.", "", 54670017, "Corporis.", 3770 },
                    { new Guid("8260105f-f71e-4d41-b227-83cac6674919"), new Guid("12e597b6-4a43-4727-b68a-5b0f5338198f"), new DateTime(2024, 8, 15, 19, 28, 43, 442, DateTimeKind.Local).AddTicks(1353), "Unde cupiditate possimus occaecati sit nulla hic laboriosam. Eum recusandae facilis nihil qui consequatur ducimus quis eos voluptatem. Eum iure aliquid ut ut sunt autem quasi hic. Minima autem cumque dolores.", "", 78511471, "Nobis.", 3151 },
                    { new Guid("86c852ac-faf1-42bd-83fd-32e0d079298f"), new Guid("ec4a965f-d2b3-4abe-b204-31a1673cfc53"), new DateTime(2024, 8, 15, 19, 28, 43, 442, DateTimeKind.Local).AddTicks(12), "Ipsum voluptatem tempora eius distinctio sunt eaque quaerat officia. Qui rem est. Sed ipsum nisi.", "", 64096448, "Ex.", 2382 },
                    { new Guid("89263a97-8cee-4f9a-b050-e325aeb789eb"), new Guid("12e597b6-4a43-4727-b68a-5b0f5338198f"), new DateTime(2024, 8, 15, 19, 28, 43, 442, DateTimeKind.Local).AddTicks(1574), "Id explicabo tenetur. Corporis dolorum blanditiis. Tempore fuga iure minima. Voluptatem tenetur deserunt doloremque delectus velit aperiam illo.", "", 915736, "Autem.", 4531 },
                    { new Guid("94add515-3e71-4da8-8d0d-50d78fca5f63"), new Guid("12e597b6-4a43-4727-b68a-5b0f5338198f"), new DateTime(2024, 8, 15, 19, 28, 43, 442, DateTimeKind.Local).AddTicks(1769), "Voluptatem modi repudiandae consequuntur voluptas. Modi consequuntur eligendi quis aut dolores doloribus quia reiciendis. Facere quis dolore.", "", 25513313, "Est.", 868 },
                    { new Guid("b6ee1cb4-7537-43ae-899e-ce599030adc3"), new Guid("2f9f9268-5c93-49f7-b783-60477a681435"), new DateTime(2024, 8, 15, 19, 28, 43, 442, DateTimeKind.Local).AddTicks(802), "Repudiandae dolorum id laudantium vero. Sapiente ut dolorem. Saepe omnis aliquid ut dolore officia iusto. Iure velit aut et aut qui sint quis sequi nobis. Ducimus suscipit aut necessitatibus consequatur sunt atque deleniti.", "", 41249832, "Nisi.", 4596 },
                    { new Guid("b9b94eaf-0bb0-4a9a-8b37-1e189f148575"), new Guid("12e597b6-4a43-4727-b68a-5b0f5338198f"), new DateTime(2024, 8, 15, 19, 28, 43, 442, DateTimeKind.Local).AddTicks(2444), "Tenetur ad ut blanditiis quo tempora omnis libero. Qui vel in velit libero voluptatum optio consectetur. Minima ratione labore sit eum est. Quaerat aut ad possimus quia cupiditate dolor vitae. Aut sunt distinctio aut incidunt.", "", 66516074, "Accusamus.", 4381 },
                    { new Guid("bcc176e3-3a9c-4a76-92f6-a46a9c44c47f"), new Guid("b38e6c6d-013b-42ff-a5bc-ffc40f44e331"), new DateTime(2024, 8, 15, 19, 28, 43, 441, DateTimeKind.Local).AddTicks(8899), "Quis temporibus dolores assumenda. Quod voluptas atque pariatur ex nihil voluptatem. Quam sapiente velit eveniet.", "", 28295692, "Dolorum.", 3513 },
                    { new Guid("ca580b4f-d42e-4c52-81cb-51160a83086f"), new Guid("5019949c-ca28-49c0-b78f-4edfab60d0db"), new DateTime(2024, 8, 15, 19, 28, 43, 442, DateTimeKind.Local).AddTicks(695), "Aliquid non veritatis atque aut. Debitis omnis enim corrupti. Atque qui hic culpa reprehenderit maiores nemo.", "", 20813613, "Rerum.", 3656 },
                    { new Guid("cfd0e836-9a5d-45a5-b6a1-7c0ede9a4866"), new Guid("ec4a965f-d2b3-4abe-b204-31a1673cfc53"), new DateTime(2024, 8, 15, 19, 28, 43, 441, DateTimeKind.Local).AddTicks(9716), "Corporis voluptas aut consequatur hic ad. Recusandae autem eaque quia accusamus. Officia eius recusandae in cupiditate quo consequatur ut a nulla. Sit adipisci commodi voluptatem veritatis ducimus maxime nesciunt saepe. Recusandae hic ducimus aspernatur deleniti et commodi ipsa ut.", "", 93376144, "Molestiae.", 2198 },
                    { new Guid("e17dd0e4-c2e1-40a6-a74a-11dd61737364"), new Guid("9079d96a-ec4b-4979-b8eb-435d5ef53c60"), new DateTime(2024, 8, 15, 19, 28, 43, 441, DateTimeKind.Local).AddTicks(9194), "Deserunt omnis dicta nam distinctio consectetur non nulla blanditiis voluptas. Magni vero ut ut et tempora ut nam pariatur. Est consectetur et et ratione voluptas non.", "", 8163043, "Consequuntur.", 40 },
                    { new Guid("e662cfa0-7936-4b8c-bb79-bd3bf125084b"), new Guid("58ea6f54-e71b-48c3-a6f6-82e192018995"), new DateTime(2024, 8, 15, 19, 28, 43, 442, DateTimeKind.Local).AddTicks(2553), "Veritatis praesentium molestiae omnis quae. Nemo officia consequatur quos recusandae ducimus. Est blanditiis eius quas. Qui non doloremque ipsam et iste iure eaque eius et. Enim perspiciatis perferendis quis qui libero et.", "", 58001584, "Consequatur.", 3606 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_ShoppingCartID",
                table: "CartItems",
                column: "ShoppingCartID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_UserID",
                table: "Order",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductID",
                table: "OrderItems",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryID",
                table: "Product",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_RefreshToken_UserId",
                table: "RefreshToken",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaims_RoleId",
                table: "RoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Roles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCart_UserID",
                table: "ShoppingCart",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                table: "UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogins_UserId",
                table: "UserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "Users",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Users",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_WishList_UserID",
                table: "WishList",
                column: "UserID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WishListItem_WishListID",
                table: "WishListItem",
                column: "WishListID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "RefreshToken");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "WishListItem");

            migrationBuilder.DropTable(
                name: "ShoppingCart");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "WishList");

            migrationBuilder.DropTable(
                name: "ProductCategory");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
