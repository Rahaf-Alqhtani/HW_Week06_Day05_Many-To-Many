using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstApp.Migrations
{
    public partial class AddCustomerDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "id", "Email", "FirstName", "LastName" },
                values: new object[] { 1, "xxxxxxx@xxxx.xxx", "Ahmad", "Alqhtani" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "id", "Email", "FirstName", "LastName" },
                values: new object[] { 2, "xxxxxxx@xxxx.xxx", "Abdualla", "Alqhtani" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "id",
                keyValue: 2);
        }
    }
}
