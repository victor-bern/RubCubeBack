using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RubCubeBack.Infra.Migrations
{
    /// <inheritdoc />
    public partial class logremoveresponse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Response",
                table: "Logs");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Response",
                table: "Logs",
                type: "text",
                nullable: true);
        }
    }
}
