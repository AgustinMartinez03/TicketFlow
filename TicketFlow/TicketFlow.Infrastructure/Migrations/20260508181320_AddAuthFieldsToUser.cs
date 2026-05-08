using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TicketFlow.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddAuthFieldsToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("01c430c1-42cc-4872-a29b-0980fb1e48f6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("07f6f1dc-71cb-4813-ae4a-0613c092700c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("081fa2c9-bd7c-424c-8876-72773c6e06cd"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0d484b8f-39f1-4229-981d-ff21700e7a73"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0f33f8ab-c6a7-49fc-b01a-e2169ecb5ca3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("12dcfe06-7fe4-44ef-8777-f99277aa9154"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("14224af6-fd9e-4556-98f5-be652630c68c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("15554ac2-ebda-486a-94dd-6e7219b070e6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("17db3074-2ca7-4848-bbb1-3d93607dc55d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1956f04f-c369-41b1-8c0e-21712f8ffae8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1ba0aa70-50e0-4793-a564-b700eac91551"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1ddb6d16-0550-4072-ba9e-f3a8d223360d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1efde5fb-9ac5-4006-8961-30154a478f60"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2018f535-5289-4fca-98c5-b9b161e1b7e2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("21fae280-a93e-45e6-befa-c0bb38fe425b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("22c99fb3-59eb-4c1c-940a-b54208c84285"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("23d614d8-d0c5-4dae-9ee7-eb4a4a5a7873"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("25c6c46a-be36-42ec-b871-4bd908dd3aa7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("26adbc29-bab2-4c26-9ecb-b8420eda9f31"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("27657278-02b1-4cf2-9b3c-d3b0ae19c0fe"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2780921c-5372-4570-aa03-09677c14a886"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2ccabb17-116c-4dad-8162-def44480a47d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2e981fe9-d5ad-4d70-92f4-d52d5d01de9b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3076c99d-1e1a-4bb8-b879-067e8b921f03"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("313199ff-1ff0-4fec-b8c8-d99f21ab605e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3290fc1a-a5c7-440d-82a5-103d858fa698"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3461ffed-946c-4c6e-807a-232f7dc4a526"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("39908dc1-bb88-461c-ba2b-b66caa591ae3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3ddf495e-2d26-43b7-92f5-1a8d57912a8c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("420a4fb9-4134-4276-890e-d585baf82f77"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("42619e8d-5aaf-4aff-85df-a7d0336d89c6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("42c2246a-caad-490a-a66c-0f6ebb9a51ab"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4426425e-8688-4d98-afea-2eb0ccf51bdc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("46049ef3-3c2b-43b7-8924-b01b38cca32a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4668a702-7ca4-4df1-b7f2-d7a41fb0da16"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4822be68-1d6f-4c93-8c26-118d0855428d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("49d1c5ca-66d1-4b9f-8f8e-314665b810db"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4bb2cadc-72e2-4967-9e69-c4cb57fdbe52"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4cdb54e6-09d8-4265-8997-22bcfe6bca51"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4fddd258-7f28-4196-a6c4-a544dbe01841"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("576ed78b-ea29-4d45-8317-65254309d29a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6229b530-e5c6-4d58-bef1-9519a1feecac"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("63522422-909f-4d33-9b87-473a370cc970"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6578a930-9f5a-48fb-b10d-057b6552658d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6c0c5a74-b353-4e41-bcd6-ee649ea2d585"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("743a37e6-7890-46f4-9c68-019120812138"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("755b01e5-06fc-471f-b997-bec7253d1857"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("76182d4f-46a8-40ed-8f0e-b7b73e025652"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("781f6285-905f-4823-9129-f09b209185eb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7b478a53-2198-4de1-8200-e033705e9179"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7b651b2d-8b17-470c-bdca-dfe304bd026f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7fb8df55-4722-403e-bf9e-85bdfc8ac5c9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7fe31f31-db05-48b0-814c-e081e8447a8b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("822846b9-4ba2-4f26-9584-291318c94dce"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("83ddbd5d-01a7-4101-a935-32f6a7eaca3d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("84ba70ac-5330-4354-b2fa-eae72cb1fabb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("84d57bb6-fe0c-4b55-b910-1e52ea844d09"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("89eac0ba-3154-498a-8e53-b7db49513a58"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8d5dc6e1-5294-4e81-b412-dadca2f12698"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("907e5003-c090-4c2f-8046-be2037e809b5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("90b91afa-c825-45a5-af6d-019ed1161449"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("91c2366e-bca7-4ebd-b3a3-57f62488820e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("94506aa8-cd36-4251-97c2-bad63b89473a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("953889b6-b8ff-4bb7-b162-f255d0912da7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("96ab1a0b-5d0d-4f14-8278-b4f39dc41965"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("980c819a-7baf-4169-9159-f0eb729d0563"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("987414ae-9c2e-4237-b674-f8f3571f97c8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9b8f9e2d-df8e-42f4-b0cb-13b9cf94caf6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9ce7b764-4446-4531-95a6-1a85c8660a4c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a1d4db36-e8bf-421b-a6fc-85f70fa8cba9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a20f2b40-be78-4cda-ba85-3bb9add1338a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a2a9241c-3a07-4261-9b3f-78261c63438d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a513df71-78ba-4b19-a351-4126ed1d827e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a820cfeb-3f9c-4c13-bd9d-9621f7d0b88a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a898111e-c012-4559-bd45-e67dcf8beeff"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ace5cf8d-5095-4239-9f44-3ca9999d1f53"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("af92aa01-d6e8-47b1-b014-e25c14b6ba7c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b3ca6073-c578-4066-be93-f87a5714031e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b4c52af6-c591-4503-8aa0-a868effebc1c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b68167b2-3d60-4ea5-a058-b41fedfa4faa"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ba350bbb-4feb-401c-8529-88bcab8e7bdf"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bb93bcd5-c3ae-43b0-a8ed-cca072591931"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("be17ae66-ce79-4c81-be45-e87fb9061f64"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c1feb8f6-b5c6-475c-bd22-0a36bb749c21"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c29bc3d2-18db-406d-82b2-e9329d1f6101"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c2c63ed6-642e-45f2-8b46-7d02783810bc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cc953a10-8f81-48e2-96e9-67babcea3ab0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d0415301-626f-45ef-a2eb-b88b5bcea853"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d2cf8e33-2f7d-4654-9aa6-ef6dd252cfe4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d3dbb917-bf85-477b-bb09-d76e17296d94"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d93e6a03-d111-4e99-a431-e40039379682"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d9f353b4-20a6-4cea-aff3-95bd74d76588"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("dc0b4c84-c7d2-482a-877c-e836c6294ad3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ec05bc0e-6cb3-4cf6-8825-c0463305f685"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ed3b9f20-3808-41a7-bf10-580483080154"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ee838cfb-755c-441a-85ca-747b70bc3a22"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f6411047-f2a2-4343-9066-94e45fb13578"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f6d5e1be-7437-499b-8818-5b587db8996a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f8cdfded-8b71-4578-a801-3d98ea5d396b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fba9bb27-2057-4847-92c3-0709aa6e8acb"));

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Users",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "RowIdentifier", "SeatNumber", "SectorId", "Status", "Version" },
                values: new object[,]
                {
                    { new Guid("012fa838-7617-483e-a403-debd7f3b89be"), "C", 9, 2, "Available", 1 },
                    { new Guid("03fb8b35-4810-41d0-aa5a-1a2ff00c0b88"), "E", 2, 1, "Available", 1 },
                    { new Guid("041bfd9c-eefb-4f2d-9ff1-8258d046d627"), "B", 6, 2, "Available", 1 },
                    { new Guid("0d0fe4b8-2767-4003-984e-5698e9824a4e"), "D", 2, 1, "Available", 1 },
                    { new Guid("0e2b2d6c-47a3-495a-93cc-b979dedc4b5f"), "E", 6, 2, "Available", 1 },
                    { new Guid("0f3e71f9-ccfd-48ad-b9ca-938f1957e6c1"), "D", 3, 1, "Available", 1 },
                    { new Guid("0fb98f44-f2e0-446a-a076-e26e4dd6ef76"), "B", 10, 2, "Available", 1 },
                    { new Guid("115e1236-8a91-467b-a677-c864f30697a3"), "A", 5, 1, "Available", 1 },
                    { new Guid("12175de4-c59c-4504-a742-343df1768260"), "E", 1, 2, "Available", 1 },
                    { new Guid("12fab705-7354-4883-8b61-57b10ef05037"), "A", 1, 1, "Available", 1 },
                    { new Guid("13af99a3-71e6-4ae5-a5f5-d3ddf814a0a0"), "A", 4, 2, "Available", 1 },
                    { new Guid("14581d5e-9428-4a8b-817a-2f261e202595"), "B", 5, 2, "Available", 1 },
                    { new Guid("14daf5c3-1aba-49f7-9e09-4493015e725f"), "B", 7, 2, "Available", 1 },
                    { new Guid("15cef4db-fc3b-4733-a6aa-a9a84bdc244f"), "C", 7, 2, "Available", 1 },
                    { new Guid("15f6bb01-aedf-486f-bd5d-6f7dc39a61d4"), "C", 6, 2, "Available", 1 },
                    { new Guid("16234610-2f9f-474e-bf2e-d3915fc65655"), "E", 9, 1, "Available", 1 },
                    { new Guid("16739d69-61fc-46de-87eb-c43408c04d21"), "C", 2, 1, "Available", 1 },
                    { new Guid("1768294a-fa25-4e90-838c-6b1e0b6e1733"), "A", 6, 1, "Available", 1 },
                    { new Guid("1954284f-1db1-4fdc-902a-998a6b6740b5"), "A", 9, 1, "Available", 1 },
                    { new Guid("1964258c-4b64-47bc-9bca-ee6afc6314f2"), "B", 4, 2, "Available", 1 },
                    { new Guid("1ac7719d-702b-442e-9751-7835794c84a8"), "D", 8, 2, "Available", 1 },
                    { new Guid("202bca41-f7a7-41f4-a388-d8395ba2a3db"), "A", 3, 2, "Available", 1 },
                    { new Guid("2153a6ed-f968-451c-af23-b1205102454a"), "B", 9, 2, "Available", 1 },
                    { new Guid("231bf464-b6b7-408b-90b7-fbc4b91883b8"), "C", 8, 2, "Available", 1 },
                    { new Guid("251aad74-6b42-4b09-a5e3-de87901a7ed0"), "D", 9, 1, "Available", 1 },
                    { new Guid("25c25e02-de6f-442f-80d6-37aa7f98ad9b"), "D", 1, 2, "Available", 1 },
                    { new Guid("2a9f6894-9b3e-401c-9899-a67a64403360"), "B", 1, 2, "Available", 1 },
                    { new Guid("2c32e646-9acd-4475-856d-21d35a084cdf"), "B", 10, 1, "Available", 1 },
                    { new Guid("2c76bc45-d0fa-4314-9020-225c5982c1d9"), "C", 3, 1, "Available", 1 },
                    { new Guid("2c879a83-63ae-4ea4-8151-76298cef7350"), "A", 8, 2, "Available", 1 },
                    { new Guid("3140f751-ebf2-4fb2-8316-6e3d11821dde"), "D", 2, 2, "Available", 1 },
                    { new Guid("31c05d70-192e-4b3c-b884-c3acf298ef5c"), "D", 10, 2, "Available", 1 },
                    { new Guid("344d0a26-a100-485f-91fe-47f0250f4e9e"), "D", 6, 2, "Available", 1 },
                    { new Guid("3cca9d63-efa6-4a99-9c51-b463ade623bf"), "E", 10, 1, "Available", 1 },
                    { new Guid("46936849-f6ab-4081-a3a6-297fc69fa1ff"), "D", 5, 1, "Available", 1 },
                    { new Guid("46a0efe1-c990-4049-917e-417afcfba1b5"), "D", 4, 1, "Available", 1 },
                    { new Guid("4fc62670-0b24-4054-896a-c7225f17cbb0"), "A", 1, 2, "Available", 1 },
                    { new Guid("4fe54889-499b-484a-8cf7-a2fbc8aebe58"), "C", 7, 1, "Available", 1 },
                    { new Guid("512cf0b7-38a9-4221-8ffe-f4535c2bb746"), "B", 5, 1, "Available", 1 },
                    { new Guid("51d934b8-57c0-41b0-8952-ec1da82cd1bc"), "B", 2, 2, "Available", 1 },
                    { new Guid("555bc595-669b-4829-b5e5-cee2a71f674e"), "C", 10, 2, "Available", 1 },
                    { new Guid("573c4779-aa5a-46cc-9fff-0bb42b08fda0"), "A", 9, 2, "Available", 1 },
                    { new Guid("59032d96-1b20-4840-af03-419ebff903f0"), "E", 3, 2, "Available", 1 },
                    { new Guid("5b2153a5-23a3-41e8-ad8e-e41ece088f5f"), "B", 2, 1, "Available", 1 },
                    { new Guid("5d63c7a7-fe73-4ea7-82b7-cd16a3c45ce0"), "E", 10, 2, "Available", 1 },
                    { new Guid("644dcf95-f5a3-4794-9f87-8a445b0a75cf"), "E", 5, 1, "Available", 1 },
                    { new Guid("66eeb61b-8b0f-4800-a8d3-5fc9a519cb33"), "C", 2, 2, "Available", 1 },
                    { new Guid("6ff1fc92-5088-46e7-8dbb-d44589710954"), "D", 1, 1, "Available", 1 },
                    { new Guid("70a63ee8-861c-4b13-9cb3-92367c73e1bd"), "D", 3, 2, "Available", 1 },
                    { new Guid("74d9851e-cbce-4934-9d84-a8c7f400bfd9"), "E", 1, 1, "Available", 1 },
                    { new Guid("74dfa587-0e6e-43f4-85bb-956839267306"), "D", 10, 1, "Available", 1 },
                    { new Guid("76eda118-7458-4185-a7a4-b81ba8d12b5b"), "C", 4, 1, "Available", 1 },
                    { new Guid("79f56afa-e1a8-4b0d-b391-fa2b3460bad5"), "A", 2, 1, "Available", 1 },
                    { new Guid("7dd9f62d-00f9-4591-b533-63662d190ab1"), "B", 8, 1, "Available", 1 },
                    { new Guid("7ea5f2d6-2f23-4cbb-bb69-05a27ee09fee"), "D", 4, 2, "Available", 1 },
                    { new Guid("85cc404d-2bc5-493d-8fd4-d10955c2606e"), "C", 4, 2, "Available", 1 },
                    { new Guid("8b479e9e-a547-453c-9cc1-3460f94f594f"), "A", 7, 2, "Available", 1 },
                    { new Guid("8b5b87f1-79e4-40f9-aa7c-898a0f1b8cde"), "E", 5, 2, "Available", 1 },
                    { new Guid("8c7306af-fc43-4782-a4b6-648d92180efa"), "C", 1, 2, "Available", 1 },
                    { new Guid("94088506-7fb2-4f57-9d03-78b73ba171aa"), "D", 9, 2, "Available", 1 },
                    { new Guid("981c064f-ea35-4730-8f0f-e4da5900fa8b"), "B", 7, 1, "Available", 1 },
                    { new Guid("9cd4d0d0-f255-4da5-8df6-ba09ee24039b"), "B", 3, 2, "Available", 1 },
                    { new Guid("9fce73a4-ff7b-4dac-a66a-a1ce0f66f417"), "A", 10, 2, "Available", 1 },
                    { new Guid("9fd0611c-1be9-42f1-b626-44bd830d54fd"), "C", 9, 1, "Available", 1 },
                    { new Guid("a132eaa4-c5ea-438c-b8d7-b542514f8137"), "D", 7, 2, "Available", 1 },
                    { new Guid("a2f21b5c-21ee-4a04-b6fe-cb429f406da3"), "C", 1, 1, "Available", 1 },
                    { new Guid("a3f5ab4b-fe62-42a0-9ed2-1573a6bf0810"), "E", 2, 2, "Available", 1 },
                    { new Guid("a6e8b0b8-ca2a-464a-8977-3353549101e9"), "E", 6, 1, "Available", 1 },
                    { new Guid("ac67a541-d387-4f8a-91c0-6d846ac9632b"), "A", 7, 1, "Available", 1 },
                    { new Guid("ac723e50-bb10-49dd-b1e7-6ab7e5eaf240"), "C", 5, 1, "Available", 1 },
                    { new Guid("ae1460bd-8e8c-414b-a38d-0429e2450bde"), "C", 8, 1, "Available", 1 },
                    { new Guid("b39a8227-6c1f-4393-a5e4-16c6b825e89d"), "A", 3, 1, "Available", 1 },
                    { new Guid("b617fb0c-b757-4f07-8500-f8dfe0ccd9e0"), "B", 8, 2, "Available", 1 },
                    { new Guid("b61cbb86-4323-4763-a825-78680c75f957"), "C", 10, 1, "Available", 1 },
                    { new Guid("b791c35a-1137-43dd-8c99-2a8bda0eae17"), "B", 9, 1, "Available", 1 },
                    { new Guid("b7caace8-6352-4a6a-9114-118c7a487179"), "B", 1, 1, "Available", 1 },
                    { new Guid("bb74ad9f-c66e-4272-8f98-a24dc2323bae"), "D", 8, 1, "Available", 1 },
                    { new Guid("bdab22d9-01fc-4402-84bb-62089d142493"), "E", 8, 2, "Available", 1 },
                    { new Guid("c07d37f8-54ca-4010-aaa7-6a9956925c9c"), "A", 6, 2, "Available", 1 },
                    { new Guid("c7368db1-4c21-48fd-82ee-52283842de50"), "E", 9, 2, "Available", 1 },
                    { new Guid("c7575053-d4fd-4360-9a3a-3c4b8a02478a"), "A", 5, 2, "Available", 1 },
                    { new Guid("cf1bb88e-bfda-4783-aec2-a28e73eb3c8f"), "C", 3, 2, "Available", 1 },
                    { new Guid("d12f6eb9-29ec-4deb-81d0-7d78fb644fb1"), "A", 4, 1, "Available", 1 },
                    { new Guid("d185c197-eae7-4dbf-a109-f970cd41acd6"), "D", 5, 2, "Available", 1 },
                    { new Guid("d2a8531f-af30-4c37-8f82-249844b41010"), "A", 8, 1, "Available", 1 },
                    { new Guid("d475b647-d5b0-4d82-ae4a-6444e76dbcb3"), "E", 7, 2, "Available", 1 },
                    { new Guid("d4e2005d-a189-4b20-a06f-dc6c77f40b11"), "E", 7, 1, "Available", 1 },
                    { new Guid("da49e168-b694-40af-a676-32af3441d422"), "A", 2, 2, "Available", 1 },
                    { new Guid("dd83a7cb-ab1c-49ad-ae08-885c4def434c"), "B", 3, 1, "Available", 1 },
                    { new Guid("deb8782d-6a7b-4633-99c0-00c890956cd4"), "D", 7, 1, "Available", 1 },
                    { new Guid("def5f354-55a2-42b9-aa59-2bbcc9d9551d"), "C", 6, 1, "Available", 1 },
                    { new Guid("df536c92-5c77-47af-a636-79d533c08986"), "E", 4, 2, "Available", 1 },
                    { new Guid("e8768449-6ef1-420a-b533-53b3e4685c54"), "B", 4, 1, "Available", 1 },
                    { new Guid("e8c97102-6289-4d65-834b-275d37254e73"), "A", 10, 1, "Available", 1 },
                    { new Guid("e941631c-bd52-4161-924e-a55eb7df0d8c"), "E", 4, 1, "Available", 1 },
                    { new Guid("e95522a4-24d8-4b82-b844-1cbba3a76a83"), "C", 5, 2, "Available", 1 },
                    { new Guid("f041fda6-a664-481b-9728-631f103093fe"), "D", 6, 1, "Available", 1 },
                    { new Guid("f7ad2383-6dc8-45e6-bce0-ea6a6f31d623"), "B", 6, 1, "Available", 1 },
                    { new Guid("fc28faec-8844-45d0-956a-0922e91445f5"), "E", 3, 1, "Available", 1 },
                    { new Guid("fcfa7368-d87d-4df0-a3de-cc38ecd2e92c"), "E", 8, 1, "Available", 1 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "Name", "PasswordHash", "Role" },
                values: new object[] { "admin@ticketflow.com", "Admin General", "admin123", "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Role",
                value: "Client");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "PasswordHash", "Role" },
                values: new object[] { 3, "agus@ticketflow.com", "Agustin", "123456", "Client" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("012fa838-7617-483e-a403-debd7f3b89be"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("03fb8b35-4810-41d0-aa5a-1a2ff00c0b88"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("041bfd9c-eefb-4f2d-9ff1-8258d046d627"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0d0fe4b8-2767-4003-984e-5698e9824a4e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0e2b2d6c-47a3-495a-93cc-b979dedc4b5f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0f3e71f9-ccfd-48ad-b9ca-938f1957e6c1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0fb98f44-f2e0-446a-a076-e26e4dd6ef76"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("115e1236-8a91-467b-a677-c864f30697a3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("12175de4-c59c-4504-a742-343df1768260"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("12fab705-7354-4883-8b61-57b10ef05037"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("13af99a3-71e6-4ae5-a5f5-d3ddf814a0a0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("14581d5e-9428-4a8b-817a-2f261e202595"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("14daf5c3-1aba-49f7-9e09-4493015e725f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("15cef4db-fc3b-4733-a6aa-a9a84bdc244f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("15f6bb01-aedf-486f-bd5d-6f7dc39a61d4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("16234610-2f9f-474e-bf2e-d3915fc65655"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("16739d69-61fc-46de-87eb-c43408c04d21"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1768294a-fa25-4e90-838c-6b1e0b6e1733"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1954284f-1db1-4fdc-902a-998a6b6740b5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1964258c-4b64-47bc-9bca-ee6afc6314f2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1ac7719d-702b-442e-9751-7835794c84a8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("202bca41-f7a7-41f4-a388-d8395ba2a3db"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2153a6ed-f968-451c-af23-b1205102454a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("231bf464-b6b7-408b-90b7-fbc4b91883b8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("251aad74-6b42-4b09-a5e3-de87901a7ed0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("25c25e02-de6f-442f-80d6-37aa7f98ad9b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2a9f6894-9b3e-401c-9899-a67a64403360"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2c32e646-9acd-4475-856d-21d35a084cdf"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2c76bc45-d0fa-4314-9020-225c5982c1d9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2c879a83-63ae-4ea4-8151-76298cef7350"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3140f751-ebf2-4fb2-8316-6e3d11821dde"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("31c05d70-192e-4b3c-b884-c3acf298ef5c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("344d0a26-a100-485f-91fe-47f0250f4e9e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3cca9d63-efa6-4a99-9c51-b463ade623bf"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("46936849-f6ab-4081-a3a6-297fc69fa1ff"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("46a0efe1-c990-4049-917e-417afcfba1b5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4fc62670-0b24-4054-896a-c7225f17cbb0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4fe54889-499b-484a-8cf7-a2fbc8aebe58"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("512cf0b7-38a9-4221-8ffe-f4535c2bb746"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("51d934b8-57c0-41b0-8952-ec1da82cd1bc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("555bc595-669b-4829-b5e5-cee2a71f674e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("573c4779-aa5a-46cc-9fff-0bb42b08fda0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("59032d96-1b20-4840-af03-419ebff903f0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5b2153a5-23a3-41e8-ad8e-e41ece088f5f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5d63c7a7-fe73-4ea7-82b7-cd16a3c45ce0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("644dcf95-f5a3-4794-9f87-8a445b0a75cf"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("66eeb61b-8b0f-4800-a8d3-5fc9a519cb33"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6ff1fc92-5088-46e7-8dbb-d44589710954"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("70a63ee8-861c-4b13-9cb3-92367c73e1bd"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("74d9851e-cbce-4934-9d84-a8c7f400bfd9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("74dfa587-0e6e-43f4-85bb-956839267306"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("76eda118-7458-4185-a7a4-b81ba8d12b5b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("79f56afa-e1a8-4b0d-b391-fa2b3460bad5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7dd9f62d-00f9-4591-b533-63662d190ab1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7ea5f2d6-2f23-4cbb-bb69-05a27ee09fee"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("85cc404d-2bc5-493d-8fd4-d10955c2606e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8b479e9e-a547-453c-9cc1-3460f94f594f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8b5b87f1-79e4-40f9-aa7c-898a0f1b8cde"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8c7306af-fc43-4782-a4b6-648d92180efa"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("94088506-7fb2-4f57-9d03-78b73ba171aa"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("981c064f-ea35-4730-8f0f-e4da5900fa8b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9cd4d0d0-f255-4da5-8df6-ba09ee24039b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9fce73a4-ff7b-4dac-a66a-a1ce0f66f417"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9fd0611c-1be9-42f1-b626-44bd830d54fd"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a132eaa4-c5ea-438c-b8d7-b542514f8137"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a2f21b5c-21ee-4a04-b6fe-cb429f406da3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a3f5ab4b-fe62-42a0-9ed2-1573a6bf0810"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a6e8b0b8-ca2a-464a-8977-3353549101e9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ac67a541-d387-4f8a-91c0-6d846ac9632b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ac723e50-bb10-49dd-b1e7-6ab7e5eaf240"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ae1460bd-8e8c-414b-a38d-0429e2450bde"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b39a8227-6c1f-4393-a5e4-16c6b825e89d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b617fb0c-b757-4f07-8500-f8dfe0ccd9e0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b61cbb86-4323-4763-a825-78680c75f957"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b791c35a-1137-43dd-8c99-2a8bda0eae17"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b7caace8-6352-4a6a-9114-118c7a487179"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bb74ad9f-c66e-4272-8f98-a24dc2323bae"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bdab22d9-01fc-4402-84bb-62089d142493"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c07d37f8-54ca-4010-aaa7-6a9956925c9c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c7368db1-4c21-48fd-82ee-52283842de50"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c7575053-d4fd-4360-9a3a-3c4b8a02478a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cf1bb88e-bfda-4783-aec2-a28e73eb3c8f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d12f6eb9-29ec-4deb-81d0-7d78fb644fb1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d185c197-eae7-4dbf-a109-f970cd41acd6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d2a8531f-af30-4c37-8f82-249844b41010"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d475b647-d5b0-4d82-ae4a-6444e76dbcb3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d4e2005d-a189-4b20-a06f-dc6c77f40b11"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("da49e168-b694-40af-a676-32af3441d422"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("dd83a7cb-ab1c-49ad-ae08-885c4def434c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("deb8782d-6a7b-4633-99c0-00c890956cd4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("def5f354-55a2-42b9-aa59-2bbcc9d9551d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("df536c92-5c77-47af-a636-79d533c08986"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e8768449-6ef1-420a-b533-53b3e4685c54"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e8c97102-6289-4d65-834b-275d37254e73"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e941631c-bd52-4161-924e-a55eb7df0d8c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e95522a4-24d8-4b82-b844-1cbba3a76a83"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f041fda6-a664-481b-9728-631f103093fe"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f7ad2383-6dc8-45e6-bce0-ea6a6f31d623"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fc28faec-8844-45d0-956a-0922e91445f5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fcfa7368-d87d-4df0-a3de-cc38ecd2e92c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "Role",
                table: "Users");

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

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "Name", "PasswordHash" },
                values: new object[] { "agus@ticketflow.com", "Agustin", "123456" });
        }
    }
}
