using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MinimalBookApi.Migrations
{
    /// <inheritdoc />
    public partial class booklenght : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Length",
                table: "Books",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Length",
                table: "Books");
        }
    }
}
