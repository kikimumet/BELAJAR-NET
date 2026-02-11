using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AHMITMTR.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AHMITMTR_MSTMOTOR",
                columns: table => new
                {
                    NID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    VNAMAMOTOR = table.Column<string>(type: "TEXT", nullable: false),
                    VJENIS = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AHMITMTR_MSTMOTOR", x => x.NID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AHMITMTR_MSTMOTOR");
        }
    }
}
