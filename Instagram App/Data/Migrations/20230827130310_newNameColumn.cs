using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Instagram_App.Data.Migrations
{
    /// <inheritdoc />
    public partial class newNameColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PostName",
                table: "home",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PostName",
                table: "home");
        }
    }
}
