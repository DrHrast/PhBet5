using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhBet5.Migrations
{
    /// <inheritdoc />
    public partial class twoNewMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bets",
                columns: table => new
                {
                    BetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BetSport = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BetTeam1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BetTeam2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BetRatio = table.Column<double>(type: "float", nullable: false),
                    BetDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bets", x => x.BetId);
                });

            migrationBuilder.CreateTable(
                name: "Betting",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    BetId = table.Column<int>(type: "int", nullable: false),
                    BetPlacedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BetName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GameDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BetAmount = table.Column<int>(type: "int", nullable: false),
                    IsFinished = table.Column<bool>(type: "bit", nullable: false),
                    IsWon = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Betting", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bets");

            migrationBuilder.DropTable(
                name: "Betting");
        }
    }
}
