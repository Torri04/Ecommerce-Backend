using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ASP.NET_API.Migrations
{
    /// <inheritdoc />
    public partial class V3_Review : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("01abbe6a-33ab-48d5-8c30-1ea84416daf9"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("038d6f6e-c7cd-496f-83ee-fe64b14d14ef"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("05312102-6017-427e-9cee-862a22d79dfe"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("0a31dea2-8d30-409e-9a9f-97bdbabd59cf"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("0c394d7b-003b-4beb-83b7-341e25fe8c5c"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("0f6f980f-c21f-4b7f-88b8-3c396c6fbd3d"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("276a5cc1-8f97-4c5b-93ee-a5689a74caf3"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("2845c8bf-f5ec-4126-8c16-c2c923a48b5f"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("2c76a600-80b3-42dd-aca4-b4ab01e8205a"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("34da1381-8816-486b-b075-658a8a83320b"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("362dc833-cf86-411e-9abc-32aaa7921605"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("3c43b592-fceb-487c-a75d-8534b54b632e"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("462fd85c-4cab-4f2a-ab6c-7cea4f24ae0c"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("4af6d062-e1df-4aa6-ab84-cb4b37e3ed38"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("4e00cd20-0bfd-4423-bc83-427af55380f4"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("53f212b4-53aa-48f6-81ed-7b9614ea5cae"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("75aca798-feef-4b0d-9238-a996d9c1a3ab"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("8ca0c4ec-02a0-41bc-bfef-8f63f9ace209"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("94f6c907-1ce5-4a64-86cb-525138d4c4c8"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("9f70fb2d-d2bf-456c-aca4-3df2b6f2d22d"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("a963b1fa-4433-46c8-9d06-116c15a2b0b5"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("b16ca563-aaa3-4db0-ac1e-58e4f94b62fe"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("b5404bc0-bc1f-4c33-998f-10bc30073ab1"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("bb71481e-50af-47a7-892f-46e585af0f40"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("c4a67c39-f78d-4889-9794-e2135faa2ee3"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("d2120511-5bf0-4998-9a9e-125f8d30e2d4"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("dfb572e3-39d2-4403-9bea-3848689c7a24"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("f2813df2-4f89-450c-a9f8-f6d5b4353b2d"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("f75164d3-7d09-49b1-8cc8-3d2dde851eec"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("fa2365a9-e4db-45f7-a6b5-49cc22f25bbe"));

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "ProductCategoryID",
                keyValue: new Guid("792ed138-e4f8-4380-a1a7-6e919e07531a"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1fa5e729-c343-4ba8-bb4f-5e2afa471ec9");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "366c6114-3780-4809-ac37-7794fae1739d");

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "ProductCategoryID",
                keyValue: new Guid("28c01bb3-8036-4504-896b-9a83549a16d0"));

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "ProductCategoryID",
                keyValue: new Guid("28f265f7-88fb-470d-ae90-896603c6f8c5"));

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "ProductCategoryID",
                keyValue: new Guid("5f6e3a22-81f8-459d-ac68-627dad231944"));

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "ProductCategoryID",
                keyValue: new Guid("65fb0b23-a434-4815-8940-e8540be14705"));

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "ProductCategoryID",
                keyValue: new Guid("6b4b9a42-1733-4014-8d08-09daa2796667"));

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "ProductCategoryID",
                keyValue: new Guid("add1e4ee-b3b3-4eaa-b534-06717ff1e394"));

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "ProductCategoryID",
                keyValue: new Guid("e2885722-f8d8-4f0f-bc01-c6b41ae072da"));

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "ProductCategoryID",
                keyValue: new Guid("ebc9ab56-4b8c-42e9-a65d-09475beb186a"));

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "ProductCategoryID",
                keyValue: new Guid("ed58e921-0a18-4836-80d6-c4b83c9c68f6"));

            migrationBuilder.CreateTable(
                name: "Review",
                columns: table => new
                {
                    ProductID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ReviewText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review", x => new { x.ProductID, x.UserID });
                    table.ForeignKey(
                        name: "FK_Review_Product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Review_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ProductCategory",
                columns: new[] { "ProductCategoryID", "CategoryName", "CategoryShortDescription" },
                values: new object[,]
                {
                    { new Guid("1296ebe7-33d9-413a-aad8-f4a54bdd7f9c"), "Est.", "Est tenetur sed similique. Doloribus ut quo aliquam. Omnis ut architecto id aut et. Exercitationem sit minus est quod non labore debitis molestiae molestiae. Illo voluptate fuga excepturi et vel accusantium id iure distinctio. Aut enim dignissimos alias." },
                    { new Guid("173dcb51-0414-4c5d-93a7-aacce2288723"), "Omnis.", "Ea ipsa quasi at est esse aperiam vel mollitia. Id officiis explicabo est voluptates hic. Est sapiente corporis atque ratione sit eveniet laudantium ab. Provident temporibus aut iste magni. Non repellat tenetur velit ut est ut ea facilis saepe." },
                    { new Guid("4409e5cf-13dd-41cb-b473-e9e366881719"), "Non.", "Id quis nulla reprehenderit. Et autem sit consequatur asperiores. Molestiae ullam neque culpa. Delectus recusandae id." },
                    { new Guid("5a0d4b75-2160-4d95-a434-39245db3a41c"), "Ipsam.", "Quo magni non iure. Sequi et vel totam placeat dolor corporis. Et qui corporis et. Dolorum qui eaque nulla doloremque nulla. Unde temporibus reprehenderit aliquam tempora temporibus odit omnis culpa expedita." },
                    { new Guid("78759717-9dba-4049-b6e5-9a80da949261"), "Quo.", "Sit modi dicta molestiae non atque est repellat aperiam non. Nam perferendis quis optio quia sed et aut. Molestiae illo consequatur at consequuntur." },
                    { new Guid("7936354c-3239-405f-b3ee-d191be12217c"), "Omnis.", "Aut quidem iste molestiae incidunt quaerat quibusdam. Minima quaerat accusantium ipsum. Est quae et officia atque molestiae." },
                    { new Guid("947b71de-c453-458d-bd1e-ca0365796bd6"), "Rerum.", "Ipsa est quasi. Sit temporibus perferendis ut molestiae tenetur adipisci aliquid. Quas quidem ab possimus eveniet fugit et repellat." },
                    { new Guid("9cbf0d49-d63d-4b87-b509-4796c812b1ef"), "Distinctio.", "Necessitatibus blanditiis eligendi ea asperiores deleniti sed. Iure odio voluptatem corrupti aperiam eos. Et et totam officiis et aperiam." },
                    { new Guid("a7b2ca88-a3de-4eb6-a66b-a26f9abc739b"), "Iste.", "Est nemo non est animi et. Velit excepturi et voluptatem ullam. Velit et repellat repellendus nulla voluptas voluptatem ad. Impedit quis deleniti eius neque." },
                    { new Guid("cedc9540-fe93-4787-b87e-bd56b41b0b3b"), "Labore.", "Facere unde asperiores quod consequuntur aperiam et in. Laborum voluptatem perspiciatis velit sapiente. Eos possimus deserunt numquam et velit nisi. Temporibus laborum illum praesentium sapiente vero. Ullam quis occaecati aut. Corrupti itaque saepe ut." }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b6554688-c0d6-4c5e-86ba-377c6825e779", null, "Admin", "ADMIN" },
                    { "c4e83942-f377-4911-b82d-d0a8ce38b255", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductID", "CategoryID", "CreatedDate", "Description", "ImageUrl", "Price", "ProductName", "StockQuantity" },
                values: new object[,]
                {
                    { new Guid("039f327a-a646-47ef-bf3c-9f3b71ef0227"), new Guid("cedc9540-fe93-4787-b87e-bd56b41b0b3b"), new DateTime(2024, 8, 16, 13, 36, 22, 998, DateTimeKind.Local).AddTicks(5934), "Fugiat tempora dicta officia at error ut sint nemo fuga. Voluptates neque officiis molestiae nostrum sapiente aut aut expedita. Atque ullam quae sint dignissimos.", "", 85928953, "Et.", 3447 },
                    { new Guid("04196b9a-65e2-430c-8341-fe6a44c97b91"), new Guid("cedc9540-fe93-4787-b87e-bd56b41b0b3b"), new DateTime(2024, 8, 16, 13, 36, 22, 999, DateTimeKind.Local).AddTicks(1109), "Pariatur laudantium non libero voluptatem exercitationem. Ut aliquam cum voluptas ut. Repudiandae saepe molestiae corporis. Optio sed in provident magni saepe sunt molestias.", "", 64925573, "Aut.", 2402 },
                    { new Guid("04edec7e-45ab-463c-9a38-5b123b4112bb"), new Guid("4409e5cf-13dd-41cb-b473-e9e366881719"), new DateTime(2024, 8, 16, 13, 36, 22, 998, DateTimeKind.Local).AddTicks(4214), "Natus rerum labore ut ea sed. Dolorem placeat eos assumenda aspernatur quisquam ut tempora. Ab odio exercitationem ex quo. Totam velit nemo et.", "", 64100814, "Enim.", 2431 },
                    { new Guid("0576e44c-5474-457f-935c-2aa54da3d9c0"), new Guid("9cbf0d49-d63d-4b87-b509-4796c812b1ef"), new DateTime(2024, 8, 16, 13, 36, 22, 998, DateTimeKind.Local).AddTicks(5698), "Corporis voluptas aut consequatur hic ad. Recusandae autem eaque quia accusamus. Officia eius recusandae in cupiditate quo consequatur ut a nulla. Sit adipisci commodi voluptatem veritatis ducimus maxime nesciunt saepe. Recusandae hic ducimus aspernatur deleniti et commodi ipsa ut.", "", 93376144, "Molestiae.", 2198 },
                    { new Guid("06e0c722-4a5e-443e-9d38-e8a6cf303690"), new Guid("4409e5cf-13dd-41cb-b473-e9e366881719"), new DateTime(2024, 8, 16, 13, 36, 22, 998, DateTimeKind.Local).AddTicks(5429), "Eaque corrupti aut animi qui ex quia natus voluptatem quis. Architecto ea qui iste quis labore porro omnis et. Velit soluta reiciendis rerum aut error. Commodi repellendus eius.", "", 76710518, "Corrupti.", 3134 },
                    { new Guid("1b8e2d59-0be4-406f-a7af-3056417c1eba"), new Guid("947b71de-c453-458d-bd1e-ca0365796bd6"), new DateTime(2024, 8, 16, 13, 36, 22, 999, DateTimeKind.Local).AddTicks(752), "Sit quis aut in quaerat qui ipsam quae. Id dolorem maiores dolor minima soluta. Et et sit et nemo saepe cupiditate laboriosam officiis.", "", 59237929, "Ut.", 1318 },
                    { new Guid("2ac00c20-3855-4f8f-aac8-5412c0b70c0e"), new Guid("cedc9540-fe93-4787-b87e-bd56b41b0b3b"), new DateTime(2024, 8, 16, 13, 36, 22, 998, DateTimeKind.Local).AddTicks(7138), "Quae quo in voluptatum odio velit corrupti enim adipisci distinctio. Illum distinctio perferendis ipsa omnis alias voluptas eligendi accusantium. Dolorem a dolorum sed tenetur at alias officiis dolore. Esse eum aliquid. Enim id distinctio nobis iusto aut velit sunt dolores.", "", 76092837, "Possimus.", 703 },
                    { new Guid("2b9af6dc-c511-461b-839c-8d7142e17b58"), new Guid("1296ebe7-33d9-413a-aad8-f4a54bdd7f9c"), new DateTime(2024, 8, 16, 13, 36, 22, 998, DateTimeKind.Local).AddTicks(4725), "Molestiae ipsum eum nam quod eveniet dolore. Magni cum fuga est recusandae fugiat blanditiis. Enim mollitia vel quas atque molestiae quia labore. Expedita incidunt officia ut sint fugiat ipsum in dolor nihil. Minus architecto aspernatur officia id illum in. Unde optio accusantium in dignissimos culpa reprehenderit.", "", 75184307, "Aut.", 805 },
                    { new Guid("31ee0376-41c4-4bf8-b1f0-5b40d4ff892e"), new Guid("9cbf0d49-d63d-4b87-b509-4796c812b1ef"), new DateTime(2024, 8, 16, 13, 36, 22, 998, DateTimeKind.Local).AddTicks(9561), "Sint fuga inventore voluptatem enim. Qui iusto veniam. Rerum et molestiae corporis dolore exercitationem minima nihil. Consequatur dolores eos exercitationem. Enim accusantium est voluptas vitae ipsam eveniet. Distinctio nesciunt iure et ut incidunt et.", "", 83167562, "Dicta.", 1058 },
                    { new Guid("36e4a593-1803-493a-845a-45d3317bc51e"), new Guid("cedc9540-fe93-4787-b87e-bd56b41b0b3b"), new DateTime(2024, 8, 16, 13, 36, 22, 998, DateTimeKind.Local).AddTicks(9780), "Nesciunt est debitis molestiae. Eligendi eius et occaecati quo expedita sit unde aut dolore. Nobis aliquid ut assumenda vel.", "", 20683902, "Quos.", 1354 },
                    { new Guid("3abe9171-49ee-4f79-9e37-f266ea0f5e61"), new Guid("cedc9540-fe93-4787-b87e-bd56b41b0b3b"), new DateTime(2024, 8, 16, 13, 36, 22, 998, DateTimeKind.Local).AddTicks(5165), "Eos ullam perferendis et rerum fuga commodi quod. Quis enim ducimus. Laborum sequi aliquam recusandae similique laudantium voluptatem. Ut qui praesentium perferendis excepturi. Nobis voluptas ducimus in impedit nihil.", "", 22213381, "Ab.", 4140 },
                    { new Guid("4499595c-da29-4643-bd8e-ed1cc6cec6d6"), new Guid("947b71de-c453-458d-bd1e-ca0365796bd6"), new DateTime(2024, 8, 16, 13, 36, 22, 998, DateTimeKind.Local).AddTicks(7254), "Aliquid non veritatis atque aut. Debitis omnis enim corrupti. Atque qui hic culpa reprehenderit maiores nemo.", "", 20813613, "Rerum.", 3656 },
                    { new Guid("4b7da03a-2fb3-461d-a5ce-5df7c02abc74"), new Guid("5a0d4b75-2160-4d95-a434-39245db3a41c"), new DateTime(2024, 8, 16, 13, 36, 22, 999, DateTimeKind.Local).AddTicks(1641), "Animi soluta qui voluptates consectetur consequuntur odit corporis et. Nemo et animi architecto veritatis commodi error molestiae earum saepe. Commodi distinctio asperiores dolores praesentium accusamus aspernatur doloremque.", "", 74524844, "Quam.", 3461 },
                    { new Guid("4fc4a579-023f-4652-8397-1ef3a45a2771"), new Guid("9cbf0d49-d63d-4b87-b509-4796c812b1ef"), new DateTime(2024, 8, 16, 13, 36, 22, 998, DateTimeKind.Local).AddTicks(6359), "Aliquid molestiae ipsa libero velit nihil expedita consequatur. Animi doloribus quod aut facilis nihil harum reprehenderit recusandae at. Labore nisi dolorem. Et labore est ut enim. Nulla dignissimos et nihil debitis nostrum et ut fuga iste.", "", 93285617, "Voluptatem.", 125 },
                    { new Guid("5361586b-de3f-43e5-9912-3e8de094bf7e"), new Guid("5a0d4b75-2160-4d95-a434-39245db3a41c"), new DateTime(2024, 8, 16, 13, 36, 22, 998, DateTimeKind.Local).AddTicks(3928), "Quia autem aut esse nihil ut optio. Et quo velit sit qui cupiditate. Consequuntur earum sint nobis vel quia.", "", 54670017, "Corporis.", 3770 },
                    { new Guid("5514a92c-9d17-4e10-89ce-d2f38ac0e911"), new Guid("9cbf0d49-d63d-4b87-b509-4796c812b1ef"), new DateTime(2024, 8, 16, 13, 36, 22, 998, DateTimeKind.Local).AddTicks(6068), "Ipsum voluptatem tempora eius distinctio sunt eaque quaerat officia. Qui rem est. Sed ipsum nisi.", "", 64096448, "Ex.", 2382 },
                    { new Guid("57176eee-be71-485f-878e-39cc2f6cb810"), new Guid("cedc9540-fe93-4787-b87e-bd56b41b0b3b"), new DateTime(2024, 8, 16, 13, 36, 22, 998, DateTimeKind.Local).AddTicks(4923), "Deserunt omnis dicta nam distinctio consectetur non nulla blanditiis voluptas. Magni vero ut ut et tempora ut nam pariatur. Est consectetur et et ratione voluptas non.", "", 8163043, "Consequuntur.", 40 },
                    { new Guid("626ebf9a-7351-469c-b548-eb376b455277"), new Guid("7936354c-3239-405f-b3ee-d191be12217c"), new DateTime(2024, 8, 16, 13, 36, 22, 998, DateTimeKind.Local).AddTicks(4339), "Quis temporibus dolores assumenda. Quod voluptas atque pariatur ex nihil voluptatem. Quam sapiente velit eveniet.", "", 28295692, "Dolorum.", 3513 },
                    { new Guid("7aef6851-5ad9-4440-8825-84e1676d0c40"), new Guid("78759717-9dba-4049-b6e5-9a80da949261"), new DateTime(2024, 8, 16, 13, 36, 22, 998, DateTimeKind.Local).AddTicks(6841), "Quae dolorem impedit voluptatem autem mollitia reiciendis sequi. Accusamus consectetur eveniet dolores qui ut fuga nostrum aut sed. Nesciunt id facere modi. Mollitia itaque ipsum laboriosam ad at ratione dolores dolores consequuntur. Mollitia rem veniam nesciunt similique a et ut eius.", "", 11927421, "Tenetur.", 1763 },
                    { new Guid("7ce30486-05b9-48ef-844d-e7fd81eb3f52"), new Guid("78759717-9dba-4049-b6e5-9a80da949261"), new DateTime(2024, 8, 16, 13, 36, 22, 999, DateTimeKind.Local).AddTicks(517), "Nesciunt beatae non quas voluptatem reiciendis. Alias assumenda officiis ducimus sit. Culpa fugiat neque quia corrupti quia. Illo aut reprehenderit dolor. Iste rerum nostrum et id qui iusto. Qui est facere blanditiis nulla.", "", 11616105, "Pariatur.", 1855 },
                    { new Guid("83974e38-306d-4812-9871-ebf85069bb38"), new Guid("4409e5cf-13dd-41cb-b473-e9e366881719"), new DateTime(2024, 8, 16, 13, 36, 22, 999, DateTimeKind.Local).AddTicks(1785), "Tenetur ad ut blanditiis quo tempora omnis libero. Qui vel in velit libero voluptatum optio consectetur. Minima ratione labore sit eum est. Quaerat aut ad possimus quia cupiditate dolor vitae. Aut sunt distinctio aut incidunt.", "", 66516074, "Accusamus.", 4381 },
                    { new Guid("95f7988b-f1b7-4349-9a34-cbfacaf0e6f7"), new Guid("7936354c-3239-405f-b3ee-d191be12217c"), new DateTime(2024, 8, 16, 13, 36, 22, 998, DateTimeKind.Local).AddTicks(9933), "Quibusdam suscipit sequi. Quis adipisci quis aut esse saepe. Dicta dolorum cum qui eos.", "", 32305068, "Mollitia.", 3661 },
                    { new Guid("97e1370b-224c-4dc8-98a3-2e93a0738fed"), new Guid("5a0d4b75-2160-4d95-a434-39245db3a41c"), new DateTime(2024, 8, 16, 13, 36, 22, 999, DateTimeKind.Local).AddTicks(1973), "Veritatis praesentium molestiae omnis quae. Nemo officia consequatur quos recusandae ducimus. Est blanditiis eius quas. Qui non doloremque ipsam et iste iure eaque eius et. Enim perspiciatis perferendis quis qui libero et.", "", 58001584, "Consequatur.", 3606 },
                    { new Guid("afdc2fcf-061e-4bf6-a5a6-1cbf7592412c"), new Guid("4409e5cf-13dd-41cb-b473-e9e366881719"), new DateTime(2024, 8, 16, 13, 36, 22, 999, DateTimeKind.Local).AddTicks(170), "Unde cupiditate possimus occaecati sit nulla hic laboriosam. Eum recusandae facilis nihil qui consequatur ducimus quis eos voluptatem. Eum iure aliquid ut ut sunt autem quasi hic. Minima autem cumque dolores.", "", 78511471, "Nobis.", 3151 },
                    { new Guid("b02ad131-f3ca-447b-8de9-683f0af7d83d"), new Guid("4409e5cf-13dd-41cb-b473-e9e366881719"), new DateTime(2024, 8, 16, 13, 36, 22, 999, DateTimeKind.Local).AddTicks(935), "Voluptatem modi repudiandae consequuntur voluptas. Modi consequuntur eligendi quis aut dolores doloribus quia reiciendis. Facere quis dolore.", "", 25513313, "Est.", 868 },
                    { new Guid("baaa95a6-fb7f-456e-b900-0ab942c106c6"), new Guid("cedc9540-fe93-4787-b87e-bd56b41b0b3b"), new DateTime(2024, 8, 16, 13, 36, 22, 998, DateTimeKind.Local).AddTicks(9174), "Aut illo doloremque eaque quidem inventore dolorum exercitationem. Tenetur odio autem. Illum mollitia unde corrupti et. Nostrum vel dolor rerum distinctio. Omnis voluptas aut accusantium eaque dolor cum.", "", 29236123, "Cupiditate.", 4854 },
                    { new Guid("d7b9db9f-0e39-4bb5-a32c-71751bcffeb7"), new Guid("4409e5cf-13dd-41cb-b473-e9e366881719"), new DateTime(2024, 8, 16, 13, 36, 22, 999, DateTimeKind.Local).AddTicks(634), "Id explicabo tenetur. Corporis dolorum blanditiis. Tempore fuga iure minima. Voluptatem tenetur deserunt doloremque delectus velit aperiam illo.", "", 915736, "Autem.", 4531 },
                    { new Guid("f9cccebd-1416-46d9-bcae-8d72ff8a3040"), new Guid("9cbf0d49-d63d-4b87-b509-4796c812b1ef"), new DateTime(2024, 8, 16, 13, 36, 22, 998, DateTimeKind.Local).AddTicks(6546), "Adipisci cupiditate quidem aut dicta. Totam rem corrupti aut. Quisquam voluptas quia. Nemo minus architecto. Perspiciatis aut officia assumenda velit perferendis corrupti nemo exercitationem.", "", 13344878, "Officiis.", 1072 },
                    { new Guid("fb4a8288-6d0f-40d5-9843-f1ad82c40c73"), new Guid("173dcb51-0414-4c5d-93a7-aacce2288723"), new DateTime(2024, 8, 16, 13, 36, 22, 998, DateTimeKind.Local).AddTicks(8246), "Repudiandae dolorum id laudantium vero. Sapiente ut dolorem. Saepe omnis aliquid ut dolore officia iusto. Iure velit aut et aut qui sint quis sequi nobis. Ducimus suscipit aut necessitatibus consequatur sunt atque deleniti.", "", 41249832, "Nisi.", 4596 },
                    { new Guid("fec9bbd9-d8b7-4b0c-bd91-e0305a5c4f4a"), new Guid("4409e5cf-13dd-41cb-b473-e9e366881719"), new DateTime(2024, 8, 16, 13, 36, 22, 999, DateTimeKind.Local).AddTicks(1376), "Molestias est sint voluptate. Praesentium autem architecto repellendus tempora minus provident numquam. Animi praesentium ex eum officiis consequatur ipsam sed eaque. Sit harum explicabo consequatur facilis. Suscipit beatae dolorem omnis omnis laudantium repellat atque minus.", "", 84182394, "Quia.", 1305 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Review_UserID",
                table: "Review",
                column: "UserID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Review");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("039f327a-a646-47ef-bf3c-9f3b71ef0227"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("04196b9a-65e2-430c-8341-fe6a44c97b91"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("04edec7e-45ab-463c-9a38-5b123b4112bb"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("0576e44c-5474-457f-935c-2aa54da3d9c0"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("06e0c722-4a5e-443e-9d38-e8a6cf303690"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("1b8e2d59-0be4-406f-a7af-3056417c1eba"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("2ac00c20-3855-4f8f-aac8-5412c0b70c0e"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("2b9af6dc-c511-461b-839c-8d7142e17b58"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("31ee0376-41c4-4bf8-b1f0-5b40d4ff892e"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("36e4a593-1803-493a-845a-45d3317bc51e"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("3abe9171-49ee-4f79-9e37-f266ea0f5e61"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("4499595c-da29-4643-bd8e-ed1cc6cec6d6"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("4b7da03a-2fb3-461d-a5ce-5df7c02abc74"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("4fc4a579-023f-4652-8397-1ef3a45a2771"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("5361586b-de3f-43e5-9912-3e8de094bf7e"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("5514a92c-9d17-4e10-89ce-d2f38ac0e911"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("57176eee-be71-485f-878e-39cc2f6cb810"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("626ebf9a-7351-469c-b548-eb376b455277"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("7aef6851-5ad9-4440-8825-84e1676d0c40"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("7ce30486-05b9-48ef-844d-e7fd81eb3f52"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("83974e38-306d-4812-9871-ebf85069bb38"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("95f7988b-f1b7-4349-9a34-cbfacaf0e6f7"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("97e1370b-224c-4dc8-98a3-2e93a0738fed"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("afdc2fcf-061e-4bf6-a5a6-1cbf7592412c"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("b02ad131-f3ca-447b-8de9-683f0af7d83d"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("baaa95a6-fb7f-456e-b900-0ab942c106c6"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("d7b9db9f-0e39-4bb5-a32c-71751bcffeb7"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("f9cccebd-1416-46d9-bcae-8d72ff8a3040"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("fb4a8288-6d0f-40d5-9843-f1ad82c40c73"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("fec9bbd9-d8b7-4b0c-bd91-e0305a5c4f4a"));

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "ProductCategoryID",
                keyValue: new Guid("a7b2ca88-a3de-4eb6-a66b-a26f9abc739b"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "b6554688-c0d6-4c5e-86ba-377c6825e779");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "c4e83942-f377-4911-b82d-d0a8ce38b255");

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "ProductCategoryID",
                keyValue: new Guid("1296ebe7-33d9-413a-aad8-f4a54bdd7f9c"));

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "ProductCategoryID",
                keyValue: new Guid("173dcb51-0414-4c5d-93a7-aacce2288723"));

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "ProductCategoryID",
                keyValue: new Guid("4409e5cf-13dd-41cb-b473-e9e366881719"));

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "ProductCategoryID",
                keyValue: new Guid("5a0d4b75-2160-4d95-a434-39245db3a41c"));

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "ProductCategoryID",
                keyValue: new Guid("78759717-9dba-4049-b6e5-9a80da949261"));

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "ProductCategoryID",
                keyValue: new Guid("7936354c-3239-405f-b3ee-d191be12217c"));

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "ProductCategoryID",
                keyValue: new Guid("947b71de-c453-458d-bd1e-ca0365796bd6"));

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "ProductCategoryID",
                keyValue: new Guid("9cbf0d49-d63d-4b87-b509-4796c812b1ef"));

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "ProductCategoryID",
                keyValue: new Guid("cedc9540-fe93-4787-b87e-bd56b41b0b3b"));

            migrationBuilder.InsertData(
                table: "ProductCategory",
                columns: new[] { "ProductCategoryID", "CategoryName", "CategoryShortDescription" },
                values: new object[,]
                {
                    { new Guid("28c01bb3-8036-4504-896b-9a83549a16d0"), "Non.", "Id quis nulla reprehenderit. Et autem sit consequatur asperiores. Molestiae ullam neque culpa. Delectus recusandae id." },
                    { new Guid("28f265f7-88fb-470d-ae90-896603c6f8c5"), "Distinctio.", "Necessitatibus blanditiis eligendi ea asperiores deleniti sed. Iure odio voluptatem corrupti aperiam eos. Et et totam officiis et aperiam." },
                    { new Guid("5f6e3a22-81f8-459d-ac68-627dad231944"), "Omnis.", "Aut quidem iste molestiae incidunt quaerat quibusdam. Minima quaerat accusantium ipsum. Est quae et officia atque molestiae." },
                    { new Guid("65fb0b23-a434-4815-8940-e8540be14705"), "Labore.", "Facere unde asperiores quod consequuntur aperiam et in. Laborum voluptatem perspiciatis velit sapiente. Eos possimus deserunt numquam et velit nisi. Temporibus laborum illum praesentium sapiente vero. Ullam quis occaecati aut. Corrupti itaque saepe ut." },
                    { new Guid("6b4b9a42-1733-4014-8d08-09daa2796667"), "Omnis.", "Ea ipsa quasi at est esse aperiam vel mollitia. Id officiis explicabo est voluptates hic. Est sapiente corporis atque ratione sit eveniet laudantium ab. Provident temporibus aut iste magni. Non repellat tenetur velit ut est ut ea facilis saepe." },
                    { new Guid("792ed138-e4f8-4380-a1a7-6e919e07531a"), "Iste.", "Est nemo non est animi et. Velit excepturi et voluptatem ullam. Velit et repellat repellendus nulla voluptas voluptatem ad. Impedit quis deleniti eius neque." },
                    { new Guid("add1e4ee-b3b3-4eaa-b534-06717ff1e394"), "Quo.", "Sit modi dicta molestiae non atque est repellat aperiam non. Nam perferendis quis optio quia sed et aut. Molestiae illo consequatur at consequuntur." },
                    { new Guid("e2885722-f8d8-4f0f-bc01-c6b41ae072da"), "Ipsam.", "Quo magni non iure. Sequi et vel totam placeat dolor corporis. Et qui corporis et. Dolorum qui eaque nulla doloremque nulla. Unde temporibus reprehenderit aliquam tempora temporibus odit omnis culpa expedita." },
                    { new Guid("ebc9ab56-4b8c-42e9-a65d-09475beb186a"), "Est.", "Est tenetur sed similique. Doloribus ut quo aliquam. Omnis ut architecto id aut et. Exercitationem sit minus est quod non labore debitis molestiae molestiae. Illo voluptate fuga excepturi et vel accusantium id iure distinctio. Aut enim dignissimos alias." },
                    { new Guid("ed58e921-0a18-4836-80d6-c4b83c9c68f6"), "Rerum.", "Ipsa est quasi. Sit temporibus perferendis ut molestiae tenetur adipisci aliquid. Quas quidem ab possimus eveniet fugit et repellat." }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1fa5e729-c343-4ba8-bb4f-5e2afa471ec9", null, "Admin", "ADMIN" },
                    { "366c6114-3780-4809-ac37-7794fae1739d", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductID", "CategoryID", "CreatedDate", "Description", "ImageUrl", "Price", "ProductName", "StockQuantity" },
                values: new object[,]
                {
                    { new Guid("01abbe6a-33ab-48d5-8c30-1ea84416daf9"), new Guid("65fb0b23-a434-4815-8940-e8540be14705"), new DateTime(2024, 8, 16, 11, 21, 43, 217, DateTimeKind.Local).AddTicks(5418), "Fugiat tempora dicta officia at error ut sint nemo fuga. Voluptates neque officiis molestiae nostrum sapiente aut aut expedita. Atque ullam quae sint dignissimos.", "", 85928953, "Et.", 3447 },
                    { new Guid("038d6f6e-c7cd-496f-83ee-fe64b14d14ef"), new Guid("28f265f7-88fb-470d-ae90-896603c6f8c5"), new DateTime(2024, 8, 16, 11, 21, 43, 217, DateTimeKind.Local).AddTicks(5558), "Ipsum voluptatem tempora eius distinctio sunt eaque quaerat officia. Qui rem est. Sed ipsum nisi.", "", 64096448, "Ex.", 2382 },
                    { new Guid("05312102-6017-427e-9cee-862a22d79dfe"), new Guid("28c01bb3-8036-4504-896b-9a83549a16d0"), new DateTime(2024, 8, 16, 11, 21, 43, 218, DateTimeKind.Local).AddTicks(243), "Voluptatem modi repudiandae consequuntur voluptas. Modi consequuntur eligendi quis aut dolores doloribus quia reiciendis. Facere quis dolore.", "", 25513313, "Est.", 868 },
                    { new Guid("0a31dea2-8d30-409e-9a9f-97bdbabd59cf"), new Guid("28f265f7-88fb-470d-ae90-896603c6f8c5"), new DateTime(2024, 8, 16, 11, 21, 43, 217, DateTimeKind.Local).AddTicks(7738), "Sint fuga inventore voluptatem enim. Qui iusto veniam. Rerum et molestiae corporis dolore exercitationem minima nihil. Consequatur dolores eos exercitationem. Enim accusantium est voluptas vitae ipsam eveniet. Distinctio nesciunt iure et ut incidunt et.", "", 83167562, "Dicta.", 1058 },
                    { new Guid("0c394d7b-003b-4beb-83b7-341e25fe8c5c"), new Guid("28c01bb3-8036-4504-896b-9a83549a16d0"), new DateTime(2024, 8, 16, 11, 21, 43, 217, DateTimeKind.Local).AddTicks(4866), "Eaque corrupti aut animi qui ex quia natus voluptatem quis. Architecto ea qui iste quis labore porro omnis et. Velit soluta reiciendis rerum aut error. Commodi repellendus eius.", "", 76710518, "Corrupti.", 3134 },
                    { new Guid("0f6f980f-c21f-4b7f-88b8-3c396c6fbd3d"), new Guid("28f265f7-88fb-470d-ae90-896603c6f8c5"), new DateTime(2024, 8, 16, 11, 21, 43, 217, DateTimeKind.Local).AddTicks(5186), "Corporis voluptas aut consequatur hic ad. Recusandae autem eaque quia accusamus. Officia eius recusandae in cupiditate quo consequatur ut a nulla. Sit adipisci commodi voluptatem veritatis ducimus maxime nesciunt saepe. Recusandae hic ducimus aspernatur deleniti et commodi ipsa ut.", "", 93376144, "Molestiae.", 2198 },
                    { new Guid("276a5cc1-8f97-4c5b-93ee-a5689a74caf3"), new Guid("add1e4ee-b3b3-4eaa-b534-06717ff1e394"), new DateTime(2024, 8, 16, 11, 21, 43, 217, DateTimeKind.Local).AddTicks(6389), "Quae dolorem impedit voluptatem autem mollitia reiciendis sequi. Accusamus consectetur eveniet dolores qui ut fuga nostrum aut sed. Nesciunt id facere modi. Mollitia itaque ipsum laboriosam ad at ratione dolores dolores consequuntur. Mollitia rem veniam nesciunt similique a et ut eius.", "", 11927421, "Tenetur.", 1763 },
                    { new Guid("2845c8bf-f5ec-4126-8c16-c2c923a48b5f"), new Guid("e2885722-f8d8-4f0f-bc01-c6b41ae072da"), new DateTime(2024, 8, 16, 11, 21, 43, 218, DateTimeKind.Local).AddTicks(1983), "Veritatis praesentium molestiae omnis quae. Nemo officia consequatur quos recusandae ducimus. Est blanditiis eius quas. Qui non doloremque ipsam et iste iure eaque eius et. Enim perspiciatis perferendis quis qui libero et.", "", 58001584, "Consequatur.", 3606 },
                    { new Guid("2c76a600-80b3-42dd-aca4-b4ab01e8205a"), new Guid("ed58e921-0a18-4836-80d6-c4b83c9c68f6"), new DateTime(2024, 8, 16, 11, 21, 43, 217, DateTimeKind.Local).AddTicks(6844), "Aliquid non veritatis atque aut. Debitis omnis enim corrupti. Atque qui hic culpa reprehenderit maiores nemo.", "", 20813613, "Rerum.", 3656 },
                    { new Guid("34da1381-8816-486b-b075-658a8a83320b"), new Guid("add1e4ee-b3b3-4eaa-b534-06717ff1e394"), new DateTime(2024, 8, 16, 11, 21, 43, 217, DateTimeKind.Local).AddTicks(9391), "Nesciunt beatae non quas voluptatem reiciendis. Alias assumenda officiis ducimus sit. Culpa fugiat neque quia corrupti quia. Illo aut reprehenderit dolor. Iste rerum nostrum et id qui iusto. Qui est facere blanditiis nulla.", "", 11616105, "Pariatur.", 1855 },
                    { new Guid("362dc833-cf86-411e-9abc-32aaa7921605"), new Guid("65fb0b23-a434-4815-8940-e8540be14705"), new DateTime(2024, 8, 16, 11, 21, 43, 217, DateTimeKind.Local).AddTicks(4667), "Eos ullam perferendis et rerum fuga commodi quod. Quis enim ducimus. Laborum sequi aliquam recusandae similique laudantium voluptatem. Ut qui praesentium perferendis excepturi. Nobis voluptas ducimus in impedit nihil.", "", 22213381, "Ab.", 4140 },
                    { new Guid("3c43b592-fceb-487c-a75d-8534b54b632e"), new Guid("28f265f7-88fb-470d-ae90-896603c6f8c5"), new DateTime(2024, 8, 16, 11, 21, 43, 217, DateTimeKind.Local).AddTicks(6049), "Adipisci cupiditate quidem aut dicta. Totam rem corrupti aut. Quisquam voluptas quia. Nemo minus architecto. Perspiciatis aut officia assumenda velit perferendis corrupti nemo exercitationem.", "", 13344878, "Officiis.", 1072 },
                    { new Guid("462fd85c-4cab-4f2a-ab6c-7cea4f24ae0c"), new Guid("28c01bb3-8036-4504-896b-9a83549a16d0"), new DateTime(2024, 8, 16, 11, 21, 43, 217, DateTimeKind.Local).AddTicks(9713), "Id explicabo tenetur. Corporis dolorum blanditiis. Tempore fuga iure minima. Voluptatem tenetur deserunt doloremque delectus velit aperiam illo.", "", 915736, "Autem.", 4531 },
                    { new Guid("4af6d062-e1df-4aa6-ab84-cb4b37e3ed38"), new Guid("65fb0b23-a434-4815-8940-e8540be14705"), new DateTime(2024, 8, 16, 11, 21, 43, 217, DateTimeKind.Local).AddTicks(4389), "Deserunt omnis dicta nam distinctio consectetur non nulla blanditiis voluptas. Magni vero ut ut et tempora ut nam pariatur. Est consectetur et et ratione voluptas non.", "", 8163043, "Consequuntur.", 40 },
                    { new Guid("4e00cd20-0bfd-4423-bc83-427af55380f4"), new Guid("5f6e3a22-81f8-459d-ac68-627dad231944"), new DateTime(2024, 8, 16, 11, 21, 43, 217, DateTimeKind.Local).AddTicks(3777), "Quis temporibus dolores assumenda. Quod voluptas atque pariatur ex nihil voluptatem. Quam sapiente velit eveniet.", "", 28295692, "Dolorum.", 3513 },
                    { new Guid("53f212b4-53aa-48f6-81ed-7b9614ea5cae"), new Guid("65fb0b23-a434-4815-8940-e8540be14705"), new DateTime(2024, 8, 16, 11, 21, 43, 218, DateTimeKind.Local).AddTicks(487), "Pariatur laudantium non libero voluptatem exercitationem. Ut aliquam cum voluptas ut. Repudiandae saepe molestiae corporis. Optio sed in provident magni saepe sunt molestias.", "", 64925573, "Aut.", 2402 },
                    { new Guid("75aca798-feef-4b0d-9238-a996d9c1a3ab"), new Guid("ebc9ab56-4b8c-42e9-a65d-09475beb186a"), new DateTime(2024, 8, 16, 11, 21, 43, 217, DateTimeKind.Local).AddTicks(4198), "Molestiae ipsum eum nam quod eveniet dolore. Magni cum fuga est recusandae fugiat blanditiis. Enim mollitia vel quas atque molestiae quia labore. Expedita incidunt officia ut sint fugiat ipsum in dolor nihil. Minus architecto aspernatur officia id illum in. Unde optio accusantium in dignissimos culpa reprehenderit.", "", 75184307, "Aut.", 805 },
                    { new Guid("8ca0c4ec-02a0-41bc-bfef-8f63f9ace209"), new Guid("6b4b9a42-1733-4014-8d08-09daa2796667"), new DateTime(2024, 8, 16, 11, 21, 43, 217, DateTimeKind.Local).AddTicks(7159), "Repudiandae dolorum id laudantium vero. Sapiente ut dolorem. Saepe omnis aliquid ut dolore officia iusto. Iure velit aut et aut qui sint quis sequi nobis. Ducimus suscipit aut necessitatibus consequatur sunt atque deleniti.", "", 41249832, "Nisi.", 4596 },
                    { new Guid("94f6c907-1ce5-4a64-86cb-525138d4c4c8"), new Guid("28c01bb3-8036-4504-896b-9a83549a16d0"), new DateTime(2024, 8, 16, 11, 21, 43, 217, DateTimeKind.Local).AddTicks(3541), "Natus rerum labore ut ea sed. Dolorem placeat eos assumenda aspernatur quisquam ut tempora. Ab odio exercitationem ex quo. Totam velit nemo et.", "", 64100814, "Enim.", 2431 },
                    { new Guid("9f70fb2d-d2bf-456c-aca4-3df2b6f2d22d"), new Guid("e2885722-f8d8-4f0f-bc01-c6b41ae072da"), new DateTime(2024, 8, 16, 11, 21, 43, 218, DateTimeKind.Local).AddTicks(1218), "Animi soluta qui voluptates consectetur consequuntur odit corporis et. Nemo et animi architecto veritatis commodi error molestiae earum saepe. Commodi distinctio asperiores dolores praesentium accusamus aspernatur doloremque.", "", 74524844, "Quam.", 3461 },
                    { new Guid("a963b1fa-4433-46c8-9d06-116c15a2b0b5"), new Guid("65fb0b23-a434-4815-8940-e8540be14705"), new DateTime(2024, 8, 16, 11, 21, 43, 217, DateTimeKind.Local).AddTicks(7363), "Aut illo doloremque eaque quidem inventore dolorum exercitationem. Tenetur odio autem. Illum mollitia unde corrupti et. Nostrum vel dolor rerum distinctio. Omnis voluptas aut accusantium eaque dolor cum.", "", 29236123, "Cupiditate.", 4854 },
                    { new Guid("b16ca563-aaa3-4db0-ac1e-58e4f94b62fe"), new Guid("65fb0b23-a434-4815-8940-e8540be14705"), new DateTime(2024, 8, 16, 11, 21, 43, 217, DateTimeKind.Local).AddTicks(8144), "Nesciunt est debitis molestiae. Eligendi eius et occaecati quo expedita sit unde aut dolore. Nobis aliquid ut assumenda vel.", "", 20683902, "Quos.", 1354 },
                    { new Guid("b5404bc0-bc1f-4c33-998f-10bc30073ab1"), new Guid("28c01bb3-8036-4504-896b-9a83549a16d0"), new DateTime(2024, 8, 16, 11, 21, 43, 218, DateTimeKind.Local).AddTicks(1558), "Tenetur ad ut blanditiis quo tempora omnis libero. Qui vel in velit libero voluptatum optio consectetur. Minima ratione labore sit eum est. Quaerat aut ad possimus quia cupiditate dolor vitae. Aut sunt distinctio aut incidunt.", "", 66516074, "Accusamus.", 4381 },
                    { new Guid("bb71481e-50af-47a7-892f-46e585af0f40"), new Guid("28c01bb3-8036-4504-896b-9a83549a16d0"), new DateTime(2024, 8, 16, 11, 21, 43, 218, DateTimeKind.Local).AddTicks(906), "Molestias est sint voluptate. Praesentium autem architecto repellendus tempora minus provident numquam. Animi praesentium ex eum officiis consequatur ipsam sed eaque. Sit harum explicabo consequatur facilis. Suscipit beatae dolorem omnis omnis laudantium repellat atque minus.", "", 84182394, "Quia.", 1305 },
                    { new Guid("c4a67c39-f78d-4889-9794-e2135faa2ee3"), new Guid("ed58e921-0a18-4836-80d6-c4b83c9c68f6"), new DateTime(2024, 8, 16, 11, 21, 43, 217, DateTimeKind.Local).AddTicks(9971), "Sit quis aut in quaerat qui ipsam quae. Id dolorem maiores dolor minima soluta. Et et sit et nemo saepe cupiditate laboriosam officiis.", "", 59237929, "Ut.", 1318 },
                    { new Guid("d2120511-5bf0-4998-9a9e-125f8d30e2d4"), new Guid("e2885722-f8d8-4f0f-bc01-c6b41ae072da"), new DateTime(2024, 8, 16, 11, 21, 43, 217, DateTimeKind.Local).AddTicks(3317), "Quia autem aut esse nihil ut optio. Et quo velit sit qui cupiditate. Consequuntur earum sint nobis vel quia.", "", 54670017, "Corporis.", 3770 },
                    { new Guid("dfb572e3-39d2-4403-9bea-3848689c7a24"), new Guid("28c01bb3-8036-4504-896b-9a83549a16d0"), new DateTime(2024, 8, 16, 11, 21, 43, 217, DateTimeKind.Local).AddTicks(8846), "Unde cupiditate possimus occaecati sit nulla hic laboriosam. Eum recusandae facilis nihil qui consequatur ducimus quis eos voluptatem. Eum iure aliquid ut ut sunt autem quasi hic. Minima autem cumque dolores.", "", 78511471, "Nobis.", 3151 },
                    { new Guid("f2813df2-4f89-450c-a9f8-f6d5b4353b2d"), new Guid("28f265f7-88fb-470d-ae90-896603c6f8c5"), new DateTime(2024, 8, 16, 11, 21, 43, 217, DateTimeKind.Local).AddTicks(5855), "Aliquid molestiae ipsa libero velit nihil expedita consequatur. Animi doloribus quod aut facilis nihil harum reprehenderit recusandae at. Labore nisi dolorem. Et labore est ut enim. Nulla dignissimos et nihil debitis nostrum et ut fuga iste.", "", 93285617, "Voluptatem.", 125 },
                    { new Guid("f75164d3-7d09-49b1-8cc8-3d2dde851eec"), new Guid("5f6e3a22-81f8-459d-ac68-627dad231944"), new DateTime(2024, 8, 16, 11, 21, 43, 217, DateTimeKind.Local).AddTicks(8366), "Quibusdam suscipit sequi. Quis adipisci quis aut esse saepe. Dicta dolorum cum qui eos.", "", 32305068, "Mollitia.", 3661 },
                    { new Guid("fa2365a9-e4db-45f7-a6b5-49cc22f25bbe"), new Guid("65fb0b23-a434-4815-8940-e8540be14705"), new DateTime(2024, 8, 16, 11, 21, 43, 217, DateTimeKind.Local).AddTicks(6700), "Quae quo in voluptatum odio velit corrupti enim adipisci distinctio. Illum distinctio perferendis ipsa omnis alias voluptas eligendi accusantium. Dolorem a dolorum sed tenetur at alias officiis dolore. Esse eum aliquid. Enim id distinctio nobis iusto aut velit sunt dolores.", "", 76092837, "Possimus.", 703 }
                });
        }
    }
}
