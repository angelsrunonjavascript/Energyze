using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebsiteProject.Migrations
{
    /// <inheritdoc />
    public partial class AddRatings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Favorites_UserId",
                table: "Favorites");

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    EnergyDrinkId = table.Column<int>(type: "INTEGER", nullable: false),
                    Score = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ratings_EnergyDrinks_EnergyDrinkId",
                        column: x => x.EnergyDrinkId,
                        principalTable: "EnergyDrinks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ratings_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Favorites_UserId_EnergyDrinkId",
                table: "Favorites",
                columns: new[] { "UserId", "EnergyDrinkId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_EnergyDrinkId",
                table: "Ratings",
                column: "EnergyDrinkId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_UserId_EnergyDrinkId",
                table: "Ratings",
                columns: new[] { "UserId", "EnergyDrinkId" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropIndex(
                name: "IX_Favorites_UserId_EnergyDrinkId",
                table: "Favorites");

            migrationBuilder.CreateIndex(
                name: "IX_Favorites_UserId",
                table: "Favorites",
                column: "UserId");
        }
    }
}
