using Microsoft.EntityFrameworkCore.Migrations;

namespace listingApi.Migrations
{
    public partial class seedingUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contries",
                keyColumn: "countryId",
                keyValue: 3,
                column: "Name",
                value: "jabalpur mp");

            migrationBuilder.InsertData(
                table: "Contries",
                columns: new[] { "countryId", "Name", "ShortName" },
                values: new object[] { 4, "delhi", "da" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contries",
                keyColumn: "countryId",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Contries",
                keyColumn: "countryId",
                keyValue: 3,
                column: "Name",
                value: "jabalpur");
        }
    }
}
