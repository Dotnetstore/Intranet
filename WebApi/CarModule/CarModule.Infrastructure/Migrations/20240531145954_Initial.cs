using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarModule.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "CarModule");

            migrationBuilder.CreateTable(
                name: "CarMakes",
                schema: "CarModule",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastUpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastUpdatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsSystem = table.Column<bool>(type: "bit", nullable: false),
                    IsGdpr = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarMakes", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "CarModule",
                table: "CarMakes",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "IsGdpr", "IsSystem", "LastUpdatedBy", "LastUpdatedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("01033e6f-1d02-4a9a-aaf9-0678c21a158a"), null, new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8729), new TimeSpan(0, 2, 0, 0, 0)), null, null, false, false, false, null, null, "Mini" },
                    { new Guid("01eed1ba-e980-42c7-be5c-53b89ca44123"), null, new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8677), new TimeSpan(0, 2, 0, 0, 0)), null, null, false, false, false, null, null, "GMC" },
                    { new Guid("0d0c430f-76a9-4fd1-b1ee-8e7a0fed8d75"), null, new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8655), new TimeSpan(0, 2, 0, 0, 0)), null, null, false, false, false, null, null, "Jeep" },
                    { new Guid("17c56ff4-ed4a-4b3b-b171-cebaffa2ccc6"), null, new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8666), new TimeSpan(0, 2, 0, 0, 0)), null, null, false, false, false, null, null, "Kia" },
                    { new Guid("1e46d67d-10a5-48dd-990e-6798fb55e8e1"), null, new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8707), new TimeSpan(0, 2, 0, 0, 0)), null, null, false, false, false, null, null, "Volvo" },
                    { new Guid("20dc528d-0fde-4551-a0b3-6c4027d39411"), null, new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8683), new TimeSpan(0, 2, 0, 0, 0)), null, null, false, false, false, null, null, "Subaru" },
                    { new Guid("220c821a-1331-472c-a02e-2303811a3a60"), null, new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8687), new TimeSpan(0, 2, 0, 0, 0)), null, null, false, false, false, null, null, "Volkswagen" },
                    { new Guid("262e0d81-48a1-4a29-b0bf-49f84e0e49a9"), null, new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8753), new TimeSpan(0, 2, 0, 0, 0)), null, null, false, false, false, null, null, "Genesis" },
                    { new Guid("2fe719ae-fa15-440a-a810-124563e065ee"), null, new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8834), new TimeSpan(0, 2, 0, 0, 0)), null, null, false, false, false, null, null, "Aston Martin" },
                    { new Guid("33740f26-ab9e-423a-80ee-643a971c870f"), null, new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8766), new TimeSpan(0, 2, 0, 0, 0)), null, null, false, false, false, null, null, "McLaren" },
                    { new Guid("33b0b393-8a2d-4d01-b2a9-fff72a96473e"), null, new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8745), new TimeSpan(0, 2, 0, 0, 0)), null, null, false, false, false, null, null, "Scion" },
                    { new Guid("36602f7c-35f7-4a6c-b1e3-e7c3b0e23b46"), null, new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8816), new TimeSpan(0, 2, 0, 0, 0)), null, null, false, false, false, null, null, "Bugatti" },
                    { new Guid("3a3e7ecd-41bc-47c1-80e6-49f3c898be21"), null, new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8739), new TimeSpan(0, 2, 0, 0, 0)), null, null, false, false, false, null, null, "Fiat" },
                    { new Guid("3c94ddc7-abaf-4f2c-bef6-0dc5614df837"), null, new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8736), new TimeSpan(0, 2, 0, 0, 0)), null, null, false, false, false, null, null, "Bentley" },
                    { new Guid("421c4af8-5874-45ae-8cac-0129a1bc7751"), null, new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8700), new TimeSpan(0, 2, 0, 0, 0)), null, null, false, false, false, null, null, "Buick" },
                    { new Guid("43e5b83d-32e6-47ac-a5c6-11c068b14cd6"), null, new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8759), new TimeSpan(0, 2, 0, 0, 0)), null, null, false, false, false, null, null, "Ferrari" },
                    { new Guid("479344bc-520a-40e4-af5c-50adccae5484"), null, new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8749), new TimeSpan(0, 2, 0, 0, 0)), null, null, false, false, false, null, null, "Tesla" },
                    { new Guid("4decf079-3f54-4c38-9a77-9b68d07956de"), null, new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8662), new TimeSpan(0, 2, 0, 0, 0)), null, null, false, false, false, null, null, "Dodge" },
                    { new Guid("5142099b-9355-407e-a229-1b307e71f201"), null, new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8763), new TimeSpan(0, 2, 0, 0, 0)), null, null, false, false, false, null, null, "Lamborghini" },
                    { new Guid("53481d9d-acdf-41bb-b720-4a267536442d"), null, new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8643), new TimeSpan(0, 2, 0, 0, 0)), null, null, false, false, false, null, null, "Chevrolet" },
                    { new Guid("55ad59a4-2ec6-4fb0-a3a4-b9659781aea1"), null, new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8827), new TimeSpan(0, 2, 0, 0, 0)), null, null, false, false, false, null, null, "Lotus" },
                    { new Guid("63c09ddd-eb45-4a18-8b0d-cabb4194edcf"), null, new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8713), new TimeSpan(0, 2, 0, 0, 0)), null, null, false, false, false, null, null, "Land Rover" },
                    { new Guid("6b285a80-5693-42fd-baf2-8e1e4d499995"), null, new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8812), new TimeSpan(0, 2, 0, 0, 0)), null, null, false, false, false, null, null, "Rolls-Royce" },
                    { new Guid("6de8ac30-ecd2-43aa-b575-ba9a6d844ba6"), null, new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8823), new TimeSpan(0, 2, 0, 0, 0)), null, null, false, false, false, null, null, "Pagani" },
                    { new Guid("714ed326-9edb-4b80-97f8-66df5ca5392a"), null, new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8819), new TimeSpan(0, 2, 0, 0, 0)), null, null, false, false, false, null, null, "Koenigsegg" },
                    { new Guid("7287e4d6-b648-46ea-b81d-cdbb7ad872da"), null, new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8576), new TimeSpan(0, 2, 0, 0, 0)), null, null, false, false, false, null, null, "Toyota" },
                    { new Guid("75880695-b23d-4ce2-a77a-a5021cd10505"), null, new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8732), new TimeSpan(0, 2, 0, 0, 0)), null, null, false, false, false, null, null, "Mitsubishi" },
                    { new Guid("80890a69-3175-4d7d-9a26-dffe46f09b4d"), null, new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8704), new TimeSpan(0, 2, 0, 0, 0)), null, null, false, false, false, null, null, "Cadillac" },
                    { new Guid("8544f301-edb6-4dc8-9b8d-e8eff68b878e"), null, new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8726), new TimeSpan(0, 2, 0, 0, 0)), null, null, false, false, false, null, null, "Infiniti" },
                    { new Guid("87e75c03-91d8-49ce-b073-89d365fe59f0"), null, new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8670), new TimeSpan(0, 2, 0, 0, 0)), null, null, false, false, false, null, null, "BMW" },
                    { new Guid("99e4c746-59cb-43c3-b23d-e0fa0b4cdd3b"), null, new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8659), new TimeSpan(0, 2, 0, 0, 0)), null, null, false, false, false, null, null, "Hyundai" },
                    { new Guid("9d16b331-b955-486d-9f4b-b5cf66a577ac"), null, new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8637), new TimeSpan(0, 2, 0, 0, 0)), null, null, false, false, false, null, null, "Ford" },
                    { new Guid("9fb88bad-8658-463f-b5c3-8dd7ee5a88a4"), null, new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8720), new TimeSpan(0, 2, 0, 0, 0)), null, null, false, false, false, null, null, "Jaguar" },
                    { new Guid("a4938e80-588e-4ca1-b621-4400b0bb2467"), null, new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8693), new TimeSpan(0, 2, 0, 0, 0)), null, null, false, false, false, null, null, "Lexus" },
                    { new Guid("a5c9ca04-db41-421d-8c22-e86882f11f2f"), null, new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8742), new TimeSpan(0, 2, 0, 0, 0)), null, null, false, false, false, null, null, "Smart" },
                    { new Guid("b4700214-a16b-48bf-96fc-93928db68063"), null, new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8673), new TimeSpan(0, 2, 0, 0, 0)), null, null, false, false, false, null, null, "Ram" },
                    { new Guid("b7ff96b6-e9cf-48ec-aac7-74bd40ae4a1c"), null, new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8723), new TimeSpan(0, 2, 0, 0, 0)), null, null, false, false, false, null, null, "Acura" },
                    { new Guid("bb814475-6aa6-4113-8685-5484095bf05d"), null, new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8697), new TimeSpan(0, 2, 0, 0, 0)), null, null, false, false, false, null, null, "Mazda" },
                    { new Guid("c9a81f4f-0ce7-427e-b0d3-fc8245ea35d9"), null, new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8716), new TimeSpan(0, 2, 0, 0, 0)), null, null, false, false, false, null, null, "Porsche" },
                    { new Guid("d39bb50e-ab01-4ed3-a7df-ce8b285ac987"), null, new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, 2, 0, 0, 0)), null, null, false, false, false, null, null, "Audi" },
                    { new Guid("dbff39ee-0fea-4c34-9dd4-c5054385ebc0"), null, new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8837), new TimeSpan(0, 2, 0, 0, 0)), null, null, false, false, false, null, null, "Bentley" },
                    { new Guid("def12ff1-1cd2-473a-924f-8d9ca09e1c93"), null, new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8830), new TimeSpan(0, 2, 0, 0, 0)), null, null, false, false, false, null, null, "Alfa Romeo" },
                    { new Guid("e7e82a96-8602-4fcb-9dcf-59d3f1e6fedc"), null, new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8650), new TimeSpan(0, 2, 0, 0, 0)), null, null, false, false, false, null, null, "Nissan" },
                    { new Guid("e8379af2-ac28-4ea9-b272-c2b44d158c6c"), null, new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8680), new TimeSpan(0, 2, 0, 0, 0)), null, null, false, false, false, null, null, "Mercedes-Benz" },
                    { new Guid("e9ca2bd2-20f3-447b-9e30-d6f536e69a55"), null, new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8756), new TimeSpan(0, 2, 0, 0, 0)), null, null, false, false, false, null, null, "Maserati" },
                    { new Guid("eab78139-37bc-4df6-a3e6-7446552469ca"), null, new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8647), new TimeSpan(0, 2, 0, 0, 0)), null, null, false, false, false, null, null, "Honda" },
                    { new Guid("f8b41df5-77c9-4490-8df7-836a2038bbed"), null, new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8710), new TimeSpan(0, 2, 0, 0, 0)), null, null, false, false, false, null, null, "Lincoln" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarMakes_Id",
                schema: "CarModule",
                table: "CarMakes",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CarMakes_IsDeleted",
                schema: "CarModule",
                table: "CarMakes",
                column: "IsDeleted");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarMakes",
                schema: "CarModule");
        }
    }
}
