using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ASP.NET_API.Migrations
{
    /// <inheritdoc />
    public partial class V2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("06f29673-ffe4-459d-a93d-a05cdbaa7ecf"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("089657ad-aca2-4063-bb61-55567ce9b8ef"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("0965cb87-dbbb-4a9b-bc2c-7c8de9d1e7c4"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("0ab9abbe-f0a9-4f26-b3ae-9ab7771ce5b9"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("0cc28e4f-10ad-46a4-8a77-867b56615927"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("1525e829-df3d-4d9d-9561-ba9b419f164c"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("1840ebde-fea2-45ed-a719-7120ff26fbaf"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("32584661-7b84-4612-8041-fed23d5ac475"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("3ddab5c4-b3b1-4521-9069-cb054b099c61"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("424e008d-d3d4-4414-b2a2-6e30d86de161"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("4658013f-b9c6-4abd-a00a-bc759da19d28"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("5329ff04-3f44-47aa-ab42-5c87226b2934"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("54bb077f-a0a8-4a35-9d24-a889d3d7a895"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("679afb9d-19e8-4c68-81a0-251da50541bb"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("70638512-ca68-468a-871b-072b5c6d57a6"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("7960dc1b-a5e2-497b-9050-80eefff475c8"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("7c083059-b390-4ed5-b0a3-e765bccc7296"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("7e63546a-8ac6-403d-8b09-df40fd05fa2b"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("819e0079-69dd-4e5c-9ddf-b23c5badced3"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("8260105f-f71e-4d41-b227-83cac6674919"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("86c852ac-faf1-42bd-83fd-32e0d079298f"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("89263a97-8cee-4f9a-b050-e325aeb789eb"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("94add515-3e71-4da8-8d0d-50d78fca5f63"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("b6ee1cb4-7537-43ae-899e-ce599030adc3"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("b9b94eaf-0bb0-4a9a-8b37-1e189f148575"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("bcc176e3-3a9c-4a76-92f6-a46a9c44c47f"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("ca580b4f-d42e-4c52-81cb-51160a83086f"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("cfd0e836-9a5d-45a5-b6a1-7c0ede9a4866"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("e17dd0e4-c2e1-40a6-a74a-11dd61737364"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: new Guid("e662cfa0-7936-4b8c-bb79-bd3bf125084b"));

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "ProductCategoryID",
                keyValue: new Guid("b91e8ba3-a5b4-4278-b055-b6e1c8ef4b87"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "73de7301-0fdd-4b00-9501-6cf6a1f0b7d9");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "be5dd9f3-a8b6-4dc0-a54e-a7e554c935a5");

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "ProductCategoryID",
                keyValue: new Guid("0be413f7-9034-49fc-abe3-d250e88db135"));

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "ProductCategoryID",
                keyValue: new Guid("12e597b6-4a43-4727-b68a-5b0f5338198f"));

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "ProductCategoryID",
                keyValue: new Guid("2f9f9268-5c93-49f7-b783-60477a681435"));

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "ProductCategoryID",
                keyValue: new Guid("5019949c-ca28-49c0-b78f-4edfab60d0db"));

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "ProductCategoryID",
                keyValue: new Guid("58ea6f54-e71b-48c3-a6f6-82e192018995"));

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "ProductCategoryID",
                keyValue: new Guid("9079d96a-ec4b-4979-b8eb-435d5ef53c60"));

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "ProductCategoryID",
                keyValue: new Guid("9b103844-3b33-405b-86b1-4f832f7bd370"));

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "ProductCategoryID",
                keyValue: new Guid("b38e6c6d-013b-42ff-a5bc-ffc40f44e331"));

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "ProductCategoryID",
                keyValue: new Guid("ec4a965f-d2b3-4abe-b204-31a1673cfc53"));

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "WishList");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "WishList",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
        }
    }
}
