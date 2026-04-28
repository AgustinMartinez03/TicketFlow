using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TicketFlow.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    EventDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Venue = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
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
                name: "AuditLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    Action = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EntityType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EntityId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AuditLogs_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
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
                table: "Events",
                columns: new[] { "Id", "EventDate", "Name", "Status", "Venue" },
                values: new object[] { 1, new DateTime(2026, 10, 15, 20, 0, 0, 0, DateTimeKind.Unspecified), "Concierto de Rock Universitario", "Active", "Estadio UNAJ" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "PasswordHash" },
                values: new object[,]
                {
                    { 1, "agus@ticketflow.com", "Agustin", "123456" },
                    { 2, "ale@ticketflow.com", "Alejandro", "123456" }
                });

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
                    { new Guid("01c430c1-42cc-4872-a29b-0980fb1e48f6"), "E", 1, 2, "Available", 1 },
                    { new Guid("07f6f1dc-71cb-4813-ae4a-0613c092700c"), "E", 3, 2, "Available", 1 },
                    { new Guid("081fa2c9-bd7c-424c-8876-72773c6e06cd"), "C", 5, 2, "Available", 1 },
                    { new Guid("0d484b8f-39f1-4229-981d-ff21700e7a73"), "B", 1, 1, "Available", 1 },
                    { new Guid("0f33f8ab-c6a7-49fc-b01a-e2169ecb5ca3"), "A", 10, 1, "Available", 1 },
                    { new Guid("12dcfe06-7fe4-44ef-8777-f99277aa9154"), "A", 3, 1, "Available", 1 },
                    { new Guid("14224af6-fd9e-4556-98f5-be652630c68c"), "E", 5, 2, "Available", 1 },
                    { new Guid("15554ac2-ebda-486a-94dd-6e7219b070e6"), "D", 2, 2, "Available", 1 },
                    { new Guid("17db3074-2ca7-4848-bbb1-3d93607dc55d"), "A", 2, 1, "Available", 1 },
                    { new Guid("1956f04f-c369-41b1-8c0e-21712f8ffae8"), "A", 6, 2, "Available", 1 },
                    { new Guid("1ba0aa70-50e0-4793-a564-b700eac91551"), "D", 3, 1, "Available", 1 },
                    { new Guid("1ddb6d16-0550-4072-ba9e-f3a8d223360d"), "A", 9, 1, "Available", 1 },
                    { new Guid("1efde5fb-9ac5-4006-8961-30154a478f60"), "D", 10, 1, "Available", 1 },
                    { new Guid("2018f535-5289-4fca-98c5-b9b161e1b7e2"), "A", 4, 1, "Available", 1 },
                    { new Guid("21fae280-a93e-45e6-befa-c0bb38fe425b"), "E", 4, 2, "Available", 1 },
                    { new Guid("22c99fb3-59eb-4c1c-940a-b54208c84285"), "A", 5, 1, "Available", 1 },
                    { new Guid("23d614d8-d0c5-4dae-9ee7-eb4a4a5a7873"), "B", 10, 2, "Available", 1 },
                    { new Guid("25c6c46a-be36-42ec-b871-4bd908dd3aa7"), "E", 8, 2, "Available", 1 },
                    { new Guid("26adbc29-bab2-4c26-9ecb-b8420eda9f31"), "A", 10, 2, "Available", 1 },
                    { new Guid("27657278-02b1-4cf2-9b3c-d3b0ae19c0fe"), "C", 3, 1, "Available", 1 },
                    { new Guid("2780921c-5372-4570-aa03-09677c14a886"), "E", 7, 1, "Available", 1 },
                    { new Guid("2ccabb17-116c-4dad-8162-def44480a47d"), "B", 5, 1, "Available", 1 },
                    { new Guid("2e981fe9-d5ad-4d70-92f4-d52d5d01de9b"), "C", 6, 1, "Available", 1 },
                    { new Guid("3076c99d-1e1a-4bb8-b879-067e8b921f03"), "A", 7, 1, "Available", 1 },
                    { new Guid("313199ff-1ff0-4fec-b8c8-d99f21ab605e"), "D", 5, 1, "Available", 1 },
                    { new Guid("3290fc1a-a5c7-440d-82a5-103d858fa698"), "C", 1, 2, "Available", 1 },
                    { new Guid("3461ffed-946c-4c6e-807a-232f7dc4a526"), "B", 3, 2, "Available", 1 },
                    { new Guid("39908dc1-bb88-461c-ba2b-b66caa591ae3"), "C", 8, 2, "Available", 1 },
                    { new Guid("3ddf495e-2d26-43b7-92f5-1a8d57912a8c"), "D", 4, 1, "Available", 1 },
                    { new Guid("420a4fb9-4134-4276-890e-d585baf82f77"), "E", 10, 2, "Available", 1 },
                    { new Guid("42619e8d-5aaf-4aff-85df-a7d0336d89c6"), "C", 6, 2, "Available", 1 },
                    { new Guid("42c2246a-caad-490a-a66c-0f6ebb9a51ab"), "C", 7, 1, "Available", 1 },
                    { new Guid("4426425e-8688-4d98-afea-2eb0ccf51bdc"), "B", 8, 2, "Available", 1 },
                    { new Guid("46049ef3-3c2b-43b7-8924-b01b38cca32a"), "E", 2, 2, "Available", 1 },
                    { new Guid("4668a702-7ca4-4df1-b7f2-d7a41fb0da16"), "C", 3, 2, "Available", 1 },
                    { new Guid("4822be68-1d6f-4c93-8c26-118d0855428d"), "E", 10, 1, "Available", 1 },
                    { new Guid("49d1c5ca-66d1-4b9f-8f8e-314665b810db"), "E", 6, 1, "Available", 1 },
                    { new Guid("4bb2cadc-72e2-4967-9e69-c4cb57fdbe52"), "E", 8, 1, "Available", 1 },
                    { new Guid("4cdb54e6-09d8-4265-8997-22bcfe6bca51"), "B", 8, 1, "Available", 1 },
                    { new Guid("4fddd258-7f28-4196-a6c4-a544dbe01841"), "A", 6, 1, "Available", 1 },
                    { new Guid("576ed78b-ea29-4d45-8317-65254309d29a"), "E", 9, 1, "Available", 1 },
                    { new Guid("6229b530-e5c6-4d58-bef1-9519a1feecac"), "C", 10, 1, "Available", 1 },
                    { new Guid("63522422-909f-4d33-9b87-473a370cc970"), "B", 2, 2, "Available", 1 },
                    { new Guid("6578a930-9f5a-48fb-b10d-057b6552658d"), "C", 9, 2, "Available", 1 },
                    { new Guid("6c0c5a74-b353-4e41-bcd6-ee649ea2d585"), "D", 9, 1, "Available", 1 },
                    { new Guid("743a37e6-7890-46f4-9c68-019120812138"), "D", 1, 1, "Available", 1 },
                    { new Guid("755b01e5-06fc-471f-b997-bec7253d1857"), "B", 4, 2, "Available", 1 },
                    { new Guid("76182d4f-46a8-40ed-8f0e-b7b73e025652"), "B", 6, 1, "Available", 1 },
                    { new Guid("781f6285-905f-4823-9129-f09b209185eb"), "E", 2, 1, "Available", 1 },
                    { new Guid("7b478a53-2198-4de1-8200-e033705e9179"), "B", 7, 1, "Available", 1 },
                    { new Guid("7b651b2d-8b17-470c-bdca-dfe304bd026f"), "E", 4, 1, "Available", 1 },
                    { new Guid("7fb8df55-4722-403e-bf9e-85bdfc8ac5c9"), "D", 7, 1, "Available", 1 },
                    { new Guid("7fe31f31-db05-48b0-814c-e081e8447a8b"), "D", 1, 2, "Available", 1 },
                    { new Guid("822846b9-4ba2-4f26-9584-291318c94dce"), "A", 1, 2, "Available", 1 },
                    { new Guid("83ddbd5d-01a7-4101-a935-32f6a7eaca3d"), "C", 2, 2, "Available", 1 },
                    { new Guid("84ba70ac-5330-4354-b2fa-eae72cb1fabb"), "C", 9, 1, "Available", 1 },
                    { new Guid("84d57bb6-fe0c-4b55-b910-1e52ea844d09"), "D", 6, 1, "Available", 1 },
                    { new Guid("89eac0ba-3154-498a-8e53-b7db49513a58"), "B", 10, 1, "Available", 1 },
                    { new Guid("8d5dc6e1-5294-4e81-b412-dadca2f12698"), "C", 4, 1, "Available", 1 },
                    { new Guid("907e5003-c090-4c2f-8046-be2037e809b5"), "B", 3, 1, "Available", 1 },
                    { new Guid("90b91afa-c825-45a5-af6d-019ed1161449"), "D", 4, 2, "Available", 1 },
                    { new Guid("91c2366e-bca7-4ebd-b3a3-57f62488820e"), "A", 1, 1, "Available", 1 },
                    { new Guid("94506aa8-cd36-4251-97c2-bad63b89473a"), "C", 1, 1, "Available", 1 },
                    { new Guid("953889b6-b8ff-4bb7-b162-f255d0912da7"), "E", 5, 1, "Available", 1 },
                    { new Guid("96ab1a0b-5d0d-4f14-8278-b4f39dc41965"), "D", 3, 2, "Available", 1 },
                    { new Guid("980c819a-7baf-4169-9159-f0eb729d0563"), "B", 9, 1, "Available", 1 },
                    { new Guid("987414ae-9c2e-4237-b674-f8f3571f97c8"), "E", 6, 2, "Available", 1 },
                    { new Guid("9b8f9e2d-df8e-42f4-b0cb-13b9cf94caf6"), "A", 8, 1, "Available", 1 },
                    { new Guid("9ce7b764-4446-4531-95a6-1a85c8660a4c"), "B", 1, 2, "Available", 1 },
                    { new Guid("a1d4db36-e8bf-421b-a6fc-85f70fa8cba9"), "B", 5, 2, "Available", 1 },
                    { new Guid("a20f2b40-be78-4cda-ba85-3bb9add1338a"), "C", 2, 1, "Available", 1 },
                    { new Guid("a2a9241c-3a07-4261-9b3f-78261c63438d"), "B", 6, 2, "Available", 1 },
                    { new Guid("a513df71-78ba-4b19-a351-4126ed1d827e"), "D", 7, 2, "Available", 1 },
                    { new Guid("a820cfeb-3f9c-4c13-bd9d-9621f7d0b88a"), "C", 4, 2, "Available", 1 },
                    { new Guid("a898111e-c012-4559-bd45-e67dcf8beeff"), "E", 3, 1, "Available", 1 },
                    { new Guid("ace5cf8d-5095-4239-9f44-3ca9999d1f53"), "A", 8, 2, "Available", 1 },
                    { new Guid("af92aa01-d6e8-47b1-b014-e25c14b6ba7c"), "A", 4, 2, "Available", 1 },
                    { new Guid("b3ca6073-c578-4066-be93-f87a5714031e"), "D", 10, 2, "Available", 1 },
                    { new Guid("b4c52af6-c591-4503-8aa0-a868effebc1c"), "B", 2, 1, "Available", 1 },
                    { new Guid("b68167b2-3d60-4ea5-a058-b41fedfa4faa"), "A", 3, 2, "Available", 1 },
                    { new Guid("ba350bbb-4feb-401c-8529-88bcab8e7bdf"), "A", 2, 2, "Available", 1 },
                    { new Guid("bb93bcd5-c3ae-43b0-a8ed-cca072591931"), "B", 9, 2, "Available", 1 },
                    { new Guid("be17ae66-ce79-4c81-be45-e87fb9061f64"), "A", 7, 2, "Available", 1 },
                    { new Guid("c1feb8f6-b5c6-475c-bd22-0a36bb749c21"), "E", 7, 2, "Available", 1 },
                    { new Guid("c29bc3d2-18db-406d-82b2-e9329d1f6101"), "C", 10, 2, "Available", 1 },
                    { new Guid("c2c63ed6-642e-45f2-8b46-7d02783810bc"), "C", 8, 1, "Available", 1 },
                    { new Guid("cc953a10-8f81-48e2-96e9-67babcea3ab0"), "A", 9, 2, "Available", 1 },
                    { new Guid("d0415301-626f-45ef-a2eb-b88b5bcea853"), "D", 5, 2, "Available", 1 },
                    { new Guid("d2cf8e33-2f7d-4654-9aa6-ef6dd252cfe4"), "D", 6, 2, "Available", 1 },
                    { new Guid("d3dbb917-bf85-477b-bb09-d76e17296d94"), "B", 4, 1, "Available", 1 },
                    { new Guid("d93e6a03-d111-4e99-a431-e40039379682"), "D", 8, 1, "Available", 1 },
                    { new Guid("d9f353b4-20a6-4cea-aff3-95bd74d76588"), "D", 9, 2, "Available", 1 },
                    { new Guid("dc0b4c84-c7d2-482a-877c-e836c6294ad3"), "D", 8, 2, "Available", 1 },
                    { new Guid("ec05bc0e-6cb3-4cf6-8825-c0463305f685"), "A", 5, 2, "Available", 1 },
                    { new Guid("ed3b9f20-3808-41a7-bf10-580483080154"), "D", 2, 1, "Available", 1 },
                    { new Guid("ee838cfb-755c-441a-85ca-747b70bc3a22"), "C", 5, 1, "Available", 1 },
                    { new Guid("f6411047-f2a2-4343-9066-94e45fb13578"), "E", 9, 2, "Available", 1 },
                    { new Guid("f6d5e1be-7437-499b-8818-5b587db8996a"), "C", 7, 2, "Available", 1 },
                    { new Guid("f8cdfded-8b71-4578-a801-3d98ea5d396b"), "B", 7, 2, "Available", 1 },
                    { new Guid("fba9bb27-2057-4847-92c3-0709aa6e8acb"), "E", 1, 1, "Available", 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuditLogs_UserId",
                table: "AuditLogs",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_SeatId",
                table: "Reservations",
                column: "SeatId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_UserId",
                table: "Reservations",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Seats_SectorId",
                table: "Seats",
                column: "SectorId");

            migrationBuilder.CreateIndex(
                name: "IX_Sectors_EventId",
                table: "Sectors",
                column: "EventId");

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
                name: "Seats");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Sectors");

            migrationBuilder.DropTable(
                name: "Events");
        }
    }
}
