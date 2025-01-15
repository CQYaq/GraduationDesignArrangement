using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GDAS.ef.Migrations
{
    /// <inheritdoc />
    public partial class _20250114 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "UserInfo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "UserInfo",
                type: "int",
                nullable: true);
        }
    }
}
