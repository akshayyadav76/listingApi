using Microsoft.EntityFrameworkCore.Migrations;

namespace listingApi.Migrations
{
    public partial class seedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Contries",
                columns: new[] { "countryId", "Name", "ShortName" },
                values: new object[] { 1, "bhopal", "bu" });

            migrationBuilder.InsertData(
                table: "Contries",
                columns: new[] { "countryId", "Name", "ShortName" },
                values: new object[] { 2, "indore", "in" });

            migrationBuilder.InsertData(
                table: "Contries",
                columns: new[] { "countryId", "Name", "ShortName" },
                values: new object[] { 3, "jabalpur", "ja" });

            migrationBuilder.InsertData(
                table: "hotels",
                columns: new[] { "Id", "Address", "CountryId", "Name", "Rating" },
                values: new object[] { 1, "mp nager", 1, "hotel 1", 3.5 });

            migrationBuilder.InsertData(
                table: "hotels",
                columns: new[] { "Id", "Address", "CountryId", "Name", "Rating" },
                values: new object[] { 2, "jp nager", 2, "hotel 2", 3.2000000000000002 });

            migrationBuilder.InsertData(
                table: "hotels",
                columns: new[] { "Id", "Address", "CountryId", "Name", "Rating" },
                values: new object[] { 3, "kp nager", 3, "hotel 3", 4.5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "hotels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "hotels",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "hotels",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Contries",
                keyColumn: "countryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Contries",
                keyColumn: "countryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Contries",
                keyColumn: "countryId",
                keyValue: 3);
        }
    }
}
