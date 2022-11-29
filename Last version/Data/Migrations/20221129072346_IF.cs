using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lastversion.Data.Migrations
{
    /// <inheritdoc />
    public partial class IF : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "importantFacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IFTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IFText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pictureURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    userID = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_importantFacts", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "importantFacts");
        }
    }
}
