using Microsoft.EntityFrameworkCore.Migrations;

namespace MeetupAPI.Migrations
{
    public partial class Cost100 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cost",
                table: "Meetups");

            migrationBuilder.AddColumn<int>(
                name: "Cost",
                table: "Meetups",
                nullable: false,
                defaultValue: 100);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
