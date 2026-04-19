using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TicketFlow.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddReservationUserAndAudit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0202a046-5b97-4da8-8b0c-cdda5183c8eb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("025643d9-6fd1-4502-8621-27c33a20b942"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("03292de0-83f2-4b9d-ab37-cddd0e6e1c3d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("03b68653-6e92-45b7-962d-9e9cf3344138"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("065e2910-df2a-4bf6-bbf6-b7c0c73ca130"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("094883d5-f3ad-4d69-92d6-13f151d0f9b5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0e8a37c5-c9d7-4686-8631-b75ecdba5a02"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0f8a52d1-cb0b-4966-8d2a-c94be4f55b7e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("136037de-cd83-43d6-8d63-fe39a73d9d3b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("145be9b8-43a3-4085-8b4f-effb53a3503b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("18e2cacf-83cb-45e3-991e-8b185ce924c3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("206732de-a035-4808-b5ca-8dfd511b647d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("250d4f35-8929-4dbe-bcbf-c78de7daf9bc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2541b945-8808-4693-9f04-d29c0d147b52"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("25adfae1-e0fe-4039-a6d2-91a4aabcfcac"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("26850e48-77b0-48c4-966e-7a464bd58fc0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2755b48a-0f09-434e-9b8c-9946a9fe60d4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2ccd03de-aed6-4b31-9663-7e9543c6a18d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("308cc514-888b-4b05-abe3-ef6135470920"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("30b7b28e-6812-4949-badf-199b00f147e8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3514f7dc-e1a4-4380-a052-662389cc0a0b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3619b6cc-e227-4fc8-9e9e-a85cd6f7e743"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3669b857-6007-4612-a44a-2c364c412a49"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3d8fed55-468b-49af-85b6-425390e5c38b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3e63d703-298b-4a2e-9e3e-5a1baa7bff68"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3f558448-468d-4853-a26b-3f6c30d458a3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4065c6cd-f6a4-451d-9e93-b7f7789adc60"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("40a32b93-dbb0-40c5-ab30-574131d62cfe"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4103b6df-a6b1-4a31-85d3-4815de3d2bb4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("42562e91-88f0-48aa-b352-b453d93151a4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("433789e6-e19e-452b-9b9f-9ae9ed37a509"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4474655f-23f0-4566-b2d6-5cd8d05fe2a7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("463904f5-adaa-4d50-8213-74cb979a14e0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4d3b4be1-28d5-48dc-a4f0-7e35f426547b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("50a97312-da5b-4bfd-bf9f-a820809bfd60"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("50ed3c68-6fc9-471c-b41a-24e5b53b5a38"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("53017212-3de7-4f79-a8aa-688069445f8d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("55e9a790-8cd2-4fea-9f7e-9fa18c4b7680"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("56e5b24b-d76e-4c05-8fc4-a900cee47d90"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("58e7b881-96f8-4b39-bfb4-f222976a61f9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5acfe074-f131-4f9d-a229-4cbb05408f34"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5badab93-c929-45fe-a4bb-8d23dfb451c5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5ce8ffa4-92ef-4b36-bbdd-b9a3e16e928a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6022b1e7-81ee-4925-a03c-8398fae73d26"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("612dc299-1973-450b-bced-7c43fcbcb1d0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("63ea2c22-4177-4d95-a404-2148b97c8753"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6622cda5-18a9-4966-84fa-84e99788d6d7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("683cc6d3-faa4-4134-873e-f9ab0842fb8a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("687b142c-8f4b-4f39-92ba-a2c9617432b9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6bbefeef-6c05-4d90-aa94-76d336698ae2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("703d1f46-b591-4250-91f3-d78f3dc1c45d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7058f2f3-4674-4bb7-83d1-15f44156a12b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("73cc61a7-8b8d-4090-b164-18de49408e67"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("77f93cca-b1fd-4fcd-8af1-b3749bd38b2d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("798fa49d-0fb2-4675-be86-75fa1c274a80"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7f52a596-78c1-4645-8ccc-07cf8c54b56f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("828474c8-f596-44e0-8352-7165185f1875"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("85aca70e-8fc2-400f-ab9e-1aa35aa5dc10"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8709ad40-3295-4418-9071-99264202cdc0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8a9b040e-8128-4334-b918-f0eed328704e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("926dc2ee-6fb5-4928-97b0-5c2d0452e3c7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("92ac7f7e-c296-47c8-876d-63781046d267"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("92ecbd2a-4f7e-4585-81f1-25b371ecec5b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("934ea849-b7eb-407e-a863-ec1709a02a4c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("95db05fe-67d6-430c-a6dc-fc9916f4d55c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9a52cb9d-cc94-4818-94d3-a384b0e9230f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9e029466-6109-4080-9505-08b747ff02a6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9f668963-b121-47c9-9ad7-146700861b0a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a77dc70b-0643-4b7c-9da4-53b858e6334b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a80ee77f-fa62-4d87-8b46-3c6cc96cf575"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a96e0566-20ef-4a54-b98d-4f54dadf1bcd"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("adbd34df-6ef3-428c-bcb3-6ed810b31297"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ae508171-f18b-4e20-8452-efca3c6b36f8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("aebc0cb3-3386-4da2-9e1a-c068b8dc481a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b0791afd-5113-4cc5-a7a0-ae4c7db691c3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b64e2eee-080f-4a1b-9fe1-08e12dd61e3c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b7e3643d-6d28-4ec0-a25b-79fe953bab88"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("baaedf43-eead-453c-95b1-bae608c92ab8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bdd41749-a153-4809-975f-ca6f6c886413"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bded897b-9757-4fdb-a8ba-30c2d2b0c8a7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bedeadca-2f6a-4814-b456-4af4be061c79"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c4b133e9-4eec-4e9d-ae5f-d05c30614243"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cb40ef1a-f9a8-4e07-ad1b-e74540c876ac"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cd55baee-5b68-4166-92ae-b29fd957a10b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ce161f24-6e44-4ce1-9e6d-55a64ad026fc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("dbdedba5-57e8-4a7f-86c3-52704b381d0c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("deb8f823-7118-44f3-bfba-71a61b0579fa"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e1826b78-f963-4705-a153-a238acd09ab7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("eac573d1-7eea-4335-b64d-7696d31fe240"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f13700fc-f909-47af-9a94-e1be4f4cf056"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f1dd2067-1f83-4031-9002-11ae132a8c9a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f1f5e8e1-e58f-416f-88ee-ac15fd1f7f5b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f25a0709-32da-45f8-9275-da381d05b8b9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f514adc9-3d76-4b79-8e62-4906e32226db"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f75385c7-a671-4a6e-896f-0e810955b3ae"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f9571c5f-db8a-49b8-bfbb-1729196982d6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fa15b0cb-7fa8-4744-9a51-2cf936c156fa"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fa4388cb-dcdc-45ec-b9cf-7cfc47f216c5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fb16c8d3-7ee2-4397-95bc-3d9d1d441027"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fbb7be59-a921-458f-ba94-d3a31185c8f7"));

            migrationBuilder.CreateTable(
                name: "AuditLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Action = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EntityType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EntityId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditLogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    SeatId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ReservedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpiresAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservations_Seats_SeatId",
                        column: x => x.SeatId,
                        principalTable: "Seats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reservations_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "RowIdentifier", "SeatNumber", "SectorId", "Status", "Version" },
                values: new object[,]
                {
                    { new Guid("00b5e1b2-2d71-405e-824d-d7d090db1543"), "B", 19, 2, "Available", 1 },
                    { new Guid("010d10e4-388a-453f-92c1-31dafed7fbad"), "A", 4, 1, "Available", 1 },
                    { new Guid("0286176a-0494-4399-aaa0-ee8a9efa356f"), "A", 8, 1, "Available", 1 },
                    { new Guid("03b82c21-a3b0-459b-80b5-1bb7da48bc96"), "B", 47, 2, "Available", 1 },
                    { new Guid("046aac8a-46a0-4cc8-9358-56d90de5f015"), "B", 20, 2, "Available", 1 },
                    { new Guid("11f9b195-c3c1-48ab-b880-f319102102bd"), "B", 1, 2, "Available", 1 },
                    { new Guid("15223da0-71fd-48a1-9461-dfaac8dc4cfd"), "B", 26, 2, "Available", 1 },
                    { new Guid("15a9a2cc-72a2-44de-984f-9eff0760d008"), "B", 50, 2, "Available", 1 },
                    { new Guid("167ce08c-c615-49b5-9345-752293401c2e"), "B", 5, 2, "Available", 1 },
                    { new Guid("186404f9-ac5c-46cb-8a14-6be6200182b7"), "B", 32, 2, "Available", 1 },
                    { new Guid("1c65014b-4e07-4146-be94-419ceedaa2ff"), "B", 25, 2, "Available", 1 },
                    { new Guid("23ec113b-c338-4b5e-b416-beae1b192838"), "B", 8, 2, "Available", 1 },
                    { new Guid("24af3176-c767-4a9d-9bbd-b3e9082f025d"), "A", 39, 1, "Available", 1 },
                    { new Guid("27ad3a7a-2c64-4280-b01e-fd33f20d146b"), "A", 7, 1, "Available", 1 },
                    { new Guid("282063f8-c420-4322-8b59-dc1ee3d1c2b0"), "A", 17, 1, "Available", 1 },
                    { new Guid("28bc76a8-5f4c-400a-8f0e-80a00c5a5d45"), "B", 24, 2, "Available", 1 },
                    { new Guid("28efaada-362e-4643-8912-7fbe753920b7"), "A", 35, 1, "Available", 1 },
                    { new Guid("29df7c9e-80ec-4ba1-a0d4-1e7b92d4d951"), "B", 17, 2, "Available", 1 },
                    { new Guid("29eb86d7-e25e-4c94-b420-63664b149dc9"), "A", 27, 1, "Available", 1 },
                    { new Guid("3580391d-c711-4b3a-a533-fdc59cb67a0d"), "A", 41, 1, "Available", 1 },
                    { new Guid("35d4c8bc-9086-400b-91b6-f33a98080d7d"), "A", 36, 1, "Available", 1 },
                    { new Guid("3638e0af-2692-49b4-9943-16e6971a7523"), "B", 2, 2, "Available", 1 },
                    { new Guid("367b2e33-6338-4889-99d3-e010d12ec493"), "B", 30, 2, "Available", 1 },
                    { new Guid("37731e90-ca6b-4357-8e80-2797e3ca02d2"), "A", 28, 1, "Available", 1 },
                    { new Guid("3f0a0aaf-1bdc-4417-9dac-aee3adeaace7"), "A", 43, 1, "Available", 1 },
                    { new Guid("48009b98-3a10-403e-b59c-aaac7bf91a5b"), "B", 35, 2, "Available", 1 },
                    { new Guid("4c4c78e5-8ba9-407e-a619-94a858dddaae"), "A", 10, 1, "Available", 1 },
                    { new Guid("4c7255b1-495d-43db-ba53-f5c049af73a5"), "B", 23, 2, "Available", 1 },
                    { new Guid("5047adeb-67b8-495f-8393-0d2952c5d254"), "A", 40, 1, "Available", 1 },
                    { new Guid("52e6fe31-d2bf-4eca-a52b-2609193b9b5d"), "B", 10, 2, "Available", 1 },
                    { new Guid("555ae8bf-b374-4496-8cff-fede2a1444c7"), "B", 15, 2, "Available", 1 },
                    { new Guid("5618733c-f3a5-4951-9fe5-ae9df142afd1"), "A", 46, 1, "Available", 1 },
                    { new Guid("5b76252a-40fa-4122-84ae-ad814195d727"), "A", 49, 1, "Available", 1 },
                    { new Guid("5b777fbe-9c40-4220-ad2f-6b765e2f7f67"), "A", 1, 1, "Available", 1 },
                    { new Guid("62c013a2-3608-450f-8a53-81ceaa5a114e"), "A", 22, 1, "Available", 1 },
                    { new Guid("637b2930-5ac6-4bc7-80ed-2436875129a1"), "A", 30, 1, "Available", 1 },
                    { new Guid("65330b81-c1d4-4fdc-b7a4-1be7dea182bc"), "A", 11, 1, "Available", 1 },
                    { new Guid("68231cf2-2024-4e84-8f44-7ccd4a1480cd"), "A", 14, 1, "Available", 1 },
                    { new Guid("6b3ba1a8-1bc8-4e91-b933-19a7d4da350b"), "A", 44, 1, "Available", 1 },
                    { new Guid("6b7bf540-f975-4059-9742-ca4bfa0670a3"), "A", 16, 1, "Available", 1 },
                    { new Guid("71b8a684-9004-4977-bd2c-254158e8f2a3"), "B", 22, 2, "Available", 1 },
                    { new Guid("740fd539-1060-4aaa-820b-1457893de79b"), "B", 9, 2, "Available", 1 },
                    { new Guid("74e3af23-7b79-4268-bb34-b024cf3e4989"), "A", 38, 1, "Available", 1 },
                    { new Guid("766aafe8-b093-4e58-b509-3c49f86905ac"), "A", 20, 1, "Available", 1 },
                    { new Guid("7960ed4d-b942-4704-8140-e0724a5e5b35"), "B", 4, 2, "Available", 1 },
                    { new Guid("7a91a07e-6213-463f-9dc1-9b7b6d1d7bbe"), "A", 31, 1, "Available", 1 },
                    { new Guid("7aa86c02-6c72-435c-adbb-2bcd9849f380"), "A", 15, 1, "Available", 1 },
                    { new Guid("7db1d41f-f0a7-4a38-96ed-e355bb511fed"), "A", 6, 1, "Available", 1 },
                    { new Guid("84c8d2c6-e2e6-4ed9-88fc-d8d0b3addb70"), "B", 39, 2, "Available", 1 },
                    { new Guid("886ccb64-2bdb-47b4-885d-d6c724fe6d7a"), "B", 29, 2, "Available", 1 },
                    { new Guid("88f472a1-e04f-44e0-8883-863d6d398825"), "B", 13, 2, "Available", 1 },
                    { new Guid("89453466-8da4-4330-9392-88c6416d9886"), "B", 45, 2, "Available", 1 },
                    { new Guid("8c1b3f2c-d026-4b87-85ed-817bef53da9e"), "A", 23, 1, "Available", 1 },
                    { new Guid("8e435141-bf59-4f3b-a516-9d7addc6b5f2"), "B", 11, 2, "Available", 1 },
                    { new Guid("8e664ca3-404b-4070-b1b2-a91a38982632"), "A", 5, 1, "Available", 1 },
                    { new Guid("8ee7722d-bc22-4e46-aff2-97a8929a8126"), "B", 27, 2, "Available", 1 },
                    { new Guid("91882da0-6fa4-4b72-b96d-56f95777dd8f"), "B", 48, 2, "Available", 1 },
                    { new Guid("93576ab2-ff5b-4b6e-a867-5ca6ed6068a7"), "B", 37, 2, "Available", 1 },
                    { new Guid("940c684a-cfa2-4952-b71f-fdfeb3ad623f"), "A", 33, 1, "Available", 1 },
                    { new Guid("9678e4d2-b08a-4e12-9db4-1cff8f1b2ad7"), "B", 49, 2, "Available", 1 },
                    { new Guid("96846c2b-d5f8-4eca-a01a-3444ed1b1ab0"), "B", 43, 2, "Available", 1 },
                    { new Guid("96cec133-6b01-46c4-8441-d98595617492"), "A", 18, 1, "Available", 1 },
                    { new Guid("973ac3f5-c9c3-4b18-a8d1-398f860c7cee"), "A", 21, 1, "Available", 1 },
                    { new Guid("988782d8-2d28-4270-9acd-c1b6b914e2a3"), "A", 24, 1, "Available", 1 },
                    { new Guid("98d973d9-4e6a-416a-90a9-76b257f64e0b"), "B", 16, 2, "Available", 1 },
                    { new Guid("9aab7bab-5939-4789-8195-0439ec6bc138"), "B", 36, 2, "Available", 1 },
                    { new Guid("9bd0e2ea-d307-4f7a-b346-ed802534f7b1"), "B", 34, 2, "Available", 1 },
                    { new Guid("9c421316-7893-4780-ba28-322a8af7566f"), "B", 14, 2, "Available", 1 },
                    { new Guid("9c6529ba-b14f-41d4-81d8-7c92079c0c3b"), "A", 45, 1, "Available", 1 },
                    { new Guid("9ff83104-6326-4832-b30c-e69f3dca8d19"), "B", 44, 2, "Available", 1 },
                    { new Guid("9ff9b21f-5456-418b-bc0c-9147cda5d8f4"), "A", 2, 1, "Available", 1 },
                    { new Guid("a0b4b86f-59eb-421d-b5e0-32b2150f53e1"), "B", 12, 2, "Available", 1 },
                    { new Guid("a6a0ffcc-fa67-412c-ab2b-aaece3e430f1"), "B", 46, 2, "Available", 1 },
                    { new Guid("a882619d-1260-4208-b61d-d06722f59e6a"), "B", 6, 2, "Available", 1 },
                    { new Guid("a8b6238f-f3c9-4664-a4a9-4475dfc0eac0"), "A", 26, 1, "Available", 1 },
                    { new Guid("a8ccb309-a7c9-4266-a51c-6f51e5b4914d"), "A", 34, 1, "Available", 1 },
                    { new Guid("a9029da2-1391-4063-bd18-6ddda46810e8"), "A", 29, 1, "Available", 1 },
                    { new Guid("b721393f-aeb7-4079-a95e-a6569d5f6252"), "A", 13, 1, "Available", 1 },
                    { new Guid("b74fb0ce-e71c-44cb-a5b8-ec6aa1ac8f60"), "B", 38, 2, "Available", 1 },
                    { new Guid("bd9d6b9a-c590-4bd1-b56d-f16cc8cebe7f"), "B", 7, 2, "Available", 1 },
                    { new Guid("be56f09a-d421-42ce-a2bd-efc2a546c116"), "A", 19, 1, "Available", 1 },
                    { new Guid("c009c0ac-aa80-4c98-9928-b6cb888ee07c"), "B", 3, 2, "Available", 1 },
                    { new Guid("c117ef32-bf93-497f-a377-2fa9334f2450"), "A", 47, 1, "Available", 1 },
                    { new Guid("c501c2b4-9a8e-4eed-8989-8dc4c8d478c7"), "A", 32, 1, "Available", 1 },
                    { new Guid("c5863bfc-6bb8-4462-be1b-29a8a0b5ee95"), "B", 18, 2, "Available", 1 },
                    { new Guid("c631a2f8-8f67-4a95-bc34-826b730df7e6"), "A", 37, 1, "Available", 1 },
                    { new Guid("c6cd4c37-5a27-42bf-af8c-290f067a46d7"), "B", 33, 2, "Available", 1 },
                    { new Guid("c7e99cee-5936-47b1-8002-41967cdfd555"), "B", 28, 2, "Available", 1 },
                    { new Guid("c7f028ac-6ac5-4fde-92bc-c6248c937a59"), "B", 42, 2, "Available", 1 },
                    { new Guid("d159f490-b626-4165-8f42-00a711e9f8e9"), "A", 9, 1, "Available", 1 },
                    { new Guid("d44bd392-f5c9-4f49-a68e-71e4b1a8e126"), "A", 42, 1, "Available", 1 },
                    { new Guid("d775e9c6-bbf8-4042-9dcf-3db882398d8e"), "B", 41, 2, "Available", 1 },
                    { new Guid("d8654778-d833-426a-83de-0dd9f3e234b8"), "A", 3, 1, "Available", 1 },
                    { new Guid("da11155d-d8c4-4668-b21f-49a76fcbdcda"), "A", 25, 1, "Available", 1 },
                    { new Guid("dc46415e-3f4c-4061-af5d-a22e561f9cb1"), "A", 12, 1, "Available", 1 },
                    { new Guid("e5c7acbc-e658-415f-865f-9c529ed95539"), "B", 21, 2, "Available", 1 },
                    { new Guid("e6e6f2f3-3f58-4bb8-9ca9-0b3914d9a8eb"), "A", 48, 1, "Available", 1 },
                    { new Guid("f0754b9c-5f0c-4d92-904a-ca0770b9d7de"), "B", 40, 2, "Available", 1 },
                    { new Guid("f4c8d7af-a642-4a14-8c88-a7d7771485d5"), "A", 50, 1, "Available", 1 },
                    { new Guid("ff6af541-3da6-48a7-bd50-328df4735077"), "B", 31, 2, "Available", 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_SeatId",
                table: "Reservations",
                column: "SeatId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_UserId",
                table: "Reservations",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuditLogs");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("00b5e1b2-2d71-405e-824d-d7d090db1543"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("010d10e4-388a-453f-92c1-31dafed7fbad"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0286176a-0494-4399-aaa0-ee8a9efa356f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("03b82c21-a3b0-459b-80b5-1bb7da48bc96"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("046aac8a-46a0-4cc8-9358-56d90de5f015"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("11f9b195-c3c1-48ab-b880-f319102102bd"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("15223da0-71fd-48a1-9461-dfaac8dc4cfd"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("15a9a2cc-72a2-44de-984f-9eff0760d008"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("167ce08c-c615-49b5-9345-752293401c2e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("186404f9-ac5c-46cb-8a14-6be6200182b7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1c65014b-4e07-4146-be94-419ceedaa2ff"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("23ec113b-c338-4b5e-b416-beae1b192838"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("24af3176-c767-4a9d-9bbd-b3e9082f025d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("27ad3a7a-2c64-4280-b01e-fd33f20d146b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("282063f8-c420-4322-8b59-dc1ee3d1c2b0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("28bc76a8-5f4c-400a-8f0e-80a00c5a5d45"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("28efaada-362e-4643-8912-7fbe753920b7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("29df7c9e-80ec-4ba1-a0d4-1e7b92d4d951"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("29eb86d7-e25e-4c94-b420-63664b149dc9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3580391d-c711-4b3a-a533-fdc59cb67a0d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("35d4c8bc-9086-400b-91b6-f33a98080d7d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3638e0af-2692-49b4-9943-16e6971a7523"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("367b2e33-6338-4889-99d3-e010d12ec493"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("37731e90-ca6b-4357-8e80-2797e3ca02d2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3f0a0aaf-1bdc-4417-9dac-aee3adeaace7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("48009b98-3a10-403e-b59c-aaac7bf91a5b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4c4c78e5-8ba9-407e-a619-94a858dddaae"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4c7255b1-495d-43db-ba53-f5c049af73a5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5047adeb-67b8-495f-8393-0d2952c5d254"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("52e6fe31-d2bf-4eca-a52b-2609193b9b5d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("555ae8bf-b374-4496-8cff-fede2a1444c7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5618733c-f3a5-4951-9fe5-ae9df142afd1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5b76252a-40fa-4122-84ae-ad814195d727"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5b777fbe-9c40-4220-ad2f-6b765e2f7f67"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("62c013a2-3608-450f-8a53-81ceaa5a114e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("637b2930-5ac6-4bc7-80ed-2436875129a1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("65330b81-c1d4-4fdc-b7a4-1be7dea182bc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("68231cf2-2024-4e84-8f44-7ccd4a1480cd"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6b3ba1a8-1bc8-4e91-b933-19a7d4da350b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6b7bf540-f975-4059-9742-ca4bfa0670a3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("71b8a684-9004-4977-bd2c-254158e8f2a3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("740fd539-1060-4aaa-820b-1457893de79b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("74e3af23-7b79-4268-bb34-b024cf3e4989"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("766aafe8-b093-4e58-b509-3c49f86905ac"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7960ed4d-b942-4704-8140-e0724a5e5b35"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7a91a07e-6213-463f-9dc1-9b7b6d1d7bbe"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7aa86c02-6c72-435c-adbb-2bcd9849f380"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7db1d41f-f0a7-4a38-96ed-e355bb511fed"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("84c8d2c6-e2e6-4ed9-88fc-d8d0b3addb70"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("886ccb64-2bdb-47b4-885d-d6c724fe6d7a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("88f472a1-e04f-44e0-8883-863d6d398825"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("89453466-8da4-4330-9392-88c6416d9886"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8c1b3f2c-d026-4b87-85ed-817bef53da9e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8e435141-bf59-4f3b-a516-9d7addc6b5f2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8e664ca3-404b-4070-b1b2-a91a38982632"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8ee7722d-bc22-4e46-aff2-97a8929a8126"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("91882da0-6fa4-4b72-b96d-56f95777dd8f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("93576ab2-ff5b-4b6e-a867-5ca6ed6068a7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("940c684a-cfa2-4952-b71f-fdfeb3ad623f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9678e4d2-b08a-4e12-9db4-1cff8f1b2ad7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("96846c2b-d5f8-4eca-a01a-3444ed1b1ab0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("96cec133-6b01-46c4-8441-d98595617492"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("973ac3f5-c9c3-4b18-a8d1-398f860c7cee"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("988782d8-2d28-4270-9acd-c1b6b914e2a3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("98d973d9-4e6a-416a-90a9-76b257f64e0b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9aab7bab-5939-4789-8195-0439ec6bc138"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9bd0e2ea-d307-4f7a-b346-ed802534f7b1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9c421316-7893-4780-ba28-322a8af7566f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9c6529ba-b14f-41d4-81d8-7c92079c0c3b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9ff83104-6326-4832-b30c-e69f3dca8d19"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9ff9b21f-5456-418b-bc0c-9147cda5d8f4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a0b4b86f-59eb-421d-b5e0-32b2150f53e1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a6a0ffcc-fa67-412c-ab2b-aaece3e430f1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a882619d-1260-4208-b61d-d06722f59e6a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a8b6238f-f3c9-4664-a4a9-4475dfc0eac0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a8ccb309-a7c9-4266-a51c-6f51e5b4914d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a9029da2-1391-4063-bd18-6ddda46810e8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b721393f-aeb7-4079-a95e-a6569d5f6252"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b74fb0ce-e71c-44cb-a5b8-ec6aa1ac8f60"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bd9d6b9a-c590-4bd1-b56d-f16cc8cebe7f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("be56f09a-d421-42ce-a2bd-efc2a546c116"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c009c0ac-aa80-4c98-9928-b6cb888ee07c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c117ef32-bf93-497f-a377-2fa9334f2450"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c501c2b4-9a8e-4eed-8989-8dc4c8d478c7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c5863bfc-6bb8-4462-be1b-29a8a0b5ee95"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c631a2f8-8f67-4a95-bc34-826b730df7e6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c6cd4c37-5a27-42bf-af8c-290f067a46d7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c7e99cee-5936-47b1-8002-41967cdfd555"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c7f028ac-6ac5-4fde-92bc-c6248c937a59"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d159f490-b626-4165-8f42-00a711e9f8e9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d44bd392-f5c9-4f49-a68e-71e4b1a8e126"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d775e9c6-bbf8-4042-9dcf-3db882398d8e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d8654778-d833-426a-83de-0dd9f3e234b8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("da11155d-d8c4-4668-b21f-49a76fcbdcda"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("dc46415e-3f4c-4061-af5d-a22e561f9cb1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e5c7acbc-e658-415f-865f-9c529ed95539"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e6e6f2f3-3f58-4bb8-9ca9-0b3914d9a8eb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f0754b9c-5f0c-4d92-904a-ca0770b9d7de"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f4c8d7af-a642-4a14-8c88-a7d7771485d5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ff6af541-3da6-48a7-bd50-328df4735077"));

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "RowIdentifier", "SeatNumber", "SectorId", "Status", "Version" },
                values: new object[,]
                {
                    { new Guid("0202a046-5b97-4da8-8b0c-cdda5183c8eb"), "B", 46, 2, "Available", 1 },
                    { new Guid("025643d9-6fd1-4502-8621-27c33a20b942"), "B", 45, 2, "Available", 1 },
                    { new Guid("03292de0-83f2-4b9d-ab37-cddd0e6e1c3d"), "B", 47, 2, "Available", 1 },
                    { new Guid("03b68653-6e92-45b7-962d-9e9cf3344138"), "A", 6, 1, "Available", 1 },
                    { new Guid("065e2910-df2a-4bf6-bbf6-b7c0c73ca130"), "A", 31, 1, "Available", 1 },
                    { new Guid("094883d5-f3ad-4d69-92d6-13f151d0f9b5"), "A", 20, 1, "Available", 1 },
                    { new Guid("0e8a37c5-c9d7-4686-8631-b75ecdba5a02"), "B", 23, 2, "Available", 1 },
                    { new Guid("0f8a52d1-cb0b-4966-8d2a-c94be4f55b7e"), "B", 21, 2, "Available", 1 },
                    { new Guid("136037de-cd83-43d6-8d63-fe39a73d9d3b"), "B", 17, 2, "Available", 1 },
                    { new Guid("145be9b8-43a3-4085-8b4f-effb53a3503b"), "B", 25, 2, "Available", 1 },
                    { new Guid("18e2cacf-83cb-45e3-991e-8b185ce924c3"), "B", 6, 2, "Available", 1 },
                    { new Guid("206732de-a035-4808-b5ca-8dfd511b647d"), "B", 11, 2, "Available", 1 },
                    { new Guid("250d4f35-8929-4dbe-bcbf-c78de7daf9bc"), "B", 37, 2, "Available", 1 },
                    { new Guid("2541b945-8808-4693-9f04-d29c0d147b52"), "A", 49, 1, "Available", 1 },
                    { new Guid("25adfae1-e0fe-4039-a6d2-91a4aabcfcac"), "A", 42, 1, "Available", 1 },
                    { new Guid("26850e48-77b0-48c4-966e-7a464bd58fc0"), "B", 29, 2, "Available", 1 },
                    { new Guid("2755b48a-0f09-434e-9b8c-9946a9fe60d4"), "B", 5, 2, "Available", 1 },
                    { new Guid("2ccd03de-aed6-4b31-9663-7e9543c6a18d"), "A", 38, 1, "Available", 1 },
                    { new Guid("308cc514-888b-4b05-abe3-ef6135470920"), "A", 25, 1, "Available", 1 },
                    { new Guid("30b7b28e-6812-4949-badf-199b00f147e8"), "B", 20, 2, "Available", 1 },
                    { new Guid("3514f7dc-e1a4-4380-a052-662389cc0a0b"), "A", 24, 1, "Available", 1 },
                    { new Guid("3619b6cc-e227-4fc8-9e9e-a85cd6f7e743"), "A", 11, 1, "Available", 1 },
                    { new Guid("3669b857-6007-4612-a44a-2c364c412a49"), "B", 49, 2, "Available", 1 },
                    { new Guid("3d8fed55-468b-49af-85b6-425390e5c38b"), "B", 9, 2, "Available", 1 },
                    { new Guid("3e63d703-298b-4a2e-9e3e-5a1baa7bff68"), "B", 24, 2, "Available", 1 },
                    { new Guid("3f558448-468d-4853-a26b-3f6c30d458a3"), "B", 13, 2, "Available", 1 },
                    { new Guid("4065c6cd-f6a4-451d-9e93-b7f7789adc60"), "B", 31, 2, "Available", 1 },
                    { new Guid("40a32b93-dbb0-40c5-ab30-574131d62cfe"), "A", 5, 1, "Available", 1 },
                    { new Guid("4103b6df-a6b1-4a31-85d3-4815de3d2bb4"), "B", 32, 2, "Available", 1 },
                    { new Guid("42562e91-88f0-48aa-b352-b453d93151a4"), "A", 36, 1, "Available", 1 },
                    { new Guid("433789e6-e19e-452b-9b9f-9ae9ed37a509"), "B", 1, 2, "Available", 1 },
                    { new Guid("4474655f-23f0-4566-b2d6-5cd8d05fe2a7"), "A", 23, 1, "Available", 1 },
                    { new Guid("463904f5-adaa-4d50-8213-74cb979a14e0"), "A", 1, 1, "Available", 1 },
                    { new Guid("4d3b4be1-28d5-48dc-a4f0-7e35f426547b"), "A", 47, 1, "Available", 1 },
                    { new Guid("50a97312-da5b-4bfd-bf9f-a820809bfd60"), "B", 3, 2, "Available", 1 },
                    { new Guid("50ed3c68-6fc9-471c-b41a-24e5b53b5a38"), "A", 3, 1, "Available", 1 },
                    { new Guid("53017212-3de7-4f79-a8aa-688069445f8d"), "A", 40, 1, "Available", 1 },
                    { new Guid("55e9a790-8cd2-4fea-9f7e-9fa18c4b7680"), "A", 34, 1, "Available", 1 },
                    { new Guid("56e5b24b-d76e-4c05-8fc4-a900cee47d90"), "B", 12, 2, "Available", 1 },
                    { new Guid("58e7b881-96f8-4b39-bfb4-f222976a61f9"), "B", 19, 2, "Available", 1 },
                    { new Guid("5acfe074-f131-4f9d-a229-4cbb05408f34"), "B", 42, 2, "Available", 1 },
                    { new Guid("5badab93-c929-45fe-a4bb-8d23dfb451c5"), "B", 18, 2, "Available", 1 },
                    { new Guid("5ce8ffa4-92ef-4b36-bbdd-b9a3e16e928a"), "A", 16, 1, "Available", 1 },
                    { new Guid("6022b1e7-81ee-4925-a03c-8398fae73d26"), "A", 14, 1, "Available", 1 },
                    { new Guid("612dc299-1973-450b-bced-7c43fcbcb1d0"), "A", 33, 1, "Available", 1 },
                    { new Guid("63ea2c22-4177-4d95-a404-2148b97c8753"), "A", 41, 1, "Available", 1 },
                    { new Guid("6622cda5-18a9-4966-84fa-84e99788d6d7"), "B", 39, 2, "Available", 1 },
                    { new Guid("683cc6d3-faa4-4134-873e-f9ab0842fb8a"), "B", 40, 2, "Available", 1 },
                    { new Guid("687b142c-8f4b-4f39-92ba-a2c9617432b9"), "B", 10, 2, "Available", 1 },
                    { new Guid("6bbefeef-6c05-4d90-aa94-76d336698ae2"), "A", 12, 1, "Available", 1 },
                    { new Guid("703d1f46-b591-4250-91f3-d78f3dc1c45d"), "B", 41, 2, "Available", 1 },
                    { new Guid("7058f2f3-4674-4bb7-83d1-15f44156a12b"), "A", 17, 1, "Available", 1 },
                    { new Guid("73cc61a7-8b8d-4090-b164-18de49408e67"), "A", 45, 1, "Available", 1 },
                    { new Guid("77f93cca-b1fd-4fcd-8af1-b3749bd38b2d"), "B", 48, 2, "Available", 1 },
                    { new Guid("798fa49d-0fb2-4675-be86-75fa1c274a80"), "B", 15, 2, "Available", 1 },
                    { new Guid("7f52a596-78c1-4645-8ccc-07cf8c54b56f"), "A", 28, 1, "Available", 1 },
                    { new Guid("828474c8-f596-44e0-8352-7165185f1875"), "A", 10, 1, "Available", 1 },
                    { new Guid("85aca70e-8fc2-400f-ab9e-1aa35aa5dc10"), "A", 4, 1, "Available", 1 },
                    { new Guid("8709ad40-3295-4418-9071-99264202cdc0"), "B", 8, 2, "Available", 1 },
                    { new Guid("8a9b040e-8128-4334-b918-f0eed328704e"), "B", 4, 2, "Available", 1 },
                    { new Guid("926dc2ee-6fb5-4928-97b0-5c2d0452e3c7"), "A", 15, 1, "Available", 1 },
                    { new Guid("92ac7f7e-c296-47c8-876d-63781046d267"), "B", 28, 2, "Available", 1 },
                    { new Guid("92ecbd2a-4f7e-4585-81f1-25b371ecec5b"), "A", 18, 1, "Available", 1 },
                    { new Guid("934ea849-b7eb-407e-a863-ec1709a02a4c"), "A", 30, 1, "Available", 1 },
                    { new Guid("95db05fe-67d6-430c-a6dc-fc9916f4d55c"), "A", 46, 1, "Available", 1 },
                    { new Guid("9a52cb9d-cc94-4818-94d3-a384b0e9230f"), "B", 26, 2, "Available", 1 },
                    { new Guid("9e029466-6109-4080-9505-08b747ff02a6"), "B", 27, 2, "Available", 1 },
                    { new Guid("9f668963-b121-47c9-9ad7-146700861b0a"), "A", 35, 1, "Available", 1 },
                    { new Guid("a77dc70b-0643-4b7c-9da4-53b858e6334b"), "A", 43, 1, "Available", 1 },
                    { new Guid("a80ee77f-fa62-4d87-8b46-3c6cc96cf575"), "A", 37, 1, "Available", 1 },
                    { new Guid("a96e0566-20ef-4a54-b98d-4f54dadf1bcd"), "A", 44, 1, "Available", 1 },
                    { new Guid("adbd34df-6ef3-428c-bcb3-6ed810b31297"), "A", 22, 1, "Available", 1 },
                    { new Guid("ae508171-f18b-4e20-8452-efca3c6b36f8"), "A", 50, 1, "Available", 1 },
                    { new Guid("aebc0cb3-3386-4da2-9e1a-c068b8dc481a"), "B", 43, 2, "Available", 1 },
                    { new Guid("b0791afd-5113-4cc5-a7a0-ae4c7db691c3"), "A", 39, 1, "Available", 1 },
                    { new Guid("b64e2eee-080f-4a1b-9fe1-08e12dd61e3c"), "A", 27, 1, "Available", 1 },
                    { new Guid("b7e3643d-6d28-4ec0-a25b-79fe953bab88"), "B", 44, 2, "Available", 1 },
                    { new Guid("baaedf43-eead-453c-95b1-bae608c92ab8"), "A", 29, 1, "Available", 1 },
                    { new Guid("bdd41749-a153-4809-975f-ca6f6c886413"), "B", 33, 2, "Available", 1 },
                    { new Guid("bded897b-9757-4fdb-a8ba-30c2d2b0c8a7"), "A", 9, 1, "Available", 1 },
                    { new Guid("bedeadca-2f6a-4814-b456-4af4be061c79"), "B", 35, 2, "Available", 1 },
                    { new Guid("c4b133e9-4eec-4e9d-ae5f-d05c30614243"), "A", 48, 1, "Available", 1 },
                    { new Guid("cb40ef1a-f9a8-4e07-ad1b-e74540c876ac"), "B", 2, 2, "Available", 1 },
                    { new Guid("cd55baee-5b68-4166-92ae-b29fd957a10b"), "B", 34, 2, "Available", 1 },
                    { new Guid("ce161f24-6e44-4ce1-9e6d-55a64ad026fc"), "A", 7, 1, "Available", 1 },
                    { new Guid("dbdedba5-57e8-4a7f-86c3-52704b381d0c"), "A", 19, 1, "Available", 1 },
                    { new Guid("deb8f823-7118-44f3-bfba-71a61b0579fa"), "A", 32, 1, "Available", 1 },
                    { new Guid("e1826b78-f963-4705-a153-a238acd09ab7"), "B", 22, 2, "Available", 1 },
                    { new Guid("eac573d1-7eea-4335-b64d-7696d31fe240"), "B", 30, 2, "Available", 1 },
                    { new Guid("f13700fc-f909-47af-9a94-e1be4f4cf056"), "B", 50, 2, "Available", 1 },
                    { new Guid("f1dd2067-1f83-4031-9002-11ae132a8c9a"), "A", 26, 1, "Available", 1 },
                    { new Guid("f1f5e8e1-e58f-416f-88ee-ac15fd1f7f5b"), "A", 8, 1, "Available", 1 },
                    { new Guid("f25a0709-32da-45f8-9275-da381d05b8b9"), "B", 16, 2, "Available", 1 },
                    { new Guid("f514adc9-3d76-4b79-8e62-4906e32226db"), "B", 7, 2, "Available", 1 },
                    { new Guid("f75385c7-a671-4a6e-896f-0e810955b3ae"), "B", 38, 2, "Available", 1 },
                    { new Guid("f9571c5f-db8a-49b8-bfbb-1729196982d6"), "A", 2, 1, "Available", 1 },
                    { new Guid("fa15b0cb-7fa8-4744-9a51-2cf936c156fa"), "A", 13, 1, "Available", 1 },
                    { new Guid("fa4388cb-dcdc-45ec-b9cf-7cfc47f216c5"), "B", 36, 2, "Available", 1 },
                    { new Guid("fb16c8d3-7ee2-4397-95bc-3d9d1d441027"), "B", 14, 2, "Available", 1 },
                    { new Guid("fbb7be59-a921-458f-ba94-d3a31185c8f7"), "A", 21, 1, "Available", 1 }
                });
        }
    }
}
