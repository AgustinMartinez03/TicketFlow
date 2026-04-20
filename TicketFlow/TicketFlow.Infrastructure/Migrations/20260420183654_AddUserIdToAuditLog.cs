using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TicketFlow.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddUserIdToAuditLog : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "AuditLogs",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "RowIdentifier", "SeatNumber", "SectorId", "Status", "Version" },
                values: new object[,]
                {
                    { new Guid("034e23db-a732-422f-802b-7259933ad7ea"), "B", 6, 2, "Available", 1 },
                    { new Guid("045393af-57c3-4770-b56d-9c9fb204b9fc"), "B", 44, 2, "Available", 1 },
                    { new Guid("06838df7-113b-40d7-9527-ab5ee7e611e8"), "A", 11, 1, "Available", 1 },
                    { new Guid("0701d2eb-7792-4c6f-b713-485c1a422626"), "A", 26, 1, "Available", 1 },
                    { new Guid("07099f0c-d072-4ac4-9349-0c3ac7f50ae5"), "B", 12, 2, "Available", 1 },
                    { new Guid("07a18e45-4197-4700-aa5c-8ab5b12959c8"), "B", 9, 2, "Available", 1 },
                    { new Guid("08b7d80f-b451-494e-b684-1d76b70706da"), "B", 8, 2, "Available", 1 },
                    { new Guid("0f578a36-d0e7-45a2-8036-9029c30945ac"), "A", 23, 1, "Available", 1 },
                    { new Guid("0fba01f6-65e9-475f-8af8-d89f5323ff3f"), "B", 21, 2, "Available", 1 },
                    { new Guid("1b48e9ec-51ac-43ea-9a86-61bdfe9934c7"), "A", 21, 1, "Available", 1 },
                    { new Guid("216b2a97-3c87-4252-9ba2-25ad978bae17"), "B", 43, 2, "Available", 1 },
                    { new Guid("23754202-0c08-4737-a07c-7c5b3e5210b7"), "A", 5, 1, "Available", 1 },
                    { new Guid("29114ac1-6b5b-45f5-a1cd-5d01ecba295d"), "A", 34, 1, "Available", 1 },
                    { new Guid("3218b74d-b7e4-4f74-b995-30df2385620d"), "A", 29, 1, "Available", 1 },
                    { new Guid("322a32ff-0bff-469b-8463-de4c085cae7b"), "B", 18, 2, "Available", 1 },
                    { new Guid("3668e3a3-d6b8-4987-b5be-002cf44cc8e7"), "B", 5, 2, "Available", 1 },
                    { new Guid("3777f8bf-ccde-4072-bd85-ca2c796cd732"), "B", 25, 2, "Available", 1 },
                    { new Guid("3ee29462-a6f5-4ab5-84b5-726e88771220"), "A", 46, 1, "Available", 1 },
                    { new Guid("43e3abe6-6616-4507-bb88-f2b1e443382f"), "A", 40, 1, "Available", 1 },
                    { new Guid("46b10d2a-67aa-4da5-9b5b-f374585a38c1"), "A", 24, 1, "Available", 1 },
                    { new Guid("47c29f29-b8f8-47e5-ace2-28a633dbd771"), "B", 35, 2, "Available", 1 },
                    { new Guid("49ba7bd5-cca6-4745-825b-37ed2f34c9f9"), "A", 14, 1, "Available", 1 },
                    { new Guid("4ad45a40-ce20-43b8-a5ab-939b47b28bda"), "A", 22, 1, "Available", 1 },
                    { new Guid("4e232ee0-e6a5-4fc9-a552-82e78ec64832"), "A", 2, 1, "Available", 1 },
                    { new Guid("4f2cece7-ea14-4604-ac7b-e188acb29941"), "A", 1, 1, "Available", 1 },
                    { new Guid("50255234-e469-4bef-aaec-de64c904fdea"), "A", 19, 1, "Available", 1 },
                    { new Guid("509a1453-6445-45f8-82eb-38d53b23b09c"), "B", 10, 2, "Available", 1 },
                    { new Guid("531ca843-da8a-499e-b74b-acd3a08d8841"), "A", 12, 1, "Available", 1 },
                    { new Guid("575a78b6-bf6e-471d-8969-4f28ba9ec4a2"), "B", 27, 2, "Available", 1 },
                    { new Guid("59ab5e7b-5066-4a97-a579-29df0f62b707"), "B", 36, 2, "Available", 1 },
                    { new Guid("5c482d77-456f-4c6e-bb75-3fc512c67532"), "A", 47, 1, "Available", 1 },
                    { new Guid("5dd5490e-0b63-4c4e-be97-637fb8e502ab"), "A", 30, 1, "Available", 1 },
                    { new Guid("5ec30a24-f4c6-4f34-a6b4-55a8e3d84660"), "A", 3, 1, "Available", 1 },
                    { new Guid("614617e5-9a92-470d-9aea-d475c1ad00fb"), "A", 42, 1, "Available", 1 },
                    { new Guid("620439ae-4118-4074-aa85-0c9cd8df11c3"), "A", 37, 1, "Available", 1 },
                    { new Guid("6406d31f-4383-41f4-890c-d693aad86b59"), "A", 7, 1, "Available", 1 },
                    { new Guid("6bda3e93-77d0-4caa-a4d1-8ea9e4978fec"), "B", 39, 2, "Available", 1 },
                    { new Guid("6f9c8f34-e100-4c4e-b116-8760f44b0563"), "B", 31, 2, "Available", 1 },
                    { new Guid("6ff06628-ff18-4fab-9215-d9806d4d71d7"), "A", 20, 1, "Available", 1 },
                    { new Guid("70c8ea43-0359-42d6-9d60-3e1e94e835b8"), "B", 1, 2, "Available", 1 },
                    { new Guid("773829ce-02d8-440b-98cc-21f9474cdbee"), "B", 49, 2, "Available", 1 },
                    { new Guid("777e36c0-c391-415b-9148-f9e8ff917042"), "A", 41, 1, "Available", 1 },
                    { new Guid("7fa8521a-98e2-4d38-916b-d3e807ed7ea7"), "A", 50, 1, "Available", 1 },
                    { new Guid("80d90e68-fe42-4f24-b30c-93ee07fa772d"), "A", 36, 1, "Available", 1 },
                    { new Guid("82576377-b488-469b-8fbf-c665a31147e6"), "A", 8, 1, "Available", 1 },
                    { new Guid("85647410-379f-49c8-ad50-4a4d083d2e6d"), "B", 34, 2, "Available", 1 },
                    { new Guid("860d2bc2-d267-4c58-a321-2b1e7bd0de22"), "A", 43, 1, "Available", 1 },
                    { new Guid("866c3ee2-6164-4e77-868d-b24c28b38869"), "B", 45, 2, "Available", 1 },
                    { new Guid("8c5bfb4e-fa78-4817-888f-715ef3fbcaf6"), "B", 46, 2, "Available", 1 },
                    { new Guid("8e2cfb12-95cb-4d2e-b4bc-7f550d121742"), "B", 15, 2, "Available", 1 },
                    { new Guid("8ff99d67-0014-46b5-a84d-2e44a671814c"), "B", 13, 2, "Available", 1 },
                    { new Guid("8ffc6dc5-dde5-4094-9f27-89bddf817f37"), "B", 32, 2, "Available", 1 },
                    { new Guid("9041d667-7304-4497-8aaf-cda778120937"), "B", 41, 2, "Available", 1 },
                    { new Guid("908d00ee-b09f-41f2-9718-6c87b8714b59"), "B", 42, 2, "Available", 1 },
                    { new Guid("90f4e362-b19f-43ee-bde2-8f5adcccfe8b"), "A", 17, 1, "Available", 1 },
                    { new Guid("95abbb9d-db10-4c58-9610-dc85111c9af5"), "A", 33, 1, "Available", 1 },
                    { new Guid("969d627f-0a73-40a8-9f08-57fbfe35966c"), "B", 17, 2, "Available", 1 },
                    { new Guid("9bf1d709-3ab2-45aa-8614-f1aee770f835"), "A", 49, 1, "Available", 1 },
                    { new Guid("9c3da1fc-c87d-4745-a5db-5f3327615183"), "A", 9, 1, "Available", 1 },
                    { new Guid("9f4d3fd3-23dd-464c-8a4c-2c8cfe4a2f56"), "B", 14, 2, "Available", 1 },
                    { new Guid("a2f3271f-b725-44c9-baa6-7901cd7c0f42"), "B", 28, 2, "Available", 1 },
                    { new Guid("a41b471c-02cf-4552-9358-4247bce3fecb"), "A", 44, 1, "Available", 1 },
                    { new Guid("a99884eb-889c-44fd-bfa0-f2dfc77e477b"), "B", 2, 2, "Available", 1 },
                    { new Guid("ad41d481-20a6-4a78-ace0-3ee69a45f746"), "B", 37, 2, "Available", 1 },
                    { new Guid("ad978ff2-37ae-42b4-9c5b-413841438aa0"), "A", 35, 1, "Available", 1 },
                    { new Guid("ae3fa21c-c78f-4b16-a713-e9ab23c0ce81"), "A", 27, 1, "Available", 1 },
                    { new Guid("b21bff10-d1e0-4c70-819f-1b7b7306fbb7"), "B", 24, 2, "Available", 1 },
                    { new Guid("b385996f-f945-4554-ac41-10a9ee81697b"), "A", 25, 1, "Available", 1 },
                    { new Guid("b61c2bfe-8d8f-4202-81c1-aa5ead3aceea"), "A", 6, 1, "Available", 1 },
                    { new Guid("b80f4cb5-8e32-4ea9-977f-894a69918c37"), "B", 19, 2, "Available", 1 },
                    { new Guid("b9907da4-e4bb-4f74-9e78-cf44c800b83b"), "A", 39, 1, "Available", 1 },
                    { new Guid("bfb1ceae-beec-4e11-9041-4dd0a292b9aa"), "B", 47, 2, "Available", 1 },
                    { new Guid("c003ff58-633a-4ca5-a9ad-8a82a2f84da1"), "B", 23, 2, "Available", 1 },
                    { new Guid("c1455283-cede-48a8-a92e-2ac112257b62"), "A", 10, 1, "Available", 1 },
                    { new Guid("c2991480-1049-4d22-b467-a3b2e953e715"), "A", 18, 1, "Available", 1 },
                    { new Guid("c5528d50-3625-4454-b5f6-952286446592"), "A", 38, 1, "Available", 1 },
                    { new Guid("c61a0f57-6c5c-418e-9ce8-a4946fba28b2"), "B", 48, 2, "Available", 1 },
                    { new Guid("c750fa4a-edb3-4828-9d93-408f4c354e5e"), "B", 20, 2, "Available", 1 },
                    { new Guid("ca1562b3-2494-4960-82a3-e84a0ad8f3bc"), "B", 4, 2, "Available", 1 },
                    { new Guid("ca43deaa-84e4-47cd-9d32-49d5b4a0c5ec"), "B", 11, 2, "Available", 1 },
                    { new Guid("cb64e8c6-b8a3-4876-bb83-d96f2d4b66fd"), "B", 29, 2, "Available", 1 },
                    { new Guid("cce9c553-d9d2-4e40-b224-cd086875b99f"), "A", 4, 1, "Available", 1 },
                    { new Guid("d24790db-48ca-40d5-898d-28331713560e"), "A", 45, 1, "Available", 1 },
                    { new Guid("d7c19a31-bc7c-4c8c-9ca0-d79eeaa3d882"), "B", 16, 2, "Available", 1 },
                    { new Guid("d86678ae-6fa8-4a8c-8c04-1664a2ae9647"), "A", 32, 1, "Available", 1 },
                    { new Guid("da4d834c-8218-48ed-b802-fd19ad46c17c"), "A", 31, 1, "Available", 1 },
                    { new Guid("e1260e44-842c-4dd3-9640-43b08252f018"), "B", 3, 2, "Available", 1 },
                    { new Guid("e48b6149-f9e9-4931-88bc-c0f8621bcbb3"), "B", 7, 2, "Available", 1 },
                    { new Guid("ea33fbb9-856c-4211-9111-d889106478a9"), "B", 38, 2, "Available", 1 },
                    { new Guid("eb3b7091-aa6d-4d20-8c8d-fe645059c977"), "A", 13, 1, "Available", 1 },
                    { new Guid("ed605ddd-bfd6-467f-ae92-7fc6cfc54e98"), "A", 28, 1, "Available", 1 },
                    { new Guid("ef815079-bdc6-4fc3-a01c-c2a27c51752a"), "A", 16, 1, "Available", 1 },
                    { new Guid("f3005819-7342-49bf-a08e-d007b72bdcc3"), "A", 15, 1, "Available", 1 },
                    { new Guid("f3b58165-051b-4c95-a0ab-b87398c823f1"), "B", 33, 2, "Available", 1 },
                    { new Guid("f474a6f3-5310-478c-b7fa-cfa6e40502e9"), "A", 48, 1, "Available", 1 },
                    { new Guid("f612f4ce-2b14-4a7f-991c-4d2cb71c9ad3"), "B", 50, 2, "Available", 1 },
                    { new Guid("f77e144c-b524-42db-af2f-59638a6696a7"), "B", 22, 2, "Available", 1 },
                    { new Guid("f8d20daa-eb32-4131-ae4d-628581f19995"), "B", 30, 2, "Available", 1 },
                    { new Guid("f96b813e-f4e2-4978-b5dd-53b435529ba8"), "B", 40, 2, "Available", 1 },
                    { new Guid("fdc5ba0c-741f-44d4-bc62-ca662d990405"), "B", 26, 2, "Available", 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuditLogs_UserId",
                table: "AuditLogs",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AuditLogs_Users_UserId",
                table: "AuditLogs",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuditLogs_Users_UserId",
                table: "AuditLogs");

            migrationBuilder.DropIndex(
                name: "IX_AuditLogs_UserId",
                table: "AuditLogs");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("034e23db-a732-422f-802b-7259933ad7ea"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("045393af-57c3-4770-b56d-9c9fb204b9fc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("06838df7-113b-40d7-9527-ab5ee7e611e8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0701d2eb-7792-4c6f-b713-485c1a422626"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("07099f0c-d072-4ac4-9349-0c3ac7f50ae5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("07a18e45-4197-4700-aa5c-8ab5b12959c8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("08b7d80f-b451-494e-b684-1d76b70706da"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0f578a36-d0e7-45a2-8036-9029c30945ac"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0fba01f6-65e9-475f-8af8-d89f5323ff3f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1b48e9ec-51ac-43ea-9a86-61bdfe9934c7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("216b2a97-3c87-4252-9ba2-25ad978bae17"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("23754202-0c08-4737-a07c-7c5b3e5210b7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("29114ac1-6b5b-45f5-a1cd-5d01ecba295d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3218b74d-b7e4-4f74-b995-30df2385620d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("322a32ff-0bff-469b-8463-de4c085cae7b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3668e3a3-d6b8-4987-b5be-002cf44cc8e7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3777f8bf-ccde-4072-bd85-ca2c796cd732"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3ee29462-a6f5-4ab5-84b5-726e88771220"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("43e3abe6-6616-4507-bb88-f2b1e443382f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("46b10d2a-67aa-4da5-9b5b-f374585a38c1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("47c29f29-b8f8-47e5-ace2-28a633dbd771"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("49ba7bd5-cca6-4745-825b-37ed2f34c9f9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4ad45a40-ce20-43b8-a5ab-939b47b28bda"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4e232ee0-e6a5-4fc9-a552-82e78ec64832"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4f2cece7-ea14-4604-ac7b-e188acb29941"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("50255234-e469-4bef-aaec-de64c904fdea"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("509a1453-6445-45f8-82eb-38d53b23b09c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("531ca843-da8a-499e-b74b-acd3a08d8841"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("575a78b6-bf6e-471d-8969-4f28ba9ec4a2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("59ab5e7b-5066-4a97-a579-29df0f62b707"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5c482d77-456f-4c6e-bb75-3fc512c67532"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5dd5490e-0b63-4c4e-be97-637fb8e502ab"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5ec30a24-f4c6-4f34-a6b4-55a8e3d84660"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("614617e5-9a92-470d-9aea-d475c1ad00fb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("620439ae-4118-4074-aa85-0c9cd8df11c3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6406d31f-4383-41f4-890c-d693aad86b59"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6bda3e93-77d0-4caa-a4d1-8ea9e4978fec"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6f9c8f34-e100-4c4e-b116-8760f44b0563"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6ff06628-ff18-4fab-9215-d9806d4d71d7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("70c8ea43-0359-42d6-9d60-3e1e94e835b8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("773829ce-02d8-440b-98cc-21f9474cdbee"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("777e36c0-c391-415b-9148-f9e8ff917042"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7fa8521a-98e2-4d38-916b-d3e807ed7ea7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("80d90e68-fe42-4f24-b30c-93ee07fa772d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("82576377-b488-469b-8fbf-c665a31147e6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("85647410-379f-49c8-ad50-4a4d083d2e6d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("860d2bc2-d267-4c58-a321-2b1e7bd0de22"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("866c3ee2-6164-4e77-868d-b24c28b38869"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8c5bfb4e-fa78-4817-888f-715ef3fbcaf6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8e2cfb12-95cb-4d2e-b4bc-7f550d121742"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8ff99d67-0014-46b5-a84d-2e44a671814c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8ffc6dc5-dde5-4094-9f27-89bddf817f37"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9041d667-7304-4497-8aaf-cda778120937"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("908d00ee-b09f-41f2-9718-6c87b8714b59"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("90f4e362-b19f-43ee-bde2-8f5adcccfe8b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("95abbb9d-db10-4c58-9610-dc85111c9af5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("969d627f-0a73-40a8-9f08-57fbfe35966c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9bf1d709-3ab2-45aa-8614-f1aee770f835"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9c3da1fc-c87d-4745-a5db-5f3327615183"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9f4d3fd3-23dd-464c-8a4c-2c8cfe4a2f56"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a2f3271f-b725-44c9-baa6-7901cd7c0f42"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a41b471c-02cf-4552-9358-4247bce3fecb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a99884eb-889c-44fd-bfa0-f2dfc77e477b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ad41d481-20a6-4a78-ace0-3ee69a45f746"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ad978ff2-37ae-42b4-9c5b-413841438aa0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ae3fa21c-c78f-4b16-a713-e9ab23c0ce81"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b21bff10-d1e0-4c70-819f-1b7b7306fbb7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b385996f-f945-4554-ac41-10a9ee81697b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b61c2bfe-8d8f-4202-81c1-aa5ead3aceea"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b80f4cb5-8e32-4ea9-977f-894a69918c37"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b9907da4-e4bb-4f74-9e78-cf44c800b83b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bfb1ceae-beec-4e11-9041-4dd0a292b9aa"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c003ff58-633a-4ca5-a9ad-8a82a2f84da1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c1455283-cede-48a8-a92e-2ac112257b62"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c2991480-1049-4d22-b467-a3b2e953e715"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c5528d50-3625-4454-b5f6-952286446592"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c61a0f57-6c5c-418e-9ce8-a4946fba28b2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c750fa4a-edb3-4828-9d93-408f4c354e5e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ca1562b3-2494-4960-82a3-e84a0ad8f3bc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ca43deaa-84e4-47cd-9d32-49d5b4a0c5ec"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cb64e8c6-b8a3-4876-bb83-d96f2d4b66fd"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cce9c553-d9d2-4e40-b224-cd086875b99f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d24790db-48ca-40d5-898d-28331713560e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d7c19a31-bc7c-4c8c-9ca0-d79eeaa3d882"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d86678ae-6fa8-4a8c-8c04-1664a2ae9647"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("da4d834c-8218-48ed-b802-fd19ad46c17c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e1260e44-842c-4dd3-9640-43b08252f018"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e48b6149-f9e9-4931-88bc-c0f8621bcbb3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ea33fbb9-856c-4211-9111-d889106478a9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("eb3b7091-aa6d-4d20-8c8d-fe645059c977"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ed605ddd-bfd6-467f-ae92-7fc6cfc54e98"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ef815079-bdc6-4fc3-a01c-c2a27c51752a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f3005819-7342-49bf-a08e-d007b72bdcc3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f3b58165-051b-4c95-a0ab-b87398c823f1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f474a6f3-5310-478c-b7fa-cfa6e40502e9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f612f4ce-2b14-4a7f-991c-4d2cb71c9ad3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f77e144c-b524-42db-af2f-59638a6696a7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f8d20daa-eb32-4131-ae4d-628581f19995"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f96b813e-f4e2-4978-b5dd-53b435529ba8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fdc5ba0c-741f-44d4-bc62-ca662d990405"));

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "AuditLogs");

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
        }
    }
}
