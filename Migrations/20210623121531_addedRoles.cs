using Microsoft.EntityFrameworkCore.Migrations;

namespace listingApi.Migrations
{
    public partial class addedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d04f1d29-af7f-413b-b0e2-ed0b6dceb3ba", "2c54928f-349a-422c-b9cb-581b89a2edcd", "User", "USER" },
                    { "3ce540d0-2bed-4476-b454-d1fec23534b4", "a8b7ce58-05eb-40c5-8f9f-c89f359d6d19", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "Contries",
                columns: new[] { "countryId", "Name", "ShortName" },
                values: new object[,]
                {
                    { 5, "Bhopal", "BU" },
                    { 6, "Indore", "IN" },
                    { 7, "Jabalpur mp", "JA" }
                });

            migrationBuilder.InsertData(
                table: "hotels",
                columns: new[] { "Id", "Address", "CountryId", "Name", "Rating" },
                values: new object[,]
                {
                    { 5, "Negril", 1, "Sandals Resort and Spa", 4.5 },
                    { 6, "George Town", 3, "Comfort Suites", 4.2999999999999998 },
                    { 7, "Nassua", 2, "Grand Palldium", 4.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3ce540d0-2bed-4476-b454-d1fec23534b4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d04f1d29-af7f-413b-b0e2-ed0b6dceb3ba");

            migrationBuilder.DeleteData(
                table: "Contries",
                keyColumn: "countryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Contries",
                keyColumn: "countryId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Contries",
                keyColumn: "countryId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "hotels",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "hotels",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "hotels",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
