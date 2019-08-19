using Microsoft.EntityFrameworkCore.Migrations;

namespace MyVet.Web.Migrations
{
    public partial class ChangeDocumentMaxLength : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Document",
                table: "Owners",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Document",
                table: "Owners",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 30);
        }
    }
}
