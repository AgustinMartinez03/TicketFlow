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
                    PasswordHash = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Role = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
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
                columns: new[] { "Id", "Email", "Name", "PasswordHash", "Role" },
                values: new object[,]
                {
                    { 1, "admin@ticketflow.com", "Admin General", "$2a$12$eQQOCJVOpp0NS8MJ0C5c1Oo6gbsC58uD.j6wZE9Z6xnzfMsRd1H6G", "Admin" },
                    { 2, "ale@ticketflow.com", "Alejandro", "$2a$12$WQUmKUbkI6C6a2e5nDxfvO42I5fVVOnVlE1JnYAWXGP914Cs4RMPC", "Client" },
                    { 3, "agus@ticketflow.com", "Agustin", "$2a$12$aJGDFO5wFcTycwlLZ1XfFepllyAhVEawY/pOPvmZKnUcf/BEHlDqy", "Client" }
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
                    { new Guid("030373eb-8105-42a0-bfca-acdbb5657377"), "B", 1, 1, "Available", 1 },
                    { new Guid("044a94df-94dc-4850-b3d5-540dc02bea6b"), "C", 6, 1, "Available", 1 },
                    { new Guid("0d3bf94d-b824-400a-81e9-61e1fb5d3e57"), "E", 9, 2, "Available", 1 },
                    { new Guid("0d409fc9-2d09-47ce-8b8e-b96e68f10fcd"), "A", 6, 2, "Available", 1 },
                    { new Guid("0e7b8ff4-ee7a-40b8-9564-d0356c2af553"), "C", 1, 1, "Available", 1 },
                    { new Guid("0eafb96f-6a39-49ea-9daa-21fd3615e640"), "B", 5, 1, "Available", 1 },
                    { new Guid("101e6b7e-473c-4b60-90f9-3d9439b478aa"), "A", 8, 1, "Available", 1 },
                    { new Guid("1640aa7d-c342-4ba7-b8df-f840492344dd"), "A", 3, 2, "Available", 1 },
                    { new Guid("16733a02-17bf-4bf7-9aaf-d5d2c6480c99"), "C", 2, 2, "Available", 1 },
                    { new Guid("190a9d38-4fa5-4035-8d52-e12014b98b80"), "A", 4, 1, "Available", 1 },
                    { new Guid("1919292b-c2e6-4abe-be91-12ffd50ff11b"), "C", 1, 2, "Available", 1 },
                    { new Guid("19d9332e-5db7-4ff2-bbbf-a5f1754725ae"), "B", 8, 1, "Available", 1 },
                    { new Guid("21422f23-0713-4c5b-ae3c-5de3a8fee0e0"), "E", 4, 1, "Available", 1 },
                    { new Guid("219b3879-39bd-4ee5-8dc5-81022770fb74"), "E", 6, 1, "Available", 1 },
                    { new Guid("24b1930a-aa2f-4595-818f-a20c35210290"), "E", 1, 2, "Available", 1 },
                    { new Guid("29cfcef0-5199-4e5d-b513-36927645f71d"), "B", 10, 2, "Available", 1 },
                    { new Guid("2c60745c-b1b3-4a87-903d-79041f19a8b2"), "E", 10, 1, "Available", 1 },
                    { new Guid("30f9f2ef-5be2-4a4f-b418-0c919db3e9ce"), "B", 7, 2, "Available", 1 },
                    { new Guid("322c456b-fba3-402d-94eb-2c76329afbcc"), "D", 3, 2, "Available", 1 },
                    { new Guid("354d8bbb-7861-4dff-b771-6ac209f65e70"), "D", 4, 2, "Available", 1 },
                    { new Guid("36e560a0-70b3-4422-8616-9a695affb728"), "A", 7, 2, "Available", 1 },
                    { new Guid("399863d6-1535-4982-b08b-1fad8f935ae4"), "B", 2, 1, "Available", 1 },
                    { new Guid("3b1f6b40-c0cd-4981-b634-76ec4eaab0f7"), "B", 10, 1, "Available", 1 },
                    { new Guid("3b4e8d40-8a4c-4f52-8e83-b4d97bd5b110"), "D", 2, 1, "Available", 1 },
                    { new Guid("3ba9ca45-5c69-4617-82f0-c4568c975111"), "B", 9, 1, "Available", 1 },
                    { new Guid("3e59f611-bb49-4e31-878b-ee10fcbf6665"), "D", 6, 2, "Available", 1 },
                    { new Guid("43e879b9-0c5c-4391-9064-5c292f06bc7c"), "E", 1, 1, "Available", 1 },
                    { new Guid("4c7625ec-1bf4-4f52-a659-bee9c537701f"), "B", 2, 2, "Available", 1 },
                    { new Guid("4e6286ec-2ee7-4bc0-a192-7fd1e530b9ed"), "E", 5, 1, "Available", 1 },
                    { new Guid("4efccba7-2951-4b35-ac16-8d8033583809"), "C", 5, 2, "Available", 1 },
                    { new Guid("4f5afd7f-5eb3-4b72-b24d-4dc51f574491"), "A", 5, 2, "Available", 1 },
                    { new Guid("511c0425-d335-4ec4-892a-9dde1394c385"), "B", 6, 2, "Available", 1 },
                    { new Guid("542446aa-0b2e-4106-be81-625740f22ba2"), "A", 1, 2, "Available", 1 },
                    { new Guid("543f30b6-a9f7-439b-8d39-c6c5e15d13ad"), "C", 9, 2, "Available", 1 },
                    { new Guid("5686244a-0404-42c5-b3b4-a496a233d816"), "A", 1, 1, "Available", 1 },
                    { new Guid("5771de67-a4df-43f8-8164-6d9949368448"), "A", 2, 1, "Available", 1 },
                    { new Guid("5894efdb-95fa-44a5-90c2-21e6965af3c6"), "D", 7, 2, "Available", 1 },
                    { new Guid("5ba002b9-0493-47d1-bb60-4153e49c8dff"), "E", 8, 1, "Available", 1 },
                    { new Guid("5d6bd76d-7dee-4686-914c-e83aa00f08cf"), "A", 4, 2, "Available", 1 },
                    { new Guid("5dee5220-4a88-4f1f-88a9-815a4505f2da"), "C", 10, 2, "Available", 1 },
                    { new Guid("649db2ed-41ab-4560-9239-bd7ef90ce25d"), "C", 8, 1, "Available", 1 },
                    { new Guid("6759a651-9a19-4945-ab2e-7d2a811c4b82"), "B", 1, 2, "Available", 1 },
                    { new Guid("6c1fcb2f-5bb8-4204-9bdd-79b2fedf3ae2"), "B", 3, 2, "Available", 1 },
                    { new Guid("6c9bd68d-bf08-4fcd-9196-b51d76e222b1"), "A", 3, 1, "Available", 1 },
                    { new Guid("6e21eda4-48e9-4b88-89cf-f9d82709fb56"), "C", 3, 1, "Available", 1 },
                    { new Guid("701277ae-5961-4116-8a03-e500dde84927"), "E", 8, 2, "Available", 1 },
                    { new Guid("71b99f17-6b25-4a20-8dbe-03003c5a5e7e"), "D", 10, 1, "Available", 1 },
                    { new Guid("735eb79a-bcf4-425c-a164-08c1488846bb"), "D", 7, 1, "Available", 1 },
                    { new Guid("73d7c3af-eb36-4ef5-8906-918a1c68d622"), "E", 10, 2, "Available", 1 },
                    { new Guid("765adbbe-dc32-4535-b32a-eb09edee7a32"), "D", 1, 2, "Available", 1 },
                    { new Guid("7c4c9248-18a7-4bdd-8116-fdf1847cf17f"), "C", 10, 1, "Available", 1 },
                    { new Guid("7d850116-4fdd-4793-bae1-c6673bdd86e4"), "D", 8, 2, "Available", 1 },
                    { new Guid("7f16509f-248f-43aa-9124-808d1e800ba7"), "C", 4, 2, "Available", 1 },
                    { new Guid("80f5c295-5d9d-4429-bc60-c4ed216a1fb8"), "B", 5, 2, "Available", 1 },
                    { new Guid("82e367df-d860-48fb-8815-a354563c7641"), "D", 2, 2, "Available", 1 },
                    { new Guid("83e0f7ea-65eb-4c73-94da-f7ea1b0b67b0"), "D", 4, 1, "Available", 1 },
                    { new Guid("8771c9d3-381e-434c-a797-7e659671acce"), "A", 10, 2, "Available", 1 },
                    { new Guid("885c10c7-3b58-4558-a503-afaf47fe4a0c"), "D", 1, 1, "Available", 1 },
                    { new Guid("897a7bca-35a9-473b-a076-f8f76883925a"), "E", 7, 2, "Available", 1 },
                    { new Guid("89edfe1f-9991-4aaa-b5e0-9ec231324de8"), "E", 6, 2, "Available", 1 },
                    { new Guid("8cc522eb-d103-42d7-9acb-816254174e7a"), "C", 3, 2, "Available", 1 },
                    { new Guid("8e3de70f-fb64-4924-82e9-7e5e7719bcb7"), "E", 9, 1, "Available", 1 },
                    { new Guid("95e59c3b-fa0b-41b5-a10c-4f86fa9ed79b"), "A", 5, 1, "Available", 1 },
                    { new Guid("9b838391-28e1-48e9-83bd-de158be1ffd8"), "B", 4, 1, "Available", 1 },
                    { new Guid("9e9f5008-581b-4d57-8649-c762c4a22a9b"), "B", 9, 2, "Available", 1 },
                    { new Guid("a0b079e9-bff7-4e76-b8fc-5f2e01e222f9"), "D", 8, 1, "Available", 1 },
                    { new Guid("a3bd8cd8-5243-4904-9d72-472212842306"), "C", 7, 2, "Available", 1 },
                    { new Guid("a64dc812-a78d-43a3-b5f7-12dfd96157c7"), "A", 8, 2, "Available", 1 },
                    { new Guid("a81850c8-9b01-4b6e-b7df-021aab2822e9"), "D", 6, 1, "Available", 1 },
                    { new Guid("a8ff6acf-9c3d-4d42-b961-cccad8a615fd"), "B", 7, 1, "Available", 1 },
                    { new Guid("abda7ac4-0004-491c-9540-2153341fd238"), "A", 2, 2, "Available", 1 },
                    { new Guid("acaeee57-18dc-42a0-af04-de1c763e3b82"), "B", 3, 1, "Available", 1 },
                    { new Guid("b0d60168-b8bd-4bfe-97fd-2b36995c9aee"), "B", 4, 2, "Available", 1 },
                    { new Guid("b22a6fff-9784-4a86-a60f-ae717f84e28f"), "E", 7, 1, "Available", 1 },
                    { new Guid("b259ada0-9b53-4e58-aa9d-8e88f258d925"), "E", 2, 2, "Available", 1 },
                    { new Guid("b2be0159-4d7e-40ca-9f72-8ff38f7b6d58"), "E", 4, 2, "Available", 1 },
                    { new Guid("c3e0a80c-8e4c-42c7-af63-2e0c290b222a"), "C", 6, 2, "Available", 1 },
                    { new Guid("c53e608b-4bd0-4b2b-948d-670b9b64bb98"), "E", 2, 1, "Available", 1 },
                    { new Guid("cb8815b4-4681-4de0-b2fb-941df2ebbdbd"), "D", 5, 2, "Available", 1 },
                    { new Guid("cca19017-a35b-40dc-887a-5ced526b5b04"), "D", 9, 1, "Available", 1 },
                    { new Guid("ce50b42a-bea0-4692-8716-8b840a94d0f0"), "D", 9, 2, "Available", 1 },
                    { new Guid("d41b0f36-2871-4cf6-b4f9-d3147e8468ce"), "A", 7, 1, "Available", 1 },
                    { new Guid("d545db8a-8a2f-499c-9895-006e6b20c846"), "C", 9, 1, "Available", 1 },
                    { new Guid("d58ef2bb-9b0f-4fd6-9798-d3f2a671ae83"), "C", 4, 1, "Available", 1 },
                    { new Guid("d5d5de39-c3c2-4713-9fc2-dee3092f057f"), "B", 6, 1, "Available", 1 },
                    { new Guid("d71cac50-66bb-42d4-93dd-29bb565118fc"), "D", 3, 1, "Available", 1 },
                    { new Guid("d87f4f3d-ff49-4dd4-8933-f1161628886b"), "C", 2, 1, "Available", 1 },
                    { new Guid("d8922f0c-b233-4804-bb01-99aa6f85bd37"), "A", 9, 1, "Available", 1 },
                    { new Guid("df5cf9bb-e0bd-4c66-a969-c4e4ee2d2b6e"), "A", 10, 1, "Available", 1 },
                    { new Guid("e09ab150-1111-475f-b973-157f3650d7e2"), "B", 8, 2, "Available", 1 },
                    { new Guid("e1fa8d2f-8755-4407-b153-848bc2b9839d"), "A", 9, 2, "Available", 1 },
                    { new Guid("e4fd9858-b6d2-4f5b-818f-04cfd32e3688"), "E", 3, 1, "Available", 1 },
                    { new Guid("f2f1db88-20cd-4e72-ba38-33212da2f7a7"), "C", 5, 1, "Available", 1 },
                    { new Guid("f619ee44-6302-49bd-b359-0f68f23afef5"), "C", 8, 2, "Available", 1 },
                    { new Guid("f6cc3f32-2573-4012-a4b6-aa061def206b"), "A", 6, 1, "Available", 1 },
                    { new Guid("f7e6513d-954b-42ff-9657-649c4810f935"), "E", 3, 2, "Available", 1 },
                    { new Guid("fc36f2d3-b3cb-4f7b-815b-16ca23dbf0e9"), "C", 7, 1, "Available", 1 },
                    { new Guid("fdeba8f8-324d-4ceb-a49d-1b22ba2a6e09"), "D", 5, 1, "Available", 1 },
                    { new Guid("feddee16-1131-4758-bf4c-7ff36486bb18"), "E", 5, 2, "Available", 1 },
                    { new Guid("ffb7145d-b8b3-4aa2-819e-3698a2d09b0c"), "D", 10, 2, "Available", 1 }
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
