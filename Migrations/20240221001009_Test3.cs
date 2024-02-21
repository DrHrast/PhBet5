using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhBet5.Migrations
{
    /// <inheritdoc />
    public partial class Test3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "BetAmount",
                table: "Bets",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<bool>(
                name: "Team1Selected",
                table: "Bets",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Team2Selected",
                table: "Bets",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BetAmount",
                table: "Bets");

            migrationBuilder.DropColumn(
                name: "Team1Selected",
                table: "Bets");

            migrationBuilder.DropColumn(
                name: "Team2Selected",
                table: "Bets");
        }
    }
}
