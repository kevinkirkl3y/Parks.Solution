using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkAPI.Migrations
{
    public partial class TotalAreaDataType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TotalArea",
                table: "StateParks",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "TotalArea",
                table: "NationalParks",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "TotalArea",
                table: "StateParks",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TotalArea",
                table: "NationalParks",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
