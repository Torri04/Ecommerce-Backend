using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ASP.NET_API.Migrations
{
    /// <inheritdoc />
    public partial class V5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDay",
                table: "Promotion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "ProductCategory",
                columns: new[] { "ProductCategoryID", "CategoryName", "CategoryShortDescription" },
                values: new object[,]
                {
                    { new Guid("2b0c1a33-eaeb-4f42-80d3-a3331bdf1336"), "Distinctio.", "Necessitatibus blanditiis eligendi ea asperiores deleniti sed. Iure odio voluptatem corrupti aperiam eos. Et et totam officiis et aperiam." },
                    { new Guid("6853a5ca-c4bc-4e80-a42e-f9e1fe20efd0"), "Omnis.", "Aut quidem iste molestiae incidunt quaerat quibusdam. Minima quaerat accusantium ipsum. Est quae et officia atque molestiae." },
                    { new Guid("778e65e0-2680-4ff4-ad52-5b86d8e3be50"), "Ipsam.", "Quo magni non iure. Sequi et vel totam placeat dolor corporis. Et qui corporis et. Dolorum qui eaque nulla doloremque nulla. Unde temporibus reprehenderit aliquam tempora temporibus odit omnis culpa expedita." },
                    { new Guid("810ec16d-78e5-480a-94d0-ac2404ab2786"), "Quo.", "Sit modi dicta molestiae non atque est repellat aperiam non. Nam perferendis quis optio quia sed et aut. Molestiae illo consequatur at consequuntur." },
                    { new Guid("8582ccbd-c215-4c0a-be2c-24383cf5bdd1"), "Rerum.", "Ipsa est quasi. Sit temporibus perferendis ut molestiae tenetur adipisci aliquid. Quas quidem ab possimus eveniet fugit et repellat." },
                    { new Guid("9297f03d-2c44-496a-b8ed-50f808cd01e0"), "Labore.", "Facere unde asperiores quod consequuntur aperiam et in. Laborum voluptatem perspiciatis velit sapiente. Eos possimus deserunt numquam et velit nisi. Temporibus laborum illum praesentium sapiente vero. Ullam quis occaecati aut. Corrupti itaque saepe ut." },
                    { new Guid("a5a21684-d42c-4111-80f8-344b93cb2626"), "Est.", "Est tenetur sed similique. Doloribus ut quo aliquam. Omnis ut architecto id aut et. Exercitationem sit minus est quod non labore debitis molestiae molestiae. Illo voluptate fuga excepturi et vel accusantium id iure distinctio. Aut enim dignissimos alias." },
                    { new Guid("c20a185a-4fa7-4429-ace2-72e12b033a6d"), "Non.", "Id quis nulla reprehenderit. Et autem sit consequatur asperiores. Molestiae ullam neque culpa. Delectus recusandae id." },
                    { new Guid("c3792c19-adba-4999-bfc0-a23879a2bc6f"), "Omnis.", "Ea ipsa quasi at est esse aperiam vel mollitia. Id officiis explicabo est voluptates hic. Est sapiente corporis atque ratione sit eveniet laudantium ab. Provident temporibus aut iste magni. Non repellat tenetur velit ut est ut ea facilis saepe." },
                    { new Guid("ef107c79-13be-4940-9cf3-d40c41b702f1"), "Iste.", "Est nemo non est animi et. Velit excepturi et voluptatem ullam. Velit et repellat repellendus nulla voluptas voluptatem ad. Impedit quis deleniti eius neque." }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3afa045f-8617-43e2-8211-8ba622646174", null, "User", "USER" },
                    { "e10d49e6-a2e1-43ce-b988-87a40e60bbfc", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductID", "CategoryID", "CreatedDate", "Description", "ImageUrl", "Price", "ProductName", "StockQuantity" },
                values: new object[,]
                {
                    { new Guid("0a891372-e811-4a76-9439-a2797edcea46"), new Guid("c20a185a-4fa7-4429-ace2-72e12b033a6d"), new DateTime(2024, 8, 16, 17, 47, 2, 683, DateTimeKind.Local).AddTicks(3958), "Natus rerum labore ut ea sed. Dolorem placeat eos assumenda aspernatur quisquam ut tempora. Ab odio exercitationem ex quo. Totam velit nemo et.", "", 64100814, "Enim.", 2431 },
                    { new Guid("107ca45a-86c1-4ae5-ae2b-634e9fb1e4e6"), new Guid("810ec16d-78e5-480a-94d0-ac2404ab2786"), new DateTime(2024, 8, 16, 17, 47, 2, 683, DateTimeKind.Local).AddTicks(6153), "Quae dolorem impedit voluptatem autem mollitia reiciendis sequi. Accusamus consectetur eveniet dolores qui ut fuga nostrum aut sed. Nesciunt id facere modi. Mollitia itaque ipsum laboriosam ad at ratione dolores dolores consequuntur. Mollitia rem veniam nesciunt similique a et ut eius.", "", 11927421, "Tenetur.", 1763 },
                    { new Guid("18a07a92-c421-4be8-8121-0682de97a009"), new Guid("2b0c1a33-eaeb-4f42-80d3-a3331bdf1336"), new DateTime(2024, 8, 16, 17, 47, 2, 683, DateTimeKind.Local).AddTicks(5712), "Ipsum voluptatem tempora eius distinctio sunt eaque quaerat officia. Qui rem est. Sed ipsum nisi.", "", 64096448, "Ex.", 2382 },
                    { new Guid("21e0b1c0-f24f-4a78-9ff6-b656d309159a"), new Guid("810ec16d-78e5-480a-94d0-ac2404ab2786"), new DateTime(2024, 8, 16, 17, 47, 2, 683, DateTimeKind.Local).AddTicks(7609), "Nesciunt beatae non quas voluptatem reiciendis. Alias assumenda officiis ducimus sit. Culpa fugiat neque quia corrupti quia. Illo aut reprehenderit dolor. Iste rerum nostrum et id qui iusto. Qui est facere blanditiis nulla.", "", 11616105, "Pariatur.", 1855 },
                    { new Guid("25e0b759-dd20-40aa-9e73-8f8712313233"), new Guid("c20a185a-4fa7-4429-ace2-72e12b033a6d"), new DateTime(2024, 8, 16, 17, 47, 2, 683, DateTimeKind.Local).AddTicks(7464), "Unde cupiditate possimus occaecati sit nulla hic laboriosam. Eum recusandae facilis nihil qui consequatur ducimus quis eos voluptatem. Eum iure aliquid ut ut sunt autem quasi hic. Minima autem cumque dolores.", "", 78511471, "Nobis.", 3151 },
                    { new Guid("3195d2f4-52dc-40f9-9d35-13afec2eb738"), new Guid("778e65e0-2680-4ff4-ad52-5b86d8e3be50"), new DateTime(2024, 8, 16, 17, 47, 2, 683, DateTimeKind.Local).AddTicks(8273), "Animi soluta qui voluptates consectetur consequuntur odit corporis et. Nemo et animi architecto veritatis commodi error molestiae earum saepe. Commodi distinctio asperiores dolores praesentium accusamus aspernatur doloremque.", "", 74524844, "Quam.", 3461 },
                    { new Guid("3dd05f4a-9e67-4cf1-9302-4318225447a2"), new Guid("2b0c1a33-eaeb-4f42-80d3-a3331bdf1336"), new DateTime(2024, 8, 16, 17, 47, 2, 683, DateTimeKind.Local).AddTicks(7164), "Sint fuga inventore voluptatem enim. Qui iusto veniam. Rerum et molestiae corporis dolore exercitationem minima nihil. Consequatur dolores eos exercitationem. Enim accusantium est voluptas vitae ipsam eveniet. Distinctio nesciunt iure et ut incidunt et.", "", 83167562, "Dicta.", 1058 },
                    { new Guid("3de448f4-b5d1-43c4-97bb-4d1ad0be0e24"), new Guid("c20a185a-4fa7-4429-ace2-72e12b033a6d"), new DateTime(2024, 8, 16, 17, 47, 2, 683, DateTimeKind.Local).AddTicks(5317), "Eaque corrupti aut animi qui ex quia natus voluptatem quis. Architecto ea qui iste quis labore porro omnis et. Velit soluta reiciendis rerum aut error. Commodi repellendus eius.", "", 76710518, "Corrupti.", 3134 },
                    { new Guid("4209b425-3b15-4a25-8e3b-978ab20717f6"), new Guid("9297f03d-2c44-496a-b8ed-50f808cd01e0"), new DateTime(2024, 8, 16, 17, 47, 2, 683, DateTimeKind.Local).AddTicks(7246), "Nesciunt est debitis molestiae. Eligendi eius et occaecati quo expedita sit unde aut dolore. Nobis aliquid ut assumenda vel.", "", 20683902, "Quos.", 1354 },
                    { new Guid("4278cfe2-50f4-4b88-bd67-cc3e1e63bd95"), new Guid("9297f03d-2c44-496a-b8ed-50f808cd01e0"), new DateTime(2024, 8, 16, 17, 47, 2, 683, DateTimeKind.Local).AddTicks(8024), "Pariatur laudantium non libero voluptatem exercitationem. Ut aliquam cum voluptas ut. Repudiandae saepe molestiae corporis. Optio sed in provident magni saepe sunt molestias.", "", 64925573, "Aut.", 2402 },
                    { new Guid("4cd53321-02ab-4ede-bf19-b1c1692608d8"), new Guid("778e65e0-2680-4ff4-ad52-5b86d8e3be50"), new DateTime(2024, 8, 16, 17, 47, 2, 683, DateTimeKind.Local).AddTicks(8558), "Veritatis praesentium molestiae omnis quae. Nemo officia consequatur quos recusandae ducimus. Est blanditiis eius quas. Qui non doloremque ipsam et iste iure eaque eius et. Enim perspiciatis perferendis quis qui libero et.", "", 58001584, "Consequatur.", 3606 },
                    { new Guid("50bb646e-ef77-4dab-ad64-c9b0ae3fb7dd"), new Guid("2b0c1a33-eaeb-4f42-80d3-a3331bdf1336"), new DateTime(2024, 8, 16, 17, 47, 2, 683, DateTimeKind.Local).AddTicks(5849), "Aliquid molestiae ipsa libero velit nihil expedita consequatur. Animi doloribus quod aut facilis nihil harum reprehenderit recusandae at. Labore nisi dolorem. Et labore est ut enim. Nulla dignissimos et nihil debitis nostrum et ut fuga iste.", "", 93285617, "Voluptatem.", 125 },
                    { new Guid("5c182dce-7a64-4e7a-a85b-fe29bab604ea"), new Guid("6853a5ca-c4bc-4e80-a42e-f9e1fe20efd0"), new DateTime(2024, 8, 16, 17, 47, 2, 683, DateTimeKind.Local).AddTicks(4065), "Quis temporibus dolores assumenda. Quod voluptas atque pariatur ex nihil voluptatem. Quam sapiente velit eveniet.", "", 28295692, "Dolorum.", 3513 },
                    { new Guid("5cff88e1-fdcb-4fde-99f2-d632ebbfba56"), new Guid("a5a21684-d42c-4111-80f8-344b93cb2626"), new DateTime(2024, 8, 16, 17, 47, 2, 683, DateTimeKind.Local).AddTicks(4685), "Molestiae ipsum eum nam quod eveniet dolore. Magni cum fuga est recusandae fugiat blanditiis. Enim mollitia vel quas atque molestiae quia labore. Expedita incidunt officia ut sint fugiat ipsum in dolor nihil. Minus architecto aspernatur officia id illum in. Unde optio accusantium in dignissimos culpa reprehenderit.", "", 75184307, "Aut.", 805 },
                    { new Guid("833bba8c-b68e-493f-aab0-74b64e9a1bf3"), new Guid("c20a185a-4fa7-4429-ace2-72e12b033a6d"), new DateTime(2024, 8, 16, 17, 47, 2, 683, DateTimeKind.Local).AddTicks(7690), "Id explicabo tenetur. Corporis dolorum blanditiis. Tempore fuga iure minima. Voluptatem tenetur deserunt doloremque delectus velit aperiam illo.", "", 915736, "Autem.", 4531 },
                    { new Guid("851229b1-3db3-4611-8616-9820fbbd87a9"), new Guid("9297f03d-2c44-496a-b8ed-50f808cd01e0"), new DateTime(2024, 8, 16, 17, 47, 2, 683, DateTimeKind.Local).AddTicks(5142), "Eos ullam perferendis et rerum fuga commodi quod. Quis enim ducimus. Laborum sequi aliquam recusandae similique laudantium voluptatem. Ut qui praesentium perferendis excepturi. Nobis voluptas ducimus in impedit nihil.", "", 22213381, "Ab.", 4140 },
                    { new Guid("89b15e9d-c4ca-4e91-b474-2493b5c83075"), new Guid("9297f03d-2c44-496a-b8ed-50f808cd01e0"), new DateTime(2024, 8, 16, 17, 47, 2, 683, DateTimeKind.Local).AddTicks(5585), "Fugiat tempora dicta officia at error ut sint nemo fuga. Voluptates neque officiis molestiae nostrum sapiente aut aut expedita. Atque ullam quae sint dignissimos.", "", 85928953, "Et.", 3447 },
                    { new Guid("8c5cd2bd-1751-49f0-848e-58b060ca6596"), new Guid("2b0c1a33-eaeb-4f42-80d3-a3331bdf1336"), new DateTime(2024, 8, 16, 17, 47, 2, 683, DateTimeKind.Local).AddTicks(5984), "Adipisci cupiditate quidem aut dicta. Totam rem corrupti aut. Quisquam voluptas quia. Nemo minus architecto. Perspiciatis aut officia assumenda velit perferendis corrupti nemo exercitationem.", "", 13344878, "Officiis.", 1072 },
                    { new Guid("93735f5d-69fc-4c13-bba2-53a6dc489817"), new Guid("9297f03d-2c44-496a-b8ed-50f808cd01e0"), new DateTime(2024, 8, 16, 17, 47, 2, 683, DateTimeKind.Local).AddTicks(6294), "Quae quo in voluptatum odio velit corrupti enim adipisci distinctio. Illum distinctio perferendis ipsa omnis alias voluptas eligendi accusantium. Dolorem a dolorum sed tenetur at alias officiis dolore. Esse eum aliquid. Enim id distinctio nobis iusto aut velit sunt dolores.", "", 76092837, "Possimus.", 703 },
                    { new Guid("93e3cfb1-daa2-4887-acb5-eb0334a53b46"), new Guid("6853a5ca-c4bc-4e80-a42e-f9e1fe20efd0"), new DateTime(2024, 8, 16, 17, 47, 2, 683, DateTimeKind.Local).AddTicks(7347), "Quibusdam suscipit sequi. Quis adipisci quis aut esse saepe. Dicta dolorum cum qui eos.", "", 32305068, "Mollitia.", 3661 },
                    { new Guid("992ea8cc-caf7-44f3-9720-078ec8ed9d05"), new Guid("8582ccbd-c215-4c0a-be2c-24383cf5bdd1"), new DateTime(2024, 8, 16, 17, 47, 2, 683, DateTimeKind.Local).AddTicks(7821), "Sit quis aut in quaerat qui ipsam quae. Id dolorem maiores dolor minima soluta. Et et sit et nemo saepe cupiditate laboriosam officiis.", "", 59237929, "Ut.", 1318 },
                    { new Guid("a0ca9b0e-97b9-4e0c-b804-cb5373ba6127"), new Guid("c20a185a-4fa7-4429-ace2-72e12b033a6d"), new DateTime(2024, 8, 16, 17, 47, 2, 683, DateTimeKind.Local).AddTicks(7899), "Voluptatem modi repudiandae consequuntur voluptas. Modi consequuntur eligendi quis aut dolores doloribus quia reiciendis. Facere quis dolore.", "", 25513313, "Est.", 868 },
                    { new Guid("bee44680-e16b-47af-8853-64a173d34bfb"), new Guid("9297f03d-2c44-496a-b8ed-50f808cd01e0"), new DateTime(2024, 8, 16, 17, 47, 2, 683, DateTimeKind.Local).AddTicks(4941), "Deserunt omnis dicta nam distinctio consectetur non nulla blanditiis voluptas. Magni vero ut ut et tempora ut nam pariatur. Est consectetur et et ratione voluptas non.", "", 8163043, "Consequuntur.", 40 },
                    { new Guid("bfcfb55f-b8de-4254-83e4-8afa08c1a947"), new Guid("8582ccbd-c215-4c0a-be2c-24383cf5bdd1"), new DateTime(2024, 8, 16, 17, 47, 2, 683, DateTimeKind.Local).AddTicks(6709), "Aliquid non veritatis atque aut. Debitis omnis enim corrupti. Atque qui hic culpa reprehenderit maiores nemo.", "", 20813613, "Rerum.", 3656 },
                    { new Guid("cc07ccd7-009f-422d-a825-9d781f4b5308"), new Guid("c20a185a-4fa7-4429-ace2-72e12b033a6d"), new DateTime(2024, 8, 16, 17, 47, 2, 683, DateTimeKind.Local).AddTicks(8417), "Tenetur ad ut blanditiis quo tempora omnis libero. Qui vel in velit libero voluptatum optio consectetur. Minima ratione labore sit eum est. Quaerat aut ad possimus quia cupiditate dolor vitae. Aut sunt distinctio aut incidunt.", "", 66516074, "Accusamus.", 4381 },
                    { new Guid("ce353a56-b550-4a9e-97ce-4a16c958c977"), new Guid("9297f03d-2c44-496a-b8ed-50f808cd01e0"), new DateTime(2024, 8, 16, 17, 47, 2, 683, DateTimeKind.Local).AddTicks(7003), "Aut illo doloremque eaque quidem inventore dolorum exercitationem. Tenetur odio autem. Illum mollitia unde corrupti et. Nostrum vel dolor rerum distinctio. Omnis voluptas aut accusantium eaque dolor cum.", "", 29236123, "Cupiditate.", 4854 },
                    { new Guid("cf9609e4-33a5-475d-ada1-64b9a4b9457f"), new Guid("2b0c1a33-eaeb-4f42-80d3-a3331bdf1336"), new DateTime(2024, 8, 16, 17, 47, 2, 683, DateTimeKind.Local).AddTicks(5484), "Corporis voluptas aut consequatur hic ad. Recusandae autem eaque quia accusamus. Officia eius recusandae in cupiditate quo consequatur ut a nulla. Sit adipisci commodi voluptatem veritatis ducimus maxime nesciunt saepe. Recusandae hic ducimus aspernatur deleniti et commodi ipsa ut.", "", 93376144, "Molestiae.", 2198 },
                    { new Guid("dc774921-2129-4f39-b298-12bb936e789d"), new Guid("c20a185a-4fa7-4429-ace2-72e12b033a6d"), new DateTime(2024, 8, 16, 17, 47, 2, 683, DateTimeKind.Local).AddTicks(8175), "Molestias est sint voluptate. Praesentium autem architecto repellendus tempora minus provident numquam. Animi praesentium ex eum officiis consequatur ipsam sed eaque. Sit harum explicabo consequatur facilis. Suscipit beatae dolorem omnis omnis laudantium repellat atque minus.", "", 84182394, "Quia.", 1305 },
                    { new Guid("ea479b8c-b583-4a37-923e-e0b7233bf157"), new Guid("778e65e0-2680-4ff4-ad52-5b86d8e3be50"), new DateTime(2024, 8, 16, 17, 47, 2, 683, DateTimeKind.Local).AddTicks(3785), "Quia autem aut esse nihil ut optio. Et quo velit sit qui cupiditate. Consequuntur earum sint nobis vel quia.", "", 54670017, "Corporis.", 3770 },
                    { new Guid("fdec8d4a-06e7-4eb3-ab13-0d9018c3c808"), new Guid("c3792c19-adba-4999-bfc0-a23879a2bc6f"), new DateTime(2024, 8, 16, 17, 47, 2, 683, DateTimeKind.Local).AddTicks(6884), "Repudiandae dolorum id laudantium vero. Sapiente ut dolorem. Saepe omnis aliquid ut dolore officia iusto. Iure velit aut et aut qui sint quis sequi nobis. Ducimus suscipit aut necessitatibus consequatur sunt atque deleniti.", "", 41249832, "Nisi.", 4596 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("0a891372-e811-4a76-9439-a2797edcea46"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("107ca45a-86c1-4ae5-ae2b-634e9fb1e4e6"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("18a07a92-c421-4be8-8121-0682de97a009"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("21e0b1c0-f24f-4a78-9ff6-b656d309159a"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("25e0b759-dd20-40aa-9e73-8f8712313233"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("3195d2f4-52dc-40f9-9d35-13afec2eb738"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("3dd05f4a-9e67-4cf1-9302-4318225447a2"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("3de448f4-b5d1-43c4-97bb-4d1ad0be0e24"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("4209b425-3b15-4a25-8e3b-978ab20717f6"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("4278cfe2-50f4-4b88-bd67-cc3e1e63bd95"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("4cd53321-02ab-4ede-bf19-b1c1692608d8"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("50bb646e-ef77-4dab-ad64-c9b0ae3fb7dd"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("5c182dce-7a64-4e7a-a85b-fe29bab604ea"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("5cff88e1-fdcb-4fde-99f2-d632ebbfba56"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("833bba8c-b68e-493f-aab0-74b64e9a1bf3"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("851229b1-3db3-4611-8616-9820fbbd87a9"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("89b15e9d-c4ca-4e91-b474-2493b5c83075"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("8c5cd2bd-1751-49f0-848e-58b060ca6596"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("93735f5d-69fc-4c13-bba2-53a6dc489817"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("93e3cfb1-daa2-4887-acb5-eb0334a53b46"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("992ea8cc-caf7-44f3-9720-078ec8ed9d05"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("a0ca9b0e-97b9-4e0c-b804-cb5373ba6127"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("bee44680-e16b-47af-8853-64a173d34bfb"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("bfcfb55f-b8de-4254-83e4-8afa08c1a947"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("cc07ccd7-009f-422d-a825-9d781f4b5308"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("ce353a56-b550-4a9e-97ce-4a16c958c977"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("cf9609e4-33a5-475d-ada1-64b9a4b9457f"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("dc774921-2129-4f39-b298-12bb936e789d"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("ea479b8c-b583-4a37-923e-e0b7233bf157"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("fdec8d4a-06e7-4eb3-ab13-0d9018c3c808"));

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "ProductCategoryID",
                keyValue: new Guid("ef107c79-13be-4940-9cf3-d40c41b702f1"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "3afa045f-8617-43e2-8211-8ba622646174");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "e10d49e6-a2e1-43ce-b988-87a40e60bbfc");

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "ProductCategoryID",
                keyValue: new Guid("2b0c1a33-eaeb-4f42-80d3-a3331bdf1336"));

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "ProductCategoryID",
                keyValue: new Guid("6853a5ca-c4bc-4e80-a42e-f9e1fe20efd0"));

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "ProductCategoryID",
                keyValue: new Guid("778e65e0-2680-4ff4-ad52-5b86d8e3be50"));

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "ProductCategoryID",
                keyValue: new Guid("810ec16d-78e5-480a-94d0-ac2404ab2786"));

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "ProductCategoryID",
                keyValue: new Guid("8582ccbd-c215-4c0a-be2c-24383cf5bdd1"));

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "ProductCategoryID",
                keyValue: new Guid("9297f03d-2c44-496a-b8ed-50f808cd01e0"));

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "ProductCategoryID",
                keyValue: new Guid("a5a21684-d42c-4111-80f8-344b93cb2626"));

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "ProductCategoryID",
                keyValue: new Guid("c20a185a-4fa7-4429-ace2-72e12b033a6d"));

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "ProductCategoryID",
                keyValue: new Guid("c3792c19-adba-4999-bfc0-a23879a2bc6f"));

            migrationBuilder.DropColumn(
                name: "CreatedDay",
                table: "Promotion");

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
    }
}
