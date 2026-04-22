using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TicketFlow.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedInitialUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "RowIdentifier", "SeatNumber", "SectorId", "Status", "Version" },
                values: new object[,]
                {
                    { new Guid("00c44271-4caf-4afc-a5a4-326281faaaa6"), "B", 48, 2, "Available", 1 },
                    { new Guid("01658961-0274-48f9-9a9d-50cba3557ab0"), "B", 5, 2, "Available", 1 },
                    { new Guid("047b3e00-2d8c-48f2-bc89-bcc2588aded3"), "A", 42, 1, "Available", 1 },
                    { new Guid("06a39a47-ddbc-4f23-851d-2b46569c0c20"), "B", 24, 2, "Available", 1 },
                    { new Guid("06cfafa6-7a3e-4393-b9c7-fb1ab8ce2ed7"), "A", 37, 1, "Available", 1 },
                    { new Guid("071b9745-46ca-4877-8f12-4768e500353b"), "B", 14, 2, "Available", 1 },
                    { new Guid("0a99c026-b53f-4223-a760-0fe2985e929a"), "A", 5, 1, "Available", 1 },
                    { new Guid("0f81449a-60d9-48ac-9406-cfc567e1b677"), "B", 21, 2, "Available", 1 },
                    { new Guid("169b5008-b3dc-418e-9f78-b42b5039c509"), "B", 35, 2, "Available", 1 },
                    { new Guid("16fddcc5-5598-4c39-9f46-4f4be1c7af19"), "B", 36, 2, "Available", 1 },
                    { new Guid("1a220fef-79a4-4737-9f73-527b96e35595"), "A", 25, 1, "Available", 1 },
                    { new Guid("1a7c03b1-7be7-4aee-91d6-b0c20950d50d"), "B", 3, 2, "Available", 1 },
                    { new Guid("1aabc97a-e69e-4fb2-84b3-114ba98e5507"), "B", 30, 2, "Available", 1 },
                    { new Guid("1c34ad73-b93b-4471-815c-98f0534b6e43"), "B", 40, 2, "Available", 1 },
                    { new Guid("1e5505b5-64c7-46d1-9ce2-f29519260d2d"), "A", 48, 1, "Available", 1 },
                    { new Guid("24b6f70b-a5da-42bb-9f20-4a38fe3f68b5"), "A", 19, 1, "Available", 1 },
                    { new Guid("2847fe5f-e039-478c-a8cf-fa511ea47057"), "A", 50, 1, "Available", 1 },
                    { new Guid("2b1cb4fb-4494-411a-b369-104e18826696"), "B", 16, 2, "Available", 1 },
                    { new Guid("2c17c4e1-65e8-4864-ac68-c3dae495980e"), "B", 38, 2, "Available", 1 },
                    { new Guid("2da1d6fa-d867-4393-9396-084473a333cc"), "B", 46, 2, "Available", 1 },
                    { new Guid("2ef71a7d-f870-426c-82bc-7706527e6bf4"), "A", 44, 1, "Available", 1 },
                    { new Guid("353d4423-f56c-41df-8ea8-0fe1d4290ebc"), "B", 26, 2, "Available", 1 },
                    { new Guid("397771d1-f00d-4ef2-94a5-df850a511e80"), "B", 41, 2, "Available", 1 },
                    { new Guid("3bca7238-28ae-4ac1-8239-4252385b0aec"), "B", 50, 2, "Available", 1 },
                    { new Guid("3d16ef9e-b0ca-454c-93ca-3b651c7fd61c"), "B", 33, 2, "Available", 1 },
                    { new Guid("3d2d55e2-63a6-4602-b581-d33594d00f1a"), "A", 30, 1, "Available", 1 },
                    { new Guid("402724e0-bb61-4579-b6ac-5ab94cd1ab3b"), "A", 2, 1, "Available", 1 },
                    { new Guid("4217f256-f378-4fda-b86e-a8d1849dd92c"), "B", 23, 2, "Available", 1 },
                    { new Guid("42b0ba75-1607-4033-93c1-145c0667836e"), "A", 45, 1, "Available", 1 },
                    { new Guid("432cc9fb-5bf4-4f83-b277-5006946a20f7"), "A", 18, 1, "Available", 1 },
                    { new Guid("4349b73e-19fa-4fa5-9549-44a7200804d4"), "B", 8, 2, "Available", 1 },
                    { new Guid("44c2637a-5663-46ad-96bc-43a450a3231b"), "A", 26, 1, "Available", 1 },
                    { new Guid("47c94d4e-11b5-44a0-bf9c-86ad41b96023"), "A", 10, 1, "Available", 1 },
                    { new Guid("481d5ecc-c82b-4b45-b42e-333ca0f79422"), "B", 47, 2, "Available", 1 },
                    { new Guid("482958bd-4248-4ed2-a756-97c83d5c83f5"), "A", 40, 1, "Available", 1 },
                    { new Guid("4a9e425a-cb3f-440e-a175-dfd4107e3c0a"), "A", 21, 1, "Available", 1 },
                    { new Guid("5781b2d1-a7ce-49aa-ba18-e24b840acac4"), "B", 13, 2, "Available", 1 },
                    { new Guid("5bb04c96-a602-4173-96da-01bba2a5fd76"), "A", 41, 1, "Available", 1 },
                    { new Guid("5ec963c6-e6fa-4483-aca1-b93c2c295468"), "A", 43, 1, "Available", 1 },
                    { new Guid("6129f148-a615-46f5-8738-dcd66d4a94aa"), "B", 9, 2, "Available", 1 },
                    { new Guid("62ace743-716f-4055-8710-28165b6bafa1"), "B", 6, 2, "Available", 1 },
                    { new Guid("632d8353-5c69-48c2-aad1-a35459e168f6"), "B", 28, 2, "Available", 1 },
                    { new Guid("64e9ef8a-a3a3-40ab-97cb-3922d66da18c"), "B", 19, 2, "Available", 1 },
                    { new Guid("6750dddb-04d0-4c10-a159-c7681e54262c"), "A", 7, 1, "Available", 1 },
                    { new Guid("6a598460-ed8b-4ccb-b2c6-2c26e4174ee9"), "A", 38, 1, "Available", 1 },
                    { new Guid("6d6aee27-b1cb-4dd7-8ca9-e8b4667fff32"), "A", 33, 1, "Available", 1 },
                    { new Guid("6d80f5ab-a35b-47d6-a1ff-cec333213472"), "A", 35, 1, "Available", 1 },
                    { new Guid("727b0768-d2aa-467f-8296-4564d20bff4f"), "A", 32, 1, "Available", 1 },
                    { new Guid("72f246db-8c36-4539-882c-cc404a0ff70b"), "B", 45, 2, "Available", 1 },
                    { new Guid("75d943be-eaea-4dcf-9153-859d23c0d0df"), "A", 22, 1, "Available", 1 },
                    { new Guid("7719a69a-bd02-44b5-b92f-d1a0c3c3e379"), "B", 18, 2, "Available", 1 },
                    { new Guid("777361c5-95ee-4ce7-8813-da85711e901f"), "A", 16, 1, "Available", 1 },
                    { new Guid("798442dc-b34b-439c-b1a1-415adbfc1748"), "B", 15, 2, "Available", 1 },
                    { new Guid("7afdb716-3ac8-4c37-ba42-f26090dbde22"), "B", 27, 2, "Available", 1 },
                    { new Guid("7c7c9127-a345-4a46-9d09-5b8dd406296d"), "A", 31, 1, "Available", 1 },
                    { new Guid("8495d941-2903-4b10-87ab-780486e719b3"), "A", 29, 1, "Available", 1 },
                    { new Guid("84e77e5f-0f5c-4421-8867-5c329ae24fa0"), "B", 31, 2, "Available", 1 },
                    { new Guid("8c92ff49-a9c0-4275-bc06-bcbe9d2e1837"), "B", 34, 2, "Available", 1 },
                    { new Guid("9122eefe-1b3a-47d4-9cc8-bbd6e417f7ce"), "B", 29, 2, "Available", 1 },
                    { new Guid("94ab911f-99b1-428b-a61b-760df710e4f7"), "B", 25, 2, "Available", 1 },
                    { new Guid("950cff1d-cf48-4d97-ab7e-81c2984e9aa8"), "B", 20, 2, "Available", 1 },
                    { new Guid("9576af74-2068-4955-9626-fe4d9601ed57"), "A", 1, 1, "Available", 1 },
                    { new Guid("984f3012-af1f-4f09-b6f2-1289ba22493e"), "A", 46, 1, "Available", 1 },
                    { new Guid("988b4363-64e8-4875-9f9a-003f901b6066"), "A", 24, 1, "Available", 1 },
                    { new Guid("9b2df91f-b909-4a9d-a861-3b1e9e37a061"), "A", 9, 1, "Available", 1 },
                    { new Guid("9bf479de-b699-4f4f-8d49-ced3f68092fe"), "A", 12, 1, "Available", 1 },
                    { new Guid("9e2cd13b-8cef-414e-98ed-27ee263fb209"), "B", 43, 2, "Available", 1 },
                    { new Guid("9e8a561b-f4e5-44c5-bb9c-4776034f35dc"), "B", 42, 2, "Available", 1 },
                    { new Guid("a7521892-0636-4424-a82f-af70b00c6a90"), "A", 14, 1, "Available", 1 },
                    { new Guid("aa4e2f37-4bdd-4045-a9b7-771d77a0cf5a"), "A", 20, 1, "Available", 1 },
                    { new Guid("af021ee2-a5b3-449d-b522-cdad3fc9f8c2"), "A", 17, 1, "Available", 1 },
                    { new Guid("afd258c4-8ad6-42bf-9cfe-a54252383f6d"), "B", 11, 2, "Available", 1 },
                    { new Guid("b383200a-2e07-4e71-a8c9-4dccf47899fb"), "B", 2, 2, "Available", 1 },
                    { new Guid("c734b77e-99f3-41f8-9615-344f3a556427"), "B", 49, 2, "Available", 1 },
                    { new Guid("c8c4be37-65af-4016-a6fe-7af51139e820"), "A", 23, 1, "Available", 1 },
                    { new Guid("caab4fc8-cf23-4f2f-91e7-23cba2690306"), "A", 4, 1, "Available", 1 },
                    { new Guid("ccc15d21-ca59-4074-a2fd-220776e29376"), "A", 39, 1, "Available", 1 },
                    { new Guid("cce343b7-9ea9-4dee-8787-ebe7207f511e"), "A", 13, 1, "Available", 1 },
                    { new Guid("cf0a5c93-565e-40b6-91d5-4b92ece8c52b"), "B", 10, 2, "Available", 1 },
                    { new Guid("d307eb05-1ad5-460c-9f97-466724fce954"), "A", 8, 1, "Available", 1 },
                    { new Guid("d3490740-024e-4858-871b-61f587891146"), "B", 44, 2, "Available", 1 },
                    { new Guid("d5e9d9c7-c80a-4512-b136-67cc2121da35"), "A", 6, 1, "Available", 1 },
                    { new Guid("d6ce2628-1ad8-4eb1-8352-43e344fc0ed4"), "B", 37, 2, "Available", 1 },
                    { new Guid("d7eb5243-dc75-4c41-9ec1-a78c86cbbe15"), "A", 34, 1, "Available", 1 },
                    { new Guid("d868fc0a-8a78-4ca1-aade-ff3b9f48e807"), "A", 11, 1, "Available", 1 },
                    { new Guid("da318697-f5b0-4fa1-8d48-2636d93d2f96"), "A", 49, 1, "Available", 1 },
                    { new Guid("dc24778e-418d-4093-b738-1fa2c8c281e3"), "A", 47, 1, "Available", 1 },
                    { new Guid("dc45819b-badf-4d5a-beb4-b21eefd8c37f"), "B", 22, 2, "Available", 1 },
                    { new Guid("dd0cacf9-9f32-4d9b-8919-eb6b9e618419"), "B", 32, 2, "Available", 1 },
                    { new Guid("dfd9d9cc-5f63-4dd6-95d4-e8f3b16ae0a2"), "A", 36, 1, "Available", 1 },
                    { new Guid("e4b3dfb4-65b2-4b22-bfe3-936a5da9d21e"), "A", 3, 1, "Available", 1 },
                    { new Guid("e64de033-4a67-485e-85a2-333d5c2bda04"), "B", 17, 2, "Available", 1 },
                    { new Guid("e9eca9b5-1be9-4643-86e8-a0ff19e187b9"), "A", 15, 1, "Available", 1 },
                    { new Guid("ea2f93be-a54e-4f7a-a7f9-bb8e8f90b112"), "B", 1, 2, "Available", 1 },
                    { new Guid("eca3883d-0ed8-477a-92aa-a951ed55f7d0"), "B", 39, 2, "Available", 1 },
                    { new Guid("eebb7f44-76a2-4d9c-8a8b-74ddc3e3ab5b"), "B", 4, 2, "Available", 1 },
                    { new Guid("f189b30c-04c3-4926-a0f6-d916e912a398"), "B", 12, 2, "Available", 1 },
                    { new Guid("f4d66e19-5e4b-4da9-bea2-30d6e0add33e"), "B", 7, 2, "Available", 1 },
                    { new Guid("f78fc66e-6903-4330-9a21-c205303edef6"), "A", 27, 1, "Available", 1 },
                    { new Guid("fef679e0-d811-4c27-b421-4e131cb2321e"), "A", 28, 1, "Available", 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "PasswordHash" },
                values: new object[,]
                {
                    { 1, "agus@ticketflow.com", "Agustin (Tech Lead)", "123456" },
                    { 2, "ale@ticketflow.com", "Alejandro", "123456" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("00c44271-4caf-4afc-a5a4-326281faaaa6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("01658961-0274-48f9-9a9d-50cba3557ab0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("047b3e00-2d8c-48f2-bc89-bcc2588aded3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("06a39a47-ddbc-4f23-851d-2b46569c0c20"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("06cfafa6-7a3e-4393-b9c7-fb1ab8ce2ed7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("071b9745-46ca-4877-8f12-4768e500353b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0a99c026-b53f-4223-a760-0fe2985e929a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0f81449a-60d9-48ac-9406-cfc567e1b677"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("169b5008-b3dc-418e-9f78-b42b5039c509"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("16fddcc5-5598-4c39-9f46-4f4be1c7af19"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1a220fef-79a4-4737-9f73-527b96e35595"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1a7c03b1-7be7-4aee-91d6-b0c20950d50d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1aabc97a-e69e-4fb2-84b3-114ba98e5507"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1c34ad73-b93b-4471-815c-98f0534b6e43"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1e5505b5-64c7-46d1-9ce2-f29519260d2d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("24b6f70b-a5da-42bb-9f20-4a38fe3f68b5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2847fe5f-e039-478c-a8cf-fa511ea47057"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2b1cb4fb-4494-411a-b369-104e18826696"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2c17c4e1-65e8-4864-ac68-c3dae495980e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2da1d6fa-d867-4393-9396-084473a333cc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2ef71a7d-f870-426c-82bc-7706527e6bf4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("353d4423-f56c-41df-8ea8-0fe1d4290ebc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("397771d1-f00d-4ef2-94a5-df850a511e80"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3bca7238-28ae-4ac1-8239-4252385b0aec"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3d16ef9e-b0ca-454c-93ca-3b651c7fd61c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3d2d55e2-63a6-4602-b581-d33594d00f1a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("402724e0-bb61-4579-b6ac-5ab94cd1ab3b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4217f256-f378-4fda-b86e-a8d1849dd92c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("42b0ba75-1607-4033-93c1-145c0667836e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("432cc9fb-5bf4-4f83-b277-5006946a20f7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4349b73e-19fa-4fa5-9549-44a7200804d4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("44c2637a-5663-46ad-96bc-43a450a3231b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("47c94d4e-11b5-44a0-bf9c-86ad41b96023"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("481d5ecc-c82b-4b45-b42e-333ca0f79422"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("482958bd-4248-4ed2-a756-97c83d5c83f5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4a9e425a-cb3f-440e-a175-dfd4107e3c0a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5781b2d1-a7ce-49aa-ba18-e24b840acac4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5bb04c96-a602-4173-96da-01bba2a5fd76"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5ec963c6-e6fa-4483-aca1-b93c2c295468"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6129f148-a615-46f5-8738-dcd66d4a94aa"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("62ace743-716f-4055-8710-28165b6bafa1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("632d8353-5c69-48c2-aad1-a35459e168f6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("64e9ef8a-a3a3-40ab-97cb-3922d66da18c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6750dddb-04d0-4c10-a159-c7681e54262c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6a598460-ed8b-4ccb-b2c6-2c26e4174ee9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6d6aee27-b1cb-4dd7-8ca9-e8b4667fff32"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6d80f5ab-a35b-47d6-a1ff-cec333213472"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("727b0768-d2aa-467f-8296-4564d20bff4f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("72f246db-8c36-4539-882c-cc404a0ff70b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("75d943be-eaea-4dcf-9153-859d23c0d0df"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7719a69a-bd02-44b5-b92f-d1a0c3c3e379"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("777361c5-95ee-4ce7-8813-da85711e901f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("798442dc-b34b-439c-b1a1-415adbfc1748"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7afdb716-3ac8-4c37-ba42-f26090dbde22"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7c7c9127-a345-4a46-9d09-5b8dd406296d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8495d941-2903-4b10-87ab-780486e719b3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("84e77e5f-0f5c-4421-8867-5c329ae24fa0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8c92ff49-a9c0-4275-bc06-bcbe9d2e1837"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9122eefe-1b3a-47d4-9cc8-bbd6e417f7ce"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("94ab911f-99b1-428b-a61b-760df710e4f7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("950cff1d-cf48-4d97-ab7e-81c2984e9aa8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9576af74-2068-4955-9626-fe4d9601ed57"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("984f3012-af1f-4f09-b6f2-1289ba22493e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("988b4363-64e8-4875-9f9a-003f901b6066"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9b2df91f-b909-4a9d-a861-3b1e9e37a061"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9bf479de-b699-4f4f-8d49-ced3f68092fe"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9e2cd13b-8cef-414e-98ed-27ee263fb209"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9e8a561b-f4e5-44c5-bb9c-4776034f35dc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a7521892-0636-4424-a82f-af70b00c6a90"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("aa4e2f37-4bdd-4045-a9b7-771d77a0cf5a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("af021ee2-a5b3-449d-b522-cdad3fc9f8c2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("afd258c4-8ad6-42bf-9cfe-a54252383f6d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b383200a-2e07-4e71-a8c9-4dccf47899fb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c734b77e-99f3-41f8-9615-344f3a556427"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c8c4be37-65af-4016-a6fe-7af51139e820"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("caab4fc8-cf23-4f2f-91e7-23cba2690306"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ccc15d21-ca59-4074-a2fd-220776e29376"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cce343b7-9ea9-4dee-8787-ebe7207f511e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cf0a5c93-565e-40b6-91d5-4b92ece8c52b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d307eb05-1ad5-460c-9f97-466724fce954"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d3490740-024e-4858-871b-61f587891146"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d5e9d9c7-c80a-4512-b136-67cc2121da35"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d6ce2628-1ad8-4eb1-8352-43e344fc0ed4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d7eb5243-dc75-4c41-9ec1-a78c86cbbe15"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d868fc0a-8a78-4ca1-aade-ff3b9f48e807"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("da318697-f5b0-4fa1-8d48-2636d93d2f96"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("dc24778e-418d-4093-b738-1fa2c8c281e3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("dc45819b-badf-4d5a-beb4-b21eefd8c37f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("dd0cacf9-9f32-4d9b-8919-eb6b9e618419"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("dfd9d9cc-5f63-4dd6-95d4-e8f3b16ae0a2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e4b3dfb4-65b2-4b22-bfe3-936a5da9d21e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e64de033-4a67-485e-85a2-333d5c2bda04"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e9eca9b5-1be9-4643-86e8-a0ff19e187b9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ea2f93be-a54e-4f7a-a7f9-bb8e8f90b112"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("eca3883d-0ed8-477a-92aa-a951ed55f7d0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("eebb7f44-76a2-4d9c-8a8b-74ddc3e3ab5b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f189b30c-04c3-4926-a0f6-d916e912a398"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f4d66e19-5e4b-4da9-bea2-30d6e0add33e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f78fc66e-6903-4330-9a21-c205303edef6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fef679e0-d811-4c27-b421-4e131cb2321e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

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
        }
    }
}
