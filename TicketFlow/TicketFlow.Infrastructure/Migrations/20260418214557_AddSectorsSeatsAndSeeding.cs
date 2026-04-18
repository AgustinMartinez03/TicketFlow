using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TicketFlow.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddSectorsSeatsAndSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sectors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sectors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sectors_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Seats",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SectorId = table.Column<int>(type: "int", nullable: false),
                    RowIdentifier = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    SeatNumber = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Seats_Sectors_SectorId",
                        column: x => x.SectorId,
                        principalTable: "Sectors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "EventDate", "Name", "Status", "Venue" },
                values: new object[] { 1, new DateTime(2026, 10, 15, 20, 0, 0, 0, DateTimeKind.Unspecified), "Concierto de Rock Universitario", "Active", "Estadio UNAJ" });

            migrationBuilder.InsertData(
                table: "Sectors",
                columns: new[] { "Id", "Capacity", "EventId", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 50, 1, "VIP", 15000.00m },
                    { 2, 50, 1, "General", 5000.00m }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Seats_SectorId",
                table: "Seats",
                column: "SectorId");

            migrationBuilder.CreateIndex(
                name: "IX_Sectors_EventId",
                table: "Sectors",
                column: "EventId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Seats");

            migrationBuilder.DropTable(
                name: "Sectors");

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
