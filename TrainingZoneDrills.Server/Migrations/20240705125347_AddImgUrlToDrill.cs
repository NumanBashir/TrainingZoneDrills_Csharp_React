using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainingZoneDrills.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddImgUrlToDrill : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImgUrl",
                table: "Drills",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImgUrl",
                table: "Drills");
        }
    }
}
