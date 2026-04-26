using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TicketFlow.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeatRowsAndNumbers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "RowIdentifier", "SeatNumber", "SectorId", "Status", "Version" },
                values: new object[,]
                {
                    { new Guid("06948517-bb24-46b7-a1c1-2500408b62a7"), "A", 10, 2, "Available", 1 },
                    { new Guid("07dc7514-7a41-4e61-b253-237f4e262917"), "D", 1, 1, "Available", 1 },
                    { new Guid("095bf0a9-eb3b-4624-ab6a-0e73193189d3"), "E", 3, 1, "Available", 1 },
                    { new Guid("0a53b92d-8253-4f0e-9215-d292fd73d8a0"), "A", 9, 1, "Available", 1 },
                    { new Guid("0c033d59-db2e-4ef2-97c5-541d305ed83c"), "C", 7, 2, "Available", 1 },
                    { new Guid("0d4491bc-902a-4857-a816-57669ffcdb51"), "A", 3, 2, "Available", 1 },
                    { new Guid("0d6595ae-2367-4c65-9c04-8a8841e744d7"), "D", 2, 2, "Available", 1 },
                    { new Guid("0e80cd74-ea37-4f14-84c7-c7068835491e"), "C", 1, 1, "Available", 1 },
                    { new Guid("109e8c6e-65f9-4b9c-86a2-292b1c8e04b8"), "C", 3, 1, "Available", 1 },
                    { new Guid("13713a1c-6410-4d2c-8fb6-892b6fb846e7"), "E", 1, 1, "Available", 1 },
                    { new Guid("1ac03819-e095-4bfd-a3eb-081a066ba7fe"), "A", 5, 2, "Available", 1 },
                    { new Guid("1b88e52f-a615-4e33-8cfd-172ce73cd073"), "C", 10, 1, "Available", 1 },
                    { new Guid("1be6874f-2461-4293-ae87-da7007349a7b"), "D", 10, 2, "Available", 1 },
                    { new Guid("1c476f9a-23bd-4d95-82e0-3ede01041111"), "E", 2, 2, "Available", 1 },
                    { new Guid("1c5804ad-dbc3-4776-8cee-fd81814e65de"), "C", 10, 2, "Available", 1 },
                    { new Guid("21034369-df46-474f-80f8-c224c1e61570"), "A", 2, 2, "Available", 1 },
                    { new Guid("21740bf6-7044-4149-bbf0-f5f871cbd582"), "D", 6, 1, "Available", 1 },
                    { new Guid("21951333-6f71-423f-96af-b76db8e054f4"), "B", 1, 2, "Available", 1 },
                    { new Guid("2575896d-bdad-4995-96ce-88518d0dd1f0"), "A", 7, 2, "Available", 1 },
                    { new Guid("277ffe5e-cfb9-4324-990b-bf8fcd6c0be3"), "C", 8, 2, "Available", 1 },
                    { new Guid("27f6b989-f289-4112-adb5-d4a7722d3289"), "C", 4, 2, "Available", 1 },
                    { new Guid("2b9d826f-7bc8-4b67-a10a-0e1bb42440e0"), "E", 2, 1, "Available", 1 },
                    { new Guid("2bf271a2-b55f-4408-9f5c-8ad157b12afc"), "E", 7, 2, "Available", 1 },
                    { new Guid("2d40a7ec-d76f-4736-9ee8-1fc48054b635"), "D", 1, 2, "Available", 1 },
                    { new Guid("30fddd05-5e6e-4774-a5de-8cf3f62ec68b"), "A", 4, 1, "Available", 1 },
                    { new Guid("314fcc67-ad78-4594-b9ae-1c7e43cc37b9"), "D", 5, 1, "Available", 1 },
                    { new Guid("32841f86-ba25-43c4-b41e-c72515044b9b"), "B", 8, 2, "Available", 1 },
                    { new Guid("33e210a0-de9f-42f7-8db4-cdebd904e2a6"), "A", 6, 2, "Available", 1 },
                    { new Guid("33eb8502-a42e-4256-946a-10f445d6daf9"), "C", 5, 2, "Available", 1 },
                    { new Guid("375087c0-e630-4592-8d0e-134f87241d54"), "D", 5, 2, "Available", 1 },
                    { new Guid("3764b29f-732f-4dd2-8708-7c3bcaf5b439"), "E", 10, 2, "Available", 1 },
                    { new Guid("412b6c18-bb62-4a18-8bdf-50756d4c107c"), "E", 1, 2, "Available", 1 },
                    { new Guid("437c9800-895d-4256-b784-99d28e240934"), "B", 9, 1, "Available", 1 },
                    { new Guid("44cee06d-5734-45f4-86ea-8ecc3d700139"), "D", 3, 2, "Available", 1 },
                    { new Guid("4832519f-ae8c-4b26-a3a5-aba28c14f13d"), "B", 5, 2, "Available", 1 },
                    { new Guid("51b55137-1527-4867-9f25-d5972e72f973"), "D", 8, 1, "Available", 1 },
                    { new Guid("5607728d-88db-4ebf-8ad8-7e465707a9b5"), "E", 5, 2, "Available", 1 },
                    { new Guid("58123b37-b404-4c5e-bdda-64b39074db23"), "B", 5, 1, "Available", 1 },
                    { new Guid("5bef7852-ad2d-4dba-a043-e37ddd062bd1"), "E", 8, 2, "Available", 1 },
                    { new Guid("5ed79725-8841-4fcb-8805-6d3162ce7772"), "D", 6, 2, "Available", 1 },
                    { new Guid("5fbfbe03-43a5-4bed-9829-29d8e29fe8bf"), "A", 4, 2, "Available", 1 },
                    { new Guid("6239e534-ebf3-4b13-9a9d-f610d94f519f"), "C", 8, 1, "Available", 1 },
                    { new Guid("64fb7bc9-e5d9-4048-a145-1379bf3a799d"), "E", 5, 1, "Available", 1 },
                    { new Guid("663e1f2c-7880-4376-844a-228cb6245988"), "C", 2, 1, "Available", 1 },
                    { new Guid("66a73461-58a4-4055-9640-cdc1f812e3da"), "C", 5, 1, "Available", 1 },
                    { new Guid("66bcf674-bd26-451a-898c-4825dd72025a"), "A", 2, 1, "Available", 1 },
                    { new Guid("68879e03-8b3a-4faf-81d8-bf7904df7d31"), "D", 2, 1, "Available", 1 },
                    { new Guid("69a4d4ed-05e7-452a-925d-7e6a269b272f"), "A", 1, 1, "Available", 1 },
                    { new Guid("6cd85d5f-4690-4e87-9302-c55bae49179d"), "B", 7, 2, "Available", 1 },
                    { new Guid("6d0fdec0-3ce1-4fa1-8af1-c92e3d414cde"), "C", 2, 2, "Available", 1 },
                    { new Guid("6d899102-edb9-4340-b2f6-c560ba7f2ff2"), "C", 6, 1, "Available", 1 },
                    { new Guid("70382125-a79d-4e34-bcb2-a6e3211a2dab"), "A", 7, 1, "Available", 1 },
                    { new Guid("78fd49ba-474c-4b67-b8db-e38210925ad2"), "E", 8, 1, "Available", 1 },
                    { new Guid("7b8340c0-87f9-491d-86e9-afca90c9cf74"), "B", 7, 1, "Available", 1 },
                    { new Guid("7c39958c-64bb-45f2-b6cd-606dd192c250"), "C", 9, 1, "Available", 1 },
                    { new Guid("878780bf-60f9-4cb9-a79e-86286f416f48"), "D", 10, 1, "Available", 1 },
                    { new Guid("8b575098-2c6d-47df-861c-b294e4abab51"), "C", 4, 1, "Available", 1 },
                    { new Guid("8d850456-c25b-4206-924f-7a4caa8ab38b"), "B", 10, 2, "Available", 1 },
                    { new Guid("8f567645-b8ae-4001-878e-e24b7a40167c"), "D", 7, 1, "Available", 1 },
                    { new Guid("96f520fe-4b79-4c02-9c9b-d0243f38e1e8"), "E", 4, 1, "Available", 1 },
                    { new Guid("9779360d-956b-47fd-826e-2b9b5a711f1c"), "A", 3, 1, "Available", 1 },
                    { new Guid("9a54a6bb-ef97-4689-98c9-06f2eb616612"), "C", 7, 1, "Available", 1 },
                    { new Guid("9b0c7894-4187-486b-8a8d-51427289a7e9"), "B", 9, 2, "Available", 1 },
                    { new Guid("9cdd12db-bb50-4e30-8f5b-40e486ca8fbd"), "C", 9, 2, "Available", 1 },
                    { new Guid("a14b0b23-fddc-4e4d-a5c4-a84ad0f9518b"), "B", 6, 1, "Available", 1 },
                    { new Guid("a20c96e0-f69a-4f77-80e1-fe53b21d8623"), "E", 10, 1, "Available", 1 },
                    { new Guid("a4652be8-8d4f-4990-92c2-9a643a05f4d1"), "D", 3, 1, "Available", 1 },
                    { new Guid("a49942a8-271a-4eba-b86a-d2d18811b029"), "A", 9, 2, "Available", 1 },
                    { new Guid("a4a84f68-2439-427c-a8ef-f3a794e5e825"), "D", 9, 1, "Available", 1 },
                    { new Guid("ab22fa9d-69c1-4b0e-aa0e-f8e9c7b6ba9f"), "A", 1, 2, "Available", 1 },
                    { new Guid("adc971e9-0eb6-42ba-b1f1-4a9b66d5cf63"), "B", 4, 1, "Available", 1 },
                    { new Guid("b288e078-bf4c-4935-9100-f71d19a72abf"), "A", 8, 1, "Available", 1 },
                    { new Guid("b877e68b-6d7c-4496-85dc-52834eaea3a2"), "C", 3, 2, "Available", 1 },
                    { new Guid("b9096692-a15f-47ba-9660-4b6066ccf959"), "D", 9, 2, "Available", 1 },
                    { new Guid("bb2f545f-0bf6-49b5-a730-c8f14784a6e7"), "A", 10, 1, "Available", 1 },
                    { new Guid("be229e3f-4455-45fa-97b8-40e0b1f6b478"), "B", 6, 2, "Available", 1 },
                    { new Guid("c450b888-c161-4b2a-9b52-480a29230333"), "B", 4, 2, "Available", 1 },
                    { new Guid("c8359cfb-a778-469f-b774-4afde6377352"), "E", 3, 2, "Available", 1 },
                    { new Guid("c9b5461a-baf7-4bf5-817f-f90d58d81733"), "C", 1, 2, "Available", 1 },
                    { new Guid("cb7cd8ca-1b13-45bb-9985-f40ed58c9a83"), "B", 3, 2, "Available", 1 },
                    { new Guid("cba9f8ba-02c8-4eb5-a6c4-c71958b4ae0e"), "D", 4, 2, "Available", 1 },
                    { new Guid("d21dc9a4-d015-42ec-8431-60b2934aa129"), "E", 4, 2, "Available", 1 },
                    { new Guid("d8a467c6-6a08-4989-8eef-45864660a430"), "E", 9, 1, "Available", 1 },
                    { new Guid("da093c63-f501-4bc8-a484-e1ff07422351"), "E", 9, 2, "Available", 1 },
                    { new Guid("daefdbb7-4e51-4ac8-8c00-5e19bc0bab49"), "B", 2, 2, "Available", 1 },
                    { new Guid("dd340b00-2022-43c8-9262-6c0dfe7c4e5c"), "D", 4, 1, "Available", 1 },
                    { new Guid("ddc172d6-95c6-408d-afcc-c99b0b37fb05"), "D", 8, 2, "Available", 1 },
                    { new Guid("e017d1df-8752-4386-9a90-8340f593d9c0"), "E", 6, 1, "Available", 1 },
                    { new Guid("e3080fdd-9ba7-4d8b-beb9-9a138942ed9e"), "B", 2, 1, "Available", 1 },
                    { new Guid("e3349eed-06b6-4f7c-9128-82eeb1919b1f"), "B", 1, 1, "Available", 1 },
                    { new Guid("e51317f2-6d87-4cad-b012-84947bf1c337"), "E", 7, 1, "Available", 1 },
                    { new Guid("e81bc41e-381b-470f-9988-859f837b7143"), "A", 6, 1, "Available", 1 },
                    { new Guid("e8d429ab-a80b-4b80-af5c-8a76a8a0767c"), "C", 6, 2, "Available", 1 },
                    { new Guid("eac073a9-3272-4794-988a-421f82163bd0"), "D", 7, 2, "Available", 1 },
                    { new Guid("ee97793f-fec8-43c8-8fb7-1714d3b119c2"), "A", 5, 1, "Available", 1 },
                    { new Guid("ef2f8307-3388-4bda-a821-68b7f6581c87"), "E", 6, 2, "Available", 1 },
                    { new Guid("f161f4d7-af8a-43bd-9a1d-32a178e451d5"), "B", 10, 1, "Available", 1 },
                    { new Guid("f1d010f8-fd22-40c8-a999-62aee8c2736b"), "B", 3, 1, "Available", 1 },
                    { new Guid("f8da6314-2a92-4456-89af-b99863b9b8c8"), "A", 8, 2, "Available", 1 },
                    { new Guid("fa63868e-9193-4e47-b309-de5f9562755c"), "B", 8, 1, "Available", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("06948517-bb24-46b7-a1c1-2500408b62a7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("07dc7514-7a41-4e61-b253-237f4e262917"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("095bf0a9-eb3b-4624-ab6a-0e73193189d3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0a53b92d-8253-4f0e-9215-d292fd73d8a0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0c033d59-db2e-4ef2-97c5-541d305ed83c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0d4491bc-902a-4857-a816-57669ffcdb51"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0d6595ae-2367-4c65-9c04-8a8841e744d7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0e80cd74-ea37-4f14-84c7-c7068835491e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("109e8c6e-65f9-4b9c-86a2-292b1c8e04b8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("13713a1c-6410-4d2c-8fb6-892b6fb846e7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1ac03819-e095-4bfd-a3eb-081a066ba7fe"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1b88e52f-a615-4e33-8cfd-172ce73cd073"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1be6874f-2461-4293-ae87-da7007349a7b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1c476f9a-23bd-4d95-82e0-3ede01041111"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1c5804ad-dbc3-4776-8cee-fd81814e65de"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("21034369-df46-474f-80f8-c224c1e61570"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("21740bf6-7044-4149-bbf0-f5f871cbd582"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("21951333-6f71-423f-96af-b76db8e054f4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2575896d-bdad-4995-96ce-88518d0dd1f0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("277ffe5e-cfb9-4324-990b-bf8fcd6c0be3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("27f6b989-f289-4112-adb5-d4a7722d3289"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2b9d826f-7bc8-4b67-a10a-0e1bb42440e0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2bf271a2-b55f-4408-9f5c-8ad157b12afc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2d40a7ec-d76f-4736-9ee8-1fc48054b635"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("30fddd05-5e6e-4774-a5de-8cf3f62ec68b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("314fcc67-ad78-4594-b9ae-1c7e43cc37b9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("32841f86-ba25-43c4-b41e-c72515044b9b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("33e210a0-de9f-42f7-8db4-cdebd904e2a6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("33eb8502-a42e-4256-946a-10f445d6daf9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("375087c0-e630-4592-8d0e-134f87241d54"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3764b29f-732f-4dd2-8708-7c3bcaf5b439"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("412b6c18-bb62-4a18-8bdf-50756d4c107c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("437c9800-895d-4256-b784-99d28e240934"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("44cee06d-5734-45f4-86ea-8ecc3d700139"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4832519f-ae8c-4b26-a3a5-aba28c14f13d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("51b55137-1527-4867-9f25-d5972e72f973"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5607728d-88db-4ebf-8ad8-7e465707a9b5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("58123b37-b404-4c5e-bdda-64b39074db23"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5bef7852-ad2d-4dba-a043-e37ddd062bd1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5ed79725-8841-4fcb-8805-6d3162ce7772"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5fbfbe03-43a5-4bed-9829-29d8e29fe8bf"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6239e534-ebf3-4b13-9a9d-f610d94f519f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("64fb7bc9-e5d9-4048-a145-1379bf3a799d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("663e1f2c-7880-4376-844a-228cb6245988"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("66a73461-58a4-4055-9640-cdc1f812e3da"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("66bcf674-bd26-451a-898c-4825dd72025a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("68879e03-8b3a-4faf-81d8-bf7904df7d31"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("69a4d4ed-05e7-452a-925d-7e6a269b272f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6cd85d5f-4690-4e87-9302-c55bae49179d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6d0fdec0-3ce1-4fa1-8af1-c92e3d414cde"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6d899102-edb9-4340-b2f6-c560ba7f2ff2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("70382125-a79d-4e34-bcb2-a6e3211a2dab"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("78fd49ba-474c-4b67-b8db-e38210925ad2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7b8340c0-87f9-491d-86e9-afca90c9cf74"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7c39958c-64bb-45f2-b6cd-606dd192c250"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("878780bf-60f9-4cb9-a79e-86286f416f48"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8b575098-2c6d-47df-861c-b294e4abab51"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8d850456-c25b-4206-924f-7a4caa8ab38b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8f567645-b8ae-4001-878e-e24b7a40167c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("96f520fe-4b79-4c02-9c9b-d0243f38e1e8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9779360d-956b-47fd-826e-2b9b5a711f1c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9a54a6bb-ef97-4689-98c9-06f2eb616612"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9b0c7894-4187-486b-8a8d-51427289a7e9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9cdd12db-bb50-4e30-8f5b-40e486ca8fbd"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a14b0b23-fddc-4e4d-a5c4-a84ad0f9518b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a20c96e0-f69a-4f77-80e1-fe53b21d8623"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a4652be8-8d4f-4990-92c2-9a643a05f4d1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a49942a8-271a-4eba-b86a-d2d18811b029"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a4a84f68-2439-427c-a8ef-f3a794e5e825"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ab22fa9d-69c1-4b0e-aa0e-f8e9c7b6ba9f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("adc971e9-0eb6-42ba-b1f1-4a9b66d5cf63"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b288e078-bf4c-4935-9100-f71d19a72abf"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b877e68b-6d7c-4496-85dc-52834eaea3a2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b9096692-a15f-47ba-9660-4b6066ccf959"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bb2f545f-0bf6-49b5-a730-c8f14784a6e7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("be229e3f-4455-45fa-97b8-40e0b1f6b478"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c450b888-c161-4b2a-9b52-480a29230333"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c8359cfb-a778-469f-b774-4afde6377352"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c9b5461a-baf7-4bf5-817f-f90d58d81733"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cb7cd8ca-1b13-45bb-9985-f40ed58c9a83"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cba9f8ba-02c8-4eb5-a6c4-c71958b4ae0e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d21dc9a4-d015-42ec-8431-60b2934aa129"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d8a467c6-6a08-4989-8eef-45864660a430"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("da093c63-f501-4bc8-a484-e1ff07422351"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("daefdbb7-4e51-4ac8-8c00-5e19bc0bab49"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("dd340b00-2022-43c8-9262-6c0dfe7c4e5c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ddc172d6-95c6-408d-afcc-c99b0b37fb05"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e017d1df-8752-4386-9a90-8340f593d9c0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e3080fdd-9ba7-4d8b-beb9-9a138942ed9e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e3349eed-06b6-4f7c-9128-82eeb1919b1f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e51317f2-6d87-4cad-b012-84947bf1c337"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e81bc41e-381b-470f-9988-859f837b7143"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e8d429ab-a80b-4b80-af5c-8a76a8a0767c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("eac073a9-3272-4794-988a-421f82163bd0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ee97793f-fec8-43c8-8fb7-1714d3b119c2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ef2f8307-3388-4bda-a821-68b7f6581c87"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f161f4d7-af8a-43bd-9a1d-32a178e451d5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f1d010f8-fd22-40c8-a999-62aee8c2736b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f8da6314-2a92-4456-89af-b99863b9b8c8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fa63868e-9193-4e47-b309-de5f9562755c"));

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
        }
    }
}
