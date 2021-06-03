using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstApp.Migrations
{
    public partial class AddData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Area",
                table: "Branches",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "ID", "Address", "Area", "Name" },
                values: new object[,]
                {
                    { 1, "Riyadh", "Al-rayan", "branch01" },
                    { 2, "Riyadh", "Al-rayan", "branch02" },
                    { 3, "Riyadh", "Al-rayan", "branch03" },
                    { 4, "Riyadh", "Al-rayan", "branch04" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.AlterColumn<string>(
                name: "Area",
                table: "Branches",
                type: "varchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20);
        }
    }
}
