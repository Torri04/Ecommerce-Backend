using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ASP.NET_API.Migrations
{
    /// <inheritdoc />
    public partial class V4_Promotion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "Promotion",
                columns: table => new
                {
                    PromotionID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PromotionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiscountAmount = table.Column<int>(type: "int", nullable: false),
                    MinOrderAmountRequired = table.Column<int>(type: "int", nullable: false),
                    MaxDiscount = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promotion", x => x.PromotionID);
                });

            migrationBuilder.InsertData(
                table: "ProductCategory",
                columns: new[] { "ProductCategoryID", "CategoryName", "CategoryShortDescription" },
                values: new object[,]
                {
                    { new Guid("07f41d16-d086-4ad0-b858-44d76497e3eb"), "Rerum.", "Ipsa est quasi. Sit temporibus perferendis ut molestiae tenetur adipisci aliquid. Quas quidem ab possimus eveniet fugit et repellat." },
                    { new Guid("1bd1d783-89b3-4b31-9148-ed9f8b81d126"), "Omnis.", "Aut quidem iste molestiae incidunt quaerat quibusdam. Minima quaerat accusantium ipsum. Est quae et officia atque molestiae." },
                    { new Guid("2e131fbf-7f71-4460-aab6-35f6bab11c18"), "Labore.", "Facere unde asperiores quod consequuntur aperiam et in. Laborum voluptatem perspiciatis velit sapiente. Eos possimus deserunt numquam et velit nisi. Temporibus laborum illum praesentium sapiente vero. Ullam quis occaecati aut. Corrupti itaque saepe ut." },
                    { new Guid("3d3a6d23-4b1d-417f-8d2f-e2b30190c415"), "Est.", "Est tenetur sed similique. Doloribus ut quo aliquam. Omnis ut architecto id aut et. Exercitationem sit minus est quod non labore debitis molestiae molestiae. Illo voluptate fuga excepturi et vel accusantium id iure distinctio. Aut enim dignissimos alias." },
                    { new Guid("453b5b34-f5e8-41d4-be8f-3251332fb5b3"), "Iste.", "Est nemo non est animi et. Velit excepturi et voluptatem ullam. Velit et repellat repellendus nulla voluptas voluptatem ad. Impedit quis deleniti eius neque." },
                    { new Guid("4be7eb68-5cfb-47ac-a4d9-d8e9a49bf6dd"), "Distinctio.", "Necessitatibus blanditiis eligendi ea asperiores deleniti sed. Iure odio voluptatem corrupti aperiam eos. Et et totam officiis et aperiam." },
                    { new Guid("635a752c-fe1d-4c89-ae57-1862e6e7a492"), "Non.", "Id quis nulla reprehenderit. Et autem sit consequatur asperiores. Molestiae ullam neque culpa. Delectus recusandae id." },
                    { new Guid("8ae09c9a-bd6d-4221-8aff-60f4178d4fd4"), "Quo.", "Sit modi dicta molestiae non atque est repellat aperiam non. Nam perferendis quis optio quia sed et aut. Molestiae illo consequatur at consequuntur." },
                    { new Guid("b3e2d902-a533-44a5-8791-6a5dcb1e2cea"), "Ipsam.", "Quo magni non iure. Sequi et vel totam placeat dolor corporis. Et qui corporis et. Dolorum qui eaque nulla doloremque nulla. Unde temporibus reprehenderit aliquam tempora temporibus odit omnis culpa expedita." },
                    { new Guid("f9b78a08-48c4-4c1c-b1c2-9a93b5ad7a92"), "Omnis.", "Ea ipsa quasi at est esse aperiam vel mollitia. Id officiis explicabo est voluptates hic. Est sapiente corporis atque ratione sit eveniet laudantium ab. Provident temporibus aut iste magni. Non repellat tenetur velit ut est ut ea facilis saepe." }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2741a20d-06e0-4cd7-8173-b1e26e395578", null, "User", "USER" },
                    { "9df031b7-cef4-48b2-8a25-8f9afb62493b", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductID", "CategoryID", "CreatedDate", "Description", "ImageUrl", "Price", "ProductName", "StockQuantity" },
                values: new object[,]
                {
                    { new Guid("1b56f445-8827-4206-b924-0f254680ada5"), new Guid("f9b78a08-48c4-4c1c-b1c2-9a93b5ad7a92"), new DateTime(2024, 8, 16, 16, 53, 36, 981, DateTimeKind.Local).AddTicks(8860), "Repudiandae dolorum id laudantium vero. Sapiente ut dolorem. Saepe omnis aliquid ut dolore officia iusto. Iure velit aut et aut qui sint quis sequi nobis. Ducimus suscipit aut necessitatibus consequatur sunt atque deleniti.", "", 41249832, "Nisi.", 4596 },
                    { new Guid("1ba7aafd-089d-484b-88f4-e547af6b9175"), new Guid("4be7eb68-5cfb-47ac-a4d9-d8e9a49bf6dd"), new DateTime(2024, 8, 16, 16, 53, 36, 981, DateTimeKind.Local).AddTicks(7835), "Corporis voluptas aut consequatur hic ad. Recusandae autem eaque quia accusamus. Officia eius recusandae in cupiditate quo consequatur ut a nulla. Sit adipisci commodi voluptatem veritatis ducimus maxime nesciunt saepe. Recusandae hic ducimus aspernatur deleniti et commodi ipsa ut.", "", 93376144, "Molestiae.", 2198 },
                    { new Guid("1eacd4ce-f8d7-44e3-8c26-bdcbcc376ace"), new Guid("2e131fbf-7f71-4460-aab6-35f6bab11c18"), new DateTime(2024, 8, 16, 16, 53, 36, 981, DateTimeKind.Local).AddTicks(9968), "Pariatur laudantium non libero voluptatem exercitationem. Ut aliquam cum voluptas ut. Repudiandae saepe molestiae corporis. Optio sed in provident magni saepe sunt molestias.", "", 64925573, "Aut.", 2402 },
                    { new Guid("2e27f1c5-4386-44d4-82e2-96cad541f8d5"), new Guid("07f41d16-d086-4ad0-b858-44d76497e3eb"), new DateTime(2024, 8, 16, 16, 53, 36, 981, DateTimeKind.Local).AddTicks(9770), "Sit quis aut in quaerat qui ipsam quae. Id dolorem maiores dolor minima soluta. Et et sit et nemo saepe cupiditate laboriosam officiis.", "", 59237929, "Ut.", 1318 },
                    { new Guid("4676507c-b88a-4426-8523-058fe6e48a29"), new Guid("4be7eb68-5cfb-47ac-a4d9-d8e9a49bf6dd"), new DateTime(2024, 8, 16, 16, 53, 36, 981, DateTimeKind.Local).AddTicks(8296), "Adipisci cupiditate quidem aut dicta. Totam rem corrupti aut. Quisquam voluptas quia. Nemo minus architecto. Perspiciatis aut officia assumenda velit perferendis corrupti nemo exercitationem.", "", 13344878, "Officiis.", 1072 },
                    { new Guid("470d361d-5b80-4f38-b2dc-f31fa6147e07"), new Guid("635a752c-fe1d-4c89-ae57-1862e6e7a492"), new DateTime(2024, 8, 16, 16, 53, 36, 982, DateTimeKind.Local).AddTicks(366), "Tenetur ad ut blanditiis quo tempora omnis libero. Qui vel in velit libero voluptatum optio consectetur. Minima ratione labore sit eum est. Quaerat aut ad possimus quia cupiditate dolor vitae. Aut sunt distinctio aut incidunt.", "", 66516074, "Accusamus.", 4381 },
                    { new Guid("585c187a-839e-4419-b1ce-99a7900e6ca6"), new Guid("b3e2d902-a533-44a5-8791-6a5dcb1e2cea"), new DateTime(2024, 8, 16, 16, 53, 36, 982, DateTimeKind.Local).AddTicks(219), "Animi soluta qui voluptates consectetur consequuntur odit corporis et. Nemo et animi architecto veritatis commodi error molestiae earum saepe. Commodi distinctio asperiores dolores praesentium accusamus aspernatur doloremque.", "", 74524844, "Quam.", 3461 },
                    { new Guid("642c8a43-9efb-4e3d-920f-13d3ab04e604"), new Guid("635a752c-fe1d-4c89-ae57-1862e6e7a492"), new DateTime(2024, 8, 16, 16, 53, 36, 981, DateTimeKind.Local).AddTicks(7665), "Eaque corrupti aut animi qui ex quia natus voluptatem quis. Architecto ea qui iste quis labore porro omnis et. Velit soluta reiciendis rerum aut error. Commodi repellendus eius.", "", 76710518, "Corrupti.", 3134 },
                    { new Guid("643af3dc-3d85-48ce-ad49-626522a5b096"), new Guid("2e131fbf-7f71-4460-aab6-35f6bab11c18"), new DateTime(2024, 8, 16, 16, 53, 36, 981, DateTimeKind.Local).AddTicks(9226), "Nesciunt est debitis molestiae. Eligendi eius et occaecati quo expedita sit unde aut dolore. Nobis aliquid ut assumenda vel.", "", 20683902, "Quos.", 1354 },
                    { new Guid("65bda6f8-a3ce-4359-9de9-d072df378a81"), new Guid("b3e2d902-a533-44a5-8791-6a5dcb1e2cea"), new DateTime(2024, 8, 16, 16, 53, 36, 981, DateTimeKind.Local).AddTicks(6719), "Quia autem aut esse nihil ut optio. Et quo velit sit qui cupiditate. Consequuntur earum sint nobis vel quia.", "", 54670017, "Corporis.", 3770 },
                    { new Guid("70cad08d-b061-440c-972f-d1522fff2c41"), new Guid("4be7eb68-5cfb-47ac-a4d9-d8e9a49bf6dd"), new DateTime(2024, 8, 16, 16, 53, 36, 981, DateTimeKind.Local).AddTicks(9123), "Sint fuga inventore voluptatem enim. Qui iusto veniam. Rerum et molestiae corporis dolore exercitationem minima nihil. Consequatur dolores eos exercitationem. Enim accusantium est voluptas vitae ipsam eveniet. Distinctio nesciunt iure et ut incidunt et.", "", 83167562, "Dicta.", 1058 },
                    { new Guid("7bb0956d-e85e-45ed-a127-9328a5f69179"), new Guid("4be7eb68-5cfb-47ac-a4d9-d8e9a49bf6dd"), new DateTime(2024, 8, 16, 16, 53, 36, 981, DateTimeKind.Local).AddTicks(8196), "Aliquid molestiae ipsa libero velit nihil expedita consequatur. Animi doloribus quod aut facilis nihil harum reprehenderit recusandae at. Labore nisi dolorem. Et labore est ut enim. Nulla dignissimos et nihil debitis nostrum et ut fuga iste.", "", 93285617, "Voluptatem.", 125 },
                    { new Guid("9c1b3e5d-b0f3-43eb-8e29-ffcf39e3d1db"), new Guid("07f41d16-d086-4ad0-b858-44d76497e3eb"), new DateTime(2024, 8, 16, 16, 53, 36, 981, DateTimeKind.Local).AddTicks(8713), "Aliquid non veritatis atque aut. Debitis omnis enim corrupti. Atque qui hic culpa reprehenderit maiores nemo.", "", 20813613, "Rerum.", 3656 },
                    { new Guid("9dd8c54a-1a0f-40f1-a286-ca0318d1e4bd"), new Guid("1bd1d783-89b3-4b31-9148-ed9f8b81d126"), new DateTime(2024, 8, 16, 16, 53, 36, 981, DateTimeKind.Local).AddTicks(9293), "Quibusdam suscipit sequi. Quis adipisci quis aut esse saepe. Dicta dolorum cum qui eos.", "", 32305068, "Mollitia.", 3661 },
                    { new Guid("a539a366-7cec-415b-a5c1-51a4e54428f2"), new Guid("635a752c-fe1d-4c89-ae57-1862e6e7a492"), new DateTime(2024, 8, 16, 16, 53, 36, 981, DateTimeKind.Local).AddTicks(9865), "Voluptatem modi repudiandae consequuntur voluptas. Modi consequuntur eligendi quis aut dolores doloribus quia reiciendis. Facere quis dolore.", "", 25513313, "Est.", 868 },
                    { new Guid("a97b7023-030b-48bf-9f08-d0a83ade2285"), new Guid("8ae09c9a-bd6d-4221-8aff-60f4178d4fd4"), new DateTime(2024, 8, 16, 16, 53, 36, 981, DateTimeKind.Local).AddTicks(8469), "Quae dolorem impedit voluptatem autem mollitia reiciendis sequi. Accusamus consectetur eveniet dolores qui ut fuga nostrum aut sed. Nesciunt id facere modi. Mollitia itaque ipsum laboriosam ad at ratione dolores dolores consequuntur. Mollitia rem veniam nesciunt similique a et ut eius.", "", 11927421, "Tenetur.", 1763 },
                    { new Guid("af18b68b-3510-4c33-a1ee-200f7ec46511"), new Guid("635a752c-fe1d-4c89-ae57-1862e6e7a492"), new DateTime(2024, 8, 16, 16, 53, 36, 981, DateTimeKind.Local).AddTicks(9405), "Unde cupiditate possimus occaecati sit nulla hic laboriosam. Eum recusandae facilis nihil qui consequatur ducimus quis eos voluptatem. Eum iure aliquid ut ut sunt autem quasi hic. Minima autem cumque dolores.", "", 78511471, "Nobis.", 3151 },
                    { new Guid("b014562a-a8d8-4754-84e6-59060546eade"), new Guid("8ae09c9a-bd6d-4221-8aff-60f4178d4fd4"), new DateTime(2024, 8, 16, 16, 53, 36, 981, DateTimeKind.Local).AddTicks(9575), "Nesciunt beatae non quas voluptatem reiciendis. Alias assumenda officiis ducimus sit. Culpa fugiat neque quia corrupti quia. Illo aut reprehenderit dolor. Iste rerum nostrum et id qui iusto. Qui est facere blanditiis nulla.", "", 11616105, "Pariatur.", 1855 },
                    { new Guid("b48a59a0-a7de-457d-818a-b6859e3ec9b2"), new Guid("4be7eb68-5cfb-47ac-a4d9-d8e9a49bf6dd"), new DateTime(2024, 8, 16, 16, 53, 36, 981, DateTimeKind.Local).AddTicks(8023), "Ipsum voluptatem tempora eius distinctio sunt eaque quaerat officia. Qui rem est. Sed ipsum nisi.", "", 64096448, "Ex.", 2382 },
                    { new Guid("bfdca5d2-b745-4a90-bcd3-4e2a40d8ecb3"), new Guid("3d3a6d23-4b1d-417f-8d2f-e2b30190c415"), new DateTime(2024, 8, 16, 16, 53, 36, 981, DateTimeKind.Local).AddTicks(7145), "Molestiae ipsum eum nam quod eveniet dolore. Magni cum fuga est recusandae fugiat blanditiis. Enim mollitia vel quas atque molestiae quia labore. Expedita incidunt officia ut sint fugiat ipsum in dolor nihil. Minus architecto aspernatur officia id illum in. Unde optio accusantium in dignissimos culpa reprehenderit.", "", 75184307, "Aut.", 805 },
                    { new Guid("c8af8f37-da5a-4cf4-b3fb-f058f42ba660"), new Guid("2e131fbf-7f71-4460-aab6-35f6bab11c18"), new DateTime(2024, 8, 16, 16, 53, 36, 981, DateTimeKind.Local).AddTicks(7931), "Fugiat tempora dicta officia at error ut sint nemo fuga. Voluptates neque officiis molestiae nostrum sapiente aut aut expedita. Atque ullam quae sint dignissimos.", "", 85928953, "Et.", 3447 },
                    { new Guid("cb748d45-c176-474a-9cf0-5f3605204e8c"), new Guid("2e131fbf-7f71-4460-aab6-35f6bab11c18"), new DateTime(2024, 8, 16, 16, 53, 36, 981, DateTimeKind.Local).AddTicks(7546), "Eos ullam perferendis et rerum fuga commodi quod. Quis enim ducimus. Laborum sequi aliquam recusandae similique laudantium voluptatem. Ut qui praesentium perferendis excepturi. Nobis voluptas ducimus in impedit nihil.", "", 22213381, "Ab.", 4140 },
                    { new Guid("cddd3090-1c21-4799-9725-bccbbe12d052"), new Guid("b3e2d902-a533-44a5-8791-6a5dcb1e2cea"), new DateTime(2024, 8, 16, 16, 53, 36, 982, DateTimeKind.Local).AddTicks(509), "Veritatis praesentium molestiae omnis quae. Nemo officia consequatur quos recusandae ducimus. Est blanditiis eius quas. Qui non doloremque ipsam et iste iure eaque eius et. Enim perspiciatis perferendis quis qui libero et.", "", 58001584, "Consequatur.", 3606 },
                    { new Guid("d173ef22-f47d-4427-94ed-30e0db79c680"), new Guid("2e131fbf-7f71-4460-aab6-35f6bab11c18"), new DateTime(2024, 8, 16, 16, 53, 36, 981, DateTimeKind.Local).AddTicks(7393), "Deserunt omnis dicta nam distinctio consectetur non nulla blanditiis voluptas. Magni vero ut ut et tempora ut nam pariatur. Est consectetur et et ratione voluptas non.", "", 8163043, "Consequuntur.", 40 },
                    { new Guid("e8baa771-0442-461a-a372-8192c586f743"), new Guid("2e131fbf-7f71-4460-aab6-35f6bab11c18"), new DateTime(2024, 8, 16, 16, 53, 36, 981, DateTimeKind.Local).AddTicks(8967), "Aut illo doloremque eaque quidem inventore dolorum exercitationem. Tenetur odio autem. Illum mollitia unde corrupti et. Nostrum vel dolor rerum distinctio. Omnis voluptas aut accusantium eaque dolor cum.", "", 29236123, "Cupiditate.", 4854 },
                    { new Guid("ed41964c-d864-4049-b891-8b0250daff28"), new Guid("2e131fbf-7f71-4460-aab6-35f6bab11c18"), new DateTime(2024, 8, 16, 16, 53, 36, 981, DateTimeKind.Local).AddTicks(8637), "Quae quo in voluptatum odio velit corrupti enim adipisci distinctio. Illum distinctio perferendis ipsa omnis alias voluptas eligendi accusantium. Dolorem a dolorum sed tenetur at alias officiis dolore. Esse eum aliquid. Enim id distinctio nobis iusto aut velit sunt dolores.", "", 76092837, "Possimus.", 703 },
                    { new Guid("edcee903-93db-444a-88b8-0f5ad841b1a4"), new Guid("635a752c-fe1d-4c89-ae57-1862e6e7a492"), new DateTime(2024, 8, 16, 16, 53, 36, 981, DateTimeKind.Local).AddTicks(9680), "Id explicabo tenetur. Corporis dolorum blanditiis. Tempore fuga iure minima. Voluptatem tenetur deserunt doloremque delectus velit aperiam illo.", "", 915736, "Autem.", 4531 },
                    { new Guid("f4b59885-6695-4880-b485-5a4ace2b8aac"), new Guid("635a752c-fe1d-4c89-ae57-1862e6e7a492"), new DateTime(2024, 8, 16, 16, 53, 36, 982, DateTimeKind.Local).AddTicks(121), "Molestias est sint voluptate. Praesentium autem architecto repellendus tempora minus provident numquam. Animi praesentium ex eum officiis consequatur ipsam sed eaque. Sit harum explicabo consequatur facilis. Suscipit beatae dolorem omnis omnis laudantium repellat atque minus.", "", 84182394, "Quia.", 1305 },
                    { new Guid("fb9f8762-b2bf-421a-a217-dd009332bf61"), new Guid("635a752c-fe1d-4c89-ae57-1862e6e7a492"), new DateTime(2024, 8, 16, 16, 53, 36, 981, DateTimeKind.Local).AddTicks(6859), "Natus rerum labore ut ea sed. Dolorem placeat eos assumenda aspernatur quisquam ut tempora. Ab odio exercitationem ex quo. Totam velit nemo et.", "", 64100814, "Enim.", 2431 },
                    { new Guid("fd4d58e4-42e2-4c78-8483-7316d7c3bc33"), new Guid("1bd1d783-89b3-4b31-9148-ed9f8b81d126"), new DateTime(2024, 8, 16, 16, 53, 36, 981, DateTimeKind.Local).AddTicks(6964), "Quis temporibus dolores assumenda. Quod voluptas atque pariatur ex nihil voluptatem. Quam sapiente velit eveniet.", "", 28295692, "Dolorum.", 3513 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Promotion");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("1b56f445-8827-4206-b924-0f254680ada5"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("1ba7aafd-089d-484b-88f4-e547af6b9175"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("1eacd4ce-f8d7-44e3-8c26-bdcbcc376ace"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("2e27f1c5-4386-44d4-82e2-96cad541f8d5"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("4676507c-b88a-4426-8523-058fe6e48a29"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("470d361d-5b80-4f38-b2dc-f31fa6147e07"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("585c187a-839e-4419-b1ce-99a7900e6ca6"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("642c8a43-9efb-4e3d-920f-13d3ab04e604"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("643af3dc-3d85-48ce-ad49-626522a5b096"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("65bda6f8-a3ce-4359-9de9-d072df378a81"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("70cad08d-b061-440c-972f-d1522fff2c41"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("7bb0956d-e85e-45ed-a127-9328a5f69179"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("9c1b3e5d-b0f3-43eb-8e29-ffcf39e3d1db"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("9dd8c54a-1a0f-40f1-a286-ca0318d1e4bd"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("a539a366-7cec-415b-a5c1-51a4e54428f2"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("a97b7023-030b-48bf-9f08-d0a83ade2285"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("af18b68b-3510-4c33-a1ee-200f7ec46511"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("b014562a-a8d8-4754-84e6-59060546eade"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("b48a59a0-a7de-457d-818a-b6859e3ec9b2"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("bfdca5d2-b745-4a90-bcd3-4e2a40d8ecb3"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("c8af8f37-da5a-4cf4-b3fb-f058f42ba660"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("cb748d45-c176-474a-9cf0-5f3605204e8c"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("cddd3090-1c21-4799-9725-bccbbe12d052"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("d173ef22-f47d-4427-94ed-30e0db79c680"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("e8baa771-0442-461a-a372-8192c586f743"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("ed41964c-d864-4049-b891-8b0250daff28"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("edcee903-93db-444a-88b8-0f5ad841b1a4"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("f4b59885-6695-4880-b485-5a4ace2b8aac"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("fb9f8762-b2bf-421a-a217-dd009332bf61"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("fd4d58e4-42e2-4c78-8483-7316d7c3bc33"));

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "ProductCategoryID",
                keyValue: new Guid("453b5b34-f5e8-41d4-be8f-3251332fb5b3"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2741a20d-06e0-4cd7-8173-b1e26e395578");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "9df031b7-cef4-48b2-8a25-8f9afb62493b");

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "ProductCategoryID",
                keyValue: new Guid("07f41d16-d086-4ad0-b858-44d76497e3eb"));

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "ProductCategoryID",
                keyValue: new Guid("1bd1d783-89b3-4b31-9148-ed9f8b81d126"));

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "ProductCategoryID",
                keyValue: new Guid("2e131fbf-7f71-4460-aab6-35f6bab11c18"));

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "ProductCategoryID",
                keyValue: new Guid("3d3a6d23-4b1d-417f-8d2f-e2b30190c415"));

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "ProductCategoryID",
                keyValue: new Guid("4be7eb68-5cfb-47ac-a4d9-d8e9a49bf6dd"));

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "ProductCategoryID",
                keyValue: new Guid("635a752c-fe1d-4c89-ae57-1862e6e7a492"));

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "ProductCategoryID",
                keyValue: new Guid("8ae09c9a-bd6d-4221-8aff-60f4178d4fd4"));

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "ProductCategoryID",
                keyValue: new Guid("b3e2d902-a533-44a5-8791-6a5dcb1e2cea"));

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "ProductCategoryID",
                keyValue: new Guid("f9b78a08-48c4-4c1c-b1c2-9a93b5ad7a92"));

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
        }
    }
}
